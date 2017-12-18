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
            Console.WriteLine("│   NAME: " + Name.NAME +  "                                ");
            Console.WriteLine("│                                               │");
            Console.WriteLine("│   RACE: " + Race.RACE + "      CLASS: " + SelectClass.CHOSENCLASS + "      ");
            Console.WriteLine("│                                               │");
            Console.WriteLine("│   STR: " + strength + " DEX: " + dexterity + " CONST: " + constitution + "             ");
            Console.WriteLine("│                                               │");
            Console.WriteLine("│   INT: " + intelligence + " WIS: " + wisdom + " CHA: " + charisma + "               ");
            Console.WriteLine("│                                               │");
            Console.WriteLine("│                                               │");
            Console.WriteLine("│                                               │");
            Console.WriteLine("│                                               │");
            Console.WriteLine("│                                               │");
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
    }
}
