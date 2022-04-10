using System;

namespace SavingStringVariables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            School school = new School();

            Console.WriteLine("Iveskite mokyklos pavadinima");
            school.Name = Console.ReadLine();

            Console.WriteLine("Iveskite kurso pavadinima");
            school.CourseName = Console.ReadLine();

            Console.WriteLine("Iveskite mokyniu skaiciu");
            school.StudentsNumber = Convert.ToInt32(Console.ReadLine())
       ;
            Console.WriteLine("Iveskite kurso pradzios data");
            school.StartDate = Convert.ToDateTime(Console.ReadLine());

            Console.WriteLine("Iveskite kurso pabaigos data");
            school.EndDate = Convert.ToDateTime(Console.ReadLine());
            
            Console.WriteLine("Rezultatas");
            school.Print();
            school.PrintCourseDuration();
            
        }

        public class School
        {
            public string Name { get; set; }
            public string CourseName { get; set; }
            public int StudentsNumber { get; set; }
            public DateTime StartDate { get; set; }
            public DateTime EndDate { get; set; }

            public bool Print()
            {
                Console.WriteLine($">Mokyklos pavadinimas yra {Name}");
                Console.WriteLine($">Kurso pavadinimas yra {CourseName}");
                Console.WriteLine($">Studentu skaicius yra {StudentsNumber}");
                
                return true;
            }

            public bool PrintCourseDuration()
            {
                int duration = (EndDate - StartDate).Days;
                Console.WriteLine($">Kurso trukme {duration} dienas.");

                duration = (EndDate - StartDate).Days / 7;
                Console.WriteLine($">Kurso trukme {duration}  savaites.");
                return true;
            }
        }

    } 
}
