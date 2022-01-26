
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
            this.label4 = new System.Windows.Forms.Label();
            this.fontBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(3, 17);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Question Display:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(3, 55);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(153, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Answer Display:";
            // 
            // questionDisplaySeconds
            // 
            this.questionDisplaySeconds.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.questionDisplaySeconds.Location = new System.Drawing.Point(187, 14);
            this.questionDisplaySeconds.Margin = new System.Windows.Forms.Padding(4);
            this.questionDisplaySeconds.Name = "questionDisplaySeconds";
            this.questionDisplaySeconds.Size = new System.Drawing.Size(283, 30);
            this.questionDisplaySeconds.TabIndex = 2;
            // 
            // answerDisplaySeconds
            // 
            this.answerDisplaySeconds.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.answerDisplaySeconds.Location = new System.Drawing.Point(187, 52);
            this.answerDisplaySeconds.Margin = new System.Windows.Forms.Padding(4);
            this.answerDisplaySeconds.Name = "answerDisplaySeconds";
            this.answerDisplaySeconds.Size = new System.Drawing.Size(283, 30);
            this.answerDisplaySeconds.TabIndex = 3;
            // 
            // saveSettings
            // 
            this.saveSettings.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.saveSettings.Location = new System.Drawing.Point(8, 129);
            this.saveSettings.Margin = new System.Windows.Forms.Padding(4);
            this.saveSettings.Name = "saveSettings";
            this.saveSettings.Size = new System.Drawing.Size(156, 34);
            this.saveSettings.TabIndex = 4;
            this.saveSettings.Text = "Save";
            this.saveSettings.UseVisualStyleBackColor = true;
            this.saveSettings.MouseClick += new System.Windows.Forms.MouseEventHandler(this.saveButtonOnClick);
            // 
            // cancelButton
            // 
            this.cancelButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cancelButton.Location = new System.Drawing.Point(311, 129);
            this.cancelButton.Margin = new System.Windows.Forms.Padding(4);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(156, 34);
            this.cancelButton.TabIndex = 5;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.MouseClick += new System.Windows.Forms.MouseEventHandler(this.cancelButtonOnClick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label4.Location = new System.Drawing.Point(3, 95);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(144, 25);
            this.label4.TabIndex = 8;
            this.label4.Text = "Max Font Size:";
            // 
            // fontBox
            // 
            this.fontBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.fontBox.Location = new System.Drawing.Point(187, 91);
            this.fontBox.Margin = new System.Windows.Forms.Padding(4);
            this.fontBox.Name = "fontBox";
            this.fontBox.Size = new System.Drawing.Size(283, 30);
            this.fontBox.TabIndex = 9;
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(480, 172);
            this.Controls.Add(this.fontBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.saveSettings);
            this.Controls.Add(this.answerDisplaySeconds);
            this.Controls.Add(this.questionDisplaySeconds);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximumSize = new System.Drawing.Size(498, 219);
            this.MinimumSize = new System.Drawing.Size(498, 219);
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
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox fontBox;
    }
}