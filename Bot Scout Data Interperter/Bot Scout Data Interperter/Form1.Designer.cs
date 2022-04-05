
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
            // Main_page
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataDirectoryLabel);
            this.Controls.Add(this.dataFolderDirectoryLabel);
            this.Controls.Add(this.getDataDirectoryButton);
            this.Name = "Main_page";
            this.Text = "Bot Scout Viewer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button getDataDirectoryButton;
        private System.Windows.Forms.Label dataFolderDirectoryLabel;
        private System.Windows.Forms.Label dataDirectoryLabel;
    }
}

