using System;

class Program
{
    static void Main()
    {
        while (true)
        {
            Console.WriteLine("\n=== Console Tools ===");
            Console.WriteLine("1. Grade Calculator");
            Console.WriteLine("2. Ticket Price Calculator");
            Console.WriteLine("3. Exit");
            Console.Write("Choose an option (1-3): ");

            string choice = Console.ReadLine();
            if (choice == "1")
                GradeCalculator();
            else if (choice == "2")
                TicketPriceCalculator();
            else if (choice == "3")
            {
                Console.WriteLine("Goodbye!");
                break;
            }
            else
                Console.WriteLine("Invalid option. Please choose 1–3.");
        }
    }

    static void GradeCalculator()
    {
        Console.Write("\nEnter numerical grade (0–100): ");
        if (int.TryParse(Console.ReadLine(), out int grade) && grade >= 0 && grade <= 100)
        {
            string letter = grade >= 90 ? "A"
                          : grade >= 80 ? "B"
                          : grade >= 70 ? "C"
                          : grade >= 60 ? "D" : "F";
            Console.WriteLine($"Letter Grade: {letter}");
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a number between 0 and 100.");
        }
    }

    static void TicketPriceCalculator()
    {
        Console.Write("\nEnter your age: ");
        if (int.TryParse(Console.ReadLine(), out int age) && age >= 0)
        {
            const double fullPrice = 10.0;
            const double discounted = 7.0;
            double price = (age <= 12 || age >= 65) ? discounted : fullPrice;
            Console.WriteLine($"Ticket Price: GHC{price}");
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a valid age.");
        }
    }
}
