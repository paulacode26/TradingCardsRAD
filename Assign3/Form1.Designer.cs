namespace Assign3
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            dataGridView1 = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label7 = new Label();
            txtName = new TextBox();
            txtGoals = new TextBox();
            txtAssists = new TextBox();
            txtMatchesPlayed = new TextBox();
            cboTeam = new ComboBox();
            cboPosition = new ComboBox();
            picPlayer = new PictureBox();
            btnUpload = new Button();
            txtUrl = new TextBox();
            btnAdd = new Button();
            btnDelete = new Button();
            label8 = new Label();
            btnDetail = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picPlayer).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(740, 286);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 82;
            dataGridView1.Size = new Size(465, 688);
            dataGridView1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold);
            label1.ForeColor = Color.White;
            label1.Location = new Point(68, 118);
            label1.Name = "label1";
            label1.Size = new Size(122, 45);
            label1.TabIndex = 1;
            label1.Text = "Name:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold);
            label2.ForeColor = Color.White;
            label2.Location = new Point(68, 171);
            label2.Name = "label2";
            label2.Size = new Size(116, 45);
            label2.TabIndex = 2;
            label2.Text = "Team:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold);
            label3.ForeColor = Color.White;
            label3.Location = new Point(68, 218);
            label3.Name = "label3";
            label3.Size = new Size(116, 45);
            label3.TabIndex = 3;
            label3.Text = "Goals:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(68, 266);
            label4.Name = "label4";
            label4.Size = new Size(137, 45);
            label4.TabIndex = 4;
            label4.Text = "Assists:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold);
            label5.ForeColor = Color.White;
            label5.Location = new Point(68, 312);
            label5.Name = "label5";
            label5.Size = new Size(268, 45);
            label5.TabIndex = 5;
            label5.Text = "MatchesPlayed:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold);
            label7.ForeColor = Color.White;
            label7.Location = new Point(68, 356);
            label7.Name = "label7";
            label7.Size = new Size(159, 45);
            label7.TabIndex = 7;
            label7.Text = "Position:";
            // 
            // txtName
            // 
            txtName.Location = new Point(253, 118);
            txtName.Name = "txtName";
            txtName.Size = new Size(310, 39);
            txtName.TabIndex = 8;
            // 
            // txtGoals
            // 
            txtGoals.Location = new Point(363, 211);
            txtGoals.Name = "txtGoals";
            txtGoals.Size = new Size(200, 39);
            txtGoals.TabIndex = 9;
            // 
            // txtAssists
            // 
            txtAssists.Location = new Point(363, 266);
            txtAssists.Name = "txtAssists";
            txtAssists.Size = new Size(200, 39);
            txtAssists.TabIndex = 10;
            // 
            // txtMatchesPlayed
            // 
            txtMatchesPlayed.Location = new Point(363, 312);
            txtMatchesPlayed.Name = "txtMatchesPlayed";
            txtMatchesPlayed.Size = new Size(200, 39);
            txtMatchesPlayed.TabIndex = 11;
            // 
            // cboTeam
            // 
            cboTeam.FormattingEnabled = true;
            cboTeam.Items.AddRange(new object[] { "Colombia", "Argentina", "Brazil" });
            cboTeam.Location = new Point(363, 163);
            cboTeam.Name = "cboTeam";
            cboTeam.Size = new Size(200, 40);
            cboTeam.TabIndex = 12;
            // 
            // cboPosition
            // 
            cboPosition.FormattingEnabled = true;
            cboPosition.Items.AddRange(new object[] { "Midfielder", "Striker", "Winger", "Forward", "Left Winger", "Right Winger", "Center-Back", "Full-Back", "Goalkeeper ", "Sweeper ", "Central Midfielder ", "Defensive Midfielder" });
            cboPosition.Location = new Point(363, 357);
            cboPosition.Name = "cboPosition";
            cboPosition.Size = new Size(200, 40);
            cboPosition.TabIndex = 13;
            // 
            // picPlayer
            // 
            picPlayer.BackColor = SystemColors.ButtonFace;
            picPlayer.BorderStyle = BorderStyle.FixedSingle;
            picPlayer.Location = new Point(160, 580);
            picPlayer.Name = "picPlayer";
            picPlayer.Size = new Size(321, 247);
            picPlayer.SizeMode = PictureBoxSizeMode.AutoSize;
            picPlayer.TabIndex = 14;
            picPlayer.TabStop = false;
            // 
            // btnUpload
            // 
            btnUpload.BackColor = Color.IndianRed;
            btnUpload.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnUpload.ForeColor = Color.White;
            btnUpload.Location = new Point(222, 508);
            btnUpload.Name = "btnUpload";
            btnUpload.Size = new Size(216, 46);
            btnUpload.TabIndex = 15;
            btnUpload.Text = "Upload Photo";
            btnUpload.UseVisualStyleBackColor = false;
            btnUpload.Click += btnUpload_Click;
            // 
            // txtUrl
            // 
            txtUrl.Location = new Point(108, 885);
            txtUrl.Name = "txtUrl";
            txtUrl.Size = new Size(444, 39);
            txtUrl.TabIndex = 16;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.IndianRed;
            btnAdd.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAdd.ForeColor = Color.White;
            btnAdd.Location = new Point(728, 204);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(150, 46);
            btnAdd.TabIndex = 17;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.IndianRed;
            btnDelete.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDelete.ForeColor = Color.White;
            btnDelete.Location = new Point(913, 204);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(150, 46);
            btnDelete.TabIndex = 18;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Segoe UI Black", 16F, FontStyle.Bold);
            label8.ForeColor = Color.White;
            label8.Location = new Point(469, 9);
            label8.Name = "label8";
            label8.Size = new Size(474, 59);
            label8.TabIndex = 19;
            label8.Text = "Football Player Cards";
            // 
            // btnDetail
            // 
            btnDetail.BackColor = Color.IndianRed;
            btnDetail.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDetail.ForeColor = Color.White;
            btnDetail.Location = new Point(1090, 204);
            btnDetail.Name = "btnDetail";
            btnDetail.Size = new Size(137, 43);
            btnDetail.TabIndex = 20;
            btnDetail.Text = "Detail";
            btnDetail.UseVisualStyleBackColor = false;
            btnDetail.Click += btnDetail_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Honeydew;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1363, 1088);
            Controls.Add(btnDetail);
            Controls.Add(label8);
            Controls.Add(btnDelete);
            Controls.Add(btnAdd);
            Controls.Add(txtUrl);
            Controls.Add(btnUpload);
            Controls.Add(picPlayer);
            Controls.Add(cboPosition);
            Controls.Add(cboTeam);
            Controls.Add(txtMatchesPlayed);
            Controls.Add(txtAssists);
            Controls.Add(txtGoals);
            Controls.Add(txtName);
            Controls.Add(label7);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)picPlayer).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label7;
        private TextBox txtName;
        private TextBox txtGoals;
        private TextBox txtAssists;
        private TextBox txtMatchesPlayed;
        private ComboBox cboTeam;
        private ComboBox cboPosition;
        private PictureBox picPlayer;
        private Button btnUpload;
        private TextBox txtUrl;
        private Button btnAdd;
        private Button btnDelete;
        private Label label8;
        private Button btnDetail;
    }
}
