using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnDCharacterCreation
{
    class Dice
    {

        Random r = new Random();

        public int D4()
        {
            int rolledNumber = r.Next(1, 5);
            return rolledNumber;
        }

        public int D6()
        {
            int rolledNumber = r.Next(1, 7);
            return rolledNumber;
        }

        public int D8()
        {
            int rolledNumber = r.Next(1, 9);
            return rolledNumber;
        }

        public int D10()
        {
            int rolledNumber = r.Next(1, 11);
            return rolledNumber;
        }

        public int D12()
        {
            int rolledNumber = r.Next(1, 13);
            return rolledNumber;
        }

        public int D20()
        {
            int rolledNumber = r.Next(1, 21);
            return rolledNumber;
        }
    }
}
