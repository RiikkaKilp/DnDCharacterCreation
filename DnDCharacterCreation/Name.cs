using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnDCharacterCreation
{
    class Name : TextEffects
    {
        //      THE CHOSEN NAME     //
        public static string NAME;

        public void SetName()
        {
            bool nameOkay = false;

            while (!nameOkay)
            {
                MenuColor();
                Console.WriteLine("INPUT A NAME:");

                PlayerColor();
                NAME = Console.ReadLine();
                Console.WriteLine();

                ClearColor();
                Console.WriteLine("Is the name " + NAME + " okay?");

                MenuColor();
                Console.WriteLine("1 YES \n2 NO");

                PlayerColor();
                string input = Console.ReadLine();
                Console.WriteLine();
                int.TryParse(input, out int inputInt);

                ClearColor();

                if (inputInt == 1)
                {
                    Console.WriteLine("Your character is named " + NAME + ".\n");
                    nameOkay = true;
                }

                else if (inputInt == 2)
                {
                    nameOkay = false;
                }

                else
                {
                    Console.WriteLine("Please check your input.");
                    nameOkay = false;
                }
            }
        }

    }
}
