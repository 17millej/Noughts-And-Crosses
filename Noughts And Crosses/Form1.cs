using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Noughts_And_Crosses
{
    public partial class Form1 : Form
    {

        bool turn = true; // true = X
        int turnCount = 0;

        public Form1()
        {
            InitializeComponent();
            FormBorderStyle = FormBorderStyle.None;
        }

        private void button_click(object sender, EventArgs e)
        {
            Button b = (Button)sender;

            if (turn)
            {
                b.Text = "X";      
            }
            else
            {
                b.Text = "O";
            }


            CheckWin();
            b.Enabled = false;
            turn = !turn;
            turnCount++;
        }

        private void button_start(object sender, EventArgs e)
        {
            for(int i = 0; i < 11; i++)
            {
                //b.Enabled = true;
            }
        }

        private void button_exit(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void CheckWin()
        {
            bool win = false;
            string player;

            if (turn)
            {
                player = "X";
            }
            else
            {
                player = "O";
            }

            //horizontal
            if((button11.Text == button21.Text)&&(button21.Text == button31.Text)&&(button11.Text != ""))
            {
                win = true;
            }
            else if ((button12.Text == button22.Text) && (button22.Text == button32.Text) && (button12.Text != ""))
            {
                win = true;
            }
            else if ((button13.Text == button23.Text) && (button23.Text == button33.Text)&&(button13.Text != ""))
            {
                win = true;
            }

            //vertical
            if ((button11.Text == button12.Text) && (button12.Text == button13.Text) && (button11.Text != ""))
            {
                win = true;
            }
            else if ((button21.Text == button22.Text) && (button22.Text == button23.Text) && (button21.Text != ""))
            {
                win = true;
            }
            else if ((button31.Text == button32.Text) && (button32.Text == button33.Text) && (button31.Text != ""))
            {
                win = true;
            }

            //diagonal
            if ((button11.Text == button22.Text) && (button22.Text == button33.Text) && (button11.Text != ""))
            {
                win = true;
            }
            else if ((button13.Text == button22.Text) && (button22.Text == button31.Text) && (button13.Text != ""))
            {
                win = true;
            }
            else if(turnCount == 8)
            {
                MessageBox.Show("Draw!");
            }

            if (win)
            {
                MessageBox.Show($"{player} wins!");
            }
        }
    }
}
