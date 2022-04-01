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
using System.Threading;

namespace Bot_Scout_RAPID_REACT
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        public void addTeam(string team)
        {
            File.Create(team + ".txt").Close();

        }
        public void addLines(string team)
        {
            for (int i = 0; i < 5000; i++)
            {
                File.AppendAllText(team + ".txt", "0" + Environment.NewLine);
            }
            Console.WriteLine("Added team!");
        }
        private void button3_Click_1(object sender, EventArgs e)
        {
            try
            {
                string current = Directory.GetCurrentDirectory() + "\\";
                int autoCargo;

                int teleCargo;

                int climbTime;

                string autoAccuracy;
                string teleAccuracy;
                int team1;
                string prompt;
                if (!File.Exists("blank.txt"))
                {
                    addTeam("blank");
                    addLines("blank");

                }
                if (!File.Exists(team.Text + ".txt"))
                {
                    addTeam(team.Text);
                    addLines(team.Text);

                }
                //addTeam(team.Text);
                //addLines(team.Text);


                //User match data
                climbTime = (Int32.Parse(climbStart.Text) - Int32.Parse(climbEnd.Text));

                double autoUpperInt = Double.Parse(autoUpper.Text);
                double autoLowerInt = Double.Parse(autoLower.Text);
                double autoMissedInt = Double.Parse(autoMissed.Text);
                autoAccuracy = (autoUpperInt + autoLowerInt) / (autoUpperInt + autoLowerInt + autoMissedInt) * 100 + "%";

                double teleUpperInt = Double.Parse(teleUpper.Text);
                double teleLowerInt = Double.Parse(teleLower.Text);
                double teleMissedInt = Double.Parse(teleMissed.Text);
                teleAccuracy = (teleUpperInt + teleLowerInt) / (teleUpperInt + teleLowerInt + teleMissedInt) * 100 + "%";

                //User match data
                writeToFile(team.Text, "Match Number: " + match.Text);
                writeToFile(team.Text, "Taxi: " + taxi.Text);
                //writeToFile(team.Text, "Tele Lower: " + teleLower.Text);
                if ((teleLower.Text).ToString().Length == 1)
                {
                    writeToFile(team.Text, "Tele Lower: 0" + teleLower.Text);
                }
                else
                {
                    writeToFile(team.Text, "Tele Lower: " + teleLower.Text);
                }
                //writeToFile(team.Text, "Tele Upper: " + teleUpper.Text);
                if ((teleUpper.Text).ToString().Length == 1)
                {
                    writeToFile(team.Text, "Tele Upper: 0" + teleUpper.Text);
                }
                else
                {
                    writeToFile(team.Text, "Tele Upper: " + teleUpper.Text);
                }
                int totalAuto = Int32.Parse(autoUpper.Text) + Int32.Parse(autoLower.Text);

                if ((totalAuto).ToString().Length == 1)
                {
                    writeToFile(team.Text, "Auto Cargo Total: 0" + totalAuto);
                }
                else
                {
                    writeToFile(team.Text, "Auto Cargo Total: " + totalAuto);
                }





                //writeToFile(team.Text, "Auto Upper: " + autoUpper.Text);
                if ((autoUpper.Text).ToString().Length == 1)
                {
                    writeToFile(team.Text, "Auto Upper: 0" + autoUpper.Text);
                }
                else
                {
                    writeToFile(team.Text, "Auto Upper: " + autoUpper.Text);
                }
                //writeToFile(team.Text, "Auto Lower: " + autoLower.Text);
                if ((autoLower.Text).ToString().Length == 1)
                {
                    writeToFile(team.Text, "Auto Lower: 0" + autoLower.Text);
                }
                else
                {
                    writeToFile(team.Text, "Auto Lower: " + autoLower.Text);
                }


                //writeToFile(team.Text, "Auto Missed: " + autoMissed.Text);
                if ((autoMissed.Text).ToString().Length == 1)
                {
                    writeToFile(team.Text, "Auto Missed: 0" + autoMissed.Text);
                }
                else
                {
                    writeToFile(team.Text, "Auto Missed: " + autoMissed.Text);
                }

                writeToFile(team.Text, "Tele Missed: " + teleMissed.Text);
                if ((teleMissed.Text).ToString().Length == 1)
                {
                    writeToFile(team.Text, "Tele Missed: 0" + teleMissed.Text);
                }
                else
                {
                    writeToFile(team.Text, "Tele Missed: " + teleMissed.Text);
                }


                //writeToFile(team.Text, "Start: " + climbStart.Text);
                if ((climbStart.Text).ToString().Length == 1)
                {
                    writeToFile(team.Text, "Start: 0" + climbStart.Text);
                }
                else
                {
                    writeToFile(team.Text, "Start: " + climbStart.Text);
                }
                //writeToFile(team.Text, "End: " + climbEnd.Text);
                if ((climbEnd.Text).ToString().Length == 1)
                {
                    writeToFile(team.Text, "End: 0" + climbEnd.Text);
                }
                else
                {
                    writeToFile(team.Text, "End: " + climbEnd.Text);
                }

                if ((climbTime).ToString().Length == 1)
                {
                    writeToFile(team.Text, "Total Climb Time: 0" + climbTime);
                }
                else
                {
                    writeToFile(team.Text, "Total Climb Time: " + climbTime);
                }
                writeToFile(team.Text, "Climb Type: " + climbType.Text);
                writeToFile(team.Text, "Defense: " + "0" + defense.Text);
                writeToFile(team.Text, "Position: " + position.Text);
                writeToFile(team.Text, "Entry: " + climbEnter.Text);

                teleCargo = (Int32.Parse(teleUpper.Text) * 2) + (Int32.Parse(teleLower.Text) * 1);
                autoCargo = (Int32.Parse(autoUpper.Text) * 4) + (Int32.Parse(autoLower.Text) * 2);
                //Calculated match data


                if ((teleCargo).ToString().Length == 1)
                {
                    writeToFile(team.Text, "Tele Cargo Score: 0" + teleCargo);
                }
                else
                {
                    writeToFile(team.Text, "Tele Cargo Score: " + teleCargo);
                }
                if ((autoCargo).ToString().Length == 1)
                {
                    writeToFile(team.Text, "Auto Cargo Score: 0" + autoCargo);
                }
                else
                {
                    writeToFile(team.Text, "Auto Cargo Score: " + autoCargo);
                }


                writeToFile(team.Text, "Auto Accuracy: " + autoAccuracy);
                writeToFile(team.Text, "Tele Accuracy: " + teleAccuracy);

                writeToFile(team.Text, "------------------------");
                statusText.Text = "Match Data Saved!";
                Thread.Sleep(2000);
                statusText.Text = "Enter Data";
            }
            catch
            {
                statusText.Text = "Check again, didn't load...";
            }

        }

        public string GetLine(string fileName, int line)
        {
            string current = Directory.GetCurrentDirectory() + "//";
            using (var sr = new StreamReader(fileName))
            {
                for (int i = 1; i < line; i++)
                    sr.ReadLine();
                return sr.ReadLine();
            }
        }

        public void WriteLine(string fileName, int line)
        {
            string current = Directory.GetCurrentDirectory() + "\\";
            using (var sr = new StreamWriter(fileName))
            {
                for (int i = 1; i < line; i++)
                    sr.WriteLine();
            }
        }

        public void lineChanger(string newText, string fileName, int line_to_edit)
        {
            string[] arrLine = File.ReadAllLines(fileName);
            arrLine[line_to_edit - 1] = newText;
            File.WriteAllLines(fileName, arrLine);

        }
        public void writeToFile(string team, string text)
        {
            string current = Directory.GetCurrentDirectory() + "/";
            int i = 1;
            bool emptyLine = false;
            while (emptyLine == false)
            {
                //Thread.Sleep(10);
                if (GetLine(current + team + ".txt", i) != GetLine(current + "blank.txt", 1))
                {
                    //Console.WriteLine(GetLine(team+".txt", i));
                }
                else
                {
                    //Console.WriteLine("Wrote to line "+ i);
                    lineChanger(text, current + team + ".txt", i);
                    emptyLine = true;
                }
                i++;
            }
        }

        private void team_TextChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Data data = new Data();
            data.ShowDialog();
        }
    }
}
