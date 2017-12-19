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
        
        // CHOSEN_BUG
        //int[] chosenSet;

        bool selectionOkay = false;

        //      SELECTED STATS IN THE FOLLOWING ORDER:  STR, DEX, CONST, INT, WIS, CHA, null      //
        public static int[] SKILLS = {0, 0, 0, 0, 0, 0};

        int scoreInput;

        public void ChooseMethod()
        {
            selectionOkay = false;

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
                    // CHOSEN-BUG
                    //chosenSet = standardSet;
                    SettingStandard();
                    selectionOkay = true;
                }

                else if (inputInt == 2)
                {
                    // CHOSEN-BUG
                    //chosenSet = customSet;
                    RollScore();
                    SettingCustom();
                    selectionOkay = true;
                }

                else
                {
                    ErrorColor();
                    Console.WriteLine("Please check your input.");
                    ClearColor();
                    selectionOkay = false;
                }

            }
        }

        public void SettingStandard()
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
                    // CHOSEN-BUG
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

                    // CHOSEN-BUG
                    if (standardSet.Contains(scoreInput))
                    {
                        //save scoreinput oikeaan paikkaan SKILL arrayssa
                        SKILLS[i] = scoreInput;

                        int numToRemove = scoreInput;
                        int numIndex = Array.IndexOf(standardSet, numToRemove);
                        // CHOSEN-BUG
                        standardSet = standardSet.Where((val, idx) => idx != numIndex).ToArray();

                        i1 += 1;
                        i += 1;
                    }
                    else
                    {
                        ErrorColor();
                        Console.WriteLine("Please check your input.");
                        ClearColor();
                    }

                    if (i == abilities.Length)
                    {
                        selectionOkay = true;
                    }
                }
            }

            Console.WriteLine("\nAbility scores set.\n");
        }

        public void SettingCustom()
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

                    // CHOSEN-BUG
                    if (customSet.Contains(scoreInput))
                    {
                        //save scoreinput oikeaan paikkaan SKILL arrayssa
                        SKILLS[i] = scoreInput;

                        int numToRemove = scoreInput;
                        int numIndex = Array.IndexOf(customSet, numToRemove);
                        //CHOSEN-BUG
                        customSet = customSet.Where((val, idx) => idx != numIndex).ToArray();

                        i1 += 1;
                        i += 1;
                    }
                    else
                    {
                        ErrorColor();
                        Console.WriteLine("Please check your input.");
                        ClearColor();
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

            InfoColor();
            Console.WriteLine("Rolling D6 4 times and taking the 3 highest numbers. \n");
            ClearColor();

            int setNumber = 1;

            for (int i = 0; i < 6; i++)
            {
                int rollTotal = 0;

                int roll1, roll2, roll3, roll4;
                
                roll1 = roll.D6();
                roll2 = roll.D6();
                roll3 = roll.D6();
                roll4 = roll.D6();
           
                int[] allRolls = { roll1, roll2, roll3, roll4 };
           
                int smallestRoll = allRolls.Min();
           
                rollTotal = allRolls.Sum() - smallestRoll;

                InfoColor();
                Console.Write(" #" + setNumber + ". ");
                ClearColor();
                Console.Write("Got numbers: ");
                MenuColor();
                Console.WriteLine(+roll1 + ", " + roll2 + ", " + roll3 + ", " + roll4 + ". Excluding " + smallestRoll);
                ClearColor();

                setNumber++;
                customSet[i] = rollTotal;
            }

            Console.WriteLine();
        }

        public void SetSkills()
        {
            //  STR based:
            //int athletics;
            //  DEX based:
            //int acrobatics, stealth;
            //  INT based:
            //int arcana, history, investigation, nature, religion;
            //  WIS based:
            //int animalHandling, insight, medicine, perception, survival;
            //  CHA based:
            //int deception, intimidation, performance, persuasion;

            //      1       − 5
            //      2–3     − 4
            //      4–5     − 3
            //      6–7     − 2
            //      8–9     − 1
            //      10–11   + 0
            //      12–13   + 1
            //      14–15   + 2
            //      16–17   + 3
            //      18–19   + 4
            //      20–21   + 5
            //      22–23   + 6
            //      24–25   + 7
            //      26–27   + 8
            //      28–29   + 9
            //      30      + 10
        }
    }
}
