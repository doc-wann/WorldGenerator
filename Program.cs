using System;
using CharacterVars;
using CultureVars;
using CityVars;
using BlockBuilder;
using AuxFuncs;
using PlayerManager;
using PlayerManager;

namespace WorldGenerator
{
    internal class Program
    {
        public static PlayerCharacter MC = new PlayerCharacter();
        public static int Seed = DateTime.Now.Microsecond;
        public static List<Culture> cultures = BuilderCulture.CulturesGenerator();
        static void Main(string[] args)
        {
            ChoiceAlpha();
        }

        public static void ChoiceAlpha()
        {
            int choice = AsciiArtsFuncs.ChoiceMenu();

            Auxiliary.ClearConsole();

            if (choice == 1)
            {
                Auxiliary.PrintCharacter(BuilderChar.BuildRandomCharacter());
            }
            else if (choice == 2)
            {
                BlockBuilder.BlockBuilder.BuildMap(100,100,1);
            }
            else if (choice == 3)
            {
                Auxiliary.PrintCity(BuilderCity.BuildRandomCity(cultures));
            }
            else if (choice == 4)
            {
                MC = CharacterCreator.CreateCharacter();
                
                Auxiliary.ClearConsole();
                Auxiliary.PrintCharacterSelf(MC);
            }
            else if (choice == 5)
            {
                Environment.Exit(0);
            }
            else if (choice == 6)
            {
                MusicPlayer.PlayMusic(MusicPlayer.StartMusic);
            }
            else if (choice == 7)
            {
                MusicPlayer.StopMusic();
            }
            else if (choice == 8)
            {
                ChoiceCombat();
            }

            ChoiceAlpha();
        }
        public static void ChoiceCombat()
        {
            int choice = AsciiArtsFuncs.CombatMenu();
            Auxiliary.ClearConsole();

            if (choice == 1)
            {
                Console.WriteLine("You attack!");
                MusicPlayer.HitSoundMalePlay();
            }
            else if (choice == 2)
            {
                Console.WriteLine("You defend!");
            }
            else if (choice == 3)
            {
                Console.WriteLine("You check your sheet!");
                Auxiliary.ClearConsole();
                Auxiliary.PrintCharacterSelf(MC);
            }
            else if (choice == 4)
            {
                Console.WriteLine("You run!");
            }

            Auxiliary.ClearConsoleAsk();

            ChoiceCombat();
        }
        public static int UpdateSeed()
        {
            Seed += DateTime.Now.Microsecond;
            return Seed;
        }
    
        public ActionResult ActionResultCalculator (Action Selected)
        {
            ActionResult Returnable = new ActionResult();
            foreach (Dictionary<int, int> damage in Selected.damage)
            {
                foreach (KeyValuePair<int, int> dice in damage)
                {
                    int dicetoroll = dice.Key;
                    int dicesize = dice.Value;

                    for (int i = 0; i < dicetoroll; i++)
                    {
                        Returnable.damage += new Random().Next(1, dicesize);
                    }
                }
            }
            Returnable.toHit = Selected.toHit;
            Returnable.type = Selected.type;

            return Returnable;
        }
    }
}