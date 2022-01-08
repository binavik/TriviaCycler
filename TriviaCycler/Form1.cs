using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TriviaCycler
{
    public partial class Form1 : Form
    {
        private SettingsData settings;
        private const int TIME_TO_ANSWER_SECONDS = 60;
        private const int TIME_BETWEEN_QUESTIONS_SECONDS = 10;

        public Form1()
        {
            InitializeComponent();
            settings = new SettingsData()
            {
                timeToDisplayQuestion = TIME_TO_ANSWER_SECONDS,
                timeToDisplayAnswer = TIME_BETWEEN_QUESTIONS_SECONDS,
                category = ""
            };
        }

        private void MenuExitOnClick(object sender, System.EventArgs e)
        {
            Application.Exit();
        }

        private void MenuSettingsOnClick(object sender, System.EventArgs e)
        {
            SettingsForm tmp = new SettingsForm(this);
            tmp.Show();
        }
        
        private void MenuStartOnClick(object sender, System.EventArgs e)
        {
            setFontSize(qABox);
        }

        private void setFontSize(Label box)
        {
            float height = box.Height * 0.99f;
            float width = box.Width * 0.99f;

            Size temp = TextRenderer.MeasureText(box.Text, box.Font);
            float heightRatio = height / temp.Height;
            float widthRatio = width / temp.Width;

            Font updatedFont = new Font(box.Font.FontFamily, box.Font.Size * Math.Min(widthRatio, heightRatio) * 3.0f, box.Font.Style);
            box.Font = updatedFont;
        }

        public void setNewSettings(int question, int answer, string category)
        {
            settings.timeToDisplayAnswer = answer;
            settings.timeToDisplayQuestion = question;
            settings.category = category;
        }
    }
}
