
namespace FootballScoringSystem
{
    partial class Scoreboard
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
            this.labelAwayTeamScore = new System.Windows.Forms.Label();
            this.labelHomeTeamScore = new System.Windows.Forms.Label();
            this.labelHomeTeamName = new System.Windows.Forms.Label();
            this.labelVS = new System.Windows.Forms.Label();
            this.labelAwayTeamName = new System.Windows.Forms.Label();
            this.labelTimeName = new System.Windows.Forms.Label();
            this.labelTime = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // labelAwayTeamScore
            // 
            this.labelAwayTeamScore.AutoSize = true;
            this.labelAwayTeamScore.Font = new System.Drawing.Font("Stencil", 150F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelAwayTeamScore.ForeColor = System.Drawing.Color.Red;
            this.labelAwayTeamScore.Location = new System.Drawing.Point(780, 230);
            this.labelAwayTeamScore.Name = "labelAwayTeamScore";
            this.labelAwayTeamScore.Size = new System.Drawing.Size(414, 296);
            this.labelAwayTeamScore.TabIndex = 0;
            this.labelAwayTeamScore.Text = "00";
            this.labelAwayTeamScore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelHomeTeamScore
            // 
            this.labelHomeTeamScore.AutoSize = true;
            this.labelHomeTeamScore.Font = new System.Drawing.Font("Stencil", 150F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelHomeTeamScore.ForeColor = System.Drawing.Color.Red;
            this.labelHomeTeamScore.Location = new System.Drawing.Point(75, 230);
            this.labelHomeTeamScore.Name = "labelHomeTeamScore";
            this.labelHomeTeamScore.Size = new System.Drawing.Size(414, 296);
            this.labelHomeTeamScore.TabIndex = 1;
            this.labelHomeTeamScore.Text = "00";
            this.labelHomeTeamScore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelHomeTeamName
            // 
            this.labelHomeTeamName.AutoSize = true;
            this.labelHomeTeamName.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelHomeTeamName.ForeColor = System.Drawing.Color.Yellow;
            this.labelHomeTeamName.Location = new System.Drawing.Point(40, 120);
            this.labelHomeTeamName.Name = "labelHomeTeamName";
            this.labelHomeTeamName.Size = new System.Drawing.Size(494, 81);
            this.labelHomeTeamName.TabIndex = 2;
            this.labelHomeTeamName.Tag = "";
            this.labelHomeTeamName.Text = "HomeTeamName";
            this.labelHomeTeamName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelVS
            // 
            this.labelVS.AutoSize = true;
            this.labelVS.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelVS.ForeColor = System.Drawing.Color.Yellow;
            this.labelVS.Location = new System.Drawing.Point(590, 120);
            this.labelVS.Name = "labelVS";
            this.labelVS.Size = new System.Drawing.Size(104, 81);
            this.labelVS.TabIndex = 3;
            this.labelVS.Text = "VS";
            // 
            // labelAwayTeamName
            // 
            this.labelAwayTeamName.AutoSize = true;
            this.labelAwayTeamName.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelAwayTeamName.ForeColor = System.Drawing.Color.Yellow;
            this.labelAwayTeamName.Location = new System.Drawing.Point(750, 120);
            this.labelAwayTeamName.Name = "labelAwayTeamName";
            this.labelAwayTeamName.Size = new System.Drawing.Size(474, 81);
            this.labelAwayTeamName.TabIndex = 4;
            this.labelAwayTeamName.Text = "AwayTeamName";
            this.labelAwayTeamName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelTimeName
            // 
            this.labelTimeName.AutoSize = true;
            this.labelTimeName.Font = new System.Drawing.Font("Segoe UI", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelTimeName.ForeColor = System.Drawing.Color.Yellow;
            this.labelTimeName.Location = new System.Drawing.Point(570, 280);
            this.labelTimeName.Name = "labelTimeName";
            this.labelTimeName.Size = new System.Drawing.Size(128, 62);
            this.labelTimeName.TabIndex = 5;
            this.labelTimeName.Text = "Time";
            this.labelTimeName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelTime
            // 
            this.labelTime.AutoSize = true;
            this.labelTime.Font = new System.Drawing.Font("Stencil", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelTime.ForeColor = System.Drawing.Color.Yellow;
            this.labelTime.Location = new System.Drawing.Point(540, 350);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(185, 71);
            this.labelTime.TabIndex = 6;
            this.labelTime.Text = "00:00";
            this.labelTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Tag = "";
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // Scoreboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Desktop;
            this.ClientSize = new System.Drawing.Size(1262, 673);
            this.Controls.Add(this.labelTime);
            this.Controls.Add(this.labelTimeName);
            this.Controls.Add(this.labelAwayTeamName);
            this.Controls.Add(this.labelVS);
            this.Controls.Add(this.labelHomeTeamName);
            this.Controls.Add(this.labelHomeTeamScore);
            this.Controls.Add(this.labelAwayTeamScore);
            this.MaximumSize = new System.Drawing.Size(1280, 720);
            this.MinimumSize = new System.Drawing.Size(1280, 720);
            this.Name = "Scoreboard";
            this.Text = "Scoreboard";
            this.Load += new System.EventHandler(this.Scoreboard_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Scoreboard_KeyPress);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label AwayTeamLabel;
        private System.Windows.Forms.Label labelVS;
        private System.Windows.Forms.Label labelAwayTeamName;
        private System.Windows.Forms.Label labelAwayTeamScore;
        private System.Windows.Forms.Label labelTimeName;
        private System.Windows.Forms.Label labelTime;
        public System.Windows.Forms.Label labelHomeTeamName;
        private System.Windows.Forms.Timer timer;
        public System.Windows.Forms.Label labelHomeTeamScore;
    }
}