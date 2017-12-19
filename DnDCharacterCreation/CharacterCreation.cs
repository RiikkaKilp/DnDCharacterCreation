using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnDCharacterCreation
{
    class CharacterCreation : TextEffects
    {
        public void Start()
        {
            bool running = true;

            Race race = new Race();
            SelectClass classSelect = new SelectClass();
            Name name = new Name();
            Dice roll = new Dice();
            PrintStats stats = new PrintStats();
            AbilityScores abScores = new AbilityScores();

            ClearColor();

            Console.WriteLine("Hello, and welcome to the Dungeons & Dragons 5th Edition Character Creation app!");

            while (running)
            {                
                Console.WriteLine("What do you want to set?");

                MenuColor();
                Console.WriteLine("1 NAME\n2 RACE\n3 CLASS\n4 ABILITY SCORES\n5 SHOW STATS\n6 EXIT");

                PlayerColor();
                string input = Console.ReadLine();
                Console.WriteLine();
                int.TryParse(input, out int inputInt);

                ClearColor();

                switch (inputInt)
                {
                    case 1: // CHOOSE A NAME
                        ChoiceColor();
                        Console.WriteLine("CHOOSING A NAME\n");
                        ClearColor();
                        name.SetName();
                        break;
                    case 2: // CHOOSE A RACE
                        ChoiceColor();
                        Console.WriteLine("CHOOSING A RACE\n");
                        ClearColor();
                        race.RaceSelection();
                        break;
                    case 3: // CHOOSE A CLASS
                        ChoiceColor();
                        Console.WriteLine("CHOOSING A CLASS\n");
                        ClearColor();
                        classSelect.ClassSelection();
                        break;
                    case 4: // ROLL STATS
                        ClearColor();
                        ChoiceColor();
                        Console.WriteLine("ROLLING STATS\n");
                        ClearColor();
                        ClearColor();
                        abScores.ChooseMethod();
                        break;
                    case 5: // PRINT STATS
                        Console.WriteLine("PRINT STATS\n");
                        stats.GetStats();
                        break;
                    case 6:
                        ; // EXIT PROGRAM
                        Console.WriteLine("EXIT PROGRAM\n");
                        running = false;
                        break;
                    default:
                        ErrorColor();
                        Console.WriteLine("Please check your input.");
                        ClearColor();
                        break;
                }
            }
        }
    }
}

//         Console.WriteLine("Try rolling some dice");
//         Console.WriteLine("Let's roll a D4");
//         bool doit;
//
//         while (doit = true)
//         {
//             for (int i = 0; i < 5; i++)
//             {
//                 int nRolled = roll.D4();
//                 Console.WriteLine("You got a " + nRolled);
//                 Console.WriteLine(i);
//             }
//
//             Console.WriteLine("Roll again? \n 1. yes, let's continue \n 2. no, please no more");
//             string input = Console.ReadLine();
//             int choice;
//             int.TryParse(input, out choice);
//             
//             switch (choice)
//             {
//                 case 1:
//                     Console.WriteLine("Let's roll again");
//                     doit = true;
//                     break;
//                 case 2:
//                     Console.WriteLine("That's enough.");
//                     doit = false;
//                     break;
//                 default:
//                     Console.WriteLine("Sorry I can't understand");
//                     break;
//           }
//         }
