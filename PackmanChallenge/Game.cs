using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PackmanChallenge
{
    public static class Game
    {
        public static void Start()
        {
            var Packman = new Packman();
            var Ghost = new Ghost();
            var GameArray = GetGameArray();

            for (var i = 0; i < GameArray.Length; i++)
            {
                if (Packman.Lives <= 0)
                    break;

                if (Packman.Points >= 10000 && Packman.CanGainLives == true)
                {
                    Packman.Lives++;
                    Packman.LivesGained++;
                    Packman.CanGainLives = false;
                }

                var currentItem = GameArray[i];

                switch (currentItem)
                {
                    case "Dot":
                        Packman.Points += 10;
                        break;
                    case "InvincibleGhost":
                        Packman.Lives -= 1;
                        break;
                    case "VulnerableGhost":
                        Packman.Points += Ghost.BonusFactor;
                        Ghost.BonusFactor *= 2;
                        break;
                    default:
                        var fruit = BonusFruit.Fruit[currentItem];
                        Packman.Points += fruit;
                        break;
                }
            }

            var points = Packman.Points;
            var livesGained = Packman.LivesGained;

            Console.WriteLine($"Packman points: {points}");

        }

        public static string[] GetGameArray()
        {
            string text = File.ReadAllText(@"../../data.csv");
            string[] stream = text.Split(',');
            return stream;
        }

    }
}
