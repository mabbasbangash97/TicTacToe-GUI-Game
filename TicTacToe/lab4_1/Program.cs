using TicTacToe;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToe
{
    static class game
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new TicTacToe());
        }
    }

    public class Tictactoe{

        private bool ToggleValue = true;
        private String userOne = "O", userTwo = "X";

        protected internal void setToggleValue(bool a) {
            ToggleValue = a;
        }

        protected internal bool getToggleValue() {
            return this.ToggleValue;
        }

        protected internal string getuserOne() {

            return this.userOne;
        }

        protected internal string getuserTwo()
        {
            return this.userTwo;
        }
    }
}
