using System;
using System.Linq;

namespace BinitaLabreport1
{
    internal class queston12
    {
       /* static void Main()
        {
            Console.WriteLine("Enter the number of subjects:");
            int numberOfSubjects = int.Parse(Console.ReadLine());

            int[] marks = InputMarks(numberOfSubjects);

            int minMark = marks.Min();
            int maxMark = marks.Max();
            double averageMark = marks.Average();

            Console.WriteLine($"Minimum Mark: {minMark}");
            Console.WriteLine($"Maximum Mark: {maxMark}");
            Console.WriteLine($"Average Mark: {averageMark:F2}");

            Console.ReadKey();
            Console.Read();
        }*/

        static int[] InputMarks(int numberOfSubjects)
        {
            int[] marks = new int[numberOfSubjects];
            Console.WriteLine("Enter the marks for each subject:");

            for (int i = 0; i < numberOfSubjects; i++)
            {
                Console.Write($"Subject {i + 1}: ");
                marks[i] = int.Parse(Console.ReadLine());
            }

            return marks;

        }

    }
}


