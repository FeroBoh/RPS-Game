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
    public partial class Graph : Form
    {
        public Graph()
        {
            InitializeComponent();

            this.ShowInTaskbar = false;

            chart2.Series["CPU"].Points.AddXY("Scissors", classicGraph.Classic_computerScissors);
            chart2.Series["CPU"].Points.AddXY("Paper", classicGraph.Classic_computerPaper);
            chart2.Series["CPU"].Points.AddXY("Stone", classicGraph.Classic_computerStone);

            chart2.Series["Player"].Points.AddXY("Scissors", classicGraph.Classic_playerScissors);
            chart2.Series["Player"].Points.AddXY("Paper", classicGraph.Classic_playerPaper);
            chart2.Series["Player"].Points.AddXY("Stone", classicGraph.Classic_playerStone);

            chart1.Series["Win"].Points.AddXY("Win", classicGraph.Classic_playerScore);
            chart1.Series["Win"].Points.AddXY("Loss", classicGraph.Classic_computerScore);
            chart1.Series["Win"].Points.AddXY("Draw", classicGraph.Classic_Draw);
            chart1.Series["Win"].Label = "#PERCENT{0.00 %}";
            chart1.Series["Win"].LegendText = "#VALX";



            chart3.Series["CPU"].Points.AddXY("Scissors", TBBTGraph.TBBT_computerScissors);
            chart3.Series["CPU"].Points.AddXY("Paper", TBBTGraph.TBBT_computerPaper);
            chart3.Series["CPU"].Points.AddXY("Stone", TBBTGraph.TBBT_computerStone);
            chart3.Series["CPU"].Points.AddXY("Lizard", TBBTGraph.TBBT_computerLizard);
            chart3.Series["CPU"].Points.AddXY("Spock", TBBTGraph.TBBT_computerSpock);

            chart3.Series["Player"].Points.AddXY("Scissors", TBBTGraph.TBBT_playerScissors);
            chart3.Series["Player"].Points.AddXY("Paper", TBBTGraph.TBBT_playerPaper);
            chart3.Series["Player"].Points.AddXY("Stone", TBBTGraph.TBBT_playerStone);
            chart3.Series["Player"].Points.AddXY("Lizard", TBBTGraph.TBBT_playerLizard);
            chart3.Series["Player"].Points.AddXY("Spock", TBBTGraph.TBBT_playerSpock);

            chart4.Series["Win"].Points.AddXY("Win", TBBTGraph.TBBT_playerScore);
            chart4.Series["Win"].Points.AddXY("Loss", TBBTGraph.TBBT_computerScore);
            chart4.Series["Win"].Points.AddXY("Draw", TBBTGraph.TBBT_Draw);
            chart4.Series["Win"].Label = "#PERCENT{0.00 %}";
            chart4.Series["Win"].LegendText = "#VALX";
        }
    }
}
