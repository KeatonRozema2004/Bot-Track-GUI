
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
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
            this.teamDataSpliter = new System.Windows.Forms.SplitContainer();
            this.teamDataTeamSelect = new System.Windows.Forms.ComboBox();
            this.teamDataTabs = new System.Windows.Forms.TabControl();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.teamDataMatchSelect = new System.Windows.Forms.ListBox();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.graph_table_control = new System.Windows.Forms.TabControl();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.teamChartData = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tabPage7 = new System.Windows.Forms.TabPage();
            this.match_table_view = new System.Windows.Forms.DataGridView();
            this.taxi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.auto_upper = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.auto_lower = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.auto_missed = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tele_upper = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tele_lower = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tele_missed = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.climb = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.editMatchSelect = new System.Windows.Forms.ComboBox();
            this.editMatchSelectLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.taxiChange = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.autoUpperChange = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.autoLowerChange = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.autoMissedChange = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.teleUpperChange = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.teleLowerChange = new System.Windows.Forms.TextBox();
            this.teleMissedChange = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.climbChange = new System.Windows.Forms.ComboBox();
            this.changeButtonSubmit = new System.Windows.Forms.Button();
            this.tab_body.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.overview_table)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.teamDataSpliter)).BeginInit();
            this.teamDataSpliter.Panel1.SuspendLayout();
            this.teamDataSpliter.Panel2.SuspendLayout();
            this.teamDataSpliter.SuspendLayout();
            this.teamDataTabs.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.graph_table_control.SuspendLayout();
            this.tabPage6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.teamChartData)).BeginInit();
            this.tabPage7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.match_table_view)).BeginInit();
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
            this.overview_table.ReadOnly = true;
            this.overview_table.Size = new System.Drawing.Size(759, 341);
            this.overview_table.TabIndex = 0;
            this.overview_table.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Team
            // 
            this.Team.HeaderText = "Team (Average)";
            this.Team.Name = "Team";
            this.Team.ReadOnly = true;
            // 
            // Matches
            // 
            this.Matches.HeaderText = "Matches Played";
            this.Matches.Name = "Matches";
            this.Matches.ReadOnly = true;
            // 
            // Auto
            // 
            this.Auto.HeaderText = "Auto Points";
            this.Auto.Name = "Auto";
            this.Auto.ReadOnly = true;
            // 
            // Teleop
            // 
            this.Teleop.HeaderText = "Teleop Points";
            this.Teleop.Name = "Teleop";
            this.Teleop.ReadOnly = true;
            // 
            // EndGame
            // 
            this.EndGame.HeaderText = "End Game Points";
            this.EndGame.Name = "EndGame";
            this.EndGame.ReadOnly = true;
            // 
            // Total
            // 
            this.Total.HeaderText = "Total Score";
            this.Total.Name = "Total";
            this.Total.ReadOnly = true;
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
            this.teamDataSpliter.Panel2.Controls.Add(this.graph_table_control);
            this.teamDataSpliter.Size = new System.Drawing.Size(766, 344);
            this.teamDataSpliter.SplitterDistance = 255;
            this.teamDataSpliter.TabIndex = 3;
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
            // teamDataMatchSelect
            // 
            this.teamDataMatchSelect.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.teamDataMatchSelect.FormattingEnabled = true;
            this.teamDataMatchSelect.Location = new System.Drawing.Point(6, 6);
            this.teamDataMatchSelect.Name = "teamDataMatchSelect";
            this.teamDataMatchSelect.Size = new System.Drawing.Size(225, 277);
            this.teamDataMatchSelect.TabIndex = 0;
            this.teamDataMatchSelect.SelectedIndexChanged += new System.EventHandler(this.teamDataMatchSelect_SelectedIndexChanged);
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.changeButtonSubmit);
            this.tabPage4.Controls.Add(this.climbChange);
            this.tabPage4.Controls.Add(this.label8);
            this.tabPage4.Controls.Add(this.label7);
            this.tabPage4.Controls.Add(this.teleMissedChange);
            this.tabPage4.Controls.Add(this.teleLowerChange);
            this.tabPage4.Controls.Add(this.label6);
            this.tabPage4.Controls.Add(this.teleUpperChange);
            this.tabPage4.Controls.Add(this.label5);
            this.tabPage4.Controls.Add(this.autoMissedChange);
            this.tabPage4.Controls.Add(this.label4);
            this.tabPage4.Controls.Add(this.autoLowerChange);
            this.tabPage4.Controls.Add(this.label3);
            this.tabPage4.Controls.Add(this.autoUpperChange);
            this.tabPage4.Controls.Add(this.label2);
            this.tabPage4.Controls.Add(this.taxiChange);
            this.tabPage4.Controls.Add(this.label1);
            this.tabPage4.Controls.Add(this.editMatchSelectLabel);
            this.tabPage4.Controls.Add(this.editMatchSelect);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(237, 287);
            this.tabPage4.TabIndex = 1;
            this.tabPage4.Text = "Edit";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // graph_table_control
            // 
            this.graph_table_control.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.graph_table_control.Controls.Add(this.tabPage6);
            this.graph_table_control.Controls.Add(this.tabPage7);
            this.graph_table_control.Location = new System.Drawing.Point(3, 3);
            this.graph_table_control.Name = "graph_table_control";
            this.graph_table_control.SelectedIndex = 0;
            this.graph_table_control.Size = new System.Drawing.Size(501, 338);
            this.graph_table_control.TabIndex = 1;
            // 
            // tabPage6
            // 
            this.tabPage6.Controls.Add(this.teamChartData);
            this.tabPage6.Location = new System.Drawing.Point(4, 22);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage6.Size = new System.Drawing.Size(493, 312);
            this.tabPage6.TabIndex = 0;
            this.tabPage6.Text = "Graph";
            this.tabPage6.UseVisualStyleBackColor = true;
            // 
            // teamChartData
            // 
            this.teamChartData.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea2.Name = "ChartArea1";
            this.teamChartData.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.teamChartData.Legends.Add(legend2);
            this.teamChartData.Location = new System.Drawing.Point(6, 6);
            this.teamChartData.Name = "teamChartData";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.teamChartData.Series.Add(series2);
            this.teamChartData.Size = new System.Drawing.Size(481, 300);
            this.teamChartData.TabIndex = 0;
            this.teamChartData.Tag = "";
            this.teamChartData.Text = "chart1";
            this.teamChartData.Click += new System.EventHandler(this.teamChartData_Click);
            // 
            // tabPage7
            // 
            this.tabPage7.Controls.Add(this.match_table_view);
            this.tabPage7.Location = new System.Drawing.Point(4, 22);
            this.tabPage7.Name = "tabPage7";
            this.tabPage7.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage7.Size = new System.Drawing.Size(493, 312);
            this.tabPage7.TabIndex = 1;
            this.tabPage7.Text = "Table";
            this.tabPage7.UseVisualStyleBackColor = true;
            // 
            // match_table_view
            // 
            this.match_table_view.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.match_table_view.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.match_table_view.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.match_table_view.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.taxi,
            this.auto_upper,
            this.auto_lower,
            this.auto_missed,
            this.tele_upper,
            this.tele_lower,
            this.tele_missed,
            this.climb});
            this.match_table_view.Location = new System.Drawing.Point(6, 3);
            this.match_table_view.Name = "match_table_view";
            this.match_table_view.Size = new System.Drawing.Size(481, 303);
            this.match_table_view.TabIndex = 0;
            // 
            // taxi
            // 
            this.taxi.HeaderText = "Taxi";
            this.taxi.Name = "taxi";
            this.taxi.ReadOnly = true;
            // 
            // auto_upper
            // 
            this.auto_upper.HeaderText = "Auto Upper";
            this.auto_upper.Name = "auto_upper";
            this.auto_upper.ReadOnly = true;
            // 
            // auto_lower
            // 
            this.auto_lower.HeaderText = "Auto Lower";
            this.auto_lower.Name = "auto_lower";
            this.auto_lower.ReadOnly = true;
            // 
            // auto_missed
            // 
            this.auto_missed.HeaderText = "Auto Missed";
            this.auto_missed.Name = "auto_missed";
            this.auto_missed.ReadOnly = true;
            // 
            // tele_upper
            // 
            this.tele_upper.HeaderText = "Tele Upper";
            this.tele_upper.Name = "tele_upper";
            this.tele_upper.ReadOnly = true;
            // 
            // tele_lower
            // 
            this.tele_lower.HeaderText = "Tele Lower";
            this.tele_lower.Name = "tele_lower";
            this.tele_lower.ReadOnly = true;
            // 
            // tele_missed
            // 
            this.tele_missed.HeaderText = "Tele Missed";
            this.tele_missed.Name = "tele_missed";
            this.tele_missed.ReadOnly = true;
            // 
            // climb
            // 
            this.climb.HeaderText = "Climb";
            this.climb.Name = "climb";
            this.climb.ReadOnly = true;
            // 
            // editMatchSelect
            // 
            this.editMatchSelect.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.editMatchSelect.FormattingEnabled = true;
            this.editMatchSelect.Location = new System.Drawing.Point(82, 6);
            this.editMatchSelect.Name = "editMatchSelect";
            this.editMatchSelect.Size = new System.Drawing.Size(149, 21);
            this.editMatchSelect.TabIndex = 0;
            this.editMatchSelect.SelectedIndexChanged += new System.EventHandler(this.editMatchSelect_SelectedIndexChanged);
            // 
            // editMatchSelectLabel
            // 
            this.editMatchSelectLabel.AutoSize = true;
            this.editMatchSelectLabel.Location = new System.Drawing.Point(6, 9);
            this.editMatchSelectLabel.Name = "editMatchSelectLabel";
            this.editMatchSelectLabel.Size = new System.Drawing.Size(70, 13);
            this.editMatchSelectLabel.TabIndex = 1;
            this.editMatchSelectLabel.Text = "Select Match";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Taxi:";
            // 
            // taxiChange
            // 
            this.taxiChange.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.taxiChange.Location = new System.Drawing.Point(47, 37);
            this.taxiChange.Name = "taxiChange";
            this.taxiChange.Size = new System.Drawing.Size(184, 20);
            this.taxiChange.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Auto Upper:";
            // 
            // autoUpperChange
            // 
            this.autoUpperChange.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.autoUpperChange.Location = new System.Drawing.Point(76, 63);
            this.autoUpperChange.Name = "autoUpperChange";
            this.autoUpperChange.Size = new System.Drawing.Size(155, 20);
            this.autoUpperChange.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Auto Lower:";
            // 
            // autoLowerChange
            // 
            this.autoLowerChange.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.autoLowerChange.Location = new System.Drawing.Point(76, 94);
            this.autoLowerChange.Name = "autoLowerChange";
            this.autoLowerChange.Size = new System.Drawing.Size(155, 20);
            this.autoLowerChange.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 123);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Auto Missed:";
            // 
            // autoMissedChange
            // 
            this.autoMissedChange.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.autoMissedChange.Location = new System.Drawing.Point(76, 120);
            this.autoMissedChange.Name = "autoMissedChange";
            this.autoMissedChange.Size = new System.Drawing.Size(155, 20);
            this.autoMissedChange.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 149);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Tele Upper:";
            // 
            // teleUpperChange
            // 
            this.teleUpperChange.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.teleUpperChange.Location = new System.Drawing.Point(76, 146);
            this.teleUpperChange.Name = "teleUpperChange";
            this.teleUpperChange.Size = new System.Drawing.Size(155, 20);
            this.teleUpperChange.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 175);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Tele Lower:";
            // 
            // teleLowerChange
            // 
            this.teleLowerChange.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.teleLowerChange.Location = new System.Drawing.Point(76, 172);
            this.teleLowerChange.Name = "teleLowerChange";
            this.teleLowerChange.Size = new System.Drawing.Size(155, 20);
            this.teleLowerChange.TabIndex = 13;
            // 
            // teleMissedChange
            // 
            this.teleMissedChange.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.teleMissedChange.Location = new System.Drawing.Point(76, 198);
            this.teleMissedChange.Name = "teleMissedChange";
            this.teleMissedChange.Size = new System.Drawing.Size(155, 20);
            this.teleMissedChange.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 201);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Tele Missed:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(3, 230);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "Climb:";
            // 
            // climbChange
            // 
            this.climbChange.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.climbChange.FormattingEnabled = true;
            this.climbChange.Location = new System.Drawing.Point(44, 224);
            this.climbChange.Name = "climbChange";
            this.climbChange.Size = new System.Drawing.Size(190, 21);
            this.climbChange.TabIndex = 17;
            // 
            // changeButtonSubmit
            // 
            this.changeButtonSubmit.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.changeButtonSubmit.Location = new System.Drawing.Point(6, 251);
            this.changeButtonSubmit.Name = "changeButtonSubmit";
            this.changeButtonSubmit.Size = new System.Drawing.Size(225, 30);
            this.changeButtonSubmit.TabIndex = 18;
            this.changeButtonSubmit.Text = "Submit Changes";
            this.changeButtonSubmit.UseVisualStyleBackColor = true;
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
            this.teamDataSpliter.Panel1.ResumeLayout(false);
            this.teamDataSpliter.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.teamDataSpliter)).EndInit();
            this.teamDataSpliter.ResumeLayout(false);
            this.teamDataTabs.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.graph_table_control.ResumeLayout(false);
            this.tabPage6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.teamChartData)).EndInit();
            this.tabPage7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.match_table_view)).EndInit();
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
        private System.Windows.Forms.TabControl graph_table_control;
        private System.Windows.Forms.TabPage tabPage6;
        private System.Windows.Forms.TabPage tabPage7;
        private System.Windows.Forms.DataGridView match_table_view;
        private System.Windows.Forms.DataGridViewTextBoxColumn taxi;
        private System.Windows.Forms.DataGridViewTextBoxColumn auto_upper;
        private System.Windows.Forms.DataGridViewTextBoxColumn auto_lower;
        private System.Windows.Forms.DataGridViewTextBoxColumn auto_missed;
        private System.Windows.Forms.DataGridViewTextBoxColumn tele_upper;
        private System.Windows.Forms.DataGridViewTextBoxColumn tele_lower;
        private System.Windows.Forms.DataGridViewTextBoxColumn tele_missed;
        private System.Windows.Forms.DataGridViewTextBoxColumn climb;
        private System.Windows.Forms.Label editMatchSelectLabel;
        private System.Windows.Forms.ComboBox editMatchSelect;
        private System.Windows.Forms.Button changeButtonSubmit;
        private System.Windows.Forms.ComboBox climbChange;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox teleMissedChange;
        private System.Windows.Forms.TextBox teleLowerChange;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox teleUpperChange;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox autoMissedChange;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox autoLowerChange;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox autoUpperChange;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox taxiChange;
        private System.Windows.Forms.Label label1;
    }
}

