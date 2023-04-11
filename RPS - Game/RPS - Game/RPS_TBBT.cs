using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RPS___Game
{
    public partial class RPS_TBBT : Form
    {
        public RPS_TBBT()
        {
            InitializeComponent();

            //Značné zamedzenie blikaniu obrazovky
            //DoubleBuffered = true;
        }

        private void pictureBox1_MouseHover(object sender, EventArgs e)
        {
            label3.Visible = true;
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            label3.Visible = false;
        }

        private void pictureBox2_MouseHover(object sender, EventArgs e)
        {
            label4.Visible = true;
        }

        private void pictureBox2_MouseLeave(object sender, EventArgs e)
        {
            label4.Visible = false;
        }

        private void pictureBox3_MouseHover(object sender, EventArgs e)
        {
            label7.Visible = true;
        }

        private void pictureBox3_MouseLeave(object sender, EventArgs e)
        {
            label7.Visible = false;
        }

        private void pictureBox4_MouseHover(object sender, EventArgs e)
        {
            label5.Visible = true;
        }

        private void pictureBox4_MouseLeave(object sender, EventArgs e)
        {
            label5.Visible = false;
        }

        private void pictureBox5_MouseHover(object sender, EventArgs e)
        {
            label6.Visible = true;
        }

        private void RPS_TBBT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Escape))  //po zatlačení ESC sa zobrazí ponuka Menu hry
            {
                Menu form2 = new Menu();
                form2.ShowDialog();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            //nožnice
            TBBT_playRound(1);
            TBBTGraph.TBBT_playerScissors++;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            //papier
            TBBT_playRound(2);
            TBBTGraph.TBBT_playerPaper++;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            //kameň
            TBBT_playRound(3);
            TBBTGraph.TBBT_playerStone++;
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            //jašter
            TBBT_playRound(4);
            TBBTGraph.TBBT_playerLizard++;
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            //Spock
            TBBT_playRound(5);
            TBBTGraph.TBBT_playerSpock++;
        }

        private void pictureBox5_MouseLeave(object sender, EventArgs e)
        {
            label6.Visible = false;
        }

        private void TBBT_playRound(int TBBT_vyber)
        {
            Random TBBT_rnd = new Random();  //vygenerovanie háhodného čísla v rozsahu 1-3, ktoré poslúži ako identifikátor ťahu PC
            int TBBT_tahPC = TBBT_rnd.Next(1, 6);

            TBBT_setImage(pictureBox16, TBBT_vyber);  //nastavenie obrazka hracovho tahu
            TBBT_setImage(pictureBox17, TBBT_tahPC);  //nastavenie obrazka tahu PC

            if (TBBT_tahPC == 1)
            {
                TBBTGraph.TBBT_computerScissors++;
            }
            else if (TBBT_tahPC == 2)
            {
                TBBTGraph.TBBT_computerPaper++;
            }
            else if (TBBT_tahPC == 3)
            {
                TBBTGraph.TBBT_computerStone++;
            }
            else if (TBBT_tahPC == 4)
            {
                TBBTGraph.TBBT_computerLizard++;
            }
            else if (TBBT_tahPC == 5)
            {
                TBBTGraph.TBBT_computerSpock++;
            }

            if (TBBT_tahPC == TBBT_vyber)
            {
                TBBTGraph.TBBT_Draw++;
                label1.Text = "Draw";  //zobrazenie labelu v pripade rovnakeho vyberu hraca a PC
                if (label1.Text == ("Draw"))
                {
                    label1.ForeColor = Color.Goldenrod;
                    label1.Visible = true;
                }
                return;
            }

            switch (TBBT_vyber)   //podmienky pre výhru / prehru
            {
                case 1:
                    if ((TBBT_tahPC == 2) || (TBBT_tahPC == 4))
                        TBBT_updateScore(true);
                    else
                        TBBT_updateScore(false);
                    break;

                case 2:
                    if ((TBBT_tahPC == 3) || (TBBT_tahPC == 5))
                        TBBT_updateScore(true);
                    else
                        TBBT_updateScore(false);
                    break;

                case 3:
                    if ((TBBT_tahPC == 1) || (TBBT_tahPC == 4))
                        TBBT_updateScore(true);
                    else
                        TBBT_updateScore(false);
                    break;

                case 4:
                    if ((TBBT_tahPC ==2) || (TBBT_tahPC == 5))
                        TBBT_updateScore(true);
                    else
                        TBBT_updateScore(false);
                    break;

                case 5:
                    if ((TBBT_tahPC == 1) || (TBBT_tahPC == 3))
                        TBBT_updateScore(true);
                    else
                        TBBT_updateScore(false);
                    break;
            }

        }

        private void TBBT_updateScore(bool TBBT_hracVyhra) //aktualizacia skóre
        {
            if (TBBT_hracVyhra)  //v prípade ze vyhra hráč inkrementuje sa hodnota playerScore o 1 a výpíše WIIN
            {
                TBBTGraph.TBBT_playerScore++;
                label1.Text = "WIN";
                if (label1.Text == ("WIN"))
                {
                    label1.ForeColor = Color.Chartreuse;
                    label1.Visible = true;
                }
                label18.Text = TBBTGraph.TBBT_playerScore.ToString();  //vypíše hodnotu aktuálneho skóre v tomto prípade hráča
            }
            else  //V prípade prehry inkrementuje sa hodnota computerScore o 1 a vypíše LOSE
            {
                TBBTGraph.TBBT_computerScore++;
                label1.Text = "LOSE";
                if (label1.Text == ("LOSE"))
                {
                    label1.ForeColor = Color.OrangeRed;
                    label1.Visible = true;
                }
                label19.Text = TBBTGraph.TBBT_computerScore.ToString();
            }
        }

        private void RPS_TBBT_MouseMove(object sender, MouseEventArgs e)
        {
            label18.Text = TBBTGraph.TBBT_playerScore.ToString();
            label19.Text = TBBTGraph.TBBT_computerScore.ToString();
            if ((TBBTGraph.TBBT_playerScore == 0) && (TBBTGraph.TBBT_computerScore == 0))  //ak je skóre 0-0 vymaže obrázky ťahov - napríklad v prípade reštartovania hry
            {
                pictureBox16.Image = null;  //vymaze obrázky tahov (posledný ťah) hráča a PC
                pictureBox17.Image = null;
                label1.Visible = false;
            }
        }

        private void TBBT_setImage(PictureBox TBBT_pb, int TBBT_img)  //nastavenie obrázka ťahu PC
        {
            if (TBBT_img == 1)  //V prípade vylosovania 1 sa nastavia nožnice, 2 - papier, 3 - kameň, 4- jašter a 5 - Spock
            {
                TBBT_pb.Image = global::RPS___Game.Properties.Resources.scissors;  //obrázky sú načítané z Resources
            }
            else if (TBBT_img == 2)
            {
                TBBT_pb.Image = global::RPS___Game.Properties.Resources.paper;
            }
            else if (TBBT_img == 3)
            {
                TBBT_pb.Image = global::RPS___Game.Properties.Resources.rock;
            }
            else if (TBBT_img == 4)
            {
                TBBT_pb.Image = global::RPS___Game.Properties.Resources.snake;
            }
            else if (TBBT_img == 5)
            {
                TBBT_pb.Image = global::RPS___Game.Properties.Resources.alien;
            }
        }

        private void RPS_TBBT_Load(object sender, EventArgs e)
        {
            menubug.menubuttonfix = true;
            menubug.isopened_TBBT = true;
            //menubug.isopened_classic = false;
        }
    }
}

//Vytvorenie globálnych premenných 
public static class TBBTGraph
{
    public static byte TBBT_playerStone, TBBT_playerScissors, TBBT_playerPaper, TBBT_playerLizard, TBBT_playerSpock, TBBT_computerStone, 
        TBBT_computerScissors, TBBT_computerPaper, TBBT_computerLizard, TBBT_computerSpock = 0;
    public static byte TBBT_playerScore, TBBT_computerScore, TBBT_Draw = 0;

}
