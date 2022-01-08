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
    public partial class SettingsForm : Form
    {
        private Form1 settings;
        private string[] categories = new string[] 
        {   
            "", 
            "artliterature", 
            "language", 
            "sciencenature", 
            "general", 
            "fooddrink", 
            "peopleplaces", 
            "geography", 
            "historyholidays", 
            "entertainment", 
            "toysgames", 
            "music", 
            "mathematics", 
            "religionmythology", 
            "sportsleisure" 
        };

        public SettingsForm(Form1 form, int question, int answer, string category, float multiplier, string api_key)
        {
            InitializeComponent();
            this.settings = form;
            questionDisplaySeconds.Text = question.ToString();
            answerDisplaySeconds.Text = answer.ToString();
            fontBox.Text = multiplier.ToString();
            apiKeyBox.Text = api_key;
        }

        private void saveButtonOnClick(object sender, MouseEventArgs e)
        {
            int questionDisplay, answerDisplay;
            string category;
            float multiplier;

            try{ questionDisplay = Int32.Parse(questionDisplaySeconds.Text); }
            catch { questionDisplay = 60; }

            try { answerDisplay = Int32.Parse(answerDisplaySeconds.Text); }
            catch { answerDisplay = 10; }

            try { category = categories[categoryBox.SelectedIndex]; }
            catch { category = ""; }

            try { multiplier = float.Parse(fontBox.Text); }
            catch { multiplier = 3.0f; }

            settings.setNewSettings(questionDisplay, answerDisplay, category, multiplier, apiKeyBox.Text);
            this.Close();
        }

        private void cancelButtonOnClick(object sender, MouseEventArgs e)
        {
            this.Close();
        }
    }
}
