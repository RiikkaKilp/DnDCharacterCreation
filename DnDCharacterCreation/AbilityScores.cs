using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnDCharacterCreation
{
    class AbilityScores : TextEffects
    {
        int[] standardSet = {15, 14, 13, 12, 10, 8 };
        int[] customSet = { };

        //      SELECTED STATS IN THE FOLLOWING ORDER:  STR, DEX, CONST, INT, WIS, CHA      //
        int[] selectionOrder = { };

        bool selectionOkay = false;

        public void ChooseMethod()
        {
            Console.WriteLine("You have the following ability scores: ");
            InfoColor();
            Console.Write("STRENGHT, DEXTERITY, CONSTITUTION, INTELLIGENCE, WISWOM ");
            ClearColor();
            Console.Write("and ");
            InfoColor();
            Console.Write("CHARISMA.\n\n");
            ClearColor();

            Console.WriteLine("They affect the following skills: ");
            InfoColor();
            Console.Write("STRENGHT     ");
            ClearColor();
            Console.Write("affects ");
            InfoColor();
            Console.Write("ATHLETICS\n");
            ClearColor();

            InfoColor();
            Console.Write("DEXTERITY    ");
            ClearColor();
            Console.Write("affects ");
            InfoColor();
            Console.Write("ACROBATICS, STEALTH\n");
            ClearColor();

            InfoColor();
            Console.Write("INTELLIGENCE ");
            ClearColor();
            Console.Write("affects ");
            InfoColor();
            Console.Write("ARCANA, HISTORY, INVESTIGATION, NATURE, RELIGION\n");
            ClearColor();

            InfoColor();
            Console.Write("WISDOM       ");
            ClearColor();
            Console.Write("affects ");
            InfoColor();
            Console.Write("ANIMAL HANDLING, INSIGHT, MEDICINE, PERCEPTION, SURVIVAL\n");
            ClearColor();

            InfoColor();
            Console.Write("CHARISMA     ");
            ClearColor();
            Console.Write("affects ");
            InfoColor();
            Console.Write("DECEPTION, INTIMIDATION, PERFORMANCE, PERSUASION\n\n");
            ClearColor();
            /*
             *         //STR based:
        int athletics;
        //DEX based:
        int acrobatics, stealth;
        //INT based:
        int arcana, history, investigation, nature, religion;
        //WIS based:
        int animalHandling, insight, medicine, perception, survival;
        //CHA based:
        int deception, intimidation, performance, persuasion;
             */

            //        int strength = 11, dexterity = 11, constitution = 11, intelligence = 11, wisdom = 11, charisma = 11;
            Console.WriteLine("Do you want to use the standard score set or roll a custom set?\n");
            Console.Write("Standard set:    ");
            InfoColor();
            Console.WriteLine("15, 14, 13, 12, 10, 8");
            ClearColor();
            Console.Write("Custom set:      ");
            InfoColor();
            Console.WriteLine("Roll D6 4 times, include 3 highest numbers. Repeat for each stat.\n");
            ClearColor();

            while (!selectionOkay)
            {
                MenuColor();
                Console.WriteLine("1. STANDARD SET \n2. ROLL YOUR OWN");

                PlayerColor();
                string input = Console.ReadLine();
                Console.WriteLine();
                int.TryParse(input, out int inputInt);

                ClearColor();

                if (inputInt == 1)
                {

                    int scoreInput;
                    int i = 1;

                    foreach (int item in standardSet)
                    {
                        MenuColor();
                        Console.Write("STRENGHT: ");
                        PlayerColor();
                        scoreInput = Console.Read();

                        Console.WriteLine(i + " " + item);
                        i += 1;
                    }

                    ChoiceColor();
                    Console.WriteLine("STANDARD SET\n");
                    ClearColor();
                    Console.Write("Standard set:    ");
                    InfoColor();
                    Console.WriteLine("15, 14, 13, 12, 10, 8");
                    ClearColor();

                    if (standardSet.Contains(8))
                    {

                    }

                    else
                    {
                        Console.WriteLine();
                    }



                    selectionOkay = true;
                }

                else if (inputInt == 2)
                {
                    selectionOkay = false;
                }

                else
                {
                    Console.WriteLine("Please check your input.");
                    selectionOkay = false;
                }
            }
        }

        public void StandardSet()
        {
            Console.WriteLine("");
        }

        public void CustomSet()
        {

        }
    }
}
