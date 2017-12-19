using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnDCharacterCreation
{
    class SelectClass : TextEffects
    {

        //      LIST OF CLASSES       //
        string[] allClasses = { "Barbarian", "Bard", "Cleric", "Druid", "Fighter", "Monk", "Paladin", "Ranger", "Rogue", "Sorcerer", "Warlock", "Wizard" };

        //      THE CHOSEN CLASS     //
        public static string CHOSENCLASS;

        int classNumber;

        public void ClassSelection()
        {
            Console.WriteLine("Please input the number of the selected class.");
            Console.WriteLine("List of the available classes: \n");

            int i = 1;

            foreach (string item in allClasses)
            {
                MenuColor();
                Console.WriteLine(i + " " + item);
                i += 1;
            }

            ClearColor();

            bool classSelected = false;

            while (!classSelected)
            {
                PlayerColor();
                string input = Console.ReadLine();
                Console.WriteLine();
                int.TryParse(input, out classNumber);


                ClearColor();

                if (classNumber > allClasses.Length || classNumber <= 0)
                {
                    ErrorColor();
                    Console.WriteLine("Please check your input.");
                    ClearColor();
                    classSelected = false;
                }

                else
                {
                    classNumber -= 1;

                    Console.WriteLine("Is the class " + allClasses[classNumber] + " okay?");

                    MenuColor();
                    Console.WriteLine("1 YES \n2 NO");

                    PlayerColor();
                    input = Console.ReadLine();
                    Console.WriteLine();
                    int.TryParse(input, out int inputInt);


                    ClearColor();

                    input.ToUpper();

                    if (inputInt == 1)
                    {
                        CHOSENCLASS = allClasses[classNumber];
                        Console.WriteLine("Your character's class is now " + CHOSENCLASS + ".\n");
                        classSelected = true;
                        ClassCharacteristics();
                    }

                    else if (inputInt == 2)
                    {
                        classSelected = false;
                    }

                    else
                    {
                        ErrorColor();
                        Console.WriteLine("Please check your input.");
                        ClearColor();
                        classSelected = false;
                    }
                }

            }

        }

        public void ClassCharacteristics()
        {
            switch (CHOSENCLASS)
            {
                case "Barbarian":
                    break;
                case "Bard":
                    break;
                case "Cleric":
                    break;
                case "Druid":
                    break;
                case "Fighter":
                    break;
                case "Monk":
                    break;
                case "Paladin":
                    break;
                case "Ranger":
                    break;
                case "Rogue":
                    break;
                case "Sorcerer":
                    break;
                case "Warlock":
                    break;
                case "Wizard":
                    break;

            }
        }
    }
}
