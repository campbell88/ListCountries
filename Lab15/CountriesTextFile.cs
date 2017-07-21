using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Lab15
{
    class CountriesTextFile: Program
    {
        public static void WriteToFile(string input)
        {
            StreamWriter sw = new StreamWriter("../../countries.txt", true);
            sw.WriteLine(input);
            sw.Close();
        }
        public static string ReadFromFile()
        {
            StreamReader rd = new StreamReader("../../countries.txt");
            string FileContent = rd.ReadToEnd();

            rd.Close();

            return FileContent;
        }
        public static void DeleteFile()
        {   //creates list from reading countries txt file
            List<string> lines = File.ReadAllLines("../../countries.txt").ToList();
            //loop used to print all lines with a number attached
            for (int i = 0; i < lines.Count; i++)
            {
                Console.WriteLine((i + 1) + " " + lines[i]);
            }
            //prompts user for input
            Console.Write("Please select a country number: ");
            int delCountry = Convert.ToInt32(Console.ReadLine());
            //removes the line from the countries txt file
            lines.RemoveAt(delCountry - 1);
            //moves everything back to an array
            File.WriteAllLines("../../countries.txt", lines.ToArray());
        }
    }
}
