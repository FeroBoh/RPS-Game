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
    public partial class RPS15 : Form
    {
        public RPS15()
        {
            InitializeComponent();
        }

        public static int RPS15_playerScore, RPS15_computerScore = 0;

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            /*if (e.KeyChar == Convert.ToChar(Keys.Escape))  //po zatlačení ESC sa zobrazí ponuka Menu hry
            {
                Menu form2 = new Menu();

                form2.ShowDialog();
            }*/
        }

        private void pictureBox3_MouseHover(object sender, EventArgs e)
        {
            label7.Visible = true;  //ak je kurzor nad pictureboxom zobrazí sa príslušný label
        }

        private void pictureBox3_MouseLeave(object sender, EventArgs e)
        {
            label7.Visible = false;  //ak nie je kurzor opustí picturebox príslušný label sa opäť skryje
        }

        private void pictureBox2_MouseHover(object sender, EventArgs e)
        {
            label6.Visible = true;
        }

        private void pictureBox2_MouseLeave(object sender, EventArgs e)
        {
            label6.Visible = false;
        }

        private void pictureBox1_MouseHover(object sender, EventArgs e)
        {
            label8.Visible = true;
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            label8.Visible = false;
        }

        private void pictureBox9_MouseHover(object sender, EventArgs e)
        {
            label13.Visible = true;
        }

        private void pictureBox9_MouseLeave(object sender, EventArgs e)
        {
            label13.Visible = false;
        }

        private void pictureBox10_MouseHover(object sender, EventArgs e)
        {
            label14.Visible = true;
        }

        private void pictureBox10_MouseLeave(object sender, EventArgs e)
        {
            label14.Visible = false;
        }

        private void pictureBox12_MouseHover(object sender, EventArgs e)
        {
            label15.Visible = true;
        }

        private void pictureBox12_MouseLeave(object sender, EventArgs e)
        {
            label15.Visible = false;
        }

        private void pictureBox11_MouseHover(object sender, EventArgs e)
        {
            label5.Visible = true;
        }

        private void pictureBox11_MouseLeave(object sender, EventArgs e)
        {
            label5.Visible = false;
        }

        private void pictureBox13_MouseHover(object sender, EventArgs e)
        {
            label4.Visible = true;
        }

        private void pictureBox13_MouseLeave(object sender, EventArgs e)
        {
            label4.Visible = false;
        }

        private void pictureBox15_MouseHover(object sender, EventArgs e)
        {
            label3.Visible = true;
        }

        private void pictureBox15_MouseLeave(object sender, EventArgs e)
        {
            label3.Visible = false;
        }

        private void pictureBox14_MouseHover(object sender, EventArgs e)
        {
            label1.Visible = true;
        }

        private void pictureBox14_MouseLeave(object sender, EventArgs e)
        {
            label1.Visible = false;
        }

        private void pictureBox8_MouseHover(object sender, EventArgs e)
        {
            label2.Visible = true;
        }

        private void pictureBox8_MouseLeave(object sender, EventArgs e)
        {
            label2.Visible = false;
        }

        private void pictureBox7_MouseHover(object sender, EventArgs e)
        {
            label12.Visible = true;
        }

        private void pictureBox7_MouseLeave(object sender, EventArgs e)
        {
            label12.Visible = false;
        }

        private void pictureBox6_MouseHover(object sender, EventArgs e)
        {
            label11.Visible = true;
        }

        private void pictureBox6_MouseLeave(object sender, EventArgs e)
        {
            label11.Visible = false;
        }

        private void pictureBox5_MouseHover(object sender, EventArgs e)
        {
            label10.Visible = true;
        }

        private void pictureBox5_MouseLeave(object sender, EventArgs e)
        {
            label10.Visible = false;
        }

        private void pictureBox4_MouseHover(object sender, EventArgs e)
        {
            label9.Visible = true;
        }

        private void pictureBox4_MouseLeave(object sender, EventArgs e)
        {
            label9.Visible = false;
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            //Nožnice
            RPS15_playRound(1);
        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {
            //Papier
            RPS15_playRound(2);
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            //Kameň
            RPS15_playRound(3);
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            //Had
            RPS15_playRound(4);
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            //Oheň
            RPS15_playRound(5);
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            //Človek
            RPS15_playRound(6);
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            //Strom
            RPS15_playRound(7);
        }

        private void pictureBox14_Click(object sender, EventArgs e)
        {
            //Vlk
            RPS15_playRound(8);
        }

        private void pictureBox15_Click(object sender, EventArgs e)
        {
            //Špongia
            RPS15_playRound(9);
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            //Vzduch
            RPS15_playRound(10);
        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
            //Voda
            RPS15_playRound(11);
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            //Drak
            RPS15_playRound(12);
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            //Diabol
            RPS15_playRound(13);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            //Lightning
            RPS15_playRound(14);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            //Zbraň
            RPS15_playRound(15);
        }

        private void RPS15_MouseMove(object sender, MouseEventArgs e)
        {
            label18.Text = RPS15_playerScore.ToString();
            label19.Text = RPS15_computerScore.ToString();
            if ((RPS15_playerScore == 0) && (RPS15_computerScore == 0))  //ak je skóre 0-0 vymaže obrázky ťahov - napríklad v prípade reštartovania hry
            {
                pictureBox16.Image = null;  //vymaze obrázky tahov (posledný ťah) hráča a PC
                pictureBox17.Image = null;
                label20.Visible = false;
            }
        }

        private void RPS15_playRound(int RPS15_vyber)
        {
            Random RPS15_rnd = new Random();  //vygenerovanie háhodného čísla v rozsahu 1-3, ktoré poslúži ako identifikátor ťahu PC
            int RPS15_tahPC = RPS15_rnd.Next(1, 16);

            RPS15_setImage(pictureBox16, RPS15_vyber);  //nastavenie obrazka hracovho tahu
            RPS15_setImage(pictureBox17, RPS15_tahPC);  //nastavenie obrazka tahu PC

            if (RPS15_tahPC == RPS15_vyber)
            {
                label20.Text = "Draw";  //zobrazenie labelu v pripade rovnakeho vyberu hraca a PC
                if (label20.Text == ("Draw"))
                {
                    label20.ForeColor = Color.Goldenrod;
                    label20.Visible = true;
                }
                return;
            }

            switch (RPS15_vyber)   //podmienky pre výhru / prehru
            {
                case 1:
                    if ((RPS15_tahPC == 2) || (RPS15_tahPC == 4) || (RPS15_tahPC == 6) || (RPS15_tahPC == 7) || (RPS15_tahPC == 8) || (RPS15_tahPC == 9) || (RPS15_tahPC == 10))
                        RPS15_updateScore(true);
                    else
                        RPS15_updateScore(false);
                    break;

                case 2:
                    if ((RPS15_tahPC == 3) || (RPS15_tahPC == 10) || (RPS15_tahPC == 11) || (RPS15_tahPC == 12) || (RPS15_tahPC == 13) || (RPS15_tahPC == 14) || (RPS15_tahPC == 15))
                        RPS15_updateScore(true);
                    else
                        RPS15_updateScore(false);
                    break;

                case 3:
                    if ((RPS15_tahPC == 1) || (RPS15_tahPC == 4) || (RPS15_tahPC == 5) || (RPS15_tahPC == 6) || (RPS15_tahPC == 7) || (RPS15_tahPC == 8) || (RPS15_tahPC == 9))
                        RPS15_updateScore(true);
                    else
                        RPS15_updateScore(false);
                    break;

                case 4:
                    if ((RPS15_tahPC == 2) || (RPS15_tahPC == 6) || (RPS15_tahPC == 7) || (RPS15_tahPC == 8) || (RPS15_tahPC == 9) || (RPS15_tahPC == 10) || (RPS15_tahPC == 11))
                        RPS15_updateScore(true);
                    else
                        RPS15_updateScore(false);
                    break;

                case 5:
                    if ((RPS15_tahPC == 1) || (RPS15_tahPC == 2) || (RPS15_tahPC == 4) || (RPS15_tahPC == 6) || (RPS15_tahPC == 7) || (RPS15_tahPC == 8) || (RPS15_tahPC == 9))
                        RPS15_updateScore(true);
                    else
                        RPS15_updateScore(false);
                    break;

                case 6:
                    if ((RPS15_tahPC == 7) || (RPS15_tahPC == 8) || (RPS15_tahPC == 9) || (RPS15_tahPC == 2) || (RPS15_tahPC == 10) || (RPS15_tahPC == 11) || (RPS15_tahPC == 12))
                        RPS15_updateScore(true);
                    else
                        RPS15_updateScore(false);
                    break;

                case 7:
                    if ((RPS15_tahPC == 8) || (RPS15_tahPC == 12) || (RPS15_tahPC == 9) || (RPS15_tahPC == 2) || (RPS15_tahPC == 10) || (RPS15_tahPC == 11) || (RPS15_tahPC == 13))
                        RPS15_updateScore(true);
                    else
                        RPS15_updateScore(false);
                    break;

                case 8:
                    if ((RPS15_tahPC == 9) || (RPS15_tahPC == 2) || (RPS15_tahPC == 10) || (RPS15_tahPC == 11) || (RPS15_tahPC == 12) || (RPS15_tahPC == 14) || (RPS15_tahPC == 13))
                        RPS15_updateScore(true);
                    else
                        RPS15_updateScore(false);
                    break;

                case 9:
                    if ((RPS15_tahPC == 2) || (RPS15_tahPC == 10) || (RPS15_tahPC == 11) || (RPS15_tahPC == 13) || (RPS15_tahPC == 12) || (RPS15_tahPC == 15) || (RPS15_tahPC == 14))
                        RPS15_updateScore(true);
                    else
                        RPS15_updateScore(false);
                    break;

                case 10:
                    if ((RPS15_tahPC == 5) || (RPS15_tahPC == 3) || (RPS15_tahPC == 11) || (RPS15_tahPC == 13) || (RPS15_tahPC == 15) || (RPS15_tahPC == 12) || (RPS15_tahPC == 14))
                        RPS15_updateScore(true);
                    else
                        RPS15_updateScore(false);
                    break;

                case 11:
                    if ((RPS15_tahPC == 13) || (RPS15_tahPC == 12) || (RPS15_tahPC == 3) || (RPS15_tahPC == 5) || (RPS15_tahPC == 1) || (RPS15_tahPC == 15) || (RPS15_tahPC == 14))
                        RPS15_updateScore(true);
                    else
                        RPS15_updateScore(false);
                    break;

                case 12:
                    if ((RPS15_tahPC == 13) || (RPS15_tahPC == 14) || (RPS15_tahPC == 5) || (RPS15_tahPC == 3) || (RPS15_tahPC == 1) || (RPS15_tahPC == 15) || (RPS15_tahPC == 4))
                        RPS15_updateScore(true);
                    else
                        RPS15_updateScore(false);
                    break;

                case 13:
                    if ((RPS15_tahPC == 3) || (RPS15_tahPC == 5) || (RPS15_tahPC == 1) || (RPS15_tahPC == 15) || (RPS15_tahPC == 14) || (RPS15_tahPC == 4) || (RPS15_tahPC == 6))
                        RPS15_updateScore(true);
                    else
                        RPS15_updateScore(false);
                    break;

                case 14:
                    if ((RPS15_tahPC == 15) || (RPS15_tahPC == 1) || (RPS15_tahPC == 3) || (RPS15_tahPC == 7) || (RPS15_tahPC == 5) || (RPS15_tahPC == 4) || (RPS15_tahPC == 6))
                        RPS15_updateScore(true);
                    else
                        RPS15_updateScore(false);
                    break;

                case 15:
                    if ((RPS15_tahPC == 3) || (RPS15_tahPC == 7) || (RPS15_tahPC == 5) || (RPS15_tahPC == 1) || (RPS15_tahPC == 4) || (RPS15_tahPC == 6) || (RPS15_tahPC == 8))
                        RPS15_updateScore(true);
                    else
                        RPS15_updateScore(false);
                    break;
            }
        }

        private void RPS15_updateScore(bool RPS15_hracVyhra) //aktualizacia skóre
        {
            if (RPS15_hracVyhra)  //v prípade ze vyhra hráč inkrementuje sa hodnota playerScore o 1 a výpíše WIIN
            {
                RPS15_playerScore++;
                label20.Text = "WIN";
                if (label20.Text == ("WIN"))
                {
                    label20.ForeColor = Color.Chartreuse;
                    label20.Visible = true;
                }
                label18.Text = RPS15_playerScore.ToString();  //vypíše hodnotu aktuálneho skóre v tomto prípade hráča
            }
            else  //V prípade prehry inkrementuje sa hodnota computerScore o 1 a vypíše LOSE
            {
                RPS15_computerScore++;
                label20.Text = "LOSE";
                if (label20.Text == ("LOSE"))
                {
                    label20.ForeColor = Color.OrangeRed;
                    label20.Visible = true;
                }
                label19.Text = RPS15_computerScore.ToString();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            RPS_TBBT TBBTgame = new RPS_TBBT();
            TBBTgame.Hide();
            RPS_Classic classicGame = new RPS_Classic();
            classicGame.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            RPS_TBBT TBBTgame = new RPS_TBBT();
            TBBTgame.Show();
            RPS_Classic classicGame = new RPS_Classic();
            classicGame.Hide();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            RPS15_playerScore = 0;
            RPS15_computerScore = 0;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void RPS15_setImage(PictureBox RPS15_pb, int RPS15_img)  //nastavenie obrázka ťahu PC
        {
            if (RPS15_img == 1)  //V prípade vylosovania 1 sa nastavia nožnice, 2 - papier, 3 - kameň, 4- had, 5 - oheň atď.
            {
                RPS15_pb.Image = global::RPS___Game.Properties.Resources.scissors;  //obrázky sú načítané z Resources
            }
            else if (RPS15_img == 2)
            {
                RPS15_pb.Image = global::RPS___Game.Properties.Resources.paper;
            }
            else if (RPS15_img == 3)
            {
                RPS15_pb.Image = global::RPS___Game.Properties.Resources.rock;
            }
            else if (RPS15_img == 4)
            {
                RPS15_pb.Image = global::RPS___Game.Properties.Resources.snake;
            }
            else if (RPS15_img == 5)
            {
                RPS15_pb.Image = global::RPS___Game.Properties.Resources.fire;
            }
            else if (RPS15_img == 6)
            {
                RPS15_pb.Image = global::RPS___Game.Properties.Resources.human;
            }
            else if (RPS15_img == 7)
            {
                RPS15_pb.Image = global::RPS___Game.Properties.Resources.tree;
            }
            else if (RPS15_img == 8)
            {
                RPS15_pb.Image = global::RPS___Game.Properties.Resources.wolf;
            }
            else if (RPS15_img == 9)
            {
                RPS15_pb.Image = global::RPS___Game.Properties.Resources.sponge;
            }
            else if (RPS15_img == 10)
            {
                RPS15_pb.Image = global::RPS___Game.Properties.Resources.air;
            }
            else if (RPS15_img == 11)
            {
                RPS15_pb.Image = global::RPS___Game.Properties.Resources.water;
            }
            else if (RPS15_img == 12)
            {
                RPS15_pb.Image = global::RPS___Game.Properties.Resources.dragon;
            }
            else if (RPS15_img == 13)
            {
                RPS15_pb.Image = global::RPS___Game.Properties.Resources.devil;
            }
            else if (RPS15_img == 14)
            {
                RPS15_pb.Image = global::RPS___Game.Properties.Resources.lightning;
            }
            else if (RPS15_img == 15)
            {
                RPS15_pb.Image = global::RPS___Game.Properties.Resources.gun;
            }
        }

    }
}
