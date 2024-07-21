using System;
using CharacterVars;
using CultureVars;
using CityVars;
using BlockBuilder;
using AuxFuncs;
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
                ChoiceCombat(Enemies.Zombie);
            }

            ChoiceAlpha();
        }

        public static void ChoiceCombat(Enemy enemy)
        {
            int choice = AsciiArtsFuncs.CombatMenu(enemy);
            Auxiliary.ClearConsole();

            if (choice == 1)
            {
                Console.WriteLine("You attack!");
                Action soco = new Action("Soco", "Um soco", 0, 5, new List<Dictionary<int, int>> { new Dictionary<int, int> { { 1, 4 } } }, "Bludgeoning", "Instantaneous");
                enemy.Health -= ActionResultCalculator(soco).damage;
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
                choice = 909;
            }
            else if (choice == 4)
            {
                Console.WriteLine("You run!");
            }

            Auxiliary.ClearConsoleAsk();

            if (enemy.Health <= 0)
            {
                Console.WriteLine("You defeated the enemy!");
                Console.WriteLine($"You got {enemy.LootTable[0]["Gold"]} gold and {enemy.LootTable[0]["Potion: Health"]} Health Potions!");
                return;
            }
            if (choice != 909)
            {
                EnemyTurn(enemy);
            }

            ChoiceCombat(enemy);
        }
        public static int UpdateSeed()
        {
            Seed += DateTime.Now.Microsecond;
            return Seed;
        }

        public static int EnemyTurn(Enemy enemy)
        {
            int Damage = 0;
            int choice = new Random().Next(1, 3);

            if (choice > 0)
            {
                Console.WriteLine($"The enemy attacks with {enemy.Actions[0].Name}!");

                if (Dices.Roll(Dices.D20) + enemy.Actions[0].ToHit >= 10)
                {
                    for (int i = 0; i < enemy.Actions[0].DiceNumber1; i++)
                    {
                        Damage += Dices.Roll(enemy.Actions[0].DiceType1);
                    }

                    Damage += enemy.Actions[0].BonusDamage;
                
                    MusicPlayer.HitSoundMalePlay();

                    MC.HP -= Damage;

                    Console.WriteLine($"You took {Damage} damage! Your HP is now {MC.HP}!");
                }
            }
            return choice;
        }
    
        public static ActionResult ActionResultCalculator (Action Selected)
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