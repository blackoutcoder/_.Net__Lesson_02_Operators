
using System;

namespace Simple_Calculator 
    {
        internal class Program
        {
            static void Main(string[] args)
            {
                double num1;
                double num2;
                Console.WriteLine("Enter two number and press ENTER...");
                num1 = Convert.ToDouble(Console.ReadLine());
                num2 = Convert.ToDouble(Console.ReadLine());
                Console.Clear();
                SimpleCalculator simpleCalculator = new SimpleCalculator();
                ConsoleWriter consoleWriter = new ConsoleWriter();
                double addictionResult = SimpleCalculator.Addiction(num1, num2);
                double substractionResult = SimpleCalculator.Substraction(num1, num2);
                consoleWriter.Text($"Addiction = {addictionResult}, Substraction = {substractionResult}");
                Console.ReadLine();
            }
            public class SimpleCalculator
            {
                public static double Addiction(double num1, double num2)
                {
                    return num1 + num2;
                }

                public static double Substraction(double num1, double num2)
                {
                    return num1 - num2;
                }

                public double Division(double num1, double num2)
                {
                    return num1 / num2;
                }

                public double Multiplication(double num1, double num2)
                {
                    return num1 * num2;
                }
            }

            public class ConsoleWriter
            {
                public bool Text(string text)
                {
                    Console.WriteLine(text);
                    return true;
                }
                public bool Text(double num)
                {
                    Console.WriteLine(num);
                    return true;
                }
            }
        }
    }


 

