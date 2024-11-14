using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assign3
{
    public partial class Detail : Form
    {
        public Detail(Player selectedPlayer)
        {
            InitializeComponent();

            lblName.Text = selectedPlayer.Name;
            lblTeam.Text = selectedPlayer.Team;
            lblGoals.Text = selectedPlayer.Goals.ToString();
            lblAssists.Text = selectedPlayer.Assists.ToString();
            lblMatchesPlayed.Text = selectedPlayer.MatchesPlayed.ToString();
            lblPosition.Text = selectedPlayer.Position;
            picPhoto.Image = selectedPlayer.Photo;

            this.BackColor = GetBackgroundColorForTeam(selectedPlayer.Team);
        }

        private Color GetBackgroundColorForTeam(string team)
        {
            var teamColors = new Dictionary<string, Color>(StringComparer.OrdinalIgnoreCase)
            {
                { "Colombia", Color.LemonChiffon },
                { "Brazil", Color.DarkSeaGreen },
                { "Argentina", Color.LightBlue }
            };

            if (string.IsNullOrWhiteSpace(team))
            {
                return Color.White; 
            }

            return teamColors.TryGetValue(team, out var color) ? color : Color.White;
        }
    }
}


