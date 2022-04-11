using System;
using System.IO;
using System.Windows.Forms;
using System.Collections.Generic;


//Days to work: Monday, Tuesday Wednesday

//TODO: Store data in different folders
//TODO: Best scores, add tele low, high, and total, climb time, defense, and overall score
//COMPLETE: Average auto Low, high, and total, Tele low and upper, auto accuracy, total score, climb time, and climb type
//TODO: Team Trends (looks at most recent match score, and compares it with the average total score
//TODO: Drive type for data entry and drive sheet

//TODO: Delete Refresh Button
//TODO: Alliance selection tab?
//TODO: 4/10 Make look nice
//TODO: 4/11 Test program when everything above is finished

//COMPLETE: Recent Match Button
//COMPLETE: Data Entry
//COMPLETE: See match data
//COMPLETE: Average tab, driver sheet tab, best scores tab, trends tab
namespace Bot_Scout_RAPID_REACT
{
    public partial class Form1 : Form
    {
        public Form1()
        {

            int pX = 500;
            int pY = 170;
            InitializeComponent();
            bestTeamsTableLayout.Visible = false;
            averageTeamTable.Visible = false;
            driverSheetTable.Visible = false;
            teamTrendLayout.Visible = false;
            //Sets the location of the table
            bestTeamsTableLayout.Location = new System.Drawing.Point(pX, pY);
            averageTeamTable.Location = new System.Drawing.Point(pX, pY);
            driverSheetTable.Location = new System.Drawing.Point(pX, pY);
            teamTrendLayout.Location = new System.Drawing.Point(pX, pY);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        public void addTeam(string team)
        {
            File.Create(comp.Text+"\\"+team + ".txt").Close();

        }
        public void addLines(string team)
        {
            File.AppendAllText(comp.Text + "\\" + team + ".txt", "Shutdowns: 0" + Environment.NewLine);
            for (int i = 0; i < 5000; i++)
            {
                File.AppendAllText(team + ".txt", "0" + Environment.NewLine);
            }
        }
        private void button3_Click_1(object sender, EventArgs e)
        {
            string current = Directory.GetCurrentDirectory() + "\\" ;
            
            try
            {
                if (!shutdownBot.Checked)
                {
                    statusText.Text = "Loading...";

                    int autoCargo;
                    string climbType = "";
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
                    if((autoUpperInt + autoLowerInt) / (autoUpperInt + autoLowerInt + autoMissedInt) * 100 + "" == "NaN")
                    {
                        autoAccuracy = "00";
                    }
                    else
                    {
                        autoAccuracy = (autoUpperInt + autoLowerInt) / (autoUpperInt + autoLowerInt + autoMissedInt) * 100 + "";
                    }
                    

                    double teleUpperInt = Double.Parse(teleUpper.Text);
                    double teleLowerInt = Double.Parse(teleLower.Text);
                    double teleMissedInt = Double.Parse(teleMissed.Text);
                    if ((teleUpperInt + teleLowerInt) / (teleUpperInt + teleLowerInt + teleMissedInt) * 100 + "" == "NaN")
                    {

                        teleAccuracy = "00";
                    }
                    else
                    {
                        teleAccuracy = (teleUpperInt + teleLowerInt) / (teleUpperInt + teleLowerInt + teleMissedInt) * 100 + "";
                    }
                    
                    //User match data
                    writeToFile(comp.Text+"\\"+team.Text, "Match Number: " + match.Text);
                    if (taxiYes.Checked)
                    {
                        writeToFile(comp.Text+"\\"+team.Text, "Match Number: y");
                    }
                    else if (taxiNo.Checked)
                    {
                        writeToFile(comp.Text+"\\"+team.Text, "Match Number: n");
                    }
                    //writeToFile(team.Text, "Taxi: " + taxi.Text);
                    //writeToFile(team.Text, "Tele Lower: " + teleLower.Text);
                    if ((teleLower.Text).ToString().Length == 1)
                    {
                        writeToFile(comp.Text+"\\"+team.Text, "Tele Lower: 0" + teleLower.Text);
                    }
                    else
                    {
                        writeToFile(comp.Text+"\\"+team.Text, "Tele Lower: " + teleLower.Text);
                    }
                    //writeToFile(team.Text, "Tele Upper: " + teleUpper.Text);
                    if ((teleUpper.Text).ToString().Length == 1)
                    {
                        writeToFile(comp.Text+"\\"+team.Text, "Tele Upper: 0" + teleUpper.Text);
                    }
                    else
                    {
                        writeToFile(comp.Text+"\\"+team.Text, "Tele Upper: " + teleUpper.Text);
                    }
                    int totalAuto = Int32.Parse(autoUpper.Text) + Int32.Parse(autoLower.Text);

                    if ((totalAuto).ToString().Length == 1)
                    {
                        writeToFile(comp.Text+"\\"+team.Text, "Auto Cargo Total: 0" + totalAuto);
                    }
                    else
                    {
                        writeToFile(comp.Text+"\\"+team.Text, "Auto Cargo Total: " + totalAuto);
                    }





                    //writeToFile(team.Text, "Auto Upper: " + autoUpper.Text);
                    if ((autoUpper.Text).ToString().Length == 1)
                    {
                        writeToFile(comp.Text+"\\"+team.Text, "Auto Upper: 0" + autoUpper.Text);
                    }
                    else
                    {
                        writeToFile(comp.Text+"\\"+team.Text, "Auto Upper: " + autoUpper.Text);
                    }
                    //writeToFile(team.Text, "Auto Lower: " + autoLower.Text);
                    if ((autoLower.Text).ToString().Length == 1)
                    {
                        writeToFile(comp.Text+"\\"+team.Text, "Auto Lower: 0" + autoLower.Text);
                    }
                    else
                    {
                        writeToFile(comp.Text+"\\"+team.Text, "Auto Lower: " + autoLower.Text);
                    }


                    //writeToFile(team.Text, "Auto Missed: " + autoMissed.Text);
                    if ((autoMissed.Text).ToString().Length == 1)
                    {
                        writeToFile(comp.Text+"\\"+team.Text, "Auto Missed: 0" + autoMissed.Text);
                    }
                    else
                    {
                        writeToFile(comp.Text+"\\"+team.Text, "Auto Missed: " + autoMissed.Text);
                    }

                    writeToFile(comp.Text+"\\"+team.Text, "Tele Missed: " + teleMissed.Text);
                    if ((teleMissed.Text).ToString().Length == 1)
                    {
                        writeToFile(comp.Text+"\\"+team.Text, "Tele Missed: 0" + teleMissed.Text);
                    }
                    else
                    {
                        writeToFile(comp.Text+"\\"+team.Text, "Tele Missed: " + teleMissed.Text);
                    }


                    //writeToFile(team.Text, "Start: " + climbStart.Text);
                    if ((climbStart.Text).ToString().Length == 1)
                    {
                        writeToFile(comp.Text+"\\"+team.Text, "Start: 0" + climbStart.Text);
                    }
                    else
                    {
                        writeToFile(comp.Text+"\\"+team.Text, "Start: " + climbStart.Text);
                    }
                    //writeToFile(team.Text, "End: " + climbEnd.Text);
                    if ((climbEnd.Text).ToString().Length == 1)
                    {
                        writeToFile(comp.Text+"\\"+team.Text, "End: 0" + climbEnd.Text);
                    }
                    else
                    {
                        writeToFile(comp.Text+"\\"+team.Text, "End: " + climbEnd.Text);
                    }

                    if ((climbTime).ToString().Length == 1)
                    {
                        writeToFile(comp.Text+"\\"+team.Text, "Total Climb Time: 0" + climbTime);
                    }
                    else
                    {
                        writeToFile(comp.Text+"\\"+team.Text, "Total Climb Time: " + climbTime);
                    }
                    //writeToFile(team.Text, "Climb Type: " + climbType.Text);
                    if (lowClimb.Checked)
                    {
                        writeToFile(comp.Text+"\\"+team.Text, "Climb Type: l");
                        climbType = "l";
                    }
                    else if (midClimb.Checked)
                    {
                        writeToFile(comp.Text+"\\"+team.Text, "Climb Type: m");
                        climbType = "m";
                    }
                    else if (highClimb.Checked)
                    {
                        writeToFile(comp.Text+"\\"+team.Text, "Climb Type: h");
                        climbType = "h";
                    }
                    else if (travClimb.Checked)
                    {
                        writeToFile(comp.Text+"\\"+team.Text, "Climb Type: t");
                        climbType = "t";
                    }
                    else if (noClimb.Checked)
                    {
                        writeToFile(comp.Text+"\\"+team.Text, "Climb Type: n");
                        climbType = "n";
                    }
                    writeToFile(comp.Text+"\\"+team.Text, "Defense: " + "0" + defense.Text);
                    //writeToFile(team.Text, "Position: " + position.Text);
                    if (posHub.Checked)
                    {
                        writeToFile(comp.Text+"\\"+team.Text, "Position: h");
                    }
                    else if (posLaunch.Checked)
                    {
                        writeToFile(comp.Text+"\\"+team.Text, "Entry: l");
                    }
                    else if (posTar.Checked)
                    {
                        writeToFile(comp.Text+"\\"+team.Text, "Entry: t");
                    }
                    else if (posOther.Checked)
                    {
                        writeToFile(comp.Text+"\\"+team.Text, "Entry: o");
                    }
                    //writeToFile(team.Text, "Entry: " + climbEnter.Text);
                    if (enterFront.Checked)
                    {
                        writeToFile(comp.Text+"\\"+team.Text, "Entry: f");
                    }
                    else if (enterSide.Checked)
                    {
                        writeToFile(comp.Text+"\\"+team.Text, "Entry: s");
                    }

                    teleCargo = (Int32.Parse(teleUpper.Text) * 2) + (Int32.Parse(teleLower.Text) * 1);
                    autoCargo = (Int32.Parse(autoUpper.Text) * 4) + (Int32.Parse(autoLower.Text) * 2);
                    //Calculated match data


                    if ((teleCargo).ToString().Length == 1)
                    {
                        writeToFile(comp.Text+"\\"+team.Text, "Tele Cargo Score: 0" + teleCargo);
                    }
                    else
                    {
                        writeToFile(comp.Text+"\\"+team.Text, "Tele Cargo Score: " + teleCargo);
                    }
                    if ((autoCargo).ToString().Length == 1)
                    {
                        writeToFile(comp.Text+"\\"+team.Text, "Auto Cargo Score: 0" + autoCargo);
                    }
                    else
                    {
                        writeToFile(comp.Text+"\\"+team.Text, "Auto Cargo Score: " + autoCargo);
                    }

                    if ((autoAccuracy).ToString().Length == 1)
                    {
                        writeToFile(comp.Text+"\\"+team.Text, "Auto Accuracy: 0" + autoAccuracy + "%");
                    }
                    else
                    {
                        writeToFile(comp.Text+"\\"+team.Text, "Auto Accuracy: " + autoAccuracy + "%");
                    }

                    if ((teleAccuracy).ToString().Length == 1)
                    {
                        writeToFile(comp.Text+"\\"+team.Text, "Tele Accuracy: 0" + teleAccuracy + "%");
                    }
                    else
                    {
                        writeToFile(comp.Text+"\\"+team.Text, "Tele Accuracy: " + teleAccuracy + "%");
                    }



                    
                    int climbPoints;
                    if (climbType == "l")
                    {
                        climbPoints = 4;
                    }
                    else if (climbType == "m")
                    {
                        climbPoints = 6;
                    }
                    else if (climbType == "h")
                    {
                        climbPoints = 10;
                    }
                    else if (climbType == "t")
                    {
                        climbPoints = 15;
                    }
                    else
                    {
                        climbPoints = 0;
                    }
                    int taxiPoints = 0;
                    if (taxiYes.Checked)
                    {
                        taxiPoints = 2;
                    }

                    int totalPoints = (teleCargo + autoCargo) + climbPoints+taxiPoints;
                    writeToFile(comp.Text+"\\"+team.Text, "Total Score: " + totalPoints);



                    writeToFile(comp.Text+"\\"+team.Text, "------------------------");
                    statusText.Text = "Match Data Saved!";
                }
                else
                {
                    string tempShut = GetLine(comp.Text+"\\"+team.Text + ".txt", 1)[11] + "";
                    int shutdowns = Int32.Parse(tempShut) + 1;
                    lineChanger("Shutdowns: " + shutdowns, current + comp.Text+"\\"+team.Text + ".txt", 1);
                }
                //Thread.Sleep(2000);
                team.Text = "";
                match.Text = "";
                teleLower.Text = "";
                teleUpper.Text = "";
                teleMissed.Text = "";
                autoLower.Text = "";
                autoUpper.Text = "";
                autoMissed.Text = "";
                climbEnd.Text = "";
                climbStart.Text = "";
                //climbType.Text = "";
                //climbEnter.Text = "";
                defense.Text = "";
                //position.Text = "";
                //taxi.Text = "";

            }
            catch
            {
                statusText.Text = "Check again, didn't load...";
            }

        }

        public string GetLine(string fileName, int line)
        {
            string current = Directory.GetCurrentDirectory() + "\\";
            current = current + comp.Text + "\\";
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
            current = current + comp.Text + "\\";
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
            string current = Directory.GetCurrentDirectory() + "\\";
            current = current + comp.Text + "\\";
            int i = 1;
            bool emptyLine = false;
            while (emptyLine == false)
            {
                //Thread.Sleep(10);
                if (GetLine(current + team + ".txt", i) != GetLine(current + "blank.txt", 1))
                {

                }
                else
                {

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
            //Data data = new Data();
            //data.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //BestTeams best = new BestTeams();
            //best.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            //Average ave = new Average();
            //ave.ShowDialog();
        }

        private void bestTeamsMenu_Click(object sender, EventArgs e)
        {
            bestTeamsTableLayout.Visible = true;
            averageTeamTable.Visible = false;
            driverSheetTable.Visible = false;
            teamTrendLayout.Visible = false;
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void driverSheetMenu_Click(object sender, EventArgs e)
        {
            bestTeamsTableLayout.Visible = false;
            driverSheetTable.Visible = true;
            averageTeamTable.Visible = false;
            teamTrendLayout.Visible = false;
        }

        private void averageScoresMenu_Click(object sender, EventArgs e)
        {
            bestTeamsTableLayout.Visible = false;
            averageTeamTable.Visible = true;
            driverSheetTable.Visible = false;
            teamTrendLayout.Visible = false;
            averageCargo();
        }

        private void autoLowerMenu_Click(object sender, EventArgs e)
        {
            //BestTeams bestTeams = new BestTeams();
            bestTeamsStats("Auto Lower", 12, 13, 0, 0, false, "Lower Auto");
        }
        public void bestScore(string team)
        {
            bool matchEnd = false;
            Form1 match = new Form1();
            int autoTotal1 = 0;
            int autoLow1 = 0;
            int teleHigh1 = 0;
            int teleLow1 = 0;
            int time1 = 500;
            int totalScore = 0;

            int defense1 = 0;
            int tempNum = 0;

            string climbType1 = "n";
            int i = 1;

            while (match.GetLine(team + ".txt", i) != match.GetLine("blank.txt", 1))
            {

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

                if (match.GetLine(team + ".txt", i).Contains("Total Score"))
                {
                    string num1 = match.GetLine(team + ".txt", i)[13].ToString();
                    string num2 = match.GetLine(team + ".txt", i)[14].ToString();
                    tempNum = Int32.Parse(num1 + num2);
                    if (tempNum > totalScore)
                    {
                        totalScore = tempNum;
                    }
                }
            }

            i = 0;
            while (match.GetLine(team + ".txt", i) != match.GetLine("blank.txt", 1))
            {

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
            climbType2.Text = "" + climbType1;
            defense2.Text = "" + defense1;
            totalScore2.Text = "" + totalScore;
            loadText.Text = "Data Loaded!";


        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                string team1 = comp.Text+"\\"+team.Text;
                Form1 match = new Form1();
                int i = Int32.Parse(lineMatch.Text);
                if (match.GetLine(team1 + ".txt", i + 1).Contains("Match Number"))
                {
                    try
                    {
                        driveData(1);
                    }
                    catch (Exception l)
                    {

                    }
                }
            }
            catch (Exception l)
            {
                loadText.Text = "Can't find team";
            }
        }


        public void driveData(int matchInc)
        {
            bool matchEnd = false;
            Form1 match = new Form1();
            int i = Int32.Parse(lineMatch.Text);
            string team1 = comp.Text+"\\"+team.Text;

            while (matchEnd == false)
            {
                i += matchInc;


                if (match.GetLine(team1 + ".txt", i).Contains("Match Number"))
                {
                    matchText.Text = match.GetLine(team1 + ".txt", i);

                }
                if (match.GetLine(team1 + ".txt", i).Contains("Tele Lower"))
                {
                    string num1 = match.GetLine(team1 + ".txt", i)[12].ToString();
                    string num2 = match.GetLine(team1 + ".txt", i)[13].ToString();
                    teleLow.Text = num1 + num2;

                }

                if (match.GetLine(team1 + ".txt", i).Contains("Tele Upper"))
                {
                    string num1 = match.GetLine(team1 + ".txt", i)[12].ToString();
                    string num2 = match.GetLine(team1 + ".txt", i)[13].ToString();
                    teleHigh.Text = num1 + num2;

                }

                if (match.GetLine(team1 + ".txt", i).Contains("Auto Cargo Total"))
                {
                    string num1 = match.GetLine(team1 + ".txt", i)[18].ToString();
                    string num2 = match.GetLine(team1 + ".txt", i)[19].ToString();
                    autoTotal.Text = num1 + num2;
                }

                if (match.GetLine(team1 + ".txt", i).Contains("Climb Time"))
                {
                    string num1 = match.GetLine(team1 + ".txt", i)[18].ToString();
                    string num2 = match.GetLine(team1 + ".txt", i)[19].ToString();
                    time.Text = num1 + num2;
                }

                if (match.GetLine(team1 + ".txt", i).Contains("Climb Type"))
                {
                    string climb = match.GetLine(team1 + ".txt", i)[12].ToString();
                    climbType2.Text = climb;
                }

                if (match.GetLine(team1 + ".txt", i).Contains("Defense"))
                {
                    string num1 = match.GetLine(team1 + ".txt", i)[10].ToString();
                    defense2.Text = num1;
                }
                if (match.GetLine(team1 + ".txt", i).Contains("-----"))
                {
                    matchEnd = true;
                    lineMatch.Text = "" + i;
                }

            }

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

                    while (GetLine(i + ".txt", j) != GetLine("blank.txt", 1))
                    {

                        j++;
                        if (GetLine(i + ".txt", j).Contains(contains))
                        {
                            string num1 = GetLine(i + ".txt", j)[numb1].ToString();
                            string num2 = GetLine(i + ".txt", j)[numb2].ToString();
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
                    while (GetLine(i + ".txt", j) != GetLine("blank.txt", 1))
                    {

                        j++;
                        if (GetLine(i + ".txt", j).Contains(contains) && i + ".txt" != teleHighTeam1 + ".txt")
                        {
                            string num1 = GetLine(i + ".txt", j)[numb1].ToString();
                            string num2 = GetLine(i + ".txt", j)[numb2].ToString();
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
                    while (GetLine(i + ".txt", j) != GetLine("blank.txt", 1))
                    {

                        j++;
                        if (GetLine(i + ".txt", j).Contains(contains) && i + ".txt" != teleHighTeam1 + ".txt" && i + ".txt" != teleHighTeam2 + ".txt")
                        {
                            string num1 = GetLine(i + ".txt", j)[numb1].ToString();
                            string num2 = GetLine(i + ".txt", j)[numb2].ToString();
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
                    while (GetLine(i + ".txt", j) != GetLine("blank.txt", 1))
                    {
                        //Console.WriteLine(GetLine(team+".txt",i));
                        j++;
                        if (GetLine(i + ".txt", j).Contains(contains) && i + ".txt" != teleHighTeam1 + ".txt" && i + ".txt" != teleHighTeam2 + ".txt" && i + ".txt" != teleHighTeam3 + ".txt")
                        {
                            string num1 = GetLine(i + ".txt", j)[numb1].ToString();
                            string num2 = GetLine(i + ".txt", j)[numb2].ToString();
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
                    while (GetLine(i + ".txt", j) != GetLine("blank.txt", 1))
                    {
                        //Console.WriteLine(GetLine(team+".txt",i));
                        j++;
                        if (GetLine(i + ".txt", j).Contains(contains) && i + ".txt" != teleHighTeam1 + ".txt" && i + ".txt" != teleHighTeam2 + ".txt" && i + ".txt" != teleHighTeam3 + ".txt" && i + ".txt" != teleHighTeam4 + ".txt")
                        {
                            string num1 = GetLine(i + ".txt", j)[numb1].ToString();
                            string num2 = GetLine(i + ".txt", j)[numb2].ToString();
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
                    while (GetLine(i + ".txt", j) != GetLine("blank.txt", 1))
                    {
                        //Console.WriteLine(GetLine(team+".txt",i));
                        j++;
                        if (GetLine(i + ".txt", j).Contains(contains) && i + ".txt" != teleHighTeam1 + ".txt" && i + ".txt" != teleHighTeam2 + ".txt" && i + ".txt" != teleHighTeam3 + ".txt" && i + ".txt" != teleHighTeam4 + ".txt" && i + ".txt" != teleHighTeam5 + ".txt")
                        {
                            string num1 = GetLine(i + ".txt", j)[numb1].ToString();
                            string num2 = GetLine(i + ".txt", j)[numb2].ToString();
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
                    while (GetLine(i + ".txt", j) != GetLine("blank.txt", 1))
                    {
                        //Console.WriteLine(GetLine(team+".txt",i));
                        j++;
                        if (GetLine(i + ".txt", j).Contains(contains) && i + ".txt" != teleHighTeam1 + ".txt" && i + ".txt" != teleHighTeam2 + ".txt" && i + ".txt" != teleHighTeam3 + ".txt" && i + ".txt" != teleHighTeam4 + ".txt" && i + ".txt" != teleHighTeam5 + ".txt" && i + ".txt" != teleHighTeam6 + ".txt")
                        {
                            string num1 = GetLine(i + ".txt", j)[numb1].ToString();
                            string num2 = GetLine(i + ".txt", j)[numb2].ToString();
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
                    while (GetLine(i + ".txt", j) != GetLine("blank.txt", 1))
                    {
                        //Console.WriteLine(GetLine(team+".txt",i));
                        j++;
                        if (GetLine(i + ".txt", j).Contains(contains) && i + ".txt" != teleHighTeam1 + ".txt" && i + ".txt" != teleHighTeam2 + ".txt" && i + ".txt" != teleHighTeam3 + ".txt" && i + ".txt" != teleHighTeam4 + ".txt" && i + ".txt" != teleHighTeam5 + ".txt" && i + ".txt" != teleHighTeam6 + ".txt" && i + ".txt" != teleHighTeam7 + ".txt")
                        {
                            string num1 = GetLine(i + ".txt", j)[numb1].ToString();
                            string num2 = GetLine(i + ".txt", j)[numb2].ToString();
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
                    while (GetLine(i + ".txt", j) != GetLine("blank.txt", 1))
                    {
                        //Console.WriteLine(GetLine(team+".txt",i));
                        j++;
                        if (GetLine(i + ".txt", j).Contains(contains) && i + ".txt" != teleHighTeam1 + ".txt" && i + ".txt" != teleHighTeam2 + ".txt" && i + ".txt" != teleHighTeam3 + ".txt" && i + ".txt" != teleHighTeam4 + ".txt" && i + ".txt" != teleHighTeam5 + ".txt" && i + ".txt" != teleHighTeam6 + ".txt" && i + ".txt" != teleHighTeam7 + ".txt" && i + ".txt" != teleHighTeam8 + ".txt")
                        {
                            string num1 = GetLine(i + ".txt", j)[numb1].ToString();
                            string num2 = GetLine(i + ".txt", j)[numb2].ToString();
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
                    while (GetLine(i + ".txt", j) != GetLine("blank.txt", 1))
                    {
                        //Console.WriteLine(GetLine(team+".txt",i));
                        j++;
                        if (GetLine(i + ".txt", j).Contains(contains) && i + ".txt" != teleHighTeam1 + ".txt" && i + ".txt" != teleHighTeam2 + ".txt" && i + ".txt" != teleHighTeam3 + ".txt" && i + ".txt" != teleHighTeam4 + ".txt" && i + ".txt" != teleHighTeam5 + ".txt" && i + ".txt" != teleHighTeam6 + ".txt" && i + ".txt" != teleHighTeam7 + ".txt" && i + ".txt" != teleHighTeam8 + ".txt" && i + ".txt" != teleHighTeam9 + ".txt")
                        {
                            string num1 = GetLine(i + ".txt", j)[numb1].ToString();
                            string num2 = GetLine(i + ".txt", j)[numb2].ToString();
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
                    while (GetLine(i + ".txt", j) != GetLine("blank.txt", 1))
                    {
                        //Console.WriteLine(GetLine(team+".txt",i));
                        j++;
                        if (GetLine(i + ".txt", j).Contains(contains) && i + ".txt" != teleHighTeam1 + ".txt" && i + ".txt" != teleHighTeam2 + ".txt" && i + ".txt" != teleHighTeam3 + ".txt" && i + ".txt" != teleHighTeam4 + ".txt" && i + ".txt" != teleHighTeam5 + ".txt" && i + ".txt" != teleHighTeam6 + ".txt" && i + ".txt" != teleHighTeam7 + ".txt" && i + ".txt" != teleHighTeam8 + ".txt" && i + ".txt" != teleHighTeam9 + ".txt" && i + ".txt" != teleHighTeam10 + ".txt")
                        {
                            string num1 = GetLine(i + ".txt", j)[numb1].ToString();
                            string num2 = GetLine(i + ".txt", j)[numb2].ToString();
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
                    while (GetLine(i + ".txt", j) != GetLine("blank.txt", 1))
                    {
                        //Console.WriteLine(GetLine(team+".txt",i));
                        j++;
                        if (GetLine(i + ".txt", j).Contains(contains) && i + ".txt" != teleHighTeam1 + ".txt" && i + ".txt" != teleHighTeam2 + ".txt" && i + ".txt" != teleHighTeam3 + ".txt" && i + ".txt" != teleHighTeam4 + ".txt" && i + ".txt" != teleHighTeam5 + ".txt" && i + ".txt" != teleHighTeam6 + ".txt" && i + ".txt" != teleHighTeam7 + ".txt" && i + ".txt" != teleHighTeam8 + ".txt" && i + ".txt" != teleHighTeam9 + ".txt" && i + ".txt" != teleHighTeam10 + ".txt" && i + ".txt" != teleHighTeam11 + ".txt")
                        {
                            string num1 = GetLine(i + ".txt", j)[numb1].ToString();
                            string num2 = GetLine(i + ".txt", j)[numb2].ToString();
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
                    while (GetLine(i + ".txt", j) != GetLine("blank.txt", 1))
                    {
                        //Console.WriteLine(GetLine(team+".txt",i));
                        j++;
                        if (GetLine(i + ".txt", j).Contains(contains) && i + ".txt" != teleHighTeam1 + ".txt" && i + ".txt" != teleHighTeam2 + ".txt" && i + ".txt" != teleHighTeam3 + ".txt" && i + ".txt" != teleHighTeam4 + ".txt" && i + ".txt" != teleHighTeam5 + ".txt" && i + ".txt" != teleHighTeam6 + ".txt" && i + ".txt" != teleHighTeam7 + ".txt" && i + ".txt" != teleHighTeam8 + ".txt" && i + ".txt" != teleHighTeam9 + ".txt" && i + ".txt" != teleHighTeam10 + ".txt" && i + ".txt" != teleHighTeam11 + ".txt" && i + ".txt" != teleHighTeam12 + ".txt")
                        {
                            string num1 = GetLine(i + ".txt", j)[numb1].ToString();
                            string num2 = GetLine(i + ".txt", j)[numb2].ToString();
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
                    while (GetLine(i + ".txt", j) != GetLine("blank.txt", 1))
                    {
                        //Console.WriteLine(GetLine(team+".txt",i));
                        j++;
                        if (GetLine(i + ".txt", j).Contains(contains) && i + ".txt" != teleHighTeam1 + ".txt" && i + ".txt" != teleHighTeam2 + ".txt" && i + ".txt" != teleHighTeam3 + ".txt" && i + ".txt" != teleHighTeam4 + ".txt" && i + ".txt" != teleHighTeam5 + ".txt" && i + ".txt" != teleHighTeam6 + ".txt" && i + ".txt" != teleHighTeam7 + ".txt" && i + ".txt" != teleHighTeam8 + ".txt" && i + ".txt" != teleHighTeam9 + ".txt" && i + ".txt" != teleHighTeam10 + ".txt" && i + ".txt" != teleHighTeam11 + ".txt" && i + ".txt" != teleHighTeam12 + ".txt" && i + ".txt" != teleHighTeam13 + ".txt")
                        {
                            string num1 = GetLine(i + ".txt", j)[numb1].ToString();
                            string num2 = GetLine(i + ".txt", j)[numb2].ToString();
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
                    while (GetLine(i + ".txt", j) != GetLine("blank.txt", 1))
                    {
                        //Console.WriteLine(GetLine(team+".txt",i));
                        j++;
                        if (GetLine(i + ".txt", j).Contains(contains) && i + ".txt" != teleHighTeam1 + ".txt" && i + ".txt" != teleHighTeam2 + ".txt" && i + ".txt" != teleHighTeam3 + ".txt" && i + ".txt" != teleHighTeam4 + ".txt" && i + ".txt" != teleHighTeam5 + ".txt" && i + ".txt" != teleHighTeam6 + ".txt" && i + ".txt" != teleHighTeam7 + ".txt" && i + ".txt" != teleHighTeam8 + ".txt" && i + ".txt" != teleHighTeam9 + ".txt" && i + ".txt" != teleHighTeam10 + ".txt" && i + ".txt" != teleHighTeam11 + ".txt" && i + ".txt" != teleHighTeam12 + ".txt" && i + ".txt" != teleHighTeam13 + ".txt" && i + ".txt" != teleHighTeam14 + ".txt")
                        {
                            string num1 = GetLine(i + ".txt", j)[numb1].ToString();
                            string num2 = GetLine(i + ".txt", j)[numb2].ToString();
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
                    while (GetLine(i + ".txt", j) != GetLine("blank.txt", 1))
                    {
                        //Console.WriteLine(GetLine(team+".txt",i));
                        j++;
                        if (GetLine(i + ".txt", j).Contains(contains) && i + ".txt" != teleHighTeam1 + ".txt" && i + ".txt" != teleHighTeam2 + ".txt" && i + ".txt" != teleHighTeam3 + ".txt" && i + ".txt" != teleHighTeam4 + ".txt" && i + ".txt" != teleHighTeam5 + ".txt" && i + ".txt" != teleHighTeam6 + ".txt" && i + ".txt" != teleHighTeam7 + ".txt" && i + ".txt" != teleHighTeam8 + ".txt" && i + ".txt" != teleHighTeam9 + ".txt" && i + ".txt" != teleHighTeam10 + ".txt" && i + ".txt" != teleHighTeam11 + ".txt" && i + ".txt" != teleHighTeam12 + ".txt" && i + ".txt" != teleHighTeam13 + ".txt" && i + ".txt" != teleHighTeam14 + ".txt" && i + ".txt" != teleHighTeam15 + ".txt")
                        {
                            string num1 = GetLine(i + ".txt", j)[numb1].ToString();
                            string num2 = GetLine(i + ".txt", j)[numb2].ToString();
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
                    while (GetLine(i + ".txt", j) != GetLine("blank.txt", 1))
                    {
                        //Console.WriteLine(GetLine(team+".txt",i));
                        j++;
                        if (GetLine(i + ".txt", j).Contains(contains) && i + ".txt" != teleHighTeam1 + ".txt" && i + ".txt" != teleHighTeam2 + ".txt" && i + ".txt" != teleHighTeam3 + ".txt" && i + ".txt" != teleHighTeam4 + ".txt" && i + ".txt" != teleHighTeam5 + ".txt" && i + ".txt" != teleHighTeam6 + ".txt" && i + ".txt" != teleHighTeam7 + ".txt" && i + ".txt" != teleHighTeam8 + ".txt" && i + ".txt" != teleHighTeam9 + ".txt" && i + ".txt" != teleHighTeam10 + ".txt" && i + ".txt" != teleHighTeam11 + ".txt" && i + ".txt" != teleHighTeam12 + ".txt" && i + ".txt" != teleHighTeam13 + ".txt" && i + ".txt" != teleHighTeam14 + ".txt" && i + ".txt" != teleHighTeam15 + ".txt" && i + ".txt" != teleHighTeam16 + ".txt")
                        {
                            string num1 = GetLine(i + ".txt", j)[numb1].ToString();
                            string num2 = GetLine(i + ".txt", j)[numb2].ToString();
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
                    while (GetLine(i + ".txt", j) != GetLine("blank.txt", 1))
                    {
                        //Console.WriteLine(GetLine(team+".txt",i));
                        j++;
                        if (GetLine(i + ".txt", j).Contains(contains) && i + ".txt" != teleHighTeam1 + ".txt" && i + ".txt" != teleHighTeam2 + ".txt" && i + ".txt" != teleHighTeam3 + ".txt" && i + ".txt" != teleHighTeam4 + ".txt" && i + ".txt" != teleHighTeam5 + ".txt" && i + ".txt" != teleHighTeam6 + ".txt" && i + ".txt" != teleHighTeam7 + ".txt" && i + ".txt" != teleHighTeam8 + ".txt" && i + ".txt" != teleHighTeam9 + ".txt" && i + ".txt" != teleHighTeam10 + ".txt" && i + ".txt" != teleHighTeam11 + ".txt" && i + ".txt" != teleHighTeam12 + ".txt" && i + ".txt" != teleHighTeam13 + ".txt" && i + ".txt" != teleHighTeam14 + ".txt" && i + ".txt" != teleHighTeam15 + ".txt" && i + ".txt" != teleHighTeam16 + ".txt" && i + ".txt" != teleHighTeam17 + ".txt")
                        {
                            string num1 = GetLine(i + ".txt", j)[numb1].ToString();
                            string num2 = GetLine(i + ".txt", j)[numb2].ToString();
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
                    while (GetLine(i + ".txt", j) != GetLine("blank.txt", 1))
                    {
                        //Console.WriteLine(GetLine(team+".txt",i));
                        j++;
                        if (GetLine(i + ".txt", j).Contains(contains) && i + ".txt" != teleHighTeam1 + ".txt" && i + ".txt" != teleHighTeam2 + ".txt" && i + ".txt" != teleHighTeam3 + ".txt" && i + ".txt" != teleHighTeam4 + ".txt" && i + ".txt" != teleHighTeam5 + ".txt" && i + ".txt" != teleHighTeam6 + ".txt" && i + ".txt" != teleHighTeam7 + ".txt" && i + ".txt" != teleHighTeam8 + ".txt" && i + ".txt" != teleHighTeam9 + ".txt" && i + ".txt" != teleHighTeam10 + ".txt" && i + ".txt" != teleHighTeam11 + ".txt" && i + ".txt" != teleHighTeam12 + ".txt" && i + ".txt" != teleHighTeam13 + ".txt" && i + ".txt" != teleHighTeam14 + ".txt" && i + ".txt" != teleHighTeam15 + ".txt" && i + ".txt" != teleHighTeam16 + ".txt" && i + ".txt" != teleHighTeam17 + ".txt" && i + ".txt" != teleHighTeam18 + ".txt")
                        {
                            string num1 = GetLine(i + ".txt", j)[numb1].ToString();
                            string num2 = GetLine(i + ".txt", j)[numb2].ToString();
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
                    while (GetLine(i + ".txt", j) != GetLine("blank.txt", 1))
                    {
                        //Console.WriteLine(GetLine(team+".txt",i));
                        j++;
                        if (GetLine(i + ".txt", j).Contains(contains) && i + ".txt" != teleHighTeam1 + ".txt" && i + ".txt" != teleHighTeam2 + ".txt" && i + ".txt" != teleHighTeam3 + ".txt" && i + ".txt" != teleHighTeam4 + ".txt" && i + ".txt" != teleHighTeam5 + ".txt" && i + ".txt" != teleHighTeam6 + ".txt" && i + ".txt" != teleHighTeam7 + ".txt" && i + ".txt" != teleHighTeam8 + ".txt" && i + ".txt" != teleHighTeam9 + ".txt" && i + ".txt" != teleHighTeam10 + ".txt" && i + ".txt" != teleHighTeam11 + ".txt" && i + ".txt" != teleHighTeam12 + ".txt" && i + ".txt" != teleHighTeam13 + ".txt" && i + ".txt" != teleHighTeam14 + ".txt" && i + ".txt" != teleHighTeam15 + ".txt" && i + ".txt" != teleHighTeam16 + ".txt" && i + ".txt" != teleHighTeam17 + ".txt" && i + ".txt" != teleHighTeam18 + ".txt" && i + ".txt" != teleHighTeam19 + ".txt")
                        {
                            string num1 = GetLine(i + ".txt", j)[numb1].ToString();
                            string num2 = GetLine(i + ".txt", j)[numb2].ToString();
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
            //bestName.Text = name;

            team1.Text = "Team " + teleHighTeam1;
            team1Data.Text = "" + teleHigh1;

            team2.Text = "Team " + teleHighTeam2;
            team2Data.Text = "" + teleHigh2;
            /*
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
            */

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

        private void bestStatsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                bestScore(comp.Text+"\\"+team.Text);
            }
            catch
            {
                loadText.Text = "Whoops, team does not exist!";
            }
        }

        private void previousMatchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                string team1 = comp.Text+"\\"+team.Text;
                Form1 match = new Form1();
                int i = Int32.Parse(lineMatch.Text);
                if (match.GetLine(team1 + ".txt", i - 22).Contains("-----"))
                {
                    try
                    {
                        driveData(-1);
                    }
                    catch (Exception l)
                    {
                        Console.WriteLine("Whoops");
                    }
                }
            }
            catch (Exception l)
            {
                loadText.Text = "Can't find team";
            }
        }

        private void nextMatchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                string team1 = comp.Text+"\\"+team.Text;
                Form1 match = new Form1();
                int i = Int32.Parse(lineMatch.Text);
                if (match.GetLine(team1 + ".txt", i + 1).Contains("Match Number"))
                {
                    try
                    {
                        driveData(1);
                    }
                    catch (Exception l)
                    {

                    }
                }
            }
            catch (Exception l)
            {
                loadText.Text = "Can't find team";
            }
        }

        //This method returns a value for an average (i being increment, score being the numerator, and j being the denomenator
        public string getAverage(string contains, int numb1, int numb2)
        {
            int i = 0;
            int j = 0;
            int score = 0;
            Console.Write("Team #: ");
            while (GetLine(comp.Text+"\\"+team.Text + ".txt", i) != GetLine("blank.txt", 1))
            {
                //Console.WriteLine(GetLine(team+".txt",i));
                i++;
                if (GetLine(comp.Text+"\\"+team.Text + ".txt", i).Contains(contains))
                {
                    string num1 = GetLine(comp.Text+"\\"+team.Text + ".txt", i)[numb1].ToString();
                    string num2 = GetLine(comp.Text+"\\"+team.Text + ".txt", i)[numb2].ToString();
                    score += Int32.Parse(num1 + num2);
                    j++;
                }
            }
            Console.WriteLine(score / j);
            return "" + (score/j);
        }
        public void averageCargo()
        {
            try
            {
                Form1 match = new Form1();
                
                
                averageTeleLower.Text = getAverage("Tele Lower", 12, 13);
                averageTeleUpper.Text = getAverage("Tele Upper", 12, 13);
                averageAutoUpper.Text = getAverage("Auto Lower", 12, 13);
                averageAutoLower.Text = getAverage("Auto Upper", 12, 13);
                averageTele.Text = getAverage("Tele Cargo Score", 18, 19);
                averageAuto.Text = getAverage("Auto Cargo Score", 18, 19);
                averageAutoAcc.Text = getAverage("Auto Accuracy", 15, 16) + "%";
                averageTeleAcc.Text = getAverage("Tele Accuracy", 15, 16) + "%";
                


                loadText.Text = "Data Loaded";

                //return 1;
            }
            catch (Exception l)
            {

            }
        }

        private void loadText_Click(object sender, EventArgs e)
        {

        }

        private void label49_Click(object sender, EventArgs e)
        {

        }

        public void TrendTeam()
        {
            int totalPoints;
            List<int> points = new List<int>();
            //points.Add()
        }

        private void teamTrendsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bestTeamsTableLayout.Visible = false;
            averageTeamTable.Visible = false;
            driverSheetTable.Visible = false;
            teamTrendLayout.Visible = true;
        }

        private void lowerToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            bestTeamsStats("Auto Lower", 12, 13, 0, 0, false, "Lower Auto");
        }

        private void autoUpperButton_Click(object sender, EventArgs e)
        {
            bestTeamsStats("Auto Upper", 12, 13, 0, 0, false, "Upper Auto");
        }

        private void autoTotalButton_Click(object sender, EventArgs e)
        {
            bestTeamsStats("Auto Cargo Score", 18, 19, 0, 0, false, "Total Auto");
        }

        private void teleLowerButton_Click(object sender, EventArgs e)
        {
            bestTeamsStats("Tele Lower", 12, 13, 0, 0, false, "Lower Tele");
        }

        private void teleUpperButton_Click(object sender, EventArgs e)
        {
            bestTeamsStats("Tele Upper", 12, 13, 0, 0, false, "Upper Tele");
        }

        private void teleTotalButton_Click(object sender, EventArgs e)
        {
            bestTeamsStats("Tele Cargo Score", 18, 19, 0, 0, false, "Total Tele");
        }

        private void defenseToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void climbToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bestTeamsStats("Total Climb Time", 18, 19, 0, 10000, true, "Climb Time");
        }

        private void recentMatchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string team1 = comp.Text+"\\"+team.Text;
            Form1 match = new Form1();
            int i = Int32.Parse(lineMatch.Text);
            //int i = Int32.Parse(lineMatch.Text);
            while (GetLine(team1 + ".txt", i + 1).Contains("Match Number"))
            {
                driveData(1);
                i = Int32.Parse(lineMatch.Text);
            }
        }
    }

}
