using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bot_Scout_RAPID_REACT
{
    public partial class Average : Form
    {
        public Average()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }
        public void averageCargo()
        {
            Form1 match = new Form1();
            int averageScoreTele = 0;
            int averageScoreAccTele = 0;
            int i = 1;
            int j = 0;
            Console.Write("Team #: ");
            while (match.GetLine(team.Text + ".txt", i) != match.GetLine("blank.txt", 1))
            {
                //Console.WriteLine(GetLine(team+".txt",i));
                i++;
                if (match.GetLine(team.Text + ".txt", i).Contains("Tele Cargo Score"))
                {
                    string num1 = match.GetLine(team.Text + ".txt", i)[18].ToString();
                    string num2 = match.GetLine(team.Text + ".txt", i)[19].ToString();
                    averageScoreTele += Int32.Parse(num1 + num2);
                    j++;
                }
            }
            i = 0;
            j = 0;
            while (match.GetLine(team.Text + ".txt", i) != match.GetLine("blank.txt", 1))
            {
                //Console.WriteLine(GetLine(team+".txt",i));
                i++;
                if (match.GetLine(team.Text + ".txt", i).Contains("Tele Accuracy"))
                {
                    string num1 = match.GetLine(team.Text + ".txt", i)[15].ToString();
                    string num2 = match.GetLine(team.Text + ".txt", i)[16].ToString();
                    averageScoreAccTele += Int32.Parse(num1 + num2);
                    j++;
                }
            }

            averageTele.Text = "" + averageScoreTele / j;
            averageTeleAcc.Text = averageScoreAccTele / j + "%";
            loadText.Text = "Data Loaded";

            //return 1;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                
                averageCargo();
                
            }
            catch (Exception l)
            {
                loadText.Text = "Couldn't Find Team";
            }
        }
    }
}
