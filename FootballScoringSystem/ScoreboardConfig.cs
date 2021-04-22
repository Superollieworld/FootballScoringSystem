using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace FootballScoringSystem
{
    public partial class ScoreboardConfig : Form
    {
        public ScoreboardConfig()
        {
            InitializeComponent();
        }

        // Team Name Data Members
        public static string HomeTeamName = "";
        public static string AwayTeamName = "";

        public void configStartButton_Click(object sender, EventArgs e)
        {
            // Home Team Validation
            if (configHomeTeamName.Text == "")
            {
                MessageBox.Show("Enter a valid home team name!");
                configHomeTeamName.Focus();
            }
            // Away Team Validation
            else if (configAwayTeamName.Text == "")
            {
                MessageBox.Show("Enter a valid away team name!");
                configAwayTeamName.Focus();
            }
            // Validation success
            else
            {
                this.Hide();
                HomeTeamName = configHomeTeamName.Text;
                AwayTeamName = configAwayTeamName.Text;
                Scoreboard scoreboard = new Scoreboard();
                scoreboard.Show();
            }
        }
    }
}
