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

namespace RPS___Game
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
            this.TransparencyKey = (BackColor);  //priehladné pozadie
        }

        //SoundPlayer prehravac = new SoundPlayer();

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            Application.Exit();  //ukončenie hry
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            /*RPS15 RPS15game = new RPS15();
            RPS15game.Show();
            RPS_TBBT TBBTgame = new RPS_TBBT();
            TBBTgame.Hide();
            RPS_Classic classicGame = new RPS_Classic();
            classicGame.Hide();
            this.Hide();*/
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            //menubug.isopened_classic = true;

            this.Hide();

            RPS_TBBT TBBTgame = (RPS_TBBT)Application.OpenForms["RPS_TBBT"];
            RPS_Classic classicGame = new RPS_Classic();
            classicGame.Show();

            if (menubug.isopened_TBBT == true)
            {
                TBBTgame.Close();
            }
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            //menubug.isopened_TBBT = true;

            this.Hide();

            RPS_Classic classicGame = (RPS_Classic)Application.OpenForms["RPS_Classic"];
            RPS_TBBT TBBTgame = new RPS_TBBT();
            TBBTgame.Show();

            if (menubug.isopened_classic == true)
            {
                classicGame.Close();
            }
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Autor: Bc. Tomáš Ivan" + Environment.NewLine + "Akademický rok: 2018/2019" + Environment.NewLine + "Predmet: Programovanie 1");
        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {
            //Otvorenie modálneho okna so štatistikou hry - grafy
            Graph statistics = new Graph();
            statistics.ShowDialog();
        }

        private void pictureBox4_Click_1(object sender, EventArgs e)
        {
            classicGraph.Classic_playerScore = 0;     //vyresetuje skore
            classicGraph.Classic_computerScore = 0;
            classicGraph.Classic_Draw = 0;
            classicGraph.Classic_playerStone = 0;
            classicGraph.Classic_playerScissors = 0;
            classicGraph.Classic_playerPaper = 0;
            classicGraph.Classic_computerStone = 0;
            classicGraph.Classic_computerScissors = 0;
            classicGraph.Classic_computerPaper = 0;

            TBBTGraph.TBBT_playerScore = 0;     
            TBBTGraph.TBBT_computerScore = 0;
            TBBTGraph.TBBT_Draw = 0;
            TBBTGraph.TBBT_playerStone = 0;
            TBBTGraph.TBBT_playerScissors = 0;
            TBBTGraph.TBBT_playerPaper = 0;
            TBBTGraph.TBBT_playerLizard = 0;
            TBBTGraph.TBBT_playerSpock = 0;
            TBBTGraph.TBBT_computerStone = 0;
            TBBTGraph.TBBT_computerScissors = 0;
            TBBTGraph.TBBT_computerPaper = 0;
            TBBTGraph.TBBT_computerLizard = 0;
            TBBTGraph.TBBT_computerSpock = 0;

            this.Hide();
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            this.Hide();  //zavretie menu hry
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            if(menubug.menubuttonfix == true)
            {
                pictureBox4.Enabled = true;
                pictureBox4.Visible = true;

                pictureBox8.Enabled = true;
                pictureBox8.Visible = true;
            }
            else
            {
                pictureBox4.Enabled = false;
                pictureBox4.Visible = false;

                pictureBox8.Enabled = false;
                pictureBox8.Visible = false;
            }

            /*if(menubug.isopened_classic == true)
            {
                //menubug.isopened_classic = false;
                pictureBox5.Enabled = true;
                pictureBox5.Visible = true;
                pictureBox1.Enabled = false;
                pictureBox1.Visible = false;
            }
            else if(menubug.isopened_TBBT == true)
            {
                //menubug.isopened_TBBT = false;
                pictureBox5.Enabled = false;
                pictureBox5.Visible = false;
                pictureBox1.Enabled = true;
                pictureBox1.Visible = true;
            }*/
        }
    }
}
