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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        

        private void Continue_Click(object sender, EventArgs e)
        {
            string[] tempNames = new string[4];

            tempNames[0] = player1Name.Text;
            tempNames[1] = player2Name.Text;
            tempNames[2] = player3Name.Text;
            tempNames[3] = player4Name.Text;


            for (int i = 0; i < 4; i++)
            {
                if (tempNames[i] != null && tempNames[i] != "")
                {
                    addNewPlayerName(tempNames[i], i);
                }
            }

            this.Close();
        }

        public void addNewPlayerName(string newName, int playerNum)
        {
            if (playerNum + 1 > PlayerandScore.totalPlayers)
            {
                PlayerandScore.allPlayers.Add(new PlayerandScore(newName));
                PlayerandScore.totalPlayers++;
            }
            else if ((newName == "" || newName == null) && PlayerandScore.allPlayers[playerNum].playerName != "")
            {
                PlayerandScore.allPlayers.RemoveAt(playerNum);
                PlayerandScore.totalPlayers--;
            }
            else
            {
                PlayerandScore.allPlayers[playerNum].playerName = newName;
            }


        }

    }

    
}
