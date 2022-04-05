
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
            this.getDataDirectoryButton = new System.Windows.Forms.Button();
            this.dataFolderDirectoryLabel = new System.Windows.Forms.Label();
            this.dataDirectoryLabel = new System.Windows.Forms.Label();
            this.tab_body = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.overview_table = new System.Windows.Forms.DataGridView();
            this.Team = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Matches = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Auto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Teleop = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EndGame = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tab_body.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.overview_table)).BeginInit();
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
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(768, 353);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Team Data";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // overview_table
            // 
            this.overview_table.AllowUserToAddRows = false;
            this.overview_table.AllowUserToDeleteRows = false;
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
    }
}

