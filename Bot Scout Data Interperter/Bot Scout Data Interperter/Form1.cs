using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bot_Scout_Data_Interperter.scripts;


//TODO: work on the master reset when changing the competition directory
//TODO: work on filling in the team data and building the user interface for the editing portion
//TODO: add team average to the match chart
//TODO: work on ui for the edit tab
//TODO: add table for the raw data spreadsheet
//TODO: comments
//RESEARCH: winform graph tool

//COMPLETE: overview tab
//COMPLETE: base layout for application

namespace Bot_Scout_Data_Interperter
{
    public partial class Main_page : Form
    {
        supportingFunctions functions = new supportingFunctions();
        
        public Main_page()
        {
            InitializeComponent();
            teamChartData.Series.Add("Match");
            teamChartData.Series.Add("Average");
            teamChartData.Series["Match"].IsValueShownAsLabel = true;
            teamChartData.Series["Average"].IsValueShownAsLabel = true;
            teamChartData.Series.Remove(teamChartData.Series[0]);
            teamChartData.ChartAreas[0].AxisX.LabelStyle.Angle = -90;
            teamChartData.ChartAreas[0].AxisX.LabelStyle.Interval = 1;
            teamChartData.ChartAreas[0].AxisY.LabelStyle.Interval = 2;
            
        }

        private void zzResetData()
        {
            overview_table.Rows.Clear();
            dataDirectoryLabel.Text = "None";
            teamDataMatchSelect.Items.Clear();
            teamDataTeamSelect.Items.Clear();
        }

