
namespace FootballScoringSystem
{
    partial class ScoreboardInstructions
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ScoreboardInstructions));
            this.Instructions = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Instructions
            // 
            this.Instructions.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Instructions.AutoSize = true;
            this.Instructions.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Instructions.ForeColor = System.Drawing.Color.Snow;
            this.Instructions.Location = new System.Drawing.Point(80, 10);
            this.Instructions.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Instructions.Name = "Instructions";
            this.Instructions.Size = new System.Drawing.Size(517, 333);
            this.Instructions.TabIndex = 3;
            this.Instructions.Text = resources.GetString("Instructions.Text");
            this.Instructions.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ScoreboardInstructions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(682, 353);
            this.Controls.Add(this.Instructions);
            this.MaximumSize = new System.Drawing.Size(700, 400);
            this.MinimumSize = new System.Drawing.Size(700, 400);
            this.Name = "ScoreboardInstructions";
            this.Text = "Instructions";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Instructions;
    }
}