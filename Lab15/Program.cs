using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Lab15
{
    class Program
    {
        static void Main(string[] args)
        {   //bool value for do while loop
            bool run = true;

            Console.WriteLine("Welcome to the Countires Maintenance Application!");

            do
            {   //prompts user for which type of action they would like to take
                Console.WriteLine("Enter 1 for the list of countries");
                Console.WriteLine("Enter 2 to add a country");
                Console.WriteLine("Enter 2 to delete a country");
                Console.WriteLine("Enter 4 to Exit");
                Console.Write("\nEnter number here:");
                int input = ValidateConsoleInput.GetIntWithinRange();
                //passing intput and bool value into get choice method
                run = GetChoice(input, run);

                Console.WriteLine("\n");

            } while (run == true);
            //end message
            Console.WriteLine("Thank you for using the application!");
        }

        public static bool GetChoice(int input, bool run)
        {   //takes input method and selects what type of action the program takes
            if (input == 1)
            {   //calles read method in Textfile class
                CountriesTextFile.ReadFromFile();
            }
            if (input == 2)
            {   //prompts the user to enter a country value to add to the list
                Console.WriteLine("Enter country: ");
                string newcountry = Console.ReadLine();
                //passes input into writefile method
                CountriesTextFile.WriteToFile(newcountry);

                Console.WriteLine("This country has been saved!");
            }
            if (input == 3)
            {   //calls delete file method
                CountriesTextFile.DeleteFile();
            }
            if (input == 4)
            {   //ends do/while loop
                run = false;
            }
            return run;
        }
    }
}

