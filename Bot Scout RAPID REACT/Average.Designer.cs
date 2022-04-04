
namespace Bot_Scout_RAPID_REACT
{
    partial class Average
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Average));
            this.loadText = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.team = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.averageTele = new System.Windows.Forms.Label();
            this.averageTeleAcc = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // loadText
            // 
            this.loadText.AutoSize = true;
            this.loadText.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loadText.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.loadText.Location = new System.Drawing.Point(212, 9);
            this.loadText.Name = "loadText";
            this.loadText.Size = new System.Drawing.Size(168, 17);
            this.loadText.TabIndex = 19;
            this.loadText.Text = "Enter Valid Team Number";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 16);
            this.label1.TabIndex = 18;
            this.label1.Text = "Team #: ";
            // 
            // team
            // 
            this.team.Location = new System.Drawing.Point(89, 8);
            this.team.Name = "team";
            this.team.Size = new System.Drawing.Size(100, 20);
            this.team.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(49, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 13);
            this.label2.TabIndex = 20;
            this.label2.Text = "Average Score Tele";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(49, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 13);
            this.label3.TabIndex = 21;
            this.label3.Text = "Average Accuracy Tele";
            // 
            // averageTele
            // 
            this.averageTele.AutoSize = true;
            this.averageTele.Location = new System.Drawing.Point(212, 95);
            this.averageTele.Name = "averageTele";
            this.averageTele.Size = new System.Drawing.Size(33, 13);
            this.averageTele.TabIndex = 22;
            this.averageTele.Text = "None";
            // 
            // averageTeleAcc
            // 
            this.averageTeleAcc.AutoSize = true;
            this.averageTeleAcc.Location = new System.Drawing.Point(212, 146);
            this.averageTeleAcc.Name = "averageTeleAcc";
            this.averageTeleAcc.Size = new System.Drawing.Size(33, 13);
            this.averageTeleAcc.TabIndex = 23;
            this.averageTeleAcc.Text = "None";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(386, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(92, 23);
            this.button1.TabIndex = 24;
            this.button1.Text = "Get Averages";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Average
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.averageTeleAcc);
            this.Controls.Add(this.averageTele);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.loadText);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.team);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Average";
            this.Text = "Average";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label loadText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox team;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label averageTele;
        private System.Windows.Forms.Label averageTeleAcc;
        private System.Windows.Forms.Button button1;
    }
}