using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bke2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int zetnummer = 0;
        int winner = 0;
        int gelijkspel = 0;
        string bb1;
        string bb2;
        string bb3;
        string bb4;
        string bb5;
        string bb6;
        string bb7;
        string bb8;
        string bb9;
        string currentbuttonclicked;

        string buttonclicked(string button)
        {
            currentbuttonclicked = button;
            return button;
        }

        string zet(int stap)
        {
            string welke;
            if (stap == 0)
            {
                welke = "X";
                zetnummer++;
            }
            else
            {
                welke = "O";
                zetnummer--;
            }
            return welke;
        }

        private void checkgelijk()
        {
            if (gelijkspel >= 5 && winner != 1)
            {
                MessageBox.Show("Gelijkspel!");
                b1.Text = "";
                b2.Text = "";
                b3.Text = "";
                b4.Text = "";
                b5.Text = "";
                b6.Text = "";
                b7.Text = "";
                b8.Text = "";
                b9.Text = "";
                winner = 0;
                zetnummer--;
                gelijkspel = 0;
            }
        }

        private void win()
        {
            if (zetnummer == 0 && winner == 0)
            {
                winner = 1;
                MessageBox.Show("O heeft gewonnen");
                b1.Text = "";
                b2.Text = "";
                b3.Text = "";
                b4.Text = "";
                b5.Text = "";
                b6.Text = "";
                b7.Text = "";
                b8.Text = "";
                b9.Text = "";
                winner = 0;
                gelijkspel = 0;
                zetnummer--;
            }
            if (zetnummer == 1 && winner == 0)
            {
                winner = 1;
                MessageBox.Show("X heeft gewonnen");
                b1.Text = "";
                b2.Text = "";
                b3.Text = "";
                b4.Text = "";
                b5.Text = "";
                b6.Text = "";
                b7.Text = "";
                b8.Text = "";
                b9.Text = "";
                winner = 0;
                gelijkspel = 0;
            }
        }

        private void checkwin()
        {
            if (b1.Text == b2.Text && b2.Text == b3.Text && b3.Text != "")
            {
                if (b1.Text == "X")
                {
                    win();
                    zetnummer--;
                }
                else
                {
                    win();
                    zetnummer++;
                }
            }
            if (b4.Text == b5.Text && b5.Text == b6.Text && b6.Text != "")
            {
                if (b4.Text == "X")
                {
                    win();
                    zetnummer--;
                }
                else
                {
                    win();
                    zetnummer++;
                }
            }

            if (b7.Text == b8.Text && b8.Text == b9.Text && b9.Text != "")
            {
                if (b7.Text == "X")
                {
                    win();
                    zetnummer--;
                }
                else
                {
                    win();
                    zetnummer++;
                }
            }

            if (b1.Text == b4.Text && b4.Text == b7.Text && b7.Text != "")
            {
                if (b1.Text == "X")
                {
                    win();
                    zetnummer--;
                }
                else
                {
                    win();
                    zetnummer++;
                }
            }

            if (b2.Text == b5.Text && b5.Text == b8.Text && b8.Text != "")
            {
                if (b2.Text == "X")
                {
                    win();
                    zetnummer--;
                }
                else
                {
                    win();
                    zetnummer++;
                }
            }

            if (b3.Text == b6.Text && b6.Text == b9.Text && b9.Text != "")
            {
                if (b3.Text == "X")
                {
                    win();
                    zetnummer--;
                }
                else
                {
                    win();
                    zetnummer++;
                }
            }

            if (b3.Text == b5.Text && b5.Text == b7.Text && b7.Text != "")
            {
                if (b3.Text == "X")
                {
                    win();
                    zetnummer--;
                }
                else
                {
                    win();
                    zetnummer++;
                }
            }
            if (b1.Text == b5.Text && b5.Text == b9.Text && b9.Text != "")
            {
                if (b1.Text == "X")
                {
                    win();
                    zetnummer--;
                }
                else
                {
                    win();
                    zetnummer++;
                }
            }
        }

        private void checkbeurt()
        {
            int spelernummer = zetnummer;
            if (spelernummer == 0)
            { label2.Text = "Speler X is aan de beurt"; }
            else
            { label2.Text = "Speler O is aan de beurt"; }


        }

        private void clicked(object sender)
        {
            Button btn = (Button)sender;
            if (btn.Text == "" && winner != 1)
            {
                btn.Text = "X";
                zetnummer++;
                gelijkspel++;
                checkwin();
                checkgelijk();
            }
            if (winner != 1)
            {
                algoritme();
                checkwin();
            }
            checkbeurt();
        }

        private void algoritme()
        {
            bb1 = b1.Text;
            bb2 = b2.Text;
            bb3 = b3.Text;
            bb4 = b4.Text;
            bb5 = b5.Text;
            bb6 = b6.Text;
            bb7 = b7.Text;
            bb8 = b8.Text;
            bb9 = b9.Text;

            //winning statements AI//
            if (bb1 == "O" && zetnummer != 0)
            {
                if (bb1 == bb2 && bb3 == "" && zetnummer != 0)
                {
                    b3.Text = "O";
                    zetnummer--;
                }
                if (bb1 == bb4 && bb7 == "" && zetnummer != 0)
                {
                    b7.Text = "O";
                    zetnummer--;
                }
                if (bb1 == bb5 && bb9 == "" && zetnummer != 0)
                {
                    b9.Text = "O";
                    zetnummer--;
                }
            }

            if (bb2 == "O" && zetnummer != 0)
            {
                if (bb2 == bb5 && bb8 == "" && zetnummer != 0)
                {
                    b8.Text = "O";
                    zetnummer--;
                }
            }

            if (bb3 == "O" && zetnummer != 0)
            {
                if (bb3 == bb6 && bb9 == "" && zetnummer != 0)
                {
                    b9.Text = "O";
                    zetnummer--;
                }
                if (bb3 == bb5 && bb7 == "" && zetnummer != 0)
                {
                    b7.Text = "O";
                    zetnummer--;
                }
                if (bb3 == bb9 && bb6 == "" && zetnummer != 0)
                {
                    b6.Text = "O";
                    zetnummer--;
                }
            }

            if (bb4 == "O" && zetnummer != 0)
            {
                if (bb4 == bb5 && bb6 == "" && zetnummer != 0)
                {
                    b6.Text = "O";
                    zetnummer--;
                }
            }

            if (bb7 == "O" && zetnummer != 0)
            {
                if (bb7 == bb8 && bb9 == "" && zetnummer != 0)
                {
                    b9.Text = "O";
                    zetnummer--;
                }
            }

            //Block enemy//
            if (bb1 == "X" && zetnummer != 0)
            {
                if (bb1 == bb2 && bb3 == "" && zetnummer != 0)
                {
                    b3.Text = "O";
                    zetnummer--;
                }
                if (bb1 == bb5 && bb9 == "" && zetnummer != 0)
                {
                    b9.Text = "O";
                    zetnummer--;
                }
                if (bb1 == bb4 && bb7 == "" && zetnummer != 0)
                {
                    b7.Text = "O";
                    zetnummer--;
                }
                if (bb1 == bb9 && bb5 == "" && zetnummer != 0)
                {
                    b5.Text = "O";
                    zetnummer--;
                }
                if (bb1 == bb7 && bb4 == "" && zetnummer != 0)
                {
                    b4.Text = "O";
                    zetnummer--;
                }
            }

            if (bb2 == "X" && zetnummer != 0)
            {
                if (bb2 == bb5 && bb8 == "" && zetnummer != 0)
                {
                    b8.Text = "O";
                    zetnummer--;
                }
            }

            if (bb3 == "X" && zetnummer != 0)
            {
                if (bb3 == bb6 && bb9 == "" && zetnummer != 0)
                {
                    b9.Text = "O";
                    zetnummer--;
                }
                if (bb3 == bb5 && bb7 == "" && zetnummer != 0)
                {
                    b7.Text = "O";
                    zetnummer--;
                }
                if (bb3 == bb7 && bb5 == "" && zetnummer != 0)
                {
                    b5.Text = "O";
                    zetnummer--;
                }
                if (bb3 == bb7 && bb7 == bb9 && bb8 == "" && zetnummer != 0)
                {
                    b8.Text = "O";
                    zetnummer--;
                }
                if (bb3 == bb7 && bb7 == bb9 && bb6 == "" && zetnummer != 0)
                {
                    b6.Text = "O";
                    zetnummer--;
                }
                if (bb3 == bb5 && bb7 == "" && zetnummer != 0)
                {
                    b7.Text = "O";
                    zetnummer--;
                }
                if (bb3 == bb9 && bb6 == "" && zetnummer != 0)
                {
                    b6.Text = "O";
                    zetnummer--;
                }
            }

            if (bb4 == "X" && zetnummer != 0)
            {
                if (bb4 == bb5 && bb6 == "" && zetnummer != 0)
                {
                    b6.Text = "O";
                    zetnummer--;
                }
                if (bb4 == bb6 && bb5 == "" && zetnummer != 0)
                {
                    b5.Text = "O";
                    zetnummer--;
                }
            }

            if (bb5 == "X" && zetnummer != 0)
            {
                if (bb5 == bb8 && bb2 == "" && zetnummer != 0)
                {
                    b2.Text = "O";
                    zetnummer--;
                }
                if (bb5 == bb6 && bb4 == "" && zetnummer != 0)
                {
                    b4.Text = "O";
                    zetnummer--;
                }
            }

            if (bb7 == "X" && zetnummer != 0)
            {
                if (bb7 == bb8 && bb9 == "" && zetnummer != 0)
                {
                    b9.Text = "O";
                    zetnummer--;
                }
                if (bb7 == bb5 && bb3 == "" && zetnummer != 0)
                {
                    b3.Text = "O";
                    zetnummer--;
                }
                if (bb7 == bb5 && bb3 != "" && bb2 == "" && zetnummer != 0)
                {
                    b2.Text = "O";
                    zetnummer--;
                }
                if (bb7 == bb5 && bb3 != "" && bb8 == "" && zetnummer != 0)
                {
                    b8.Text = "O";
                    zetnummer--;
                }
                if (bb7 == bb9 && bb8 == "" && zetnummer != 0)
                {
                    b8.Text = "O";
                    zetnummer--;
                }
            }

            if (bb8 == "X" && zetnummer != 0)
            {
                if (bb8 == bb9 && bb7 == "" && zetnummer != 0)
                {
                    b7.Text = "O";
                    zetnummer--;
                }
                if (bb8 == bb5 && bb2 == "" && zetnummer != 0)
                {
                    b2.Text = "O";
                    zetnummer--;
                }
            }
            if (bb9 == "X" && zetnummer != 0)
            {
                if (bb9 == bb6 && bb3 == "" && zetnummer != 0)
                {
                    b3.Text = "O";
                    zetnummer--;
                }
            }

            //AI Placement//
            if (bb5 == "" && zetnummer != 0)
            {
                b5.Text = "O";
                zetnummer--;
            }
            if (bb1 != "X" && bb2 != "X" && bb3 != "X" && zetnummer != 0)
            {
                if (bb1 != "O" && bb1 == "" && zetnummer != 0)
                {
                    b1.Text = "O";
                    zetnummer--;
                }
                if (bb1 == "O" && bb2 == "" && zetnummer != 0)
                {
                    b2.Text = "O";
                    zetnummer--;
                }
                if (bb2 == "O" && bb3 == "" && zetnummer != 0)
                {
                    b3.Text = "O";
                    zetnummer--;
                }
            }

            if (bb1 != "X" && bb4 != "X" && bb7 != "X" && zetnummer != 0)
            {
                if (bb1 != "O" && bb1 == "" && zetnummer != 0)
                {
                    b1.Text = "O";
                    zetnummer--;
                }
                if (bb1 == "O" && bb4 == "" && zetnummer != 0)
                {
                    b4.Text = "O";
                    zetnummer--;
                }
                if (bb4 == "O" && bb7 == "" && zetnummer != 0)
                {
                    b7.Text = "O";
                    zetnummer--;
                }
            }

            if (bb3 != "X" && bb6 != "X" && bb9 != "X" && zetnummer != 0)
            {
                if (bb3 != "O" && bb3 == "" && zetnummer != 0)
                {
                    b3.Text = "O";
                    zetnummer--;
                }
                if (bb3 == "O" && bb6 == "" && zetnummer != 0)
                {
                    b6.Text = "O";
                    zetnummer--;
                }
                if (bb6 == "O" && bb9 == "" && zetnummer != 0)
                {
                    b9.Text = "O";
                    zetnummer--;
                }
            }

            if (bb7 != "X" && bb8 != "X" && bb9 != "X" && zetnummer != 0)
            {
                if (bb7 != "O" && bb7 == "" && zetnummer != 0)
                {
                    b7.Text = "O";
                    zetnummer--;
                }
                if (bb7 == "O" && bb8 == "" && zetnummer != 0)
                {
                    b8.Text = "O";
                    zetnummer--;
                }
                if (bb8 == "O" && bb9 == "" && zetnummer != 0)
                {
                    b9.Text = "O";
                    zetnummer--;
                }

            }
            else
            {
                if (bb4 == "" && zetnummer != 0)
                {
                    b4.Text = "O";
                    zetnummer--;
                }
                else if (bb9 == "" && zetnummer != 0)
                {
                    b9.Text = "O";
                    zetnummer--;
                }
                else if (bb1 == "" && zetnummer != 0)
                {
                    b1.Text = "O";
                    zetnummer--;
                }
                else if (bb2 == "" && zetnummer != 0)
                {
                    b2.Text = "O";
                    zetnummer--;
                }
                else if (bb3 == "" && zetnummer != 0)
                {
                    b3.Text = "O";
                    zetnummer--;
                }

                else if (bb6 == "" && zetnummer != 0)
                {
                    b6.Text = "O";
                    zetnummer--;
                }
                else if (bb7 == "" && zetnummer != 0)
                {
                    b7.Text = "O";
                    zetnummer--;
                }
                else if (bb8 == "" && zetnummer != 0)
                {
                    b8.Text = "O";
                    zetnummer--;
                }

            }
        }

        private void b1_Click(object sender, EventArgs e)
        {
            clicked(b1);
            checkbeurt();
        }

        private void b2_Click(object sender, EventArgs e)
        {
            clicked(b2);
            checkbeurt();
        }

        private void b3_Click(object sender, EventArgs e)
        {
            clicked(b3);
            checkbeurt();
        }

        private void b4_Click(object sender, EventArgs e)
        {
            clicked(b4);
            checkbeurt();
        }

        private void b5_Click(object sender, EventArgs e)
        {
            clicked(b5);
            checkbeurt();
        }

        private void b6_Click(object sender, EventArgs e)
        {
            clicked(b6);
            checkbeurt();
        }

        private void b7_Click(object sender, EventArgs e)
        {
            clicked(b7);
            checkbeurt();
        }

        private void b8_Click(object sender, EventArgs e)
        {
            clicked(b8);
            checkbeurt();
        }

        private void b9_Click(object sender, EventArgs e)
        {
            clicked(b9);
            checkbeurt();
        }
    }
}
