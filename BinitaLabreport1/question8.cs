using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinitaLabreport1
{
    internal class question8
    {
        static void Main()
        {
            Console.Write("Enter a string: ");
            string input = Console.ReadLine();
            string reversedString = string.Empty;
            for (int i = input.Length - 1; i >= 0; i--)
            {
                reversedString += input[i];
            }
            Console.WriteLine($"Reversed string: {reversedString}");
            Console.ReadKey();
            Console.Read();
        }
    }
}


