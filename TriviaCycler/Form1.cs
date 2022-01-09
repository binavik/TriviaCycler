using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace TriviaCycler
{
    public partial class Form1 : Form
    {
        enum State
        {
            SHOWING_QUESTION,
            SHOWING_ANSWER
        }
        private SettingsData settings;
        private const int DEFAULT_TIME_TO_ANSWER_SECONDS = 60;
        private const int DEFAULT_TIME_BETWEEN_QUESTIONS_SECONDS = 10;
        private const float DEFAULT_FONT_MULTIPLIER = 1.5f;
        private const string DEFAULT_CATEGORY = "";
        private RestClient client;
        private Task<Question[]> nextQuestion;
        private System.Windows.Forms.Timer timer;
        private State state;
        private int count;

        public Form1()
        {
            InitializeComponent();
            InitSettings();
            this.timer = new System.Windows.Forms.Timer();
            this.timer.Interval = 1000;
            this.timer.Tick += new EventHandler(OnTimerTick);
        }

        private async void InitSettings()
        {
            var directory = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            try
            {
                StreamReader file = new StreamReader(Path.Combine(directory, "TriviaCycler", "settings.txt"));
                string data = await file.ReadToEndAsync();
                this.settings = JsonConvert.DeserializeObject<SettingsData>(data);
                menuStart.Enabled = true;
                file.Close();
                this.client = new RestClient(settings.category, settings.api_key);
                this.nextQuestion = client.GetNextQuestion();
            }
            catch
            {
                this.settings = new SettingsData()
                {
                    timeToDisplayQuestion = DEFAULT_TIME_TO_ANSWER_SECONDS,
                    timeToDisplayAnswer = DEFAULT_TIME_BETWEEN_QUESTIONS_SECONDS,
                    category = DEFAULT_CATEGORY,
                    fontMultiplier = DEFAULT_FONT_MULTIPLIER
                };
            }
        }

        private async void SaveSettings()
        {
            var directory = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            try
            {
                if(!Directory.Exists(Path.Combine(directory, "TriviaCycler")))
                {
                    Directory.CreateDirectory(Path.Combine(directory, "TriviaCycler"));
                }
                StreamWriter file = new StreamWriter(Path.Combine(directory, "TriviaCycler", "settings.txt"));
                await file.WriteAsync(JsonConvert.SerializeObject(this.settings));
                file.Close();
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        private void OnTimerTick(object Sender, EventArgs e)
        {
            count++;
            switch (state)
            {
                case State.SHOWING_QUESTION:
                    ShowingQuestionState();
                    break;
                case State.SHOWING_ANSWER:
                    ShowingAnswerState();
                    break;
                default:
                    break;
            }
        }

        private void ShowingQuestionState()
        {
            if(count >= settings.timeToDisplayQuestion)
            {
                qABox.Text = this.nextQuestion.Result[0].answer;
                count = 0;
                this.state = State.SHOWING_ANSWER;
                this.nextQuestion = client.GetNextQuestion();
            }
            UpdateTimer(settings.timeToDisplayQuestion - count, "Answer");
        }

        private void ShowingAnswerState()
        {
            if(count >= settings.timeToDisplayAnswer)
            {
                qABox.Text = this.nextQuestion.Result[0].question;
                setFontSize(qABox);
                count = 0;
                this.state = State.SHOWING_QUESTION;
            }
            UpdateTimer(settings.timeToDisplayAnswer - count, "Next question");
        }

        private void MenuExitOnClick(object sender, System.EventArgs e)
        {
            Application.Exit();
        }

        private void MenuSettingsOnClick(object sender, System.EventArgs e)
        {
            SettingsForm tmp = new SettingsForm(this, settings.timeToDisplayQuestion, settings.timeToDisplayAnswer, settings.category, settings.fontMultiplier, settings.api_key);
            tmp.Show();
        }

        private void MenuStopOnClick(object sender, System.EventArgs e)
        {
            this.timer.Stop();
            menuStop.Enabled = false;
            menuStart.Enabled = true;
            menuSettings.Enabled = true;
        }
        
        private void MenuStartOnClick(object sender, System.EventArgs e)
        {
            qABox.Text = this.nextQuestion.Result[0].question;
            setFontSize(qABox);
            menuStop.Enabled = true;
            menuStart.Enabled = false;
            menuSettings.Enabled = false ;
            this.count = 0;
            this.state = State.SHOWING_QUESTION;
            this.timer.Start();
        }

        private void setFontSize(Control box)
        {
            float height = box.Height * 0.99f;
            float width = box.Width * 0.99f;

            Size temp = TextRenderer.MeasureText(box.Text, box.Font);
            float heightRatio = height / temp.Height;
            float widthRatio = width / temp.Width;

            Font updatedFont = new Font(box.Font.FontFamily, box.Font.Size * Math.Min(widthRatio, heightRatio) * settings.fontMultiplier, box.Font.Style);
            box.Font = updatedFont;
        }

        private void UpdateTimer(int time, string next)
        {
            timerBox.Text = $"{next} in {time} second(s)";
        }

        public void setNewSettings(int question, int answer, string category, float multiplier, string api_key)
        {
            settings.timeToDisplayAnswer = answer;
            settings.timeToDisplayQuestion = question;
            settings.category = category;
            settings.fontMultiplier = multiplier;
            settings.api_key = api_key;
            if(api_key != "")
            {
                this.client = new RestClient(settings.category, settings.api_key);
                this.nextQuestion = client.GetNextQuestion();
                menuStart.Enabled = true;
                SaveSettings();
            }
            else
            {
                menuStart.Enabled = false;
            }
        }
    }
}
