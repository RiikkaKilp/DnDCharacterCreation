﻿using System;
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

        public void InfoColor()
        {
            //Console.ForegroundColor = ConsoleColor.Blue;
            Console.ForegroundColor = ConsoleColor.DarkCyan;
        }

        public void ClearColor()
        {
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Gray;
        }

        public void StatsColor()
        {
            Console.ForegroundColor = ConsoleColor.White;
            //Console.BackgroundColor = ConsoleColor.White;
        }

        public void ErrorColor()
        {
            Console.ForegroundColor = ConsoleColor.Red;
        }
    }
}
