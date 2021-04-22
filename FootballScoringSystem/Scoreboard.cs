using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;

namespace FootballScoringSystem
{
    public partial class Scoreboard : Form
    {
        // Score Data Members
        int scoreHomeTeam = 0;
        int scoreAwayTeam = 0;
        // Stopwatch int
        private Stopwatch stopWatch;
        public Scoreboard(string hometeam, string awayteam)
        {
            InitializeComponent();
            labelHomeTeamName.Text = hometeam;
            stopWatch = new Stopwatch();
        }

        private void Scoreboard_Load(object sender, EventArgs e)
        {
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            this.labelTime.Text = string.Format("{0:mm\\:ss}", stopWatch.Elapsed);
        }
        private void Scoreboard_KeyPress(object sender, KeyPressEventArgs e)
        {
            // homeTeamScore Key Functionality
            if (scoreHomeTeam < 99 && e.KeyChar == (char)Keys.D1)
            {
                scoreHomeTeam++;
                labelHomeTeamScore.Text = scoreHomeTeam.ToString("00");
            }
            if (scoreHomeTeam > 0 && e.KeyChar == (char)Keys.D2)
            {
                scoreHomeTeam--;
                labelHomeTeamScore.Text = scoreHomeTeam.ToString("00");
            }

            // awayTeamScore Key Functionality
            if (scoreAwayTeam < 99 && e.KeyChar == (char)Keys.D3)
            {
                scoreAwayTeam++;
                labelAwayTeamScore.Text = scoreAwayTeam.ToString("00");
            }
            if (scoreAwayTeam > 0 && e.KeyChar == (char)Keys.D4)
            {
                scoreAwayTeam--;
                labelAwayTeamScore.Text = scoreAwayTeam.ToString("00");
            }

            // Stopwatch Key Functions
            if (e.KeyChar ==(char)Keys.D5){
                stopWatch.Start();
            } else if (e.KeyChar == (char)Keys.D6)
            {
                stopWatch.Stop();
            } else if (e.KeyChar == (char)Keys.D7)
            {
                stopWatch.Reset();
            }

            // Instructions Reminder 
            if (e.KeyChar == (char)Keys.D0)
            {
                ScoreboardInstructions instructions = new ScoreboardInstructions();
                instructions.Show();
            }
        }
    }
}
