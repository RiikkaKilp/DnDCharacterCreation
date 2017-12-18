using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnDCharacterCreation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Dungeons & Dragons 5th edition Character Creation";
            CharacterCreation start = new CharacterCreation();
            start.Start();
        }
    }
}
