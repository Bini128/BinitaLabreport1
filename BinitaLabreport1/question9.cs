using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinitaLabreport1
{
    internal class question9
    {
        static void Main()
        {
            Console.Write("Enter a number: ");
            string input = Console.ReadLine();
            int number;
            bool isValidNumber = int.TryParse(input, out number);
            if (isValidNumber)
            {
                if (number % 2 == 0)
                {
                    Console.WriteLine($"{number} is even.");
                }
                else
                {
                    Console.WriteLine($"{number} is odd.");
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid integer.");
            }
            Console.ReadKey();
            Console.Read();
        }
    }
}
