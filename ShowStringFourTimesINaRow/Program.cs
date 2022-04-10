using System;

namespace ShowStringFourTimesINaRow
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter any word and press ENTER...");
            string text = Console.ReadLine();
            PrintString(text);
            Console.ReadLine();
        }

        
        public static string PrintString(string text)
        {
            string result = (text + text + text + text);
            Console.WriteLine(result);
            return result;
        }
    }
}
