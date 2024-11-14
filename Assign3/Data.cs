using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Assign3
{
    public static class Data
    {
        public static List<Player> players = new List<Player>();

        // Method to return existing players
        public static List<Player> GetPlayers()
        {
            // Si la lista está vacía, agregar jugadores predeterminados
            if (players.Count == 0)
            {
                string imagesFolderPath = @"C:\Users\paula\OneDrive\Escritorio\Paula\Software Development\level 3\SODV2101-Rapid Application Development\Assignment 3\Assign3\Assign3\Images\";

                AddDefaultPlayers(imagesFolderPath);
            }

            return players;
        }

        // Adds default players
        private static void AddDefaultPlayers(string imagesFolderPath)
        {
            Player player = new Player
            {
                Id = 1,
                Name = "James Rodriguez",
                Team = "Colombia",
                Goals = 10,
                Assists = 8,
                MatchesPlayed = 50,
                Photo = Image.FromFile(imagesFolderPath + "james.jpg"), // Path to the player's photo
                Position = "Midfielder"
            };
            players.Add(player);

            player = new Player
            {
                Id = 2,
                Name = "Radamel Falcao",
                Team = "Colombia",
                Goals = 35,
                Assists = 12,
                MatchesPlayed = 75,
                Photo = Image.FromFile(imagesFolderPath + "falcao.jpg"),
                Position = "Striker"
            };
            players.Add(player);

            player = new Player
            {
                Id = 3,
                Name = "Juan Cuadrado",
                Team = "Colombia",
                Goals = 18,
                Assists = 22,
                MatchesPlayed = 60,
                Photo = Image.FromFile(imagesFolderPath + "cuadrado.jpg"),
                Position = "Winger"
            };
            players.Add(player);

            player = new Player
            {
                Id = 4,
                Name = "Lionel Messi",
                Team = "Argentina",
                Goals = 85,
                Assists = 40,
                MatchesPlayed = 100,
                Photo = Image.FromFile(imagesFolderPath + "messi.jpg"),
                Position = "Forward"
            };
            players.Add(player);

            player = new Player
            {
                Id = 5,
                Name = "Sergio Aguero",
                Team = "Argentina",
                Goals = 45,
                Assists = 15,
                MatchesPlayed = 60,
                Photo = Image.FromFile(imagesFolderPath + "sergio.jpg"),
                Position = "Striker"
            };
            players.Add(player);

            player = new Player
            {
                Id = 6,
                Name = "Angel Di Maria",
                Team = "Argentina",
                Goals = 20,
                Assists = 25,
                MatchesPlayed = 55,
                Photo = Image.FromFile(imagesFolderPath + "angel.jpg"),
                Position = "Winger"
            };
            players.Add(player);

            player = new Player
            {
                Id = 7,
                Name = "Neymar da Silva",
                Team = "Brazil",
                Goals = 70,
                Assists = 30,
                MatchesPlayed = 90,
                Photo = Image.FromFile(imagesFolderPath + "neymar.jpg"),
                Position = "Forward"
            };
            players.Add(player);

            player = new Player
            {
                Id = 8,
                Name = "Philippe Coutinho",
                Team = "Brazil",
                Goals = 18,
                Assists = 14,
                MatchesPlayed = 50,
                Photo = Image.FromFile(imagesFolderPath + "philippe.jpg"),
                Position = "Midfielder"
            };
            players.Add(player);

            player = new Player
            {
                Id = 9,
                Name = "Gabriel Jesus",
                Team = "Brazil",
                Goals = 25,
                Assists = 20,
                MatchesPlayed = 60,
                Photo = Image.FromFile(imagesFolderPath + "gabriel.jpg"),
                Position = "Striker"
            };
            players.Add(player);

            player = new Player
            {
                Id = 10,
                Name = "Carlos Henrique",
                Team = "Brazil",
                Goals = 10,
                Assists = 5,
                MatchesPlayed = 65,
                Photo = Image.FromFile(imagesFolderPath + "casemiro.jpg"),
                Position = "Defensive Midfielder"
            };
            players.Add(player);
        }
    }
}