using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinitaLabreport1
{
    internal class question2
    {
        static void Main()
        {
            int num1, num2, num3;
            Console.Write("Enter the first integer: ");
            while (!int.TryParse(Console.ReadLine(), out num1))
            {
                Console.Write("Invalid input. Please enter a valid integer: ");
            }
            Console.Write("Enter the second integer: ");
            while (!int.TryParse(Console.ReadLine(), out num2))
            {
                Console.Write("Invalid input. Please enter a valid integer: ");
            }
            Console.Write("Enter the third integer: ");
            while (!int.TryParse(Console.ReadLine(), out num3))
            {
                Console.Write("Invalid input. Please enter a valid integer: ");
            }
            int sum = num1 + num2 + num3;
            Console.WriteLine($"The sum of {num1}, {num2}, and {num3} is {sum}.");
            Console.ReadKey();
            Console.Read();
        }
    }
}

