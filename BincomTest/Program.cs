using System;

namespace BincomTest
{
    class Program
    {
        static void Main(string[] args)
        {
            // Task 1
            Console.WriteLine("=== Task 1 ===");
            string name = "John Doe";
            int age = 25;
            bool isAdmin = true;

            Console.WriteLine("Name: " + name);
            Console.WriteLine("Age: " + age);
            Console.WriteLine("Is Admin: " + isAdmin);
            Console.WriteLine();

            // Task 2 - Even or Odd
            Console.WriteLine("=== Task 2 ===");
            Console.Write("Enter a number: ");
            int number = Convert.ToInt32(Console.ReadLine());

            if (number % 2 == 0)
            {
                Console.WriteLine("Even");
            }
            else
            {
                Console.WriteLine("Odd");
            }
            Console.WriteLine();

            // Task 3 - For Loop 1 to 10
            Console.WriteLine("=== Task 3 ===");
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine();

            // Task 4 - Array Sum + Foreach
            Console.WriteLine("=== Task 4 ===");
            int[] numbers = { 2, 4, 6, 8, 10 };
            int sum = 0;

            foreach (int num in numbers)
            {
                Console.WriteLine(num);
                sum += num;
            }

            Console.WriteLine("Sum of array: " + sum);
            Console.WriteLine();

            // Task 5 - Greet Method
            Console.WriteLine("=== Task 5 ===");
            Greet("Alice");
        }

        // Task 5 Method
        static void Greet(string name)
        {
            Console.WriteLine("Hello, " + name + "!");
        }
    }
}