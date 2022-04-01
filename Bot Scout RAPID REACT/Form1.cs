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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string current = Directory.GetCurrentDirectory() + "\\";
            int autoCargo;

            int teleCargo;

            int climbTime;

            string autoAccuracy;
            string teleAccuracy;
            int team1;
            string prompt;

            Console.WriteLine("Enter Scouting Data (Type q or quit to go back to menu)");
            Console.Write("Team #: ");
            Console.ForegroundColor = ConsoleColor.Cyan;
            team.Text = Console.ReadLine();
            if (!int.TryParse(team.Text, out team1))
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("This is not a team. Going back to menu. Press enter to continue");
                Console.ForegroundColor = ConsoleColor.White;
                Console.ReadLine();
                menu.menu();
            }
            Console.ForegroundColor = ConsoleColor.White;
            if (!File.Exists(team.Text + ".txt"))
            {
                addTeam(team.Text);
                addLines(team.Text);
                
            }


            climbTime = (Int32.Parse(climbStart) - Int32.Parse(climbEnd));

            double autoUpperInt = Double.Parse(autoUpper);
            double autoLowerInt = Double.Parse(autoLower);
            double autoMissedInt = Double.Parse(autoMissed);
            autoAccuracy = (autoUpperInt + autoLowerInt) / (autoUpperInt + autoLowerInt + autoMissedInt) * 100 + "%";

            double teleUpperInt = Double.Parse(teleUpper.Text);
            double teleLowerInt = Double.Parse(teleLower);
            double teleMissedInt = Double.Parse(teleMissed);
            teleAccuracy = (teleUpperInt + teleLowerInt) / (teleUpperInt + teleLowerInt + teleMissedInt) * 100 + "%";

            //User match data
            writeToFile(team.Text, "Match Number: " + match.Text);
            writeToFile(team.Text, "Taxi: " + taxi);
            writeToFile(team.Text, "Tele Lower: " + teleLower);
            writeToFile(team.Text, "Tele Upper: " + teleUpper);
            int totalAuto = Int32.Parse(autoUpper) + Int32.Parse(autoLower);

            if ((totalAuto).ToString().Length == 1)
            {
                writeToFile(team.Text.Text, "Auto Cargo Total: 0" + totalAuto);
            }
            else
            {
                writeToFile(team.Text.Text, "Auto Cargo Total: " + totalAuto);
            }
            writeToFile(team.Text, "Auto Upper: " + autoUpper);
            writeToFile(team.Text, "Auto Lower: " + autoLower);
            writeToFile(team.Text, "Auto Missed: " + autoMissed);

            writeToFile(team.Text, "Tele Missed: " + teleMissed);


            writeToFile(team.Text, "Start: " + climbStart);
            writeToFile(team.Text, "End: " + climbEnd);
            if ((climbTime).ToString().Length == 1)
            {
                writeToFile(team.Text.Text, "Total Climb Time: 0" + climbTime);
            }
            else
            {
                writeToFile(team.Text.Text, "Total Climb Time: " + climbTime);
            }
            writeToFile(team.Text, "Climb Type: " + climbType);
            writeToFile(team.Text, "Defense: " + "0" + defense);
            writeToFile(team.Text, "Position: " + position);
            writeToFile(team.Text, "Entry: " + climbEnter);

            teleCargo = (Int32.Parse(teleUpper) * 2) + (Int32.Parse(teleLower) * 1);
            autoCargo = (Int32.Parse(autoUpper) * 4) + (Int32.Parse(autoLower) * 2);
            //Calculated match data


            if ((teleCargo).ToString().Length == 1)
            {
                writeToFile(team.Text.Text, "Tele Cargo Score: 0" + teleCargo);
            }
            else
            {
                writeToFile(team.Text.Text, "Tele Cargo Score: " + teleCargo);
            }
            if ((autoCargo).ToString().Length == 1)
            {
                writeToFile(team.Text.Text, "Auto Cargo Score: 0" + autoCargo);
            }
            else
            {
                writeToFile(team.Text.Text, "Auto Cargo Score: " + autoCargo);
            }


            writeToFile(team.Text.Text, "Auto Accuracy: " + autoAccuracy);
            writeToFile(team.Text.Text, "Tele Accuracy: " + teleAccuracy);

            writeToFile(team.Text.Text, "------------------------");
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("***********************");
            Console.ForegroundColor = ConsoleColor.Green;
            //Console.WriteLine(autoAccuracy);
            Console.WriteLine("Success!");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("***********************");

            Thread.Sleep(2500);
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.White;
            menu.menu();
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


    }
}
