using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace TicTacToe
{
    public partial class TicTacToe : Form
    {
        Tictactoe obj = new Tictactoe();
        private SoundPlayer click = new SoundPlayer("E:\\Study Material\\V\\Visual Programming C#\\lab4\\lab4_1\\lab4_1\\sounds\\click.wav");
        private SoundPlayer winner = new SoundPlayer("E:\\Study Material\\V\\Visual Programming C#\\lab4\\lab4_1\\lab4_1\\sounds\\winner.wav");
        int counter = 0;
        public TicTacToe()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            counter++;
            click.Play();
            if (obj.getToggleValue())
            {
                this.button1.Text = obj.getuserOne();
                obj.setToggleValue(false);
            }
            else
            {
                this.button1.Text = obj.getuserTwo();
                obj.setToggleValue(true);
            }
            this.button1.Enabled = false;
            Turn(Convert.ToString(this.button1.Text));
            Check();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            counter++;
            click.Play();
            if (obj.getToggleValue())
            {
                this.button2.Text = obj.getuserOne();
                obj.setToggleValue(false);
            }
            else
            {
                this.button2.Text = obj.getuserTwo();
                obj.setToggleValue(true);
            }
            this.button2.Enabled = false;
            Turn(Convert.ToString(this.button2.Text));
            Check();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            counter++;
            click.Play();
            if (obj.getToggleValue())
            {
                this.button3.Text = obj.getuserOne();
                obj.setToggleValue(false);
            }
            else
            {
                this.button3.Text = obj.getuserTwo();
                obj.setToggleValue(true);
            }
            this.button3.Enabled = false;
            Turn(Convert.ToString(this.button3.Text));
            Check();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            counter++;
            click.Play();
            if (obj.getToggleValue())
            {
                this.button4.Text = obj.getuserOne();
                obj.setToggleValue(false);
            }
            else
            {
                this.button4.Text = obj.getuserTwo();
                obj.setToggleValue(true);
            }
            this.button4.Enabled = false;
            Turn(Convert.ToString(this.button4.Text));
            Check();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            counter++;
            click.Play();
            if (obj.getToggleValue())
            {
                this.button5.Text = obj.getuserOne();
                obj.setToggleValue(false);
            }
            else
            {
                this.button5.Text = obj.getuserTwo();
                obj.setToggleValue(true);
            }
            this.button5.Enabled = false;
            Turn(Convert.ToString(this.button5.Text));
            Check();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            counter++;
            click.Play();
            if (obj.getToggleValue())
            {
                this.button6.Text = obj.getuserOne();
                obj.setToggleValue(false);
            }
            else
            {
                this.button6.Text = obj.getuserTwo();
                obj.setToggleValue(true);
            }
            this.button6.Enabled = false;
            Turn(Convert.ToString(this.button6.Text));
            Check();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            click.Play();
            if (obj.getToggleValue())
            {
                counter++;
                this.button7.Text = obj.getuserOne();
                obj.setToggleValue(false);
            }
            else
            {
                this.button7.Text = obj.getuserTwo();
                obj.setToggleValue(true);
            }
            this.button7.Enabled = false;
            Turn(Convert.ToString(this.button7.Text));
            Check();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            counter++;
            if (obj.getToggleValue())
            {
                click.Play();
                this.button8.Text = obj.getuserOne();
                obj.setToggleValue(false);
            }
            else
            {
                this.button8.Text = obj.getuserTwo();
                obj.setToggleValue(true);
            }
            this.button8.Enabled = false;
            Turn(Convert.ToString(this.button8.Text));
            Check();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            counter++;
            click.Play();
            if (obj.getToggleValue())
            {
                this.button9.Text = obj.getuserOne();
                obj.setToggleValue(false);
            }
            else
            {
                this.button9.Text = obj.getuserTwo();
                obj.setToggleValue(true);
            }
            this.button9.Enabled = false;
            Turn(Convert.ToString(this.button9.Text));
            Check();
        }

        private void restart_click(object sender, EventArgs e)
        {
            this.button1.Enabled = true;
            this.button2.Enabled = true; 
            this.button3.Enabled = true;
            this.button4.Enabled = true;
            this.button5.Enabled = true;
            this.button6.Enabled = true;
            this.button7.Enabled = true;
            this.button8.Enabled = true;
            this.button9.Enabled = true;
            this.button1.Text = "";
            this.button2.Text = "";
            this.button3.Text = "";
            this.button4.Text = "";
            this.button5.Text = "";
            this.button6.Text = "";
            this.button7.Text = "";
            this.button8.Text = "";
            this.button9.Text = "";
            this.playing.Text = "Winner: N/A";
            this.turn.Text = "Playing:";
            counter = 0;

        }

        private void Check() 
        {
            if (counter == 9)
            {
                Disable_all();
                playing.ForeColor = System.Drawing.Color.Red;
                turn.ForeColor = System.Drawing.Color.Red;
                this.playing.Text = "DRAW!";
                this.turn.Text = "Game Finished!";
            }
            else
            {

                if (button1.Text == "O" && button2.Text == "O" && button3.Text == "O")
                {
                    Disable_all();
                    Winner('O');
                }
                else if (button1.Text == "O" && button5.Text == "O" && button9.Text == "O")
                {
                    Disable_all();
                    Winner('O');
                }
                else if (button1.Text == "O" && button4.Text == "O" && button7.Text == "O")
                {
                    Disable_all();
                    Winner('O');
                }
                else if (button4.Text == "O" && button5.Text == "O" && button6.Text == "O")
                {
                    Disable_all();
                    Winner('O');
                }
                else if (button7.Text == "O" && button8.Text == "O" && button9.Text == "O")
                {
                    Disable_all();
                    Winner('O');
                }
                else if (button7.Text == "O" && button5.Text == "O" && button3.Text == "O")
                {
                    Disable_all();
                    Winner('O');
                }
                else if (button2.Text == "O" && button5.Text == "O" && button8.Text == "O")
                {
                    Disable_all();
                    Winner('O');
                }
                else if (button3.Text == "O" && button6.Text == "O" && button9.Text == "O")
                {
                    Disable_all();
                    Winner('O');
                }
                //////for X
                if (button1.Text == "X" && button2.Text == "X" && button3.Text == "X")
                {
                    Disable_all();
                    Winner('X');
                }
                else if (button1.Text == "X" && button5.Text == "X" && button9.Text == "X")
                {
                    Disable_all();
                    Winner('X');
                }
                else if (button1.Text == "X" && button4.Text == "X" && button7.Text == "X")
                {
                    Disable_all();
                }
                else if (button4.Text == "X" && button5.Text == "X" && button6.Text == "X")
                {
                    Disable_all();
                    Winner('X');
                }
                else if (button7.Text == "X" && button8.Text == "X" && button9.Text == "X")
                {
                    Disable_all();
                    Winner('X');
                }
                else if (button7.Text == "X" && button5.Text == "X" && button3.Text == "X")
                {
                    Disable_all();
                    Winner('X');
                }
                else if (button2.Text == "X" && button5.Text == "X" && button8.Text == "X")
                {
                    Disable_all();
                    Winner('X');
                }
                else if (button3.Text == "X" && button6.Text == "X" && button9.Text == "X")
                {
                    Disable_all();
                    Winner('X');
                }
            }
        }
        private void Disable_all()
        {
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = false;
            button6.Enabled = false;
            button7.Enabled = false;
            button8.Enabled = false;
            button9.Enabled = false;
        }
        private void Winner(char a) {
            winner.Play();
            playing.ForeColor = System.Drawing.Color.Red;
            turn.ForeColor = System.Drawing.Color.Red;
            this.turn.Text = "Game Finished!";
            if (a == 'O')
            {
                this.playing.Text = "Winner: O";
            }
            else
                this.playing.Text = "Winner: X";
        }
        private void Turn(string z)
        {
            if (z == "X")
            {
                this.turn.Text = "Playing: O";
            }
            else
                this.turn.Text = "Playing: X";
        }


    }
}
