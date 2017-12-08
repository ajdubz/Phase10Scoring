using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace New_Phase_10_Scoring
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        /// 

        [STAThread]
        static void Main()
        {

            

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            


            AskForNames();
            Application.Run(new DisplayScores());
        }

        private static void AskForNames()
        {
            Application.Run(new Form1());
        }
    }
}

/*
- [AskForNames Screen] Have dropdown in top-middle of screen that says "total players" with the count in parentheses and a dropdown arrow, where when clicked will pull all current player names 
- [AskForNames Screen] Just do one name per "screen", with a "done" button in top right, and a "next player" button in bottom right. Maybe a "edit players" button in case they change their mind on a name
     already put in.
- [DisplayScores Screen] I'd like to better acknowledge the winner when it's game over. Make sure to say x person won (with some celebration thing), then maybe give a "recap" button to see full stats
- [DisplayScores Screen] I'd like to have a button for the phase rules descriptions (and eventually examples/pictures)
- [general] Need to make sure I account for any number of players, not just 4.
*/
