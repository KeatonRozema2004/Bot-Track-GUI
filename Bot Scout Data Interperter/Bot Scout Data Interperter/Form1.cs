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
        }

        private void zzResetData()
        {
            overview_table.Rows.Clear();
            dataDirectoryLabel.Text = "None";
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

                    string teamName = Path.GetFileName(allTeamFiles[z]).Split()[0];

                    tableDataList.Add(teamName);

                    string[] lines = File.ReadAllLines(allTeamFiles[z]);


                    int matches_played = functions.zzGetTeamMatchesPlayed(lines);
                    int auto = functions.zzReturnModePointsFromDataSheet(lines, auto: true);
                    int tele = functions.zzReturnModePointsFromDataSheet(lines, tele: true);
                    int endgame = functions.zzReturnModePointsFromDataSheet(lines, end: true); //I know endgame and tele op arnt different but ya know im from ftc so sue me plz 

                    overview_table.Rows.Add(teamName, matches_played, auto, tele, endgame, auto + tele + endgame);
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

        }
    }
}
