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
    public partial class RPS_Classic : Form
    {
        public RPS_Classic()
        {
            InitializeComponent();
        }

        private void RPS_Classic_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Escape))  //po zatlačení ESC sa zobrazí ponuka Menu hry
            {
                Menu form2 = new Menu();
                form2.ShowDialog();
            }
        }

        private void pictureBox5_MouseHover(object sender, EventArgs e)
        {
            label10.Visible = true;  //pokiaľ kuzror prejde cez picturebox zobrazí sa názov predmetu, v tomto prípade nožnice
        }

        private void pictureBox5_MouseLeave(object sender, EventArgs e)
        {
            label10.Visible = false;
        }

        private void pictureBox3_MouseHover(object sender, EventArgs e)
        {
            label7.Visible = true;
        }

        private void pictureBox3_MouseLeave(object sender, EventArgs e)
        {
            label7.Visible = false;
        }

        private void pictureBox13_MouseHover(object sender, EventArgs e)
        {
            label4.Visible = true;
        }

        private void pictureBox13_MouseLeave(object sender, EventArgs e)
        {
            label4.Visible = false;
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            //nožnice
            Classic_playRound(1);
            classicGraph.Classic_playerScissors++;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            //kameň
            Classic_playRound(3);
            classicGraph.Classic_playerStone++;
        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {
            //papier
            Classic_playRound(2);
            classicGraph.Classic_playerPaper++;
        }

        private void Classic_playRound(int Classic_vyber)
        {
            Random Classic_rnd = new Random();  //vygenerovanie háhodného čísla v rozsahu 1-3, ktoré poslúži ako identifikátor ťahu PC
            int Classic_tahPC = Classic_rnd.Next(1, 4);

            Classic_setImage(pictureBox16, Classic_vyber);  //nastavenie obrazka hracovho tahu
            Classic_setImage(pictureBox17, Classic_tahPC);  //nastavenie obrazka tahu PC

            if (Classic_tahPC == 1)
            {
                classicGraph.Classic_computerScissors++;
            }
            else if (Classic_tahPC == 2)
            {
                classicGraph.Classic_computerPaper++;
            }
            else if (Classic_tahPC == 3)
            {
                classicGraph.Classic_computerStone++;
            }

            if (Classic_tahPC == Classic_vyber)
            {
                classicGraph.Classic_Draw++;
                label1.Text = "Draw";  //zobrazenie labelu v pripade rovnakeho vyberu hraca a PC
                if (label1.Text == ("Draw"))
                {
                    label1.ForeColor = Color.Yellow;
                    label1.Visible = true;
                }
                return;
            }

            switch (Classic_vyber)  //podmienky pre výhru / prehru
            {
                case 1:
                    if(Classic_tahPC == 2)
                        Classic_updateScore(true);
                    else
                        Classic_updateScore(false);
                    break;

                case 2:
                    if (Classic_tahPC == 3)
                        Classic_updateScore(true);
                    else
                        Classic_updateScore(false);
                    break;

                case 3:
                    if (Classic_tahPC == 1)
                        Classic_updateScore(true);
                    else
                        Classic_updateScore(false);
                    break;
            }

        }

        private void Classic_updateScore(bool Classic_hracVyhra) //aktualizacia skóre
        {
            if (Classic_hracVyhra)  //v prípade ze vyhra hráč inkrementuje sa hodnota playerScore o 1 a výpíše WIIN
            {
                classicGraph.Classic_playerScore++;
                label1.Text = "WIN";
                if (label1.Text == ("WIN"))
                {
                    label1.ForeColor = Color.Green;
                    label1.Visible = true;
                }
                label18.Text = classicGraph.Classic_playerScore.ToString();  //vypíše hodnotu aktuálneho skóre v tomto prípade hráča
            }
            else  //V prípade prehry inkrementuje sa hodnota computerScore o 1 a vypíše LOSE
            {
                classicGraph.Classic_computerScore++;
                label1.Text = "LOSE";
                if (label1.Text == ("LOSE"))
                {
                    label1.ForeColor = Color.Red;
                    label1.Visible = true;
                }
                label19.Text = classicGraph.Classic_computerScore.ToString();
            }
        }

        private void RPS_Classic_MouseMove(object sender, MouseEventArgs e)
        {
            label18.Text = classicGraph.Classic_playerScore.ToString();
            label19.Text = classicGraph.Classic_computerScore.ToString();
            if ((classicGraph.Classic_playerScore == 0) && (classicGraph.Classic_computerScore == 0))  //ak je skóre 0-0 vymaže obrázky ťahov - napríklad v prípade reštartovania hry
            {
                pictureBox16.Image = null;  //vymaze obrázky tahov (posledný ťah) hráča a PC
                pictureBox17.Image = null;
                label1.Visible = false;
            }
        }

        private void Classic_setImage(PictureBox Classic_pb, int Classic_img)  //nastavenie obrázka ťahu PC
        {
            if (Classic_img == 1)  //V prípade vylosovania 1 sa nastavia nožnice, 2 - papier a 3 - kameň
            {
                Classic_pb.Image = global::RPS___Game.Properties.Resources.scissors;  //obrázky sú načítané z Resources
            }
            else if (Classic_img == 2)
            {
                Classic_pb.Image = global::RPS___Game.Properties.Resources.paper;
            }
            else if (Classic_img == 3)
            {
                Classic_pb.Image = global::RPS___Game.Properties.Resources.rock;
            }
        }

        private void RPS_Classic_Load(object sender, EventArgs e)
        {
            menubug.menubuttonfix = true;
            menubug.isopened_classic = true;
            //menubug.isopened_TBBT = false;
        }
    }
}
//Vytvorenie globálnych premenných 
public static class classicGraph
{
    public static byte Classic_playerStone, Classic_playerScissors, Classic_playerPaper, Classic_computerStone, Classic_computerScissors, Classic_computerPaper = 0;
    public static byte Classic_playerScore, Classic_computerScore, Classic_Draw = 0;
}
//Bugfix
public static class menubug
{
    public static bool menubuttonfix = false;
    public static bool isopened_classic = false;
    public static bool isopened_TBBT = false;
}
