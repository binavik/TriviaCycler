
using System.Windows.Forms;

namespace TriviaCycler
{
    partial class SettingsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.questionDisplaySeconds = new System.Windows.Forms.TextBox();
            this.answerDisplaySeconds = new System.Windows.Forms.TextBox();
            this.saveSettings = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.categoryBox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.fontBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.apiKeyBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(2, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Question Display:";
            new ToolTip().SetToolTip(this.label1, "Time to display question in seconds, default is 60.");
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(2, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Answer Display:";
            new ToolTip().SetToolTip(this.label2, "Time to display answer in seconds, default is 10.");
            // 
            // questionDisplaySeconds
            // 
            this.questionDisplaySeconds.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.questionDisplaySeconds.Location = new System.Drawing.Point(140, 11);
            this.questionDisplaySeconds.Name = "questionDisplaySeconds";
            this.questionDisplaySeconds.Size = new System.Drawing.Size(213, 26);
            this.questionDisplaySeconds.TabIndex = 2;
            // 
            // answerDisplaySeconds
            // 
            this.answerDisplaySeconds.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.answerDisplaySeconds.Location = new System.Drawing.Point(140, 42);
            this.answerDisplaySeconds.Name = "answerDisplaySeconds";
            this.answerDisplaySeconds.Size = new System.Drawing.Size(213, 26);
            this.answerDisplaySeconds.TabIndex = 3;
            // 
            // saveSettings
            // 
            this.saveSettings.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.saveSettings.Location = new System.Drawing.Point(6, 170);
            this.saveSettings.Name = "saveSettings";
            this.saveSettings.Size = new System.Drawing.Size(117, 28);
            this.saveSettings.TabIndex = 4;
            this.saveSettings.Text = "Save";
            this.saveSettings.UseVisualStyleBackColor = true;
            this.saveSettings.MouseClick += new System.Windows.Forms.MouseEventHandler(this.saveButtonOnClick);
            // 
            // cancelButton
            // 
            this.cancelButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cancelButton.Location = new System.Drawing.Point(233, 170);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(117, 28);
            this.cancelButton.TabIndex = 5;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.MouseClick += new System.Windows.Forms.MouseEventHandler(this.cancelButtonOnClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.Location = new System.Drawing.Point(2, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Category:";
            new ToolTip().SetToolTip(label3, "Question category, default is all.");
            // 
            // categoryBox
            // 
            this.categoryBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.categoryBox.FormattingEnabled = true;
            this.categoryBox.Items.AddRange(new object[] {
            "Any",
            "Art & Literature",
            "Science & Nature",
            "General",
            "Food & Drink",
            "People & Places",
            "Geography",
            "History & Holidays",
            "Entertainment",
            "Toys & Games",
            "Music",
            "Mathematics",
            "Religion & Mythology",
            "Sports & Leisure"});
            this.categoryBox.Location = new System.Drawing.Point(140, 137);
            this.categoryBox.Margin = new System.Windows.Forms.Padding(2);
            this.categoryBox.Name = "categoryBox";
            this.categoryBox.Size = new System.Drawing.Size(213, 28);
            this.categoryBox.TabIndex = 7;
            this.categoryBox.Text = "Select One";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label4.Location = new System.Drawing.Point(2, 77);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Font Multiplier:";
            new ToolTip().SetToolTip(label4, "How many times larger the font should be, default is 2.0");
            // 
            // fontBox
            // 
            this.fontBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.fontBox.Location = new System.Drawing.Point(140, 74);
            this.fontBox.Name = "fontBox";
            this.fontBox.Size = new System.Drawing.Size(213, 26);
            this.fontBox.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label5.Location = new System.Drawing.Point(2, 109);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "API Key:";
            new ToolTip().SetToolTip(label5, "The API Key from your api-ninjas.com account. Required.");
            // 
            // apiKeyBox
            // 
            this.apiKeyBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.apiKeyBox.Location = new System.Drawing.Point(140, 106);
            this.apiKeyBox.Name = "apiKeyBox";
            this.apiKeyBox.Size = new System.Drawing.Size(213, 26);
            this.apiKeyBox.TabIndex = 11;
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(362, 209);
            this.Controls.Add(this.apiKeyBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.fontBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.categoryBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.saveSettings);
            this.Controls.Add(this.answerDisplaySeconds);
            this.Controls.Add(this.questionDisplaySeconds);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximumSize = new System.Drawing.Size(378, 248);
            this.MinimumSize = new System.Drawing.Size(378, 212);
            this.Name = "SettingsForm";
            this.Text = "Settings";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox questionDisplaySeconds;
        private System.Windows.Forms.TextBox answerDisplaySeconds;
        private System.Windows.Forms.Button saveSettings;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox categoryBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox fontBox;
        private Label label5;
        private TextBox apiKeyBox;
    }
}