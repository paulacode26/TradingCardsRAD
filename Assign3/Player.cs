using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Assign3
{
    public class Player
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Team { get; set; }
        public int Goals { get; set; }
        public int Assists { get; set; }
        public int MatchesPlayed { get; set; }
        public Image? Photo { get; set; }
        public string? Position { get; set; }
        public override bool Equals(object? obj)
        {
            if (obj is Player other)
            {
                return Id == other.Id &&
                       Name == other.Name &&
                       Team == other.Team &&
                       Goals == other.Goals &&
                       Assists == other.Assists &&
                       MatchesPlayed == other.MatchesPlayed &&
                       Photo == other.Photo &&
                       Position == other.Position;
            }
            return false;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Id, Name, Team, Goals, Assists, MatchesPlayed, Photo, Position);
        }
    }
}