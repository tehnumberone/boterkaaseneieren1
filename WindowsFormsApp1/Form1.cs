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
                win();
            }

            if (b4.Text == b5.Text && b5.Text == b6.Text && b6.Text != "")
            {
                win();
            }

            if (b7.Text == b8.Text && b8.Text == b9.Text && b9.Text != "")
            {
                win();
            }

            if (b1.Text == b4.Text && b4.Text == b7.Text && b7.Text != "")
            {
                win();
            }

            if (b2.Text == b5.Text && b5.Text == b8.Text && b8.Text != "")
            {
                win();
            }

            if (b3.Text == b6.Text && b6.Text == b9.Text && b9.Text != "")
            {
                win();
            }

            if (b3.Text == b5.Text && b5.Text == b7.Text && b7.Text != "")
            {
                win();
            }
            if (b1.Text == b5.Text && b5.Text == b9.Text && b9.Text != "")
            {
                win();
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
                welke = "x";
                zetnummer++;
            }
            else
            {
                welke = "o";
                zetnummer--;
            }
            return welke;
        }
        private void algoritme() // maak een algoritme noob //
        {
            
        }
        private void b1_Click(object sender, EventArgs e)
        {
            if (b1.Text == "")
            {
                b1.Text = zet(zetnummer);
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
            checkbeurt();
        }

        private void b3_Click(object sender, EventArgs e)
        {
            if (b3.Text == "")
            {
                b3.Text = zet(zetnummer);
                checkwin();
            }
            checkbeurt();
        }

        private void b4_Click(object sender, EventArgs e)
        {
            if (b4.Text == "")
            {
                b4.Text = zet(zetnummer);
                checkwin();
            }
            checkbeurt();
        }

        private void b5_Click(object sender, EventArgs e)
        {
            if (b5.Text == "")
            {
                b5.Text = zet(zetnummer);
                checkwin();
            }
            checkbeurt();
        }

        private void b6_Click(object sender, EventArgs e)
        {
            if (b6.Text == "")
            {
                b6.Text = zet(zetnummer);
                checkwin();
            }
            checkbeurt();
        }

        private void b7_Click(object sender, EventArgs e)
        {
            if (b7.Text == "")
            {
                b7.Text = zet(zetnummer);
                checkwin();
            }
            checkbeurt();
        }

        private void b8_Click(object sender, EventArgs e)
        {
            if (b8.Text == "")
            {
                b8.Text = zet(zetnummer);
                checkwin();
            }
            checkbeurt();
        }

        private void b9_Click(object sender, EventArgs e)
        {
            if (b9.Text == "")
            {
                b9.Text = zet(zetnummer);
                checkwin();
            }
            checkbeurt();
        }
    }
}
