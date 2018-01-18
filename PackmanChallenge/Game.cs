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

            //while (Packman.Lives > 0 || Packman.Points > 0 || GameArray[])
            //{
                if (Packman.Points >= 10000)
                {
                    Packman.Lives++;
                    Packman.CanGainLife = false;
                }

                for (var i = 0; i < 10; i++)
                {
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

                Console.WriteLine("Packman Points: ", Packman.Points);
                    
                }
                
            //}
            
        }

        public static string[] GetGameArray()
        {
            string text = File.ReadAllText(@"../../data.csv");
            string[] stream = text.Split(',');
            return stream;
        }

    }
}
