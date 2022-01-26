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

        public SettingsForm(Form1 form, int question, int answer, int maxFontSize)
        {
            InitializeComponent();
            this.settings = form;
            questionDisplaySeconds.Text = question.ToString();
            answerDisplaySeconds.Text = answer.ToString();
            fontBox.Text = maxFontSize.ToString();
        }

        private void saveButtonOnClick(object sender, MouseEventArgs e)
        {
            int questionDisplay, answerDisplay, maxFontSize;

            try{ questionDisplay = Int32.Parse(questionDisplaySeconds.Text); }
            catch { questionDisplay = 60; }

            try { answerDisplay = Int32.Parse(answerDisplaySeconds.Text); }
            catch { answerDisplay = 10; }

            try { maxFontSize = Int32.Parse(fontBox.Text); }
            catch { maxFontSize = 72; }

            settings.setNewSettings(questionDisplay, answerDisplay, maxFontSize);
            this.Close();
        }

        private void cancelButtonOnClick(object sender, MouseEventArgs e)
        {
            this.Close();
        }
    }
}
