using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnDCharacterCreation
{
    class TextEffects
    {
        public void ChoiceColor()
        {
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
        }

        public void MenuColor()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
        }

        public void PlayerColor()
        {
            Console.ForegroundColor = ConsoleColor.Green;
        }

        public void ClearColor()
        {
            Console.ResetColor();
        }

        public void StatsColor()
        {
            Console.ForegroundColor = ConsoleColor.Black;
            Console.BackgroundColor = ConsoleColor.White;
        }
    }
}
