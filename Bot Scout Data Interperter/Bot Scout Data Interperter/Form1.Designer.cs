
namespace Bot_Scout_Data_Interperter
{
    partial class Main_page
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.getDataDirectoryButton = new System.Windows.Forms.Button();
            this.dataFolderDirectoryLabel = new System.Windows.Forms.Label();
            this.dataDirectoryLabel = new System.Windows.Forms.Label();
            this.tab_body = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.overview_table = new System.Windows.Forms.DataGridView();
            this.Team = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Matches = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Auto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Teleop = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EndGame = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.teamDataTabs = new System.Windows.Forms.TabControl();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.teamDataTeamSelect = new System.Windows.Forms.ComboBox();
            this.teamDataSpliter = new System.Windows.Forms.SplitContainer();
            this.teamChartData = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.teamDataMatchSelect = new System.Windows.Forms.ListBox();
            this.tab_body.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.overview_table)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.teamDataTabs.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.teamDataSpliter)).BeginInit();
            this.teamDataSpliter.Panel1.SuspendLayout();
            this.teamDataSpliter.Panel2.SuspendLayout();
            this.teamDataSpliter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.teamChartData)).BeginInit();
            this.SuspendLayout();
            // 
            // getDataDirectoryButton
            // 
            this.getDataDirectoryButton.Location = new System.Drawing.Point(12, 30);
            this.getDataDirectoryButton.Name = "getDataDirectoryButton";
            this.getDataDirectoryButton.Size = new System.Drawing.Size(138, 23);
            this.getDataDirectoryButton.TabIndex = 0;
            this.getDataDirectoryButton.Text = "Get Directory";
            this.getDataDirectoryButton.UseVisualStyleBackColor = true;
            this.getDataDirectoryButton.Click += new System.EventHandler(this.getDataDirectoryButton_Click);
            // 
            // dataFolderDirectoryLabel
            // 
            this.dataFolderDirectoryLabel.AutoSize = true;
            this.dataFolderDirectoryLabel.Location = new System.Drawing.Point(12, 14);
            this.dataFolderDirectoryLabel.Name = "dataFolderDirectoryLabel";
            this.dataFolderDirectoryLabel.Size = new System.Drawing.Size(144, 13);
            this.dataFolderDirectoryLabel.TabIndex = 1;
            this.dataFolderDirectoryLabel.Text = "Scouting Matches Directory: ";
            // 
            // dataDirectoryLabel
            // 
            this.dataDirectoryLabel.AutoSize = true;
            this.dataDirectoryLabel.Location = new System.Drawing.Point(162, 14);
            this.dataDirectoryLabel.Name = "dataDirectoryLabel";
            this.dataDirectoryLabel.Size = new System.Drawing.Size(33, 13);
            this.dataDirectoryLabel.TabIndex = 2;
            this.dataDirectoryLabel.Text = "None";
            // 
            // tab_body
            // 
            this.tab_body.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tab_body.Controls.Add(this.tabPage1);
            this.tab_body.Controls.Add(this.tabPage2);
            this.tab_body.Location = new System.Drawing.Point(12, 59);
            this.tab_body.Name = "tab_body";
            this.tab_body.SelectedIndex = 0;
            this.tab_body.Size = new System.Drawing.Size(776, 379);
            this.tab_body.TabIndex = 3;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.overview_table);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(768, 353);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Overview";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // overview_table
            // 
            this.overview_table.AllowUserToAddRows = false;
            this.overview_table.AllowUserToDeleteRows = false;
            this.overview_table.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.overview_table.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.overview_table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.overview_table.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Team,
            this.Matches,
            this.Auto,
            this.Teleop,
            this.EndGame,
            this.Total});
            this.overview_table.Location = new System.Drawing.Point(3, 6);
            this.overview_table.Name = "overview_table";
            this.overview_table.Size = new System.Drawing.Size(759, 341);
            this.overview_table.TabIndex = 0;
            this.overview_table.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Team
            // 
            this.Team.HeaderText = "Team (Average)";
            this.Team.Name = "Team";
            // 
            // Matches
            // 
            this.Matches.HeaderText = "Matches Played";
            this.Matches.Name = "Matches";
            // 
            // Auto
            // 
            this.Auto.HeaderText = "Auto Points";
            this.Auto.Name = "Auto";
            // 
            // Teleop
            // 
            this.Teleop.HeaderText = "Teleop Points";
            this.Teleop.Name = "Teleop";
            // 
            // EndGame
            // 
            this.EndGame.HeaderText = "End Game Points";
            this.EndGame.Name = "EndGame";
            // 
            // Total
            // 
            this.Total.HeaderText = "Total Score";
            this.Total.Name = "Total";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.teamDataSpliter);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(768, 353);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Team Data";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // teamDataTabs
            // 
            this.teamDataTabs.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.teamDataTabs.Controls.Add(this.tabPage3);
            this.teamDataTabs.Controls.Add(this.tabPage4);
            this.teamDataTabs.Location = new System.Drawing.Point(7, 28);
            this.teamDataTabs.Name = "teamDataTabs";
            this.teamDataTabs.SelectedIndex = 0;
            this.teamDataTabs.Size = new System.Drawing.Size(245, 313);
            this.teamDataTabs.TabIndex = 1;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.teamDataMatchSelect);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(237, 287);
            this.tabPage3.TabIndex = 0;
            this.tabPage3.Text = "Matches";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(237, 287);
            this.tabPage4.TabIndex = 1;
            this.tabPage4.Text = "Edit";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // teamDataTeamSelect
            // 
            this.teamDataTeamSelect.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.teamDataTeamSelect.FormattingEnabled = true;
            this.teamDataTeamSelect.Location = new System.Drawing.Point(4, 3);
            this.teamDataTeamSelect.Name = "teamDataTeamSelect";
            this.teamDataTeamSelect.Size = new System.Drawing.Size(244, 21);
            this.teamDataTeamSelect.TabIndex = 2;
            this.teamDataTeamSelect.SelectedIndexChanged += new System.EventHandler(this.teamDataTeamSelect_SelectedIndexChanged);
            // 
            // teamDataSpliter
            // 
            this.teamDataSpliter.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.teamDataSpliter.Location = new System.Drawing.Point(-1, 3);
            this.teamDataSpliter.Name = "teamDataSpliter";
            // 
            // teamDataSpliter.Panel1
            // 
            this.teamDataSpliter.Panel1.Controls.Add(this.teamDataTeamSelect);
            this.teamDataSpliter.Panel1.Controls.Add(this.teamDataTabs);
            // 
            // teamDataSpliter.Panel2
            // 
            this.teamDataSpliter.Panel2.Controls.Add(this.teamChartData);
            this.teamDataSpliter.Size = new System.Drawing.Size(766, 344);
            this.teamDataSpliter.SplitterDistance = 255;
            this.teamDataSpliter.TabIndex = 3;
            // 
            // teamChartData
            // 
            this.teamChartData.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea1.Name = "ChartArea1";
            this.teamChartData.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.teamChartData.Legends.Add(legend1);
            this.teamChartData.Location = new System.Drawing.Point(3, 3);
            this.teamChartData.Name = "teamChartData";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.teamChartData.Series.Add(series1);
            this.teamChartData.Size = new System.Drawing.Size(501, 334);
            this.teamChartData.TabIndex = 0;
            this.teamChartData.Text = "chart1";
            // 
            // teamDataMatchSelect
            // 
            this.teamDataMatchSelect.FormattingEnabled = true;
            this.teamDataMatchSelect.Location = new System.Drawing.Point(6, 6);
            this.teamDataMatchSelect.Name = "teamDataMatchSelect";
            this.teamDataMatchSelect.Size = new System.Drawing.Size(225, 277);
            this.teamDataMatchSelect.TabIndex = 0;
            // 
            // Main_page
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tab_body);
            this.Controls.Add(this.dataDirectoryLabel);
            this.Controls.Add(this.dataFolderDirectoryLabel);
            this.Controls.Add(this.getDataDirectoryButton);
            this.Name = "Main_page";
            this.Text = "Bot Scout Viewer";
            this.tab_body.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.overview_table)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.teamDataTabs.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.teamDataSpliter.Panel1.ResumeLayout(false);
            this.teamDataSpliter.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.teamDataSpliter)).EndInit();
            this.teamDataSpliter.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.teamChartData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button getDataDirectoryButton;
        private System.Windows.Forms.Label dataFolderDirectoryLabel;
        private System.Windows.Forms.Label dataDirectoryLabel;
        private System.Windows.Forms.TabControl tab_body;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView overview_table;
        private System.Windows.Forms.DataGridViewTextBoxColumn Team;
        private System.Windows.Forms.DataGridViewTextBoxColumn Matches;
        private System.Windows.Forms.DataGridViewTextBoxColumn Auto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Teleop;
        private System.Windows.Forms.DataGridViewTextBoxColumn EndGame;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
        private System.Windows.Forms.ComboBox teamDataTeamSelect;
        private System.Windows.Forms.TabControl teamDataTabs;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.SplitContainer teamDataSpliter;
        private System.Windows.Forms.DataVisualization.Charting.Chart teamChartData;
        private System.Windows.Forms.ListBox teamDataMatchSelect;
    }
}

