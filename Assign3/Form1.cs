using Microsoft.VisualBasic.Logging;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Numerics;
using System.Windows.Forms;

namespace Assign3
{
    public partial class Form1 : Form
    {
        public List<Player> players = Data.GetPlayers();
        public Form1()
        {
            InitializeComponent();

            SetupDataGridView();

            LoadData();

            btnDetail.Enabled = true;
        }

        private void SetupDataGridView()
        {
            dataGridView1.Columns.Clear();

            dataGridView1.Columns.Add("Name", "Player Name");

            DataGridViewImageColumn photoColumn = new DataGridViewImageColumn
            {
                Name = "Photo",
                HeaderText = "Photo",
                Width = 150,
                ImageLayout = DataGridViewImageCellLayout.Zoom
            };
            dataGridView1.Columns.Add(photoColumn);

            dataGridView1.RowTemplate.Height = 100;
        }

        private void LoadData()
        {
            // Fetch player and photo data
            var playerData = from player in players
                             select new
                             {
                                 player.Name,
                                 player.Photo
                             };
           
            foreach (var data in playerData)
            {
                dataGridView1.Rows.Add(data.Name, data.Photo);
            }
        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)| *.jpg; *.jeg; *.gif; *.bmp";
            if (open.ShowDialog() == DialogResult.OK)
            {
                txtUrl.Text = open.FileName;
                picPlayer.Image = new Bitmap(open.FileName);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(txtName.Text))
            {
                MessageBox.Show("Player name is empty.");
                return;
            }

            if (string.IsNullOrEmpty(cboTeam.Text))
            {
                MessageBox.Show("Team is not selected.");
                return;
            }

            if (string.IsNullOrEmpty(txtGoals.Text))
            {
                MessageBox.Show("Goals are not specified.");
                return;
            }

            if (string.IsNullOrEmpty(txtAssists.Text))
            {
                MessageBox.Show("Assists are not specified.");
                return;
            }

            if (string.IsNullOrEmpty(txtMatchesPlayed.Text))
            {
                MessageBox.Show("Matches played are not specified.");
                return;
            }

            if (cboPosition.SelectedItem == null)
            {
                MessageBox.Show("Position is not selected.");
                return;
            }

            if (string.IsNullOrEmpty(txtUrl.Text))
            {
                MessageBox.Show("Image is not uploaded");
                return;
            }

            try
            {
                Player newPlayer = new Player
                {
                    Id = Data.players.Max(p => p.Id) + 1,
                    Name = txtName.Text,
                    Team = cboTeam.SelectedItem.ToString(),
                    Goals = int.Parse(txtGoals.Text),
                    Assists = int.Parse(txtAssists.Text),
                    MatchesPlayed = int.Parse(txtMatchesPlayed.Text),
                    Position = cboPosition.SelectedItem.ToString(),
                    Photo = new Bitmap(txtUrl.Text)
                };
                Data.players.Add(newPlayer);
                LoadData();

                MessageBox.Show("New player added successfully.");

                // Clear the fields:
                txtName.Text = "";
                cboTeam.SelectedIndex = -1;
                txtGoals.Text = "";
                txtAssists.Text = "";
                txtMatchesPlayed.Text = "";
                cboPosition.SelectedIndex = -1;
                txtUrl.Text = "";
                picPlayer.Image = null;  
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while adding the player:{ex.Message}");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];

                string selectedPlayerName = (string)selectedRow.Cells["Name"].Value;

                Player selectedPlayer = players.FirstOrDefault(p => p.Name == selectedPlayerName);

                if (selectedPlayer != null)
                {
                    players.Remove(selectedPlayer); // Remove the player from the players list

                    
                    dataGridView1.Rows.RemoveAt(selectedRow.Index); // Remove the selected row from the DataGridView

                    MessageBox.Show("Player deleted successfully.");
                }
                else
                {
                    MessageBox.Show("Player not found.");
                }
            }
            else
            {
                MessageBox.Show("Please select a player to delete.");
            }
        }

        private void btnDetail_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];

                string selectedPlayerName = (string)selectedRow.Cells["Name"].Value;

                Player selectedPlayer = players.FirstOrDefault(p => p.Name == selectedPlayerName);

                if (selectedPlayer != null)
                {
                    Detail detailForm = new Detail(selectedPlayer);
                    detailForm.Show();
                }
                else
                {
                    MessageBox.Show("Player not found.");
                }
            }
            else
            {
                MessageBox.Show("Please select a player to view the details.");
            }
        }
    }
}
    
