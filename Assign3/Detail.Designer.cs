namespace Assign3
{
    partial class Detail
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
            lblName = new Label();
            lblTeam = new Label();
            lblGoals = new Label();
            lblAssists = new Label();
            lblMatchesPlayed = new Label();
            lblPosition = new Label();
            picPhoto = new PictureBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            ((System.ComponentModel.ISupportInitialize)picPhoto).BeginInit();
            SuspendLayout();
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.BackColor = Color.Transparent;
            lblName.Font = new Font("Segoe UI Black", 15F, FontStyle.Bold);
            lblName.Location = new Point(253, 35);
            lblName.Name = "lblName";
            lblName.Size = new Size(136, 54);
            lblName.TabIndex = 0;
            lblName.Text = "label1";
            // 
            // lblTeam
            // 
            lblTeam.AutoSize = true;
            lblTeam.Location = new Point(404, 643);
            lblTeam.Name = "lblTeam";
            lblTeam.Size = new Size(78, 32);
            lblTeam.TabIndex = 1;
            lblTeam.Text = "label2";
            // 
            // lblGoals
            // 
            lblGoals.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblGoals.AutoSize = true;
            lblGoals.Location = new Point(404, 690);
            lblGoals.Name = "lblGoals";
            lblGoals.Size = new Size(78, 32);
            lblGoals.TabIndex = 2;
            lblGoals.Text = "label3";
            // 
            // lblAssists
            // 
            lblAssists.AutoSize = true;
            lblAssists.Location = new Point(404, 735);
            lblAssists.Name = "lblAssists";
            lblAssists.Size = new Size(78, 32);
            lblAssists.TabIndex = 3;
            lblAssists.Text = "label4";
            // 
            // lblMatchesPlayed
            // 
            lblMatchesPlayed.AutoSize = true;
            lblMatchesPlayed.Location = new Point(404, 781);
            lblMatchesPlayed.Name = "lblMatchesPlayed";
            lblMatchesPlayed.Size = new Size(78, 32);
            lblMatchesPlayed.TabIndex = 4;
            lblMatchesPlayed.Text = "label5";
            // 
            // lblPosition
            // 
            lblPosition.AutoSize = true;
            lblPosition.Location = new Point(404, 824);
            lblPosition.Name = "lblPosition";
            lblPosition.Size = new Size(78, 32);
            lblPosition.TabIndex = 5;
            lblPosition.Text = "label6";
            // 
            // picPhoto
            // 
            picPhoto.Location = new Point(169, 112);
            picPhoto.Name = "picPhoto";
            picPhoto.Size = new Size(447, 522);
            picPhoto.SizeMode = PictureBoxSizeMode.CenterImage;
            picPhoto.TabIndex = 6;
            picPhoto.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Black", 11F, FontStyle.Bold);
            label2.Location = new Point(278, 637);
            label2.Name = "label2";
            label2.Size = new Size(110, 41);
            label2.TabIndex = 8;
            label2.Text = "Team:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Black", 11F, FontStyle.Bold);
            label3.Location = new Point(279, 684);
            label3.Name = "label3";
            label3.Size = new Size(109, 41);
            label3.TabIndex = 9;
            label3.Text = "Goals:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Black", 10.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(263, 729);
            label4.Name = "label4";
            label4.Size = new Size(125, 40);
            label4.TabIndex = 10;
            label4.Text = "Assists:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Black", 10.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(248, 775);
            label5.Name = "label5";
            label5.Size = new Size(145, 40);
            label5.TabIndex = 11;
            label5.Text = "Matches:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Black", 11F, FontStyle.Bold);
            label6.Location = new Point(248, 818);
            label6.Name = "label6";
            label6.Size = new Size(150, 41);
            label6.TabIndex = 12;
            label6.Text = "Position:";
            // 
            // Detail
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(800, 881);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(picPhoto);
            Controls.Add(lblPosition);
            Controls.Add(lblMatchesPlayed);
            Controls.Add(lblAssists);
            Controls.Add(lblGoals);
            Controls.Add(lblTeam);
            Controls.Add(lblName);
            Name = "Detail";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Detail";
            ((System.ComponentModel.ISupportInitialize)picPhoto).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblName;
        private Label lblTeam;
        private Label lblGoals;
        private Label lblAssists;
        private Label lblMatchesPlayed;
        private Label lblPosition;
        private PictureBox picPhoto;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
    }
}