using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace New_Phase_10_Scoring
{
    public partial class UpdateScores : Form
    {

        int firstValue = new int();
        int secondValue = new int();
        int thirdValue = new int();
        int fourthValue = new int();

        public UpdateScores()
        {
            InitializeComponent();
        }

        private void UpdateScores_Load(object sender, EventArgs e)
        {
            firstName.Text = PlayerandScore.allPlayers[0].playerName;
            secondName.Text = PlayerandScore.allPlayers[1].playerName;
            thirdName.Text = PlayerandScore.allPlayers[2].playerName;
            fourthName.Text = PlayerandScore.allPlayers[3].playerName;

            

        }

        private void b_Continue_Click(object sender, EventArgs e)
        {
            int.TryParse(t_firstScore.Text, out firstValue);
            int.TryParse(t_secondScore.Text, out secondValue);
            int.TryParse(t_thirdScore.Text, out thirdValue);
            int.TryParse(t_fourthScore.Text, out fourthValue);

            PlayerandScore.allPlayers[0].playerScore += firstValue;
            PlayerandScore.allPlayers[1].playerScore += secondValue;
            PlayerandScore.allPlayers[2].playerScore += thirdValue;
            PlayerandScore.allPlayers[3].playerScore += fourthValue;

            if(firstPassed.Checked)
            {
                PlayerandScore.allPlayers[0].playerPhase++;
            }

            if (secondPassed.Checked)
            {
                PlayerandScore.allPlayers[1].playerPhase++;
            }

            if (thirdPassed.Checked)
            {
                PlayerandScore.allPlayers[2].playerPhase++;
            }

            if (fourthPassed.Checked)
            {
                PlayerandScore.allPlayers[3].playerPhase++;
            }

            PlayerandScore.bGameOver = CheckForWinner();

            this.Close();
            
        }


        private bool CheckForWinner()
        {
            bool btempWinner = false;
            foreach (var item in PlayerandScore.allPlayers)
            {
                if (item.playerPhase == 11)
                {
                    btempWinner = true;
                    break;
                }
            }

            return btempWinner;
        }

        private void t_firstScore_TextChanged(object sender, EventArgs e)
        {
            b_Continue.Enabled = CheckForAllScores();
        }

        private void t_secondScore_TextChanged(object sender, EventArgs e)
        {
            b_Continue.Enabled = CheckForAllScores();
        }

        private void t_thirdScore_TextChanged(object sender, EventArgs e)
        {
            b_Continue.Enabled = CheckForAllScores();
        }

        private void t_fourthScore_TextChanged(object sender, EventArgs e)
        {
            b_Continue.Enabled = CheckForAllScores();
        }
        
        private void firstPassed_CheckedChanged(object sender, EventArgs e)
        {
            b_Continue.Enabled = CheckForAllScores();
        }

        private void secondPassed_CheckedChanged(object sender, EventArgs e)
        {
            b_Continue.Enabled = CheckForAllScores();
        }

        private void thirdPassed_CheckedChanged(object sender, EventArgs e)
        {
            b_Continue.Enabled = CheckForAllScores();
        }

        private void fourthPassed_CheckedChanged(object sender, EventArgs e)
        {
            b_Continue.Enabled = CheckForAllScores();
        }

        private bool CheckForAllScores()
        {
            bool firstEmpty, secondEmpty, thirdEmpty, fourthEmpty = new bool();

            firstEmpty = string.IsNullOrEmpty(t_firstScore.Text);
            secondEmpty = string.IsNullOrEmpty(t_secondScore.Text);
            thirdEmpty = string.IsNullOrEmpty(t_thirdScore.Text);
            fourthEmpty = string.IsNullOrEmpty(t_fourthScore.Text);

            if (!firstEmpty && !secondEmpty && !thirdEmpty && !fourthEmpty && (firstPassed.Checked || secondPassed.Checked || thirdPassed.Checked || fourthPassed.Checked))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void UpdateScores_FormClosed(object sender, FormClosedEventArgs e)
        {

        }
    }
}
