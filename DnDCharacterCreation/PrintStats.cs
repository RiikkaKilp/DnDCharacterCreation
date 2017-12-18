using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnDCharacterCreation
{
    class PrintStats : TextEffects
    {
        //      ABILITY SCORES AND SKILLS     //
        int strength = 11, dexterity = 11, constitution = 11, intelligence = 11, wisdom = 11, charisma = 11;

        //STR based:
        int athletics;
        //DEX based:
        int acrobatics, stealth;
        //INT based:
        int arcana, history, investigation, nature, religion;
        //WIS based:
        int animalHandling, insight, medicine, perception, survival;
        //CHA based:
        int deception, intimidation, performance, persuasion;

        Name n = new Name();
        Race r = new Race();

        public void GetStats()
        {
            StatsColor();
            Console.WriteLine();
            Console.WriteLine("┌───────────────────────────────────────────────┐");
            Console.WriteLine("│---------------------STATS---------------------│");
            Console.WriteLine("│                                               │");
            Console.WriteLine("│   NAME: " + Name.NAME +  "                                ");
            Console.WriteLine("│                                               │");
            Console.WriteLine("│   RACE: " + Race.RACE + "      CLASS: " + SelectClass.CHOSENCLASS + "      ");
            Console.WriteLine("│                                               │");
            Console.WriteLine("│           ---- ABILITY SCORES ----             ");
            Console.WriteLine("│                                               │");
            Console.WriteLine("│   STR: " + AbilityScores.SKILLS[0] + " DEX: " + AbilityScores.SKILLS[1] + " CONST: " + AbilityScores.SKILLS[2] + "             ");
            Console.WriteLine("│                                               │");
            Console.WriteLine("│   INT: " + AbilityScores.SKILLS[3] + " WIS: " + AbilityScores.SKILLS[4] + " CHA: " + AbilityScores.SKILLS[5] + "               ");
            Console.WriteLine("│                                               │");
            Console.WriteLine("│           -------- SKILLS --------            │");
            Console.WriteLine("│                                               │");
            Console.WriteLine("│   Acrobatics:        " + "  Medicine:             " + " │");
            Console.WriteLine("│   Animal Handling:   " + "  Nature:               " + " │");
            Console.WriteLine("│   Arcana:            " + "  Perception:           " + " │");
            Console.WriteLine("│   Athletics:         " + "  Performance:          " + " │");
            Console.WriteLine("│   Deception:         " + "  Persuasion:           " + " │");
            Console.WriteLine("│   History:           " + "  Religion:             " + " │");
            Console.WriteLine("│   Insight:           " + "  Sleight of Hand:      " + " │");
            Console.WriteLine("│   Intimidation:      " + "  Stealth:              " + " │");
            Console.WriteLine("│   Investigation:     " + "  Survival:             " + " │");
            Console.WriteLine("│                                               │");
            Console.WriteLine("│                                               │");
            Console.WriteLine("│                                               │");
            Console.WriteLine("│                                               │");
            Console.WriteLine("│                                               │");
            Console.WriteLine("│                                               │");
            Console.WriteLine("└───────────────────────────────────────────────┘");
            Console.WriteLine();

            ClearColor();
        }

        public void FillEmpty()
        {
            int nOfMissingEMpty;
            int amountOfCharacters = 2;

            nOfMissingEMpty = 48 - amountOfCharacters;

         //   foreach (nOfMissingEMpty)
         //   {
         //       MenuColor();
         //       Console.Write(var + " ");
         //       ClearColor();
         //   }
            //48 x this
        }
    }
}
