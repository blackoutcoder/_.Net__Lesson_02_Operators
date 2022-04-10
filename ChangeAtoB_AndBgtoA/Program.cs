using System;

namespace ChangeAtoB_AndBgtoA
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter A and B and press ENTER...");
            string a = Console.ReadLine();
            string b = Console.ReadLine();
            string c;

            c = a;
            a = b;
            b = c;  
            
            Console.WriteLine($"a = {a}, b = {b}");
            Console.ReadLine();
        }
    }
}
