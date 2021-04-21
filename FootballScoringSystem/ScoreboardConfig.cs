using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace FootballScoringSystem
{
    public partial class ScoreboardConfig: Form
    {
        public ScoreboardConfig()
        {
            InitializeComponent();
        }

        private Form Scoreboard;

        private void configStartButton_Click(object sender,EventArgs e)
        {
            // Home Team Validation
            if (configHomeTeamName.Text =="")
            {
                MessageBox.Show("Enter a valid home team name!");
                configHomeTeamName.Focus();
            } 
            // Away Team Validation
            else if (configAwayTeamName.Text == "") {
                MessageBox.Show("Enter a valid away team name!");
                configHomeTeamName.Focus();
            } 
            // Validation success
            else
            {

            }
        }

        private void configHomeTeamName_TextChanged(object sender, EventArgs e)
        {
            string configHomeTeamName.Text = HomeTeamName;
        }

        private void configAwayTeamName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
