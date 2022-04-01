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
    public partial class Data : Form
    {
        public Data()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                bestScore(team.Text);
            }
            catch
            {
                loadText.Text = "Whoops, team does not exist!";
            }
            
        }
        public void bestScore(string team)
        {
            Form1 match = new Form1();
            int autoTotal1 = 0;
            int autoLow1 = 0;
            int teleHigh1 = 0;
            int teleLow1 = 0;
            int time1 = 500;
            //int leastAutoMissed = 500;
            //int leastTeleMissed = 500;
            int defense1 = 0;
            int tempNum = 0;
            //string tempString;
            string climbType1 = "n";
            int i = 1;
            //Console.WriteLine("Getting team data...");
            while (match.GetLine(team + ".txt", i) != match.GetLine("blank.txt", 1))
            {
                //Console.WriteLine(match.GetLine(team+".txt",i));
                i++;
                if (match.GetLine(team + ".txt", i).Contains("Auto Cargo Total"))
                {
                    string num1 = match.GetLine(team + ".txt", i)[18].ToString();
                    string num2 = match.GetLine(team + ".txt", i)[19].ToString();
                    tempNum = Int32.Parse(num1 + num2);
                    if (tempNum > autoTotal1)
                    {
                        autoTotal1 = tempNum;
                    }
                }
                if (match.GetLine(team + ".txt", i).Contains("Tele Lower"))
                {
                    string num1 = match.GetLine(team + ".txt", i)[12].ToString();
                    string num2 = match.GetLine(team + ".txt", i)[13].ToString();
                    tempNum = Int32.Parse(num1 + num2);
                    if (tempNum > teleLow1)
                    {
                        teleLow1 = tempNum;
                    }
                }
                if (match.GetLine(team + ".txt", i).Contains("Tele Upper"))
                {
                    string num1 = match.GetLine(team + ".txt", i)[12].ToString();
                    string num2 = match.GetLine(team + ".txt", i)[13].ToString();
                    tempNum = Int32.Parse(num1 + num2);
                    if (tempNum > teleHigh1)
                    {
                        teleHigh1 = tempNum;
                    }
                }

                if (match.GetLine(team + ".txt", i).Contains("Defense"))
                {
                    string num1 = match.GetLine(team + ".txt", i)[9].ToString();
                    tempNum = Int32.Parse(num1);
                    if (tempNum > defense1)
                    {
                        defense1 = tempNum;
                    }
                }
                /*
             if(match.GetLine(team+".txt", i).Contains("Total Climb Time")){
               string num1 = match.GetLine(team+".txt", i)[18].ToString();
               string num2 = match.GetLine(team+".txt", i)[19].ToString();
               tempNum = Int32.Parse(num1+num2);
               if(tempNum < time){
                 time = tempNum;
               }
             }
       */
                if (match.GetLine(team + ".txt", i).Contains("Climb Type"))
                {
                    string climb = match.GetLine(team + ".txt", i)[12].ToString();
                    if (climb == "l" && climbType1 == "n")
                    {
                        climbType1 = climb;
                    }
                    else if (climb == "m")
                    {
                        if (climbType1 == "l" || climbType1 == "n")
                        {
                            climbType1 = climb;
                        }
                    }
                    else if (climb == "h")
                    {
                        if (climbType1 == "m" || climbType1 == "l" || climbType1 == "n")
                        {
                            climbType1 = climb;
                        }
                    }
                    else if (climb == "t")
                    {
                        if (climbType1 == "h" || climbType1 == "m" || climbType1 == "l" || climbType1 == "n")
                        {
                            climbType1 = climb;
                        }
                    }

                }
            }

            i = 0;
            while (match.GetLine(team + ".txt", i) != match.GetLine("blank.txt", 1))
            {
                //Console.WriteLine(match.GetLine(team+".txt",i));
                i++;

                if (match.GetLine(team + ".txt", i).Contains("Total Climb Time"))
                {
                    string num1 = match.GetLine(team + ".txt", i)[18].ToString();
                    string num2 = match.GetLine(team + ".txt", i)[19].ToString();
                    tempNum = Int32.Parse(num1 + num2);

                    if (tempNum < time1 && match.GetLine(team + ".txt", i + 1)[12].ToString() == climbType1)
                    {
                        time1 = tempNum;

                    }
                }

            }
            teleLow.Text = "" + teleLow1;
            teleHigh.Text = "" + teleHigh1;
            autoTotal.Text = "" + autoTotal1;
            time.Text = "" + time1;
            climbType.Text = "" + climbType1;
            defense.Text = "" + defense1;
            loadText.Text = "Data Loaded!";
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("-Best Scores-");
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("Best Low Goal Tele: " + teleLow);
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Best High Goal Tele: " + teleHigh);
            Console.WriteLine();

            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("Best Auto Cargo Scored: " + autoTotal);
            Console.WriteLine();

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Best Climb Time: " + time);
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("Best Climb Type: " + climbType);
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Best Defense: " + defense);
            Console.WriteLine();

        }
    }
}
