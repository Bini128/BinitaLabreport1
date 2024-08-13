using System;
namespace BinitaLabreport1
{
    internal class question13
    {
        static void Main()
        {
            string[] stringArray = { "Please", "Donot", "throw", "sausage", "pizza","away" };
            string resultString = ConvertArrayToString(stringArray, " ");
            Console.WriteLine("The combined string is:");
            Console.WriteLine(resultString);
            Console.ReadKey();
            Console.Read();
        }

        static string ConvertArrayToString(string[] array, string separator)
        {
            return string.Join(separator, array);
        }
    }
}


