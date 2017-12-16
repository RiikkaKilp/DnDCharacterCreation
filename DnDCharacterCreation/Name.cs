using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnDCharacterCreation
{
    class Name
    {
        public string newName;
        public string name;

        public void SetName()
        {
            bool nameOkay = false;

            while (!nameOkay)
            {
                Console.WriteLine("----- INPUT NAME -----");
                newName = Console.ReadLine();
                Console.WriteLine("Is the name " + newName + " okay?");

                Console.WriteLine("YES \n NO");
                string input = Console.ReadLine();
                input.ToUpper();

                if (input == "YES")
                {
                    Console.WriteLine("Yout character is named " + newName + ".");
                    nameOkay = true;
                }

                else if (input == "NO")
                {
                    nameOkay = false;
                }

                else
                {
                    Console.WriteLine("Please check your input.");
                    nameOkay = false;
                }
            }
        }

        public string GetName(string name)
        {
            name = newName;
            return name;
        }
    }
}
