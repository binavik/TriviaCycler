
namespace TriviaCycler
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.mainMenu1 = new System.Windows.Forms.MainMenu(this.components);
            this.fileMenu = new System.Windows.Forms.MenuItem();
            this.menuStart = new System.Windows.Forms.MenuItem();
            this.menuStop = new System.Windows.Forms.MenuItem();
            this.menuSettings = new System.Windows.Forms.MenuItem();
            this.menuExit = new System.Windows.Forms.MenuItem();
            this.timerBox = new System.Windows.Forms.Label();
            this.qABox = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // mainMenu1
            // 
            this.mainMenu1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.fileMenu});
            // 
            // fileMenu
            // 
            this.fileMenu.Index = 0;
            this.fileMenu.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuStart,
            this.menuStop,
            this.menuSettings,
            this.menuExit});
            this.fileMenu.Text = "File";
            // 
            // menuStart
            // 
            this.menuStart.Enabled = false;
            this.menuStart.Index = 0;
            this.menuStart.Text = "Start";
            this.menuStart.Click += new System.EventHandler(this.MenuStartOnClick);
            // 
            // menuStop
            // 
            this.menuStop.Enabled = false;
            this.menuStop.Index = 1;
            this.menuStop.Text = "Stop";
            this.menuStop.Click += new System.EventHandler(this.MenuStopOnClick);
            // 
            // menuSettings
            // 
            this.menuSettings.Index = 2;
            this.menuSettings.Text = "Settings";
            this.menuSettings.Click += new System.EventHandler(this.MenuSettingsOnClick);
            // 
            // menuExit
            // 
            this.menuExit.Index = 3;
            this.menuExit.Text = "Exit";
            this.menuExit.Click += new System.EventHandler(this.MenuExitOnClick);
            // 
            // timerBox
            // 
            this.timerBox.BackColor = System.Drawing.SystemColors.HighlightText;
            this.timerBox.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.timerBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timerBox.Location = new System.Drawing.Point(0, 280);
            this.timerBox.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.timerBox.Name = "timerBox";
            this.timerBox.Size = new System.Drawing.Size(1050, 193);
            this.timerBox.TabIndex = 1;
            this.timerBox.Text = "{} in XYZ second(s)";
            this.timerBox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // qABox
            // 
            this.qABox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.qABox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.qABox.Location = new System.Drawing.Point(0, 0);
            this.qABox.Margin = new System.Windows.Forms.Padding(2);
            this.qABox.Name = "qABox";
            this.qABox.ReadOnly = true;
            this.qABox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.qABox.Size = new System.Drawing.Size(1050, 280);
            this.qABox.TabIndex = 2;
            this.qABox.Text = "In Rhythmic Gymnastics Competitors Have Five Pieces Of Apparatus The Rope, Hoop, " +
    "Ball, Club And What Else?";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1050, 473);
            this.Controls.Add(this.qABox);
            this.Controls.Add(this.timerBox);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Menu = this.mainMenu1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MainMenu mainMenu1;
        private System.Windows.Forms.MenuItem fileMenu;
        private System.Windows.Forms.MenuItem menuStart;
        private System.Windows.Forms.MenuItem menuStop;
        private System.Windows.Forms.MenuItem menuSettings;
        private System.Windows.Forms.MenuItem menuExit;
        private System.Windows.Forms.Label timerBox;
        private System.Windows.Forms.RichTextBox qABox;
    }
}

