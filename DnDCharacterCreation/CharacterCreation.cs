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

            Race race = new Race();
            SelectClass classSelect = new SelectClass();
            Name name = new Name();
            Dice roll = new Dice();
            PrintStats stats = new PrintStats();

            Console.WriteLine("Hello, and welcome to the Dungeons & Dragons 5th Edition Character Creation app!");

            ChoiceColor();
            Console.WriteLine("CHOOSING A NAME\n");
            ClearColor();
            name.SetName();

            ChoiceColor();
            Console.WriteLine("CHOOSING A RACE\n");
            ClearColor();
            race.RaceSelection();

            ChoiceColor();
            Console.WriteLine("CHOOSING A CLASS\n");
            ClearColor();
            classSelect.ClassSelection();

            Console.WriteLine("Let's print the stats.");
            stats.GetStats();
            
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
        }
    }
}
