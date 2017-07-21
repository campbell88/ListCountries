using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab15
{
    class ValidateConsoleInput
    {
        public static int GetIntWithinRange()
        {
            int Min = 1;
            int Max = 4;
            int value;

            while (true)
            {
                if (!Int32.TryParse(Console.ReadLine(), out value))
                {
                    Console.Write("Please enter a valid number between 1 and 4:");
                }
                else if (value < Min || value > Max)
                {
                    Console.Write("Please enter a valid input year between {0} and {1}: ", Min, Max);
                }
                else
                {
                    break;
                }
            }
            return value;
        }

    }
}
