using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnDCharacterCreation
{
    class Race : TextEffects, IBonuses
    {

        //      LIST OF RACES       //
        string[] allRaces = { "Dragonborn", "Drawf", "Elf", "Half-Elf", "Half-Orc", "Halfling", "Human", "Thiefling" };

        //      THE CHOSEN RACE     //
        public string RACE;

        int raceNumber;
        int inputInt;

        public void RaceSelection()
        {
            Console.WriteLine("Please input the number of the selected race.");
            Console.WriteLine("List of the available races:");

            int i = 1;

            MenuColor();

            foreach (string item in allRaces)
            {
                Console.WriteLine(i + " " + item);
                i += 1;
            }

            ClearColor();

            bool raceSelected = false;

            while (!raceSelected)
            {
                PlayerColor();
                string input = Console.ReadLine();
                Console.WriteLine();
                int.TryParse(input, out raceNumber);

                ClearColor();

                if (raceNumber > allRaces.Length || raceNumber <= 0)
                {
                    Console.WriteLine("Please check your input.");
                    raceSelected = false;
                }

                else
                {
                    raceNumber -= 1;

                    Console.WriteLine("Is the race " + allRaces[raceNumber] + " okay?");

                    MenuColor();
                    Console.WriteLine("1 YES \n2 NO");

                    PlayerColor();
                    input = Console.ReadLine();
                    Console.WriteLine();
                    int.TryParse(input, out inputInt);

                    ClearColor();

                    input.ToUpper();

                    if (inputInt == 1)
                    {
                        RACE = allRaces[raceNumber];
                        Console.WriteLine("Your character's race is now " + RACE + ".\n");
                        raceSelected = true;
                        RaceCharacteristics();
                    }

                    else if (inputInt == 2)
                    {
                        raceSelected = false;
                    }

                    else
                    {
                        Console.WriteLine("Please check your input.");
                        raceSelected = false;
                    }
                }
                
            }

        }

        public void RaceCharacteristics()
        {
            switch (RACE)
            {
                case "Dragonborn":
                    break;
                case "Dwarf":
                    break;
                case "Elf":
                    break;
                case "Half-Elf":
                    break;
                case "Half-Orc":
                    break;
                case "Halfling":
                    break;
                case "Human":
                    break;
                case "Thiefling":
                    break;

            }
        }

        public void SetHeight()
        {
            throw new NotImplementedException();
        }

        public void SetSpeed()
        {
            throw new NotImplementedException();
        }

        public void SetWeight()
        {
            throw new NotImplementedException();
        }
    }
}
