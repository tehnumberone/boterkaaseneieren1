using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void win()
        {
            if (zetnummer == 0)
            {
                MessageBox.Show("O heeft gewonnen");
            }
            else
            {
                MessageBox.Show("X heeft gewonnen");
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
        int zetnummer = 0;
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
        private void algoritme() // maak een algoritme noob //

        {
            //winning statements AI//
            if (b1.Text == "O" && b1.Text == b2.Text && b3.Text == "" && zetnummer != 0)
            {
                b3.Text = "O";
                zetnummer--;
            }

            if (b4.Text == "O" && b4.Text == b5.Text && b6.Text == "" && zetnummer != 0)
            {
                b6.Text = "O";
                zetnummer--;
            }

            if (b7.Text == "O" && b7.Text == b8.Text && b9.Text == "" && zetnummer != 0)
            {
                b9.Text = "O";
                zetnummer--;
            }

            if (b1.Text == "O" && b1.Text == b4.Text && b7.Text == "" && zetnummer != 0)
            {
                b7.Text = "O";
                zetnummer--;
            }

            if (b2.Text == "O" && b2.Text == b5.Text && b8.Text == "" && zetnummer != 0)
            {
                b8.Text = "O";
                zetnummer--;
            }

            if (b3.Text == "O" && b3.Text == b6.Text && b9.Text == "" && zetnummer != 0)
            {
                b9.Text = "O";
                zetnummer--;
            }

            if (b3.Text == "O" && b3.Text == b5.Text && b7.Text == "" && zetnummer != 0)
            {
                b7.Text = "O";
                zetnummer--;
            }

            if (b1.Text == "O" && b1.Text == b5.Text && b9.Text == "" && zetnummer != 0)
            {
                b9.Text = "O";
                zetnummer--;
            }

            //Block enemy//
            if (b1.Text == "X" && b1.Text == b2.Text && b3.Text == "" && zetnummer != 0)
            {
                b3.Text = "O";
                zetnummer--;
            }

            if (b4.Text == "X" && b4.Text == b5.Text && b6.Text == "" && zetnummer != 0)
            {
                b6.Text = "O";
                zetnummer--;
            }

            if (b7.Text == "X" && b7.Text == b8.Text && b9.Text == "" && zetnummer != 0)
            {
                b9.Text = "O";
                zetnummer--;
            }

            if (b1.Text == "X" && b1.Text == b4.Text && b7.Text == "" && zetnummer != 0)
            {
                b7.Text = "O";
                zetnummer--;
            }
        
            if (b2.Text == "X" && b2.Text == b5.Text && b8.Text == "" && zetnummer != 0)
            {
                b8.Text = "O";
                zetnummer--;
            }

            if (b3.Text == "X" && b3.Text == b6.Text && b9.Text == "" && zetnummer != 0)
            {
                b9.Text = "O";
                zetnummer--;
            }

            if (b3.Text == "X" && b3.Text == b5.Text && b7.Text == "" && zetnummer != 0)
            {
                b7.Text = "O";
                zetnummer--;
            }

            if (b1.Text == "X" && b1.Text == b5.Text && b9.Text == "" && zetnummer != 0)
            {
                b9.Text = "O";
                zetnummer--;
            }

            //AI Placement//
            if (b1.Text == "" || b1.Text == "O" && b2.Text == "" || b2.Text == "O" && b3.Text == "" && zetnummer != 0)
            {
                if (b1.Text != "O" && b1.Text == "" && zetnummer != 0)
                {
                    b1.Text = "O";
                    zetnummer--;
                }
                if (b1.Text == "O" && b2.Text == "" && zetnummer != 0)
                {
                    b2.Text = "O";
                    zetnummer--;
                }
                if (b2.Text == "O" && b3.Text == "" && zetnummer != 0)
                {
                    b3.Text = "O";
                    zetnummer--;
                }
            }

            if (b1.Text == "" || b1.Text == "O" && b4.Text == "" || b4.Text == "O" && b7.Text == "" && zetnummer != 0)
            {
                if (b1.Text != "O" && b1.Text == "" && zetnummer != 0)
                {
                    b1.Text = "O";
                    zetnummer--; 
                }
                if (b1.Text == "O" && b4.Text == "" && zetnummer != 0)
                {
                    b4.Text = "O";
                    zetnummer--;
                }
                if (b4.Text == "O" && b7.Text == "" && zetnummer != 0)
                {
                    b7.Text = "O";
                    zetnummer--;
                }
            }

            if (b3.Text == "" || b3.Text == "O" && b6.Text == "" || b6.Text == "O" && b9.Text == "" && zetnummer != 0)
            {
                if (b3.Text != "O" && b3.Text == "" && zetnummer != 0)
                {
                    b3.Text = "O";
                    zetnummer--;  
                }
                if (b3.Text == "O" && b6.Text == "" && zetnummer != 0)
                {
                    b6.Text = "O";
                    zetnummer--;
                }
                if (b6.Text == "O" && b9.Text == "" && zetnummer != 0)
                {
                    b9.Text = "O";
                    zetnummer--;
                }
            }

            if (b7.Text == "" || b7.Text == "O" && b8.Text == "" || b8.Text == "O" && b9.Text == "" && zetnummer != 0)
            {
                if (b7.Text != "O" && b7.Text == ""&& zetnummer != 0)
                {
                    b7.Text = "O";
                    zetnummer--; 
                }
                if (b7.Text == "O" && b8.Text == "" && zetnummer != 0)
                {
                    b8.Text = "O";
                    zetnummer--;
                }
                if (b8.Text == "O" && b9.Text == "" && zetnummer != 0)
                {
                    b9.Text = "O";
                    zetnummer--;
                }
            }
        }

        private void b1_Click(object sender, EventArgs e)
        {
            if (b1.Text == "")
            {
                b1.Text = zet(zetnummer);
                algoritme();
                checkwin();
            }
            checkbeurt();
            
        }

        private void b2_Click(object sender, EventArgs e)
        {
            if (b2.Text == "")
            {
                b2.Text = zet(zetnummer);
                checkwin(); 
            }
            algoritme();
            checkwin();
            checkbeurt();
            
        }

        private void b3_Click(object sender, EventArgs e)
        {
            if (b3.Text == "")
            {
                b3.Text = zet(zetnummer);
                checkwin();
            }
            algoritme();
            checkwin();
            checkbeurt();
            
        }

        private void b4_Click(object sender, EventArgs e)
        {
            if (b4.Text == "")
            {
                b4.Text = zet(zetnummer);
                checkwin();
            }
            algoritme();
            checkwin();
            checkbeurt();
            
        }

        private void b5_Click(object sender, EventArgs e)
        {
            if (b5.Text == "")
            {
                b5.Text = zet(zetnummer);
                checkwin();
            }
            algoritme();
            checkwin();
            checkbeurt();
           
        }

        private void b6_Click(object sender, EventArgs e)
        {
            if (b6.Text == "")
            {
                b6.Text = zet(zetnummer);
                checkwin();
            }
            algoritme();
            checkwin();
            checkbeurt();
        }

        private void b7_Click(object sender, EventArgs e)
        {
            if (b7.Text == "")
            {
                b7.Text = zet(zetnummer);
                checkwin();
            }
            algoritme();
            checkwin();
            checkbeurt();
        }

        private void b8_Click(object sender, EventArgs e)
        {
            if (b8.Text == "")
            {
                b8.Text = zet(zetnummer);
                checkwin();
            }
            algoritme();
            checkwin();
            checkbeurt();
        }

        private void b9_Click(object sender, EventArgs e)
        {
            if (b9.Text == "")
            {
                b9.Text = zet(zetnummer);
                checkwin();
            }
            algoritme();
            checkwin();
            checkbeurt();
        }
    }
}
