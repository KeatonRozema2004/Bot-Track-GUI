using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bot_Scout_Data_Interperter.scripts;


namespace Bot_Scout_Data_Interperter
{
    public partial class Main_page : Form
    {
        supportingFunctions functions = new supportingFunctions();
        
        public Main_page()
        {
            InitializeComponent();
        }

        private void getDataDirectoryButton_Click(object sender, EventArgs e)
        {
            string directory;
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                directory = folderBrowserDialog.SelectedPath;
                dataDirectoryLabel.Text = directory;

                string tempDirectory = @"D:\GitHub\Bot-Track-GUI\Bot Scout Data Interperter\Bot Scout Data Interperter\demo_data\85.txt";

                string[] test = functions.zzGetMatchDataForTeam(directory, "85");
            }
        }
    }
}
