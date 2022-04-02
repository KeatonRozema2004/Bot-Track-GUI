using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Bot_Scout_RAPID_REACT
{
    public partial class BestTeams : Form
    {
        public BestTeams()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void bestUpperCargo_Click(object sender, EventArgs e)
        {
            bestTeamsStats("Tele Upper", 12, 13, 0, 0, false, "Upper Tele");
        }

        public void bestTeamsStats(string contains, int numb1, int numb2, int tempNumb, int startNum, bool hang, string name)
        {
            Form1 match = new Form1();
            int tempNum = tempNumb;
            int numTeams = 10000;
            int teleHigh1 = startNum;
            int teleHigh2 = startNum;
            int teleHigh3 = startNum;
            int teleHigh4 = startNum;
            int teleHigh5 = startNum;
            int teleHigh6 = startNum;
            int teleHigh7 = startNum;
            int teleHigh8 = startNum;
            int teleHigh9 = startNum;
            int teleHigh10 = startNum;
            int teleHigh11 = startNum;
            int teleHigh12 = startNum;
            int teleHigh13 = startNum;
            int teleHigh14 = startNum;
            int teleHigh15 = startNum;
            int teleHigh16 = startNum;
            int teleHigh17 = startNum;
            int teleHigh18 = startNum;
            int teleHigh19 = startNum;
            int teleHigh20 = startNum;

            string teleHighTeam1 = "";
            string teleHighTeam2 = "";
            string teleHighTeam3 = "";
            string teleHighTeam4 = "";
            string teleHighTeam5 = "";
            string teleHighTeam6 = "";
            string teleHighTeam7 = "";
            string teleHighTeam8 = "";
            string teleHighTeam9 = "";
            string teleHighTeam10 = "";
            string teleHighTeam11 = "";
            string teleHighTeam12 = "";
            string teleHighTeam13 = "";
            string teleHighTeam14 = "";
            string teleHighTeam15 = "";
            string teleHighTeam16 = "";
            string teleHighTeam17 = "";
            string teleHighTeam18 = "";
            string teleHighTeam19 = "";
            string teleHighTeam20 = "";

            for (int i = 0; i < numTeams; i++)
            {
                if (File.Exists(i + ".txt"))
                {

                    int j = 1;

                    while (match.GetLine(i + ".txt", j) != match.GetLine("blank.txt", 1))
                    {
                        //Console.WriteLine(match.GetLine(team+".txt",i));
                        j++;
                        if (match.GetLine(i + ".txt", j).Contains(contains))
                        {
                            string num1 = match.GetLine(i + ".txt", j)[numb1].ToString();
                            string num2 = match.GetLine(i + ".txt", j)[numb2].ToString();
                            tempNum = Int32.Parse(num1 + num2);
                            if (tempNum > teleHigh1 && hang == false)
                            {
                                teleHighTeam1 = i.ToString();
                                teleHigh1 = tempNum;
                            }
                            else if (tempNum < teleHigh1 && hang)
                            {
                                teleHighTeam1 = i.ToString();
                                teleHigh1 = tempNum;
                            }
                        }
                    }
                }
            }
            tempNum = tempNumb;
            for (int i = 0; i < numTeams; i++)
            {
                if (File.Exists(i + ".txt"))
                {
                    int j = 1;
                    while (match.GetLine(i + ".txt", j) != match.GetLine("blank.txt", 1))
                    {
                        //Console.WriteLine(match.GetLine(team+".txt",i));
                        j++;
                        if (match.GetLine(i + ".txt", j).Contains(contains) && i + ".txt" != teleHighTeam1 + ".txt")
                        {
                            string num1 = match.GetLine(i + ".txt", j)[numb1].ToString();
                            string num2 = match.GetLine(i + ".txt", j)[numb2].ToString();
                            tempNum = Int32.Parse(num1 + num2);
                            if (tempNum > teleHigh2 && hang == false)
                            {
                                teleHighTeam2 = i.ToString();
                                teleHigh2 = tempNum;
                            }
                            else if (tempNum < teleHigh2 && hang)
                            {
                                teleHighTeam2 = i.ToString();
                                teleHigh2 = tempNum;
                            }
                        }
                    }
                }
            }
            tempNum = tempNumb;
            for (int i = 0; i < numTeams; i++)
            {
                if (File.Exists(i + ".txt"))
                {
                    int j = 1;
                    while (match.GetLine(i + ".txt", j) != match.GetLine("blank.txt", 1))
                    {
                        //Console.WriteLine(match.GetLine(team+".txt",i));
                        j++;
                        if (match.GetLine(i + ".txt", j).Contains(contains) && i + ".txt" != teleHighTeam1 + ".txt" && i + ".txt" != teleHighTeam2 + ".txt")
                        {
                            string num1 = match.GetLine(i + ".txt", j)[numb1].ToString();
                            string num2 = match.GetLine(i + ".txt", j)[numb2].ToString();
                            tempNum = Int32.Parse(num1 + num2);
                            if (tempNum > teleHigh3 && hang == false)
                            {
                                teleHighTeam3 = i.ToString();
                                teleHigh3 = tempNum;
                            }
                            else if (tempNum < teleHigh3 && hang)
                            {
                                teleHighTeam3 = i.ToString();
                                teleHigh3 = tempNum;
                            }
                        }
                    }
                }
            }
            tempNum = tempNumb;
            for (int i = 0; i < numTeams; i++)
            {
                if (File.Exists(i + ".txt"))
                {
                    int j = 1;
                    while (match.GetLine(i + ".txt", j) != match.GetLine("blank.txt", 1))
                    {
                        //Console.WriteLine(match.GetLine(team+".txt",i));
                        j++;
                        if (match.GetLine(i + ".txt", j).Contains(contains) && i + ".txt" != teleHighTeam1 + ".txt" && i + ".txt" != teleHighTeam2 + ".txt" && i + ".txt" != teleHighTeam3 + ".txt")
                        {
                            string num1 = match.GetLine(i + ".txt", j)[numb1].ToString();
                            string num2 = match.GetLine(i + ".txt", j)[numb2].ToString();
                            tempNum = Int32.Parse(num1 + num2);
                            if (tempNum > teleHigh4 && hang == false)
                            {
                                teleHighTeam4 = i.ToString();
                                teleHigh4 = tempNum;
                            }
                            else if (tempNum < teleHigh4 && hang)
                            {
                                teleHighTeam4 = i.ToString();
                                teleHigh4 = tempNum;
                            }
                        }
                    }
                }
            }
            tempNum = tempNumb;
            for (int i = 0; i < numTeams; i++)
            {
                if (File.Exists(i + ".txt"))
                {
                    int j = 1;
                    while (match.GetLine(i + ".txt", j) != match.GetLine("blank.txt", 1))
                    {
                        //Console.WriteLine(match.GetLine(team+".txt",i));
                        j++;
                        if (match.GetLine(i + ".txt", j).Contains(contains) && i + ".txt" != teleHighTeam1 + ".txt" && i + ".txt" != teleHighTeam2 + ".txt" && i + ".txt" != teleHighTeam3 + ".txt" && i + ".txt" != teleHighTeam4 + ".txt")
                        {
                            string num1 = match.GetLine(i + ".txt", j)[numb1].ToString();
                            string num2 = match.GetLine(i + ".txt", j)[numb2].ToString();
                            tempNum = Int32.Parse(num1 + num2);
                            if (tempNum > teleHigh5 && hang == false)
                            {
                                teleHighTeam5 = i.ToString();
                                teleHigh5 = tempNum;
                            }
                            else if (tempNum < teleHigh5 && hang)
                            {
                                teleHighTeam5 = i.ToString();
                                teleHigh5 = tempNum;
                            }
                        }
                    }
                }
            }
            tempNum = tempNumb;
            for (int i = 0; i < numTeams; i++)
            {
                if (File.Exists(i + ".txt"))
                {
                    int j = 1;
                    while (match.GetLine(i + ".txt", j) != match.GetLine("blank.txt", 1))
                    {
                        //Console.WriteLine(match.GetLine(team+".txt",i));
                        j++;
                        if (match.GetLine(i + ".txt", j).Contains(contains) && i + ".txt" != teleHighTeam1 + ".txt" && i + ".txt" != teleHighTeam2 + ".txt" && i + ".txt" != teleHighTeam3 + ".txt" && i + ".txt" != teleHighTeam4 + ".txt" && i + ".txt" != teleHighTeam5 + ".txt")
                        {
                            string num1 = match.GetLine(i + ".txt", j)[numb1].ToString();
                            string num2 = match.GetLine(i + ".txt", j)[numb2].ToString();
                            tempNum = Int32.Parse(num1 + num2);
                            if (tempNum > teleHigh6 && hang == false)
                            {
                                teleHighTeam6 = i.ToString();
                                teleHigh6 = tempNum;
                            }
                            else if (tempNum < teleHigh6 && hang)
                            {
                                teleHighTeam6 = i.ToString();
                                teleHigh6 = tempNum;
                            }
                        }
                    }
                }
            }
            tempNum = tempNumb;
            for (int i = 0; i < numTeams; i++)
            {
                if (File.Exists(i + ".txt"))
                {
                    int j = 1;
                    while (match.GetLine(i + ".txt", j) != match.GetLine("blank.txt", 1))
                    {
                        //Console.WriteLine(match.GetLine(team+".txt",i));
                        j++;
                        if (match.GetLine(i + ".txt", j).Contains(contains) && i + ".txt" != teleHighTeam1 + ".txt" && i + ".txt" != teleHighTeam2 + ".txt" && i + ".txt" != teleHighTeam3 + ".txt" && i + ".txt" != teleHighTeam4 + ".txt" && i + ".txt" != teleHighTeam5 + ".txt" && i + ".txt" != teleHighTeam6 + ".txt")
                        {
                            string num1 = match.GetLine(i + ".txt", j)[numb1].ToString();
                            string num2 = match.GetLine(i + ".txt", j)[numb2].ToString();
                            tempNum = Int32.Parse(num1 + num2);
                            if (tempNum > teleHigh7 && hang == false)
                            {
                                teleHighTeam7 = i.ToString();
                                teleHigh7 = tempNum;
                            }
                            else if (tempNum < teleHigh7 && hang)
                            {
                                teleHighTeam7 = i.ToString();
                                teleHigh7 = tempNum;
                            }
                        }
                    }
                }
            }
            tempNum = tempNumb;
            for (int i = 0; i < numTeams; i++)
            {
                if (File.Exists(i + ".txt"))
                {
                    int j = 1;
                    while (match.GetLine(i + ".txt", j) != match.GetLine("blank.txt", 1))
                    {
                        //Console.WriteLine(match.GetLine(team+".txt",i));
                        j++;
                        if (match.GetLine(i + ".txt", j).Contains(contains) && i + ".txt" != teleHighTeam1 + ".txt" && i + ".txt" != teleHighTeam2 + ".txt" && i + ".txt" != teleHighTeam3 + ".txt" && i + ".txt" != teleHighTeam4 + ".txt" && i + ".txt" != teleHighTeam5 + ".txt" && i + ".txt" != teleHighTeam6 + ".txt" && i + ".txt" != teleHighTeam7 + ".txt")
                        {
                            string num1 = match.GetLine(i + ".txt", j)[numb1].ToString();
                            string num2 = match.GetLine(i + ".txt", j)[numb2].ToString();
                            tempNum = Int32.Parse(num1 + num2);
                            if (tempNum > teleHigh8 && hang == false)
                            {
                                teleHighTeam8 = i.ToString();
                                teleHigh8 = tempNum;
                            }
                            else if (tempNum < teleHigh8 && hang)
                            {
                                teleHighTeam8 = i.ToString();
                                teleHigh8 = tempNum;
                            }
                        }
                    }
                }
            }
            tempNum = tempNumb;
            for (int i = 0; i < numTeams; i++)
            {
                if (File.Exists(i + ".txt"))
                {
                    int j = 1;
                    while (match.GetLine(i + ".txt", j) != match.GetLine("blank.txt", 1))
                    {
                        //Console.WriteLine(match.GetLine(team+".txt",i));
                        j++;
                        if (match.GetLine(i + ".txt", j).Contains(contains) && i + ".txt" != teleHighTeam1 + ".txt" && i + ".txt" != teleHighTeam2 + ".txt" && i + ".txt" != teleHighTeam3 + ".txt" && i + ".txt" != teleHighTeam4 + ".txt" && i + ".txt" != teleHighTeam5 + ".txt" && i + ".txt" != teleHighTeam6 + ".txt" && i + ".txt" != teleHighTeam7 + ".txt" && i + ".txt" != teleHighTeam8 + ".txt")
                        {
                            string num1 = match.GetLine(i + ".txt", j)[numb1].ToString();
                            string num2 = match.GetLine(i + ".txt", j)[numb2].ToString();
                            tempNum = Int32.Parse(num1 + num2);
                            if (tempNum > teleHigh9 && hang == false)
                            {
                                teleHighTeam9 = i.ToString();
                                teleHigh9 = tempNum;
                            }
                            else if (tempNum < teleHigh9 && hang)
                            {
                                teleHighTeam9 = i.ToString();
                                teleHigh9 = tempNum;
                            }
                        }
                    }
                }
            }
            tempNum = tempNumb;
            for (int i = 0; i < numTeams; i++)
            {
                if (File.Exists(i + ".txt"))
                {
                    int j = 1;
                    while (match.GetLine(i + ".txt", j) != match.GetLine("blank.txt", 1))
                    {
                        //Console.WriteLine(match.GetLine(team+".txt",i));
                        j++;
                        if (match.GetLine(i + ".txt", j).Contains(contains) && i + ".txt" != teleHighTeam1 + ".txt" && i + ".txt" != teleHighTeam2 + ".txt" && i + ".txt" != teleHighTeam3 + ".txt" && i + ".txt" != teleHighTeam4 + ".txt" && i + ".txt" != teleHighTeam5 + ".txt" && i + ".txt" != teleHighTeam6 + ".txt" && i + ".txt" != teleHighTeam7 + ".txt" && i + ".txt" != teleHighTeam8 + ".txt" && i + ".txt" != teleHighTeam9 + ".txt")
                        {
                            string num1 = match.GetLine(i + ".txt", j)[numb1].ToString();
                            string num2 = match.GetLine(i + ".txt", j)[numb2].ToString();
                            tempNum = Int32.Parse(num1 + num2);
                            if (tempNum > teleHigh10 && hang == false)
                            {
                                teleHighTeam10 = i.ToString();
                                teleHigh10 = tempNum;
                            }
                            else if (tempNum < teleHigh10 && hang)
                            {
                                teleHighTeam10 = i.ToString();
                                teleHigh10 = tempNum;
                            }
                        }
                    }
                }
            }
            tempNum = tempNumb;
            for (int i = 0; i < numTeams; i++)
            {
                if (File.Exists(i + ".txt"))
                {
                    int j = 1;
                    while (match.GetLine(i + ".txt", j) != match.GetLine("blank.txt", 1))
                    {
                        //Console.WriteLine(match.GetLine(team+".txt",i));
                        j++;
                        if (match.GetLine(i + ".txt", j).Contains(contains) && i + ".txt" != teleHighTeam1 + ".txt" && i + ".txt" != teleHighTeam2 + ".txt" && i + ".txt" != teleHighTeam3 + ".txt" && i + ".txt" != teleHighTeam4 + ".txt" && i + ".txt" != teleHighTeam5 + ".txt" && i + ".txt" != teleHighTeam6 + ".txt" && i + ".txt" != teleHighTeam7 + ".txt" && i + ".txt" != teleHighTeam8 + ".txt" && i + ".txt" != teleHighTeam9 + ".txt" && i + ".txt" != teleHighTeam10 + ".txt")
                        {
                            string num1 = match.GetLine(i + ".txt", j)[numb1].ToString();
                            string num2 = match.GetLine(i + ".txt", j)[numb2].ToString();
                            tempNum = Int32.Parse(num1 + num2);
                            if (tempNum > teleHigh11 && hang == false)
                            {
                                teleHighTeam11 = i.ToString();
                                teleHigh11 = tempNum;
                            }
                            else if (tempNum < teleHigh11 && hang)
                            {
                                teleHighTeam11 = i.ToString();
                                teleHigh11 = tempNum;
                            }
                        }
                    }
                }
            }
            tempNum = tempNumb;
            for (int i = 0; i < numTeams; i++)
            {
                if (File.Exists(i + ".txt"))
                {
                    int j = 1;
                    while (match.GetLine(i + ".txt", j) != match.GetLine("blank.txt", 1))
                    {
                        //Console.WriteLine(match.GetLine(team+".txt",i));
                        j++;
                        if (match.GetLine(i + ".txt", j).Contains(contains) && i + ".txt" != teleHighTeam1 + ".txt" && i + ".txt" != teleHighTeam2 + ".txt" && i + ".txt" != teleHighTeam3 + ".txt" && i + ".txt" != teleHighTeam4 + ".txt" && i + ".txt" != teleHighTeam5 + ".txt" && i + ".txt" != teleHighTeam6 + ".txt" && i + ".txt" != teleHighTeam7 + ".txt" && i + ".txt" != teleHighTeam8 + ".txt" && i + ".txt" != teleHighTeam9 + ".txt" && i + ".txt" != teleHighTeam10 + ".txt" && i + ".txt" != teleHighTeam11 + ".txt")
                        {
                            string num1 = match.GetLine(i + ".txt", j)[numb1].ToString();
                            string num2 = match.GetLine(i + ".txt", j)[numb2].ToString();
                            tempNum = Int32.Parse(num1 + num2);
                            if (tempNum > teleHigh12 && hang == false)
                            {
                                teleHighTeam12 = i.ToString();
                                teleHigh12 = tempNum;
                            }
                            else if (tempNum < teleHigh12 && hang)
                            {
                                teleHighTeam12 = i.ToString();
                                teleHigh12 = tempNum;
                            }
                        }
                    }
                }
            }
            tempNum = tempNumb;
            for (int i = 0; i < numTeams; i++)
            {
                if (File.Exists(i + ".txt"))
                {
                    int j = 1;
                    while (match.GetLine(i + ".txt", j) != match.GetLine("blank.txt", 1))
                    {
                        //Console.WriteLine(match.GetLine(team+".txt",i));
                        j++;
                        if (match.GetLine(i + ".txt", j).Contains(contains) && i + ".txt" != teleHighTeam1 + ".txt" && i + ".txt" != teleHighTeam2 + ".txt" && i + ".txt" != teleHighTeam3 + ".txt" && i + ".txt" != teleHighTeam4 + ".txt" && i + ".txt" != teleHighTeam5 + ".txt" && i + ".txt" != teleHighTeam6 + ".txt" && i + ".txt" != teleHighTeam7 + ".txt" && i + ".txt" != teleHighTeam8 + ".txt" && i + ".txt" != teleHighTeam9 + ".txt" && i + ".txt" != teleHighTeam10 + ".txt" && i + ".txt" != teleHighTeam11 + ".txt" && i + ".txt" != teleHighTeam12 + ".txt")
                        {
                            string num1 = match.GetLine(i + ".txt", j)[numb1].ToString();
                            string num2 = match.GetLine(i + ".txt", j)[numb2].ToString();
                            tempNum = Int32.Parse(num1 + num2);
                            if (tempNum > teleHigh13 && hang == false)
                            {
                                teleHighTeam13 = i.ToString();
                                teleHigh13 = tempNum;
                            }
                            else if (tempNum < teleHigh13 && hang)
                            {
                                teleHighTeam13 = i.ToString();
                                teleHigh13 = tempNum;
                            }
                        }
                    }
                }
            }
            tempNum = tempNumb;
            for (int i = 0; i < numTeams; i++)
            {
                if (File.Exists(i + ".txt"))
                {
                    int j = 1;
                    while (match.GetLine(i + ".txt", j) != match.GetLine("blank.txt", 1))
                    {
                        //Console.WriteLine(match.GetLine(team+".txt",i));
                        j++;
                        if (match.GetLine(i + ".txt", j).Contains(contains) && i + ".txt" != teleHighTeam1 + ".txt" && i + ".txt" != teleHighTeam2 + ".txt" && i + ".txt" != teleHighTeam3 + ".txt" && i + ".txt" != teleHighTeam4 + ".txt" && i + ".txt" != teleHighTeam5 + ".txt" && i + ".txt" != teleHighTeam6 + ".txt" && i + ".txt" != teleHighTeam7 + ".txt" && i + ".txt" != teleHighTeam8 + ".txt" && i + ".txt" != teleHighTeam9 + ".txt" && i + ".txt" != teleHighTeam10 + ".txt" && i + ".txt" != teleHighTeam11 + ".txt" && i + ".txt" != teleHighTeam12 + ".txt" && i + ".txt" != teleHighTeam13 + ".txt")
                        {
                            string num1 = match.GetLine(i + ".txt", j)[numb1].ToString();
                            string num2 = match.GetLine(i + ".txt", j)[numb2].ToString();
                            tempNum = Int32.Parse(num1 + num2);
                            if (tempNum > teleHigh14 && hang == false)
                            {
                                teleHighTeam14 = i.ToString();
                                teleHigh14 = tempNum;
                            }
                            else if (tempNum < teleHigh14 && hang)
                            {
                                teleHighTeam14 = i.ToString();
                                teleHigh14 = tempNum;
                            }
                        }
                    }
                }
            }
            tempNum = tempNumb;
            for (int i = 0; i < numTeams; i++)
            {
                if (File.Exists(i + ".txt"))
                {
                    int j = 1;
                    while (match.GetLine(i + ".txt", j) != match.GetLine("blank.txt", 1))
                    {
                        //Console.WriteLine(match.GetLine(team+".txt",i));
                        j++;
                        if (match.GetLine(i + ".txt", j).Contains(contains) && i + ".txt" != teleHighTeam1 + ".txt" && i + ".txt" != teleHighTeam2 + ".txt" && i + ".txt" != teleHighTeam3 + ".txt" && i + ".txt" != teleHighTeam4 + ".txt" && i + ".txt" != teleHighTeam5 + ".txt" && i + ".txt" != teleHighTeam6 + ".txt" && i + ".txt" != teleHighTeam7 + ".txt" && i + ".txt" != teleHighTeam8 + ".txt" && i + ".txt" != teleHighTeam9 + ".txt" && i + ".txt" != teleHighTeam10 + ".txt" && i + ".txt" != teleHighTeam11 + ".txt" && i + ".txt" != teleHighTeam12 + ".txt" && i + ".txt" != teleHighTeam13 + ".txt" && i + ".txt" != teleHighTeam14 + ".txt")
                        {
                            string num1 = match.GetLine(i + ".txt", j)[numb1].ToString();
                            string num2 = match.GetLine(i + ".txt", j)[numb2].ToString();
                            tempNum = Int32.Parse(num1 + num2);
                            if (tempNum > teleHigh15 && hang == false)
                            {
                                teleHighTeam15 = i.ToString();
                                teleHigh15 = tempNum;
                            }
                            else if (tempNum < teleHigh15 && hang)
                            {
                                teleHighTeam15 = i.ToString();
                                teleHigh15 = tempNum;
                            }
                        }
                    }
                }
            }
            tempNum = tempNumb;
            for (int i = 0; i < numTeams; i++)
            {
                if (File.Exists(i + ".txt"))
                {
                    int j = 1;
                    while (match.GetLine(i + ".txt", j) != match.GetLine("blank.txt", 1))
                    {
                        //Console.WriteLine(match.GetLine(team+".txt",i));
                        j++;
                        if (match.GetLine(i + ".txt", j).Contains(contains) && i + ".txt" != teleHighTeam1 + ".txt" && i + ".txt" != teleHighTeam2 + ".txt" && i + ".txt" != teleHighTeam3 + ".txt" && i + ".txt" != teleHighTeam4 + ".txt" && i + ".txt" != teleHighTeam5 + ".txt" && i + ".txt" != teleHighTeam6 + ".txt" && i + ".txt" != teleHighTeam7 + ".txt" && i + ".txt" != teleHighTeam8 + ".txt" && i + ".txt" != teleHighTeam9 + ".txt" && i + ".txt" != teleHighTeam10 + ".txt" && i + ".txt" != teleHighTeam11 + ".txt" && i + ".txt" != teleHighTeam12 + ".txt" && i + ".txt" != teleHighTeam13 + ".txt" && i + ".txt" != teleHighTeam14 + ".txt" && i + ".txt" != teleHighTeam15 + ".txt")
                        {
                            string num1 = match.GetLine(i + ".txt", j)[numb1].ToString();
                            string num2 = match.GetLine(i + ".txt", j)[numb2].ToString();
                            tempNum = Int32.Parse(num1 + num2);
                            if (tempNum > teleHigh16 && hang == false)
                            {
                                teleHighTeam16 = i.ToString();
                                teleHigh16 = tempNum;
                            }
                            else if (tempNum < teleHigh16 && hang)
                            {
                                teleHighTeam16 = i.ToString();
                                teleHigh16 = tempNum;
                            }
                        }
                    }
                }
            }
            tempNum = tempNumb;
            for (int i = 0; i < numTeams; i++)
            {
                if (File.Exists(i + ".txt"))
                {
                    int j = 1;
                    while (match.GetLine(i + ".txt", j) != match.GetLine("blank.txt", 1))
                    {
                        //Console.WriteLine(match.GetLine(team+".txt",i));
                        j++;
                        if (match.GetLine(i + ".txt", j).Contains(contains) && i + ".txt" != teleHighTeam1 + ".txt" && i + ".txt" != teleHighTeam2 + ".txt" && i + ".txt" != teleHighTeam3 + ".txt" && i + ".txt" != teleHighTeam4 + ".txt" && i + ".txt" != teleHighTeam5 + ".txt" && i + ".txt" != teleHighTeam6 + ".txt" && i + ".txt" != teleHighTeam7 + ".txt" && i + ".txt" != teleHighTeam8 + ".txt" && i + ".txt" != teleHighTeam9 + ".txt" && i + ".txt" != teleHighTeam10 + ".txt" && i + ".txt" != teleHighTeam11 + ".txt" && i + ".txt" != teleHighTeam12 + ".txt" && i + ".txt" != teleHighTeam13 + ".txt" && i + ".txt" != teleHighTeam14 + ".txt" && i + ".txt" != teleHighTeam15 + ".txt" && i + ".txt" != teleHighTeam16 + ".txt")
                        {
                            string num1 = match.GetLine(i + ".txt", j)[numb1].ToString();
                            string num2 = match.GetLine(i + ".txt", j)[numb2].ToString();
                            tempNum = Int32.Parse(num1 + num2);
                            if (tempNum > teleHigh17 && hang == false)
                            {
                                teleHighTeam17 = i.ToString();
                                teleHigh17 = tempNum;
                            }
                            else if (tempNum < teleHigh17 && hang)
                            {
                                teleHighTeam17 = i.ToString();
                                teleHigh17 = tempNum;
                            }
                        }
                    }
                }
            }
            tempNum = tempNumb;
            for (int i = 0; i < numTeams; i++)
            {
                if (File.Exists(i + ".txt"))
                {
                    int j = 1;
                    while (match.GetLine(i + ".txt", j) != match.GetLine("blank.txt", 1))
                    {
                        //Console.WriteLine(match.GetLine(team+".txt",i));
                        j++;
                        if (match.GetLine(i + ".txt", j).Contains(contains) && i + ".txt" != teleHighTeam1 + ".txt" && i + ".txt" != teleHighTeam2 + ".txt" && i + ".txt" != teleHighTeam3 + ".txt" && i + ".txt" != teleHighTeam4 + ".txt" && i + ".txt" != teleHighTeam5 + ".txt" && i + ".txt" != teleHighTeam6 + ".txt" && i + ".txt" != teleHighTeam7 + ".txt" && i + ".txt" != teleHighTeam8 + ".txt" && i + ".txt" != teleHighTeam9 + ".txt" && i + ".txt" != teleHighTeam10 + ".txt" && i + ".txt" != teleHighTeam11 + ".txt" && i + ".txt" != teleHighTeam12 + ".txt" && i + ".txt" != teleHighTeam13 + ".txt" && i + ".txt" != teleHighTeam14 + ".txt" && i + ".txt" != teleHighTeam15 + ".txt" && i + ".txt" != teleHighTeam16 + ".txt" && i + ".txt" != teleHighTeam17 + ".txt")
                        {
                            string num1 = match.GetLine(i + ".txt", j)[numb1].ToString();
                            string num2 = match.GetLine(i + ".txt", j)[numb2].ToString();
                            tempNum = Int32.Parse(num1 + num2);
                            if (tempNum > teleHigh18 && hang == false)
                            {
                                teleHighTeam18 = i.ToString();
                                teleHigh18 = tempNum;
                            }
                            else if (tempNum < teleHigh18 && hang)
                            {
                                teleHighTeam18 = i.ToString();
                                teleHigh18 = tempNum;
                            }
                        }
                    }
                }
            }
            tempNum = tempNumb;
            for (int i = 0; i < numTeams; i++)
            {
                if (File.Exists(i + ".txt"))
                {
                    int j = 1;
                    while (match.GetLine(i + ".txt", j) != match.GetLine("blank.txt", 1))
                    {
                        //Console.WriteLine(match.GetLine(team+".txt",i));
                        j++;
                        if (match.GetLine(i + ".txt", j).Contains(contains) && i + ".txt" != teleHighTeam1 + ".txt" && i + ".txt" != teleHighTeam2 + ".txt" && i + ".txt" != teleHighTeam3 + ".txt" && i + ".txt" != teleHighTeam4 + ".txt" && i + ".txt" != teleHighTeam5 + ".txt" && i + ".txt" != teleHighTeam6 + ".txt" && i + ".txt" != teleHighTeam7 + ".txt" && i + ".txt" != teleHighTeam8 + ".txt" && i + ".txt" != teleHighTeam9 + ".txt" && i + ".txt" != teleHighTeam10 + ".txt" && i + ".txt" != teleHighTeam11 + ".txt" && i + ".txt" != teleHighTeam12 + ".txt" && i + ".txt" != teleHighTeam13 + ".txt" && i + ".txt" != teleHighTeam14 + ".txt" && i + ".txt" != teleHighTeam15 + ".txt" && i + ".txt" != teleHighTeam16 + ".txt" && i + ".txt" != teleHighTeam17 + ".txt" && i + ".txt" != teleHighTeam18 + ".txt")
                        {
                            string num1 = match.GetLine(i + ".txt", j)[numb1].ToString();
                            string num2 = match.GetLine(i + ".txt", j)[numb2].ToString();
                            tempNum = Int32.Parse(num1 + num2);
                            if (tempNum > teleHigh19 && hang == false)
                            {
                                teleHighTeam19 = i.ToString();
                                teleHigh19 = tempNum;
                            }
                            else if (tempNum < teleHigh19 && hang)
                            {
                                teleHighTeam19 = i.ToString();
                                teleHigh19 = tempNum;
                            }
                        }
                    }
                }
            }
            tempNum = tempNumb;
            for (int i = 0; i < numTeams; i++)
            {
                if (File.Exists(i + ".txt"))
                {
                    int j = 1;
                    while (match.GetLine(i + ".txt", j) != match.GetLine("blank.txt", 1))
                    {
                        //Console.WriteLine(match.GetLine(team+".txt",i));
                        j++;
                        if (match.GetLine(i + ".txt", j).Contains(contains) && i + ".txt" != teleHighTeam1 + ".txt" && i + ".txt" != teleHighTeam2 + ".txt" && i + ".txt" != teleHighTeam3 + ".txt" && i + ".txt" != teleHighTeam4 + ".txt" && i + ".txt" != teleHighTeam5 + ".txt" && i + ".txt" != teleHighTeam6 + ".txt" && i + ".txt" != teleHighTeam7 + ".txt" && i + ".txt" != teleHighTeam8 + ".txt" && i + ".txt" != teleHighTeam9 + ".txt" && i + ".txt" != teleHighTeam10 + ".txt" && i + ".txt" != teleHighTeam11 + ".txt" && i + ".txt" != teleHighTeam12 + ".txt" && i + ".txt" != teleHighTeam13 + ".txt" && i + ".txt" != teleHighTeam14 + ".txt" && i + ".txt" != teleHighTeam15 + ".txt" && i + ".txt" != teleHighTeam16 + ".txt" && i + ".txt" != teleHighTeam17 + ".txt" && i + ".txt" != teleHighTeam18 + ".txt" && i + ".txt" != teleHighTeam19 + ".txt")
                        {
                            string num1 = match.GetLine(i + ".txt", j)[numb1].ToString();
                            string num2 = match.GetLine(i + ".txt", j)[numb2].ToString();
                            tempNum = Int32.Parse(num1 + num2);
                            if (tempNum > teleHigh20 && hang == false)
                            {
                                teleHighTeam20 = i.ToString();
                                teleHigh20 = tempNum;
                            }
                            else if (tempNum < teleHigh20 && hang)
                            {
                                teleHighTeam20 = i.ToString();
                                teleHigh20 = tempNum;
                            }
                        }
                    }
                }
            }

            Console.WriteLine("1. Team " + teleHighTeam1 + " " + name + ": " + teleHigh1);
            bestName.Text = name;

            team1.Text = "Team " + teleHighTeam1;
            team1Data.Text = "" + teleHigh1;

            team2.Text = "Team " + teleHighTeam2;
            team2Data.Text = "" + teleHigh2;

            team3.Text = "Team " + teleHighTeam3;
            team3Data.Text = "" + teleHigh3;

            team4.Text = "Team " + teleHighTeam4;
            team4Data.Text = "" + teleHigh4;

            team5.Text = "Team " + teleHighTeam5;
            team5Data.Text = "" + teleHigh5;

            team6.Text = "Team " + teleHighTeam6;
            team6Data.Text = "" + teleHigh6;

            team7.Text = "Team " + teleHighTeam7;
            team7Data.Text = "" + teleHigh7;

            team8.Text = "Team " + teleHighTeam8;
            team8Data.Text = "" + teleHigh8;

            team9.Text = "Team " + teleHighTeam9;
            team9Data.Text = "" + teleHigh9;

            team10.Text = "Team " + teleHighTeam10;
            team10Data.Text = "" + teleHigh10;

            team11.Text = "Team " + teleHighTeam11;
            team11Data.Text = "" + teleHigh11;
            
            team12.Text = "Team " + teleHighTeam12;
            team12Data.Text = "" + teleHigh12;

            team13.Text = "Team " + teleHighTeam13;
            team13Data.Text = "" + teleHigh13;

            team14.Text = "Team " + teleHighTeam14;
            team14Data.Text = "" + teleHigh14;

            team15.Text = "Team " + teleHighTeam15;
            team15Data.Text = "" + teleHigh15;

            team16.Text = "Team " + teleHighTeam16;
            team16Data.Text = "" + teleHigh16;

            team17.Text = "Team " + teleHighTeam17;
            team17Data.Text = "" + teleHigh17;

            team18.Text = "Team " + teleHighTeam18;
            team18Data.Text = "" + teleHigh18;

            team19.Text = "Team " + teleHighTeam19;
            team19Data.Text = "" + teleHigh19;

            team20.Text = "Team " + teleHighTeam20;
            team20Data.Text = "" + teleHigh20;
            
            Console.WriteLine("2. Team " + teleHighTeam2 + " " + name + ": " + teleHigh2);
            Console.WriteLine("3. Team " + teleHighTeam3 + " " + name + ": " + teleHigh3);
            Console.WriteLine("4. Team " + teleHighTeam4 + " " + name + ": " + teleHigh4);
            Console.WriteLine("5. Team " + teleHighTeam5 + " " + name + ": " + teleHigh5);
            Console.WriteLine("6. Team " + teleHighTeam6 + " " + name + ": " + teleHigh6);
            Console.WriteLine("7. Team " + teleHighTeam7 + " " + name + ": " + teleHigh7);
            Console.WriteLine("8. Team " + teleHighTeam8 + " " + name + ": " + teleHigh8);
            Console.WriteLine("9. Team " + teleHighTeam9 + " " + name + ": " + teleHigh9);
            Console.WriteLine("10. Team " + teleHighTeam10 + " " + name + ": " + teleHigh10);
            Console.WriteLine("11. Team " + teleHighTeam11 + " " + name + ": " + teleHigh11);
            Console.WriteLine("12. Team " + teleHighTeam12 + " " + name + ": " + teleHigh12);
            Console.WriteLine("13. Team " + teleHighTeam13 + " " + name + ": " + teleHigh13);
            Console.WriteLine("14. Team " + teleHighTeam14 + " " + name + ": " + teleHigh14);
            Console.WriteLine("15. Team " + teleHighTeam15 + " " + name + ": " + teleHigh15);
            Console.WriteLine("16. Team " + teleHighTeam16 + " " + name + ": " + teleHigh16);
            Console.WriteLine("17. Team " + teleHighTeam17 + " " + name + ": " + teleHigh17);
            Console.WriteLine("18. Team " + teleHighTeam18 + " " + name + ": " + teleHigh18);
            Console.WriteLine("19. Team " + teleHighTeam19 + " " + name + ": " + teleHigh19);
            Console.WriteLine("20. Team " + teleHighTeam20 + " " + name + ": " + teleHigh20);


            

            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("Press Enter to go back to menu");
            Console.ForegroundColor = ConsoleColor.White;
            Console.ReadLine();
        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void BestTeams_Load(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            bestTeamsStats("Tele Lower", 12, 13, 0, 0, false, "Lower Tele");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            bestTeamsStats("Tele Cargo Score", 18, 19, 0, 0, false, "Cargo Points Tele");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            bestTeamsStats("Auto Upper", 12, 13, 0, 0, false, "Upper Auto");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            bestTeamsStats("Auto Lower", 12, 13, 0, 0, false, "Lower Auto");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            bestTeamsStats("Auto Cargo Score", 18, 19, 0, 0, false, "Cargo Points Auto");
        }
    }
}
