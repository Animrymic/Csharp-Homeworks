using System;

namespace Class04.Homeworks
{
    internal class Program
    {
        static void Main()
        {
            Console.Write("Enter your birthdate (e.g. 1990-12-31 or 12/31/1990): ");
            var input = Console.ReadLine();

            if (!DateTime.TryParse(input, out DateTime birthDate))
            {
                Console.WriteLine("Invalid date format. Please enter a valid date.");
                Console.ReadLine();
                return;
            }

            var today = DateTime.Today;
            if (birthDate.Date > today)
            {
                Console.WriteLine("The birthday you entered is in the future.");
                Console.ReadLine();
                return;
            }

            int age = AgeCalculator(birthDate);

            if (birthDate.Month == today.Month && birthDate.Day == today.Day)
            {
                Console.WriteLine($"Happy birthday! You are {age} years old today.");
            }
            else
            {
                Console.WriteLine($"You are {age} years old.");
            }

            Console.ReadLine();
        }

        public static int AgeCalculator(DateTime birthDate)
        {
            DateTime today = DateTime.Today;
            int age = today.Year - birthDate.Year;
            if (today.Month < birthDate.Month ||
               (today.Month == birthDate.Month && today.Day < birthDate.Day))
            {
                age--;
            }
            return age;
        }
    }
}