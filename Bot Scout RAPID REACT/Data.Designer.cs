
namespace Bot_Scout_RAPID_REACT
{
    partial class Data
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Data));
            this.button1 = new System.Windows.Forms.Button();
            this.team = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.teleLow = new System.Windows.Forms.Label();
            this.defense = new System.Windows.Forms.Label();
            this.climbType = new System.Windows.Forms.Label();
            this.time = new System.Windows.Forms.Label();
            this.autoTotal = new System.Windows.Forms.Label();
            this.teleHigh = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.loadText = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.lineMatch = new System.Windows.Forms.Label();
            this.dataSet1 = new System.Data.DataSet();
            this.matchText = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(134, 52);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(132, 71);
            this.button1.TabIndex = 0;
            this.button1.Text = "Load Best Cargo Teams";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // team
            // 
            this.team.Location = new System.Drawing.Point(134, 12);
            this.team.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.team.Name = "team";
            this.team.Size = new System.Drawing.Size(148, 26);
            this.team.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(18, 14);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Team #: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(54, 168);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tele Low";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(58, 220);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Tele Upper";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(58, 445);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Defense";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(60, 389);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 20);
            this.label5.TabIndex = 6;
            this.label5.Text = "Climb Type";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(60, 337);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 20);
            this.label6.TabIndex = 7;
            this.label6.Text = "Climb Time";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(58, 272);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 20);
            this.label7.TabIndex = 8;
            this.label7.Text = "Auto Total";
            // 
            // teleLow
            // 
            this.teleLow.AutoSize = true;
            this.teleLow.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teleLow.Location = new System.Drawing.Point(207, 168);
            this.teleLow.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.teleLow.Name = "teleLow";
            this.teleLow.Size = new System.Drawing.Size(72, 25);
            this.teleLow.TabIndex = 9;
            this.teleLow.Text = "Empty";
            // 
            // defense
            // 
            this.defense.AutoSize = true;
            this.defense.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.defense.Location = new System.Drawing.Point(207, 445);
            this.defense.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.defense.Name = "defense";
            this.defense.Size = new System.Drawing.Size(72, 25);
            this.defense.TabIndex = 10;
            this.defense.Text = "Empty";
            // 
            // climbType
            // 
            this.climbType.AutoSize = true;
            this.climbType.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.climbType.Location = new System.Drawing.Point(207, 389);
            this.climbType.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.climbType.Name = "climbType";
            this.climbType.Size = new System.Drawing.Size(72, 25);
            this.climbType.TabIndex = 11;
            this.climbType.Text = "Empty";
            // 
            // time
            // 
            this.time.AutoSize = true;
            this.time.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.time.Location = new System.Drawing.Point(207, 337);
            this.time.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.time.Name = "time";
            this.time.Size = new System.Drawing.Size(72, 25);
            this.time.TabIndex = 12;
            this.time.Text = "Empty";
            // 
            // autoTotal
            // 
            this.autoTotal.AutoSize = true;
            this.autoTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.autoTotal.Location = new System.Drawing.Point(207, 272);
            this.autoTotal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.autoTotal.Name = "autoTotal";
            this.autoTotal.Size = new System.Drawing.Size(72, 25);
            this.autoTotal.TabIndex = 13;
            this.autoTotal.Text = "Empty";
            // 
            // teleHigh
            // 
            this.teleHigh.AutoSize = true;
            this.teleHigh.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teleHigh.Location = new System.Drawing.Point(207, 220);
            this.teleHigh.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.teleHigh.Name = "teleHigh";
            this.teleHigh.Size = new System.Drawing.Size(72, 25);
            this.teleHigh.TabIndex = 14;
            this.teleHigh.Text = "Empty";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(18, 43);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(90, 88);
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // loadText
            // 
            this.loadText.AutoSize = true;
            this.loadText.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loadText.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.loadText.Location = new System.Drawing.Point(318, 14);
            this.loadText.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.loadText.Name = "loadText";
            this.loadText.Size = new System.Drawing.Size(243, 25);
            this.loadText.TabIndex = 16;
            this.loadText.Text = "Enter Valid Team Number";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(556, 52);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(138, 71);
            this.button2.TabIndex = 17;
            this.button2.Text = "Next Match";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // lineMatch
            // 
            this.lineMatch.AutoSize = true;
            this.lineMatch.Location = new System.Drawing.Point(756, 168);
            this.lineMatch.Name = "lineMatch";
            this.lineMatch.Size = new System.Drawing.Size(18, 20);
            this.lineMatch.TabIndex = 18;
            this.lineMatch.Text = "0";
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "NewDataSet";
            // 
            // matchText
            // 
            this.matchText.AutoSize = true;
            this.matchText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.matchText.Location = new System.Drawing.Point(207, 128);
            this.matchText.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.matchText.Name = "matchText";
            this.matchText.Size = new System.Drawing.Size(72, 25);
            this.matchText.TabIndex = 19;
            this.matchText.Text = "Empty";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(342, 52);
            this.button3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(138, 71);
            this.button3.TabIndex = 20;
            this.button3.Text = "Previous Match";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Data
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.matchText);
            this.Controls.Add(this.lineMatch);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.loadText);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.teleHigh);
            this.Controls.Add(this.autoTotal);
            this.Controls.Add(this.time);
            this.Controls.Add(this.climbType);
            this.Controls.Add(this.defense);
            this.Controls.Add(this.teleLow);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.team);
            this.Controls.Add(this.button1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Data";
            this.Text = "Driver Sheet";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox team;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label teleLow;
        private System.Windows.Forms.Label defense;
        private System.Windows.Forms.Label climbType;
        private System.Windows.Forms.Label time;
        private System.Windows.Forms.Label autoTotal;
        private System.Windows.Forms.Label teleHigh;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label loadText;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label lineMatch;
        private System.Data.DataSet dataSet1;
        private System.Windows.Forms.Label matchText;
        private System.Windows.Forms.Button button3;
    }
}