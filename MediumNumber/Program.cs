using System;

namespace MediumNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyReader reader = new MyReader();
            Calculator calculator = new Calculator();

            Console.WriteLine("Enter first number and press ENTER...");
            var number1 = reader.ReadNumber();

            Console.WriteLine("Enter second number and press ENTER...");
            var number2 = reader.ReadNumber();

            Console.WriteLine("Enter third number and press ENTER...");
            var number3 = reader.ReadNumber();

            calculator.PrintAverage(number1, number2, number3);

        }
        public class MyReader
        {
            public double ReadNumber()
            {
                return  Convert.ToDouble(Console.ReadLine());
            }

        }
        public class Calculator
        {
            public bool PrintAverage(double number1, double number2, double number3)  
               {
                double average = (number1 + number2 + number3) / 3;
                Console.Clear();
                Console.WriteLine($"The average of {number1}, {number2} and {number3} is {average}. Press ENTER to exit...");
                Console.ReadLine();
                return true;
               }
            }
    }
}
