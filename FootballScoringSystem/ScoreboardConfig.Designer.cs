
namespace FootballScoringSystem
{
    partial class ScoreboardConfig
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ScoreboardConfig));
            this.configTitleLabel = new System.Windows.Forms.Label();
            this.configInfoLabel = new System.Windows.Forms.Label();
            this.configHomeLabel = new System.Windows.Forms.Label();
            this.configAwayLabel = new System.Windows.Forms.Label();
            this.configHomeTeamName = new System.Windows.Forms.TextBox();
            this.configStartButton = new System.Windows.Forms.Button();
            this.configAwayTeamName = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // configTitleLabel
            // 
            this.configTitleLabel.AutoSize = true;
            this.configTitleLabel.Font = new System.Drawing.Font("Calibri", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.configTitleLabel.ForeColor = System.Drawing.Color.Snow;
            this.configTitleLabel.Location = new System.Drawing.Point(205, 26);
            this.configTitleLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.configTitleLabel.Name = "configTitleLabel";
            this.configTitleLabel.Size = new System.Drawing.Size(622, 73);
            this.configTitleLabel.TabIndex = 1;
            this.configTitleLabel.Text = "Football Scoring System";
            this.configTitleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // configInfoLabel
            // 
            this.configInfoLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.configInfoLabel.AutoSize = true;
            this.configInfoLabel.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.configInfoLabel.ForeColor = System.Drawing.Color.Snow;
            this.configInfoLabel.Location = new System.Drawing.Point(450, 160);
            this.configInfoLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.configInfoLabel.Name = "configInfoLabel";
            this.configInfoLabel.Size = new System.Drawing.Size(517, 333);
            this.configInfoLabel.TabIndex = 2;
            this.configInfoLabel.Text = resources.GetString("configInfoLabel.Text");
            this.configInfoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // configHomeLabel
            // 
            this.configHomeLabel.AutoSize = true;
            this.configHomeLabel.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.configHomeLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.configHomeLabel.Location = new System.Drawing.Point(51, 179);
            this.configHomeLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.configHomeLabel.Name = "configHomeLabel";
            this.configHomeLabel.Size = new System.Drawing.Size(299, 37);
            this.configHomeLabel.TabIndex = 3;
            this.configHomeLabel.Text = "Enter home team name:";
            // 
            // configAwayLabel
            // 
            this.configAwayLabel.AutoSize = true;
            this.configAwayLabel.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.configAwayLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.configAwayLabel.Location = new System.Drawing.Point(51, 307);
            this.configAwayLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.configAwayLabel.Name = "configAwayLabel";
            this.configAwayLabel.Size = new System.Drawing.Size(292, 37);
            this.configAwayLabel.TabIndex = 4;
            this.configAwayLabel.Text = "Enter away team name:";
            // 
            // configHomeTeamName
            // 
            this.configHomeTeamName.Location = new System.Drawing.Point(51, 230);
            this.configHomeTeamName.Margin = new System.Windows.Forms.Padding(2);
            this.configHomeTeamName.Name = "configHomeTeamName";
            this.configHomeTeamName.Size = new System.Drawing.Size(282, 27);
            this.configHomeTeamName.TabIndex = 8;
            // 
            // configStartButton
            // 
            this.configStartButton.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.configStartButton.Location = new System.Drawing.Point(77, 435);
            this.configStartButton.Margin = new System.Windows.Forms.Padding(2);
            this.configStartButton.Name = "configStartButton";
            this.configStartButton.Size = new System.Drawing.Size(230, 51);
            this.configStartButton.TabIndex = 7;
            this.configStartButton.Text = "Start";
            this.configStartButton.UseVisualStyleBackColor = true;
            this.configStartButton.Click += new System.EventHandler(this.configStartButton_Click);
            // 
            // configAwayTeamName
            // 
            this.configAwayTeamName.Location = new System.Drawing.Point(51, 358);
            this.configAwayTeamName.Margin = new System.Windows.Forms.Padding(2);
            this.configAwayTeamName.Name = "configAwayTeamName";
            this.configAwayTeamName.Size = new System.Drawing.Size(282, 27);
            this.configAwayTeamName.TabIndex = 9;
            this.configAwayTeamName.TextChanged += new System.EventHandler(this.configAwayTeamName_TextChanged);
            // 
            // ScoreboardConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.Desktop;
            this.ClientSize = new System.Drawing.Size(1010, 538);
            this.Controls.Add(this.configAwayTeamName);
            this.Controls.Add(this.configStartButton);
            this.Controls.Add(this.configHomeTeamName);
            this.Controls.Add(this.configAwayLabel);
            this.Controls.Add(this.configHomeLabel);
            this.Controls.Add(this.configInfoLabel);
            this.Controls.Add(this.configTitleLabel);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximumSize = new System.Drawing.Size(1028, 585);
            this.MinimumSize = new System.Drawing.Size(1028, 585);
            this.Name = "ScoreboardConfig";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ScoreboardConfig";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label configTitleLabel;
        private System.Windows.Forms.Label configInfoLabel;
        private System.Windows.Forms.Label configHomeLabel;
        private System.Windows.Forms.Label configAwayLabel;
        private System.Windows.Forms.TextBox configHomeTeamName;
        private System.Windows.Forms.Button configStartButton;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox configAwayTeamName;
    }
}