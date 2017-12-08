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
    public partial class DisplayScores : Form
    {
        List<PlayerandScore> lPlayerRankTemp = new List<PlayerandScore>();

        public DisplayScores()
        {
            InitializeComponent();
        }

        private void DisplayScores_Load(object sender, EventArgs e)
        {
            RefreshStats();
        }

        private void bRoundFin_Click(object sender, EventArgs e)
        {
            UpdateScores form = new UpdateScores();
            form.FormClosed += new FormClosedEventHandler(this.UpdateFormClosed);
            form.Show();
        }

        private void UpdateFormClosed(object sender, EventArgs e)
        {
            RefreshStats();
            this.Refresh();
        }

        private void RefreshStats()
        {
            lPlayerRankTemp = PlayerandScore.UpdateRanks();


            firstPlaceName.Text = lPlayerRankTemp[0].playerName;
            secondPlaceName.Text = lPlayerRankTemp[1].playerName;
            thirdPlaceName.Text = lPlayerRankTemp[2].playerName;
            fourthPlaceName.Text = lPlayerRankTemp[3].playerName;

            firstPhase.Text = lPlayerRankTemp[0].playerPhase.ToString();
            secondPhase.Text = lPlayerRankTemp[1].playerPhase.ToString();
            thirdPhase.Text = lPlayerRankTemp[2].playerPhase.ToString();
            fourthPhase.Text = lPlayerRankTemp[3].playerPhase.ToString();

            firstScore.Text = lPlayerRankTemp[0].playerScore.ToString();
            secondScore.Text = lPlayerRankTemp[1].playerScore.ToString();
            thirdScore.Text = lPlayerRankTemp[2].playerScore.ToString();
            fourthScore.Text = lPlayerRankTemp[3].playerScore.ToString();

            if (PlayerandScore.bGameOver)
            {
                AnnounceWinner();
            }

        }

        private void AnnounceWinner()
        {
            bRoundFin.Text = "Play Again";
        }
    }
}
