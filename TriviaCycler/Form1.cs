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
using System.Diagnostics;
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
        private const int DEFAULT_FONT_MULTIPLIER = 72;
        private const int DEFAULT_MINIMUM_FONT_SIZE = 20;
        private RestClient client;
        private string nextQuestion;
        private Question deserializedQuestion;
        private bool hasBeenDeserialized;
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
            qABox.SelectAll();
            qABox.SelectionAlignment = HorizontalAlignment.Center;
            qABox.DeselectAll();
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
                this.client = new RestClient();
                await Task.Run(() => PrepareFirstQuestion());
            }
            catch
            {
                this.settings = new SettingsData()
                {
                    timeToDisplayQuestion = DEFAULT_TIME_TO_ANSWER_SECONDS,
                    timeToDisplayAnswer = DEFAULT_TIME_BETWEEN_QUESTIONS_SECONDS,
                    maxFontSize = DEFAULT_FONT_MULTIPLIER
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
                Debug.WriteLine(e.Message);
            }
        }

        private async void OnTimerTick(object Sender, EventArgs e)
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
            if (!hasBeenDeserialized)
            {
                try
                {
                    this.deserializedQuestion = JsonConvert.DeserializeObject<Question[]>(this.nextQuestion)[0];
                    this.hasBeenDeserialized = true;
                }
                catch
                {
                    Debug.WriteLine($"Can't deserialize string: {this.nextQuestion}");
                    this.nextQuestion = await this.client.GetNextQuestion();
                    this.hasBeenDeserialized = false;
                }
            }
        }

        private async void ShowingQuestionState()
        {
            if(count >= settings.timeToDisplayQuestion)
            {
                qABox.Text = this.deserializedQuestion.answer;
                qABox.SelectAll();
                qABox.SelectionAlignment = HorizontalAlignment.Center;
                qABox.DeselectAll();
                count = 0;
                this.state = State.SHOWING_ANSWER;
                this.nextQuestion = await client.GetNextQuestion();
                this.hasBeenDeserialized = false;
            }
            UpdateTimer(settings.timeToDisplayQuestion - count, "Answer");
        }

        private void ShowingAnswerState()
        {
            if(count >= settings.timeToDisplayAnswer)
            {
                qABox.Text = $"Category: {this.deserializedQuestion.category.title}\n{this.deserializedQuestion.question}";
                qABox.SelectAll();
                qABox.SelectionAlignment = HorizontalAlignment.Center;
                qABox.DeselectAll();
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
            SettingsForm tmp = new SettingsForm(this, settings.timeToDisplayQuestion, settings.timeToDisplayAnswer, settings.maxFontSize);
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
            qABox.Text = $"Category: {this.deserializedQuestion.category.title}\n{this.deserializedQuestion.question}";
            qABox.SelectAll();
            qABox.SelectionAlignment = HorizontalAlignment.Center;
            qABox.DeselectAll();
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
            /*
            float height = box.Height * 0.79f;
            float width = box.Width * 0.79f;

            Size temp = TextRenderer.MeasureText(box.Text, box.Font);
            float heightRatio = height / temp.Height;
            float widthRatio = width / temp.Width;

            Font updatedFont = new Font(box.Font.FontFamily, box.Font.Size * Math.Min(widthRatio, heightRatio) * settings.fontMultiplier, box.Font.Style);
            box.Font = updatedFont;
            */
            bool foundGoodSize = false;
            Font original = box.Font;
            Graphics gr = box.CreateGraphics();
            for(int adjustedSize = this.settings.maxFontSize; adjustedSize >= DEFAULT_MINIMUM_FONT_SIZE; adjustedSize--)
            {
                Font testFont = new Font(original.Name, adjustedSize, original.Style);
                SizeF testSize = gr.MeasureString(box.Text, testFont);
                if(box.Width > Convert.ToInt32(testSize.Width))
                {
                    box.Font = new Font(original.Name, adjustedSize*2, original.Style);
                    foundGoodSize = true;
                    Debug.WriteLine($"good size: {adjustedSize*2}");
                    break;
                }
            }
            if (!foundGoodSize)
            {
                Font temp = new Font(original.Name, DEFAULT_MINIMUM_FONT_SIZE*2, original.Style);
                box.Font = temp;
            }
        }

        private void UpdateTimer(int time, string next)
        {
            timerBox.Text = $"{next} in {time} second(s)";
        }

        public async void setNewSettings(int question, int answer, int maxFontSize)
        {
            settings.timeToDisplayAnswer = answer;
            settings.timeToDisplayQuestion = question;
            settings.maxFontSize = maxFontSize;
            this.client = new RestClient();
            await Task.Run(() => PrepareFirstQuestion());
            menuStart.Enabled = true;
            SaveSettings();
        }

        private async void PrepareFirstQuestion()
        {
            this.nextQuestion = await client.GetNextQuestion();
            try
            {
                this.deserializedQuestion = JsonConvert.DeserializeObject<Question[]>(this.nextQuestion)[0];
                this.hasBeenDeserialized = true;
            }
            catch
            {
                PrepareFirstQuestion();
            }
        }
    }
}
