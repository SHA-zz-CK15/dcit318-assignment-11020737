using System;

namespace CSharpConsoleTools
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("\n=== C# Console Tools ===");
                Console.WriteLine("1. Grade Calculator");
                Console.WriteLine("2. Ticket Price Calculator");
                Console.WriteLine("3. Triangle Type Identifier");
                Console.WriteLine("4. Exit");
                Console.Write("Choose an option (1-4): ");

                string choice = Console.ReadLine();
                switch (choice)
                {
                    case "1": GradeCalculator(); break;
                    case "2": TicketPriceCalculator(); break;
                    case "3": TriangleTypeIdentifier(); break;
                    case "4":
                        Console.WriteLine("Goodbye!");
                        return;
                    default:
                        Console.WriteLine("Invalid selection. Please choose 1–4.");
                        break;
                }
            }
        }

        static void GradeCalculator()
        {
            Console.Write("\nEnter numerical grade (0–100): ");
            if (int.TryParse(Console.ReadLine(), out int grade))
            {
                string letter = grade >= 90 ? "A"
                                : grade >= 80 ? "B"
                                : grade >= 70 ? "C"
                                : grade >= 60 ? "D"
                                : "F";
                Console.WriteLine($"Letter Grade: {letter}");
            }
            else
                Console.WriteLine("Invalid input. Please enter an integer.");
        }

        static void TicketPriceCalculator()
        {
            Console.Write("\nEnter your age: ");
            if (int.TryParse(Console.ReadLine(), out int age))
            {
                double price = (age <= 12 || age >= 65) ? 7.0 : 10.0;
                Console.WriteLine($"Ticket Price: GHC{price}");
            }
            else
                Console.WriteLine("Invalid age. Please enter a number.");
        }

        static void TriangleTypeIdentifier()
        {
            Console.Write("\nEnter side 1: ");
            bool ok1 = double.TryParse(Console.ReadLine(), out double s1);
            Console.Write("Enter side 2: ");
            bool ok2 = double.TryParse(Console.ReadLine(), out double s2);
            Console.Write("Enter side 3: ");
            bool ok3 = double.TryParse(Console.ReadLine(), out double s3);

            if (!ok1 || !ok2 || !ok3)
            {
                Console.WriteLine("Invalid input. Please enter numeric values.");
                return;
            }

            if (s1 <= 0 || s2 <= 0 || s3 <= 0)
            {
                Console.WriteLine("Sides must all be positive.");
                return;
            }

            if (!(s1 + s2 > s3 && s1 + s3 > s2 && s2 + s3 > s1))
            {
                Console.WriteLine("These sides do not form a valid triangle.");
            }
            else if (s1 == s2 && s2 == s3)
            {
                Console.WriteLine("Triangle Type: Equilateral");
            }
            else if (s1 == s2 || s1 == s3 || s2 == s3)
            {
                Console.WriteLine("Triangle Type: Isosceles");
            }
            else
            {
                Console.WriteLine("Triangle Type: Scalene");
            }
        }
    }
}
