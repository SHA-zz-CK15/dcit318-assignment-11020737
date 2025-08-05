using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("=== C# Console Tools ===\n");

        // 1. Grade Calculator
        Console.WriteLine("📚 Grade Calculator");
        Console.Write("Enter numerical grade (0–100): ");
        if (int.TryParse(Console.ReadLine(), out int grade) && grade >= 0 && grade <= 100)
        {
            string letter = grade >= 90 ? "A"
                            : grade >= 80 ? "B"
                            : grade >= 70 ? "C"
                            : grade >= 60 ? "D"
                            : "F";
            Console.WriteLine($"Letter Grade: {letter}");
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter an integer between 0 and 100.");
        }

        Console.WriteLine("\n---------------------------\n");

        // 2. Ticket Price Calculator
        Console.WriteLine("🎟️ Ticket Price Calculator");
        Console.Write("Enter your age: ");
        if (int.TryParse(Console.ReadLine(), out int age) && age >= 0)
        {
            double price = (age <= 12 || age >= 65) ? 7.0 : 10.0;
            Console.WriteLine($"Ticket Price: GHC{price:F2}");
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a valid non-negative integer for age.");
        }

        Console.WriteLine("\n---------------------------\n");

        // 3. Triangle Type Identifier
        Console.WriteLine("🔺 Triangle Type Identifier");
        Console.Write("Enter side 1: ");
        bool ok1 = double.TryParse(Console.ReadLine(), out double s1);
        Console.Write("Enter side 2: ");
        bool ok2 = double.TryParse(Console.ReadLine(), out double s2);
        Console.Write("Enter side 3: ");
        bool ok3 = double.TryParse(Console.ReadLine(), out double s3);

        if (!ok1 || !ok2 || !ok3 || s1 <= 0 || s2 <= 0 || s3 <= 0)
        {
            Console.WriteLine("Invalid input. Please enter positive numeric values for all three sides.");
        }
        else if (!(s1 + s2 > s3 && s1 + s3 > s2 && s2 + s3 > s1))
        {
            Console.WriteLine("The entered sides do not form a valid triangle.");
        }
        else
        {
            if (s1 == s2 && s2 == s3)
                Console.WriteLine("Triangle Type: Equilateral");
            else if (s1 == s2 || s1 == s3 || s2 == s3)
                Console.WriteLine("Triangle Type: Isosceles");
            else
                Console.WriteLine("Triangle Type: Scalene");
        }

        Console.WriteLine("\nPress any key to exit...");
        Console.ReadKey();
    }
}
