
namespace Week010
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
            this.labelDate = new System.Windows.Forms.Label();
            this.buttonCheck = new System.Windows.Forms.Button();
            this.labelCapacity = new System.Windows.Forms.Label();
            this.labelStadium = new System.Windows.Forms.Label();
            this.labelAwayCaptain = new System.Windows.Forms.Label();
            this.labelAwayManager = new System.Windows.Forms.Label();
            this.labelHomeCaptain = new System.Windows.Forms.Label();
            this.labelHomeManager = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxAwayTeam = new System.Windows.Forms.ComboBox();
            this.comboBoxHomeTeam = new System.Windows.Forms.ComboBox();
            this.labelScore = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelDate
            // 
            this.labelDate.AutoSize = true;
            this.labelDate.Location = new System.Drawing.Point(333, 241);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(38, 17);
            this.labelDate.TabIndex = 23;
            this.labelDate.Text = "Date";
            // 
            // buttonCheck
            // 
            this.buttonCheck.Location = new System.Drawing.Point(353, 207);
            this.buttonCheck.Name = "buttonCheck";
            this.buttonCheck.Size = new System.Drawing.Size(75, 23);
            this.buttonCheck.TabIndex = 22;
            this.buttonCheck.Text = "Check";
            this.buttonCheck.UseVisualStyleBackColor = true;
            // 
            // labelCapacity
            // 
            this.labelCapacity.AutoSize = true;
            this.labelCapacity.Location = new System.Drawing.Point(333, 177);
            this.labelCapacity.Name = "labelCapacity";
            this.labelCapacity.Size = new System.Drawing.Size(62, 17);
            this.labelCapacity.TabIndex = 21;
            this.labelCapacity.Text = "Capacity";
            // 
            // labelStadium
            // 
            this.labelStadium.AutoSize = true;
            this.labelStadium.Location = new System.Drawing.Point(333, 147);
            this.labelStadium.Name = "labelStadium";
            this.labelStadium.Size = new System.Drawing.Size(59, 17);
            this.labelStadium.TabIndex = 20;
            this.labelStadium.Text = "Stadium";
            // 
            // labelAwayCaptain
            // 
            this.labelAwayCaptain.AutoSize = true;
            this.labelAwayCaptain.Location = new System.Drawing.Point(612, 118);
            this.labelAwayCaptain.Name = "labelAwayCaptain";
            this.labelAwayCaptain.Size = new System.Drawing.Size(93, 17);
            this.labelAwayCaptain.TabIndex = 19;
            this.labelAwayCaptain.Text = "Away Captain";
            // 
            // labelAwayManager
            // 
            this.labelAwayManager.AutoSize = true;
            this.labelAwayManager.Location = new System.Drawing.Point(612, 91);
            this.labelAwayManager.Name = "labelAwayManager";
            this.labelAwayManager.Size = new System.Drawing.Size(101, 17);
            this.labelAwayManager.TabIndex = 18;
            this.labelAwayManager.Text = "Away Manager";
            // 
            // labelHomeCaptain
            // 
            this.labelHomeCaptain.AutoSize = true;
            this.labelHomeCaptain.Location = new System.Drawing.Point(65, 118);
            this.labelHomeCaptain.Name = "labelHomeCaptain";
            this.labelHomeCaptain.Size = new System.Drawing.Size(97, 17);
            this.labelHomeCaptain.TabIndex = 17;
            this.labelHomeCaptain.Text = "Home Captain";
            // 
            // labelHomeManager
            // 
            this.labelHomeManager.AutoSize = true;
            this.labelHomeManager.Location = new System.Drawing.Point(65, 91);
            this.labelHomeManager.Name = "labelHomeManager";
            this.labelHomeManager.Size = new System.Drawing.Size(105, 17);
            this.labelHomeManager.TabIndex = 16;
            this.labelHomeManager.Text = "Home Manager";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(377, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 17);
            this.label1.TabIndex = 15;
            this.label1.Text = "VS";
            // 
            // comboBoxAwayTeam
            // 
            this.comboBoxAwayTeam.FormattingEnabled = true;
            this.comboBoxAwayTeam.Location = new System.Drawing.Point(615, 46);
            this.comboBoxAwayTeam.Name = "comboBoxAwayTeam";
            this.comboBoxAwayTeam.Size = new System.Drawing.Size(121, 24);
            this.comboBoxAwayTeam.TabIndex = 14;
            // 
            // comboBoxHomeTeam
            // 
            this.comboBoxHomeTeam.FormattingEnabled = true;
            this.comboBoxHomeTeam.Location = new System.Drawing.Point(65, 46);
            this.comboBoxHomeTeam.Name = "comboBoxHomeTeam";
            this.comboBoxHomeTeam.Size = new System.Drawing.Size(121, 24);
            this.comboBoxHomeTeam.TabIndex = 13;
            this.comboBoxHomeTeam.SelectedIndexChanged += new System.EventHandler(this.comboBoxHomeTeam_SelectedIndexChanged);
            // 
            // labelScore
            // 
            this.labelScore.AutoSize = true;
            this.labelScore.Location = new System.Drawing.Point(333, 268);
            this.labelScore.Name = "labelScore";
            this.labelScore.Size = new System.Drawing.Size(45, 17);
            this.labelScore.TabIndex = 24;
            this.labelScore.Text = "Score";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelScore);
            this.Controls.Add(this.labelDate);
            this.Controls.Add(this.buttonCheck);
            this.Controls.Add(this.labelCapacity);
            this.Controls.Add(this.labelStadium);
            this.Controls.Add(this.labelAwayCaptain);
            this.Controls.Add(this.labelAwayManager);
            this.Controls.Add(this.labelHomeCaptain);
            this.Controls.Add(this.labelHomeManager);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxAwayTeam);
            this.Controls.Add(this.comboBoxHomeTeam);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelDate;
        private System.Windows.Forms.Button buttonCheck;
        private System.Windows.Forms.Label labelCapacity;
        private System.Windows.Forms.Label labelStadium;
        private System.Windows.Forms.Label labelAwayCaptain;
        private System.Windows.Forms.Label labelAwayManager;
        private System.Windows.Forms.Label labelHomeCaptain;
        private System.Windows.Forms.Label labelHomeManager;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxAwayTeam;
        private System.Windows.Forms.ComboBox comboBoxHomeTeam;
        private System.Windows.Forms.Label labelScore;
    }
}

