using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnDCharacterCreation
{
    class AbilityScores : TextEffects
    {
        string[] abilities = { "STRENGHT", "DEXTERITY", "CONSTITUTION", "INTELLIGENCE", "WISWOM", "CHARISMA" };
        int[] standardSet = {15, 14, 13, 12, 10, 8 };
        int[] customSet = {0, 0, 0, 0, 0, 0 };

        //      SELECTED STATS IN THE FOLLOWING ORDER:  STR, DEX, CONST, INT, WIS, CHA, null      //
        public static int[] SKILLS = {0, 0, 0, 0, 0, 0};

        bool selectionOkay = false;
        int scoreInput;

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
            Console.Write("CONSTITUTION ");
            ClearColor();
            Console.Write("affects ");
            InfoColor();
            Console.Write("HIT POINT TOTAL\n");
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
                    StandardSet();
                    selectionOkay = true;
                }

                else if (inputInt == 2)
                {
                    StandardSet();
                    selectionOkay = true;
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
            selectionOkay = false;

            foreach (string item in abilities)
            {
                int i = 0;
                while (!selectionOkay && i < abilities.Length)
                {

                    ClearColor();
                    Console.Write("Select a value from the following list ");
                    MenuColor();

                    int i1 = 0;
                    foreach (int var in standardSet)
                    {
                        MenuColor();
                        Console.Write(var + " ");
                        ClearColor();
                    }
                    ClearColor();

                    Console.WriteLine();

                    MenuColor();
                    Console.Write(abilities[i] + " ");
                    PlayerColor();

                    string input = Console.ReadLine();
                    ClearColor();
                    int.TryParse(input, out scoreInput);

                    if (standardSet.Contains(scoreInput))
                    {
                        //save scoreinput oikeaan paikkaan SKILL arrayssa
                        SKILLS[i] = scoreInput;

                        int numToRemove = scoreInput;
                        int numIndex = Array.IndexOf(standardSet, numToRemove);
                        standardSet = standardSet.Where((val, idx) => idx != numIndex).ToArray();

                        i1 += 1;
                        i += 1;
                    }
                    else
                    {
                        Console.WriteLine("Please check your input.");
                    }

                    if (i == abilities.Length)
                    {
                        selectionOkay = true;
                    }
                }
            }

            Console.WriteLine("\nAbility scores set.\n");
        }

        public void RollScore()
        {
            Dice roll = new Dice();

            Console.WriteLine("Rolling ");
            InfoColor();
            Console.Write(" D6 4 times and taking the 3 highest numbers.\n");
            ClearColor();

            for (int six = 6)
            {

            }
            int iRoll = roll.D6();
        }

        public void CustomSet()
        {

            {
                selectionOkay = false;

                foreach (string item in abilities)
                {
                    int i = 0;
                    while (!selectionOkay && i < abilities.Length)
                    {

                        ClearColor();
                        Console.Write("Select a value from the following list ");
                        MenuColor();

                        int i1 = 0;
                        foreach (int var in customSet)
                        {
                            MenuColor();
                            Console.Write(var + " ");
                            ClearColor();
                        }
                        ClearColor();

                        Console.WriteLine();

                        MenuColor();
                        Console.Write(abilities[i] + " ");
                        PlayerColor();

                        string input = Console.ReadLine();
                        ClearColor();
                        int.TryParse(input, out scoreInput);

                        if (customSet.Contains(scoreInput))
                        {
                            //save scoreinput oikeaan paikkaan SKILL arrayssa
                            SKILLS[i] = scoreInput;

                            int numToRemove = scoreInput;
                            int numIndex = Array.IndexOf(customSet, numToRemove);
                            customSet = customSet.Where((val, idx) => idx != numIndex).ToArray();

                            i1 += 1;
                            i += 1;
                        }
                        else
                        {
                            Console.WriteLine("Please check your input.");
                        }

                        if (i == abilities.Length)
                        {
                            selectionOkay = true;
                        }
                    }
                }

                Console.WriteLine("\nAbility scores set.\n");
            }
        }
    }
}