        private void getDataDirectoryButton_Click(object sender, EventArgs e)
        {
            string directory;
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                directory = folderBrowserDialog.SelectedPath;
                dataDirectoryLabel.Text = directory;

                string[] allTeamFiles = functions.zzGetDataFilesFromDirectory(directory);

                for (int z = 0; allTeamFiles.Length > z; z++)
                {
                    List<string> tableDataList = new List<string>();

                    string teamName = Path.GetFileName(allTeamFiles[z]).Split('.')[0];

                    tableDataList.Add(teamName);

                    string[] lines = File.ReadAllLines(allTeamFiles[z]);


                    int matches_played = functions.zzGetTeamMatchesPlayed(lines);
                    int auto = functions.zzReturnModePointsFromDataSheet(lines, auto: true);
                    int tele = functions.zzReturnModePointsFromDataSheet(lines, tele: true);
                    int endgame = functions.zzReturnModePointsFromDataSheet(lines, end: true); //I know endgame and tele op arnt different but ya know im from ftc so sue me plz 

                    overview_table.Rows.Add(teamName, matches_played, auto, tele, endgame, auto + tele + endgame);

                    teamDataTeamSelect.Items.Add(teamName);

                    // teamDataMatchSelect.Items.Add(teamName);
                }

                // string tempDirectory = @"D:\GitHub\Bot-Track-GUI\Bot Scout Data Interperter\Bot Scout Data Interperter\demo_data\85.txt";
                // string[] test = functions.zzGetMatchDataForTeam(directory, "85");
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void teamDataTeamSelect_SelectedIndexChanged(object sender, EventArgs e)
        {

            teamDataMatchSelect.Items.Clear();
            editMatchSelect.Items.Clear();
            teamChartData.Series["Average"].Points.Clear();
            teamChartData.Series["Match"].Points.Clear();
            match_table_view.Rows.Clear();
            string file = functions.zzGetFileDirectoryFromTeamName(dataDirectoryLabel.Text, teamDataTeamSelect.Text);
            string[] matches = functions.zzGetMatchesPlayedByTeam(teamDataTeamSelect.Text, file);

            dynamic[] averages = functions.zzReturnMatchAveragePointsByTeamNumber(dataDirectoryLabel.Text, teamDataTeamSelect.Text);
            string[] labels = averages[1];
            int[] average = averages[0];

            foreach (string match in matches)
            {
                teamDataMatchSelect.Items.Add(match);
                editMatchSelect.Items.Add(match);
            }

            for (int z=0; labels.Length > z; z++)
            {
                teamChartData.Series["Average"].Points.AddXY(labels[z], average[z]);
            }
        }

        private void teamDataMatchSelect_SelectedIndexChanged(object sender, EventArgs e)
        {
            teamChartData.Series["Match"].Points.Clear();
            teamChartData.Series["Average"].Points.Clear();
            match_table_view.Rows.Clear();
            string matchNumber = teamDataMatchSelect.SelectedItem.ToString().Split(':')[1];
            dynamic[] matchData = functions.zzGetMatchDataFromTeamByMatchNumber(dataDirectoryLabel.Text, teamDataTeamSelect.Text, matchNumber);
            int[] matchPoints = matchData[0];
            string[] matchLabels = matchData[1];

            for (var z = 0; matchLabels.Length > z; z++)
            {
                teamChartData.Series["Match"].Points.AddXY(matchLabels[z], matchPoints[z]);
            }

            dynamic[] averages = functions.zzReturnMatchAveragePointsByTeamNumber(dataDirectoryLabel.Text, teamDataTeamSelect.Text);
            string[] labels = averages[1];
            int[] average = averages[0];

            for (int z = 0; labels.Length > z; z++)
            {
                teamChartData.Series["Average"].Points.AddXY(labels[z], average[z]);
            }

            string mp = String.Join(",", matchPoints.Select(p => p.ToString()).ToArray());
            string ma = String.Join(",", average.Select(p => p.ToString()).ToArray());
            string headers = String.Join(",", labels.Select(p => p.ToString()).ToArray());

            match_table_view.Rows.Add(mp.Split(','));
            match_table_view.Rows.Add(ma.Split(','));
            match_table_view.Rows[0].DefaultCellStyle.BackColor = Color.LightBlue;
            match_table_view.Rows[1].DefaultCellStyle.BackColor = Color.OrangeRed;
        }

        private void editMatchSelect_SelectedIndexChanged(object sender, EventArgs e)
        {
            dynamic[] matchData = functions.zzGetMatchDataFromTeamByMatchNumber(dataDirectoryLabel.Text, teamDataTeamSelect.Text, editMatchSelect.Text.Split(':')[1]);
            int[] matchNumbers = matchData[0];
            string[] matchLabels = matchData[1];

            for (int z = 0; matchLabels.Length > z; z++)
            {
                if (matchLabels[z] == "Taxi")
                {
                    if (matchNumbers[z] == 2)
                        taxiChange.Text = " y";
                    else
                        taxiChange.Text = " n";   
                } else if (matchLabels[z] == "Auto Lower")
                {
                    autoLowerChange.Text = (matchNumbers[z] / 2).ToString();
                } else if (matchLabels[z] == "Auto Upper")
                {
                    autoUpperChange.Text = (matchNumbers[z] / 4).ToString();
                } else if (matchLabels[z] == "Auto Missed")
                {
                    autoMissedChange.Text = matchNumbers[z].ToString(); 
                } else if (matchLabels[z] == "Tele Lower")
                {
                    teleLowerChange.Text = matchNumbers[z].ToString();
                } else if (matchLabels[z] == "Tele Upper")
                {
                    teleUpperChange.Text = (matchNumbers[z] / 2).ToString();
                } else if (matchLabels[z] == "Tele Missed")
                {
                    teleMissedChange.Text = matchNumbers[z].ToString();
                } else if (matchLabels[z] == "Climb")
                {
                    if (matchNumbers[z] == 4)
                        climbChange.Text = " l";
                    else if (matchNumbers[z] == 6)
                        climbChange.Text = " m";
                    else if (matchNumbers[z] == 10)
                        climbChange.Text = " h";
                    else if (matchNumbers[z] == 15)
                        climbChange.Text = " t";
                }
            }
        }

        private void teamChartData_Click(object sender, EventArgs e)
        {

        }

        private string[] zzGetRecordedTeamNumbers()
        {
            string[] files = functions.zzGetDataFilesFromDirectory(dataDirectoryLabel.Text);
            List<string> teamNames = new List<string>();

            for (int z = 0; files.Length > z; z++)
            {
                string fileName = Path.GetFileName(teamNames[z]).Split('.')[0];
                teamNames.Add(fileName);
            }

            return teamNames.ToArray();
        }

        private void changeButtonSubmit_Click(object sender, EventArgs e)
        {
            functions.zzRunEditChangeSubmit(dataDirectoryLabel.Text, teamDataTeamSelect.Text, editMatchSelect.Text, taxiChange.Text, autoLowerChange.Text, autoUpperChange.Text, autoMissedChange.Text, teleLowerChange.Text, teleUpperChange.Text, teleMissedChange.Text, climbChange.Text);
        }
    }
}
