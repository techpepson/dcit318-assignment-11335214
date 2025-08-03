using System;

class Program
{
    static void Main()
    {
        bool exit = false;
        
        while (!exit)
        {
            Console.Clear();
            Console.WriteLine("Main Menu");
            Console.WriteLine("---------");
            Console.WriteLine("1. Grade Calculator");
            Console.WriteLine("2. Ticket Price Calculator");
            Console.WriteLine("3. Triangle Type Identifier");
            Console.WriteLine("0. Exit");
            Console.Write("\nSelect an option (0-3): ");

            if (int.TryParse(Console.ReadLine(), out int choice))
            {
                switch (choice)
                {
                    case 1:
                        RunGradeCalculator();
                        break;
                    case 2:
                        RunTicketPriceCalculator();
                        break;
                    case 3:
    RunTriangleTypeIdentifier();
    break;
                    case 0:
                        exit = true;
                        break;
                    default:
                        Console.WriteLine("\nInvalid option. Please try again.");
                        Console.WriteLine("Press any key to continue...");
                        Console.ReadKey();
                        break;
                }
            }
            else
            {
                Console.WriteLine("\nPlease enter a valid number.");
                Console.WriteLine("Press any key to continue...");
                Console.ReadKey();
            }
        }
    }

    static void RunGradeCalculator()
    {
        Console.Clear();
        Console.WriteLine("Grade Calculator");
        Console.WriteLine("----------------");
        
        // Prompt user for numerical grade
        Console.Write("Enter a numerical grade (0-100): ");
        
        // Read and validate input
        if (int.TryParse(Console.ReadLine(), out int numericalGrade))
        {
            // Ensure grade is within valid range
            if (numericalGrade >= 0 && numericalGrade <= 100)
            {
                string letterGrade = CalculateLetterGrade(numericalGrade);
                
                // Display the result
                Console.WriteLine($"\nNumerical Grade: {numericalGrade}");
                Console.WriteLine($"Letter Grade: {letterGrade}");
            }
            else
            {
                Console.WriteLine("Error: Please enter a grade between 0 and 100.");
            }
        }
        else
        {
            Console.WriteLine("Error: Please enter a valid numerical grade.");
        }
        
        Console.WriteLine("\nPress any key to return to main menu...");
        Console.ReadKey();
    }

    static string CalculateLetterGrade(int grade)
    {
        if (grade >= 90) return "A";
        if (grade >= 80) return "B";
        if (grade >= 70) return "C";
        if (grade >= 60) return "D";
        return "F";
    }

    static void RunTicketPriceCalculator()
{
    Console.Clear();
    Console.WriteLine("Ticket Price Calculator");
    Console.WriteLine("------------------------");
    
    Console.Write("Please enter your age: ");
    
    if (int.TryParse(Console.ReadLine(), out int age) && age > 0)
    {
        const double standardPrice = 10.0;
        const double discountedPrice = 7.0;
        
        double ticketPrice = (age <= 12 || age >= 65) ? discountedPrice : standardPrice;
        
        Console.WriteLine("\nTicket Information:");
        Console.WriteLine($"Age: {age}");
        Console.WriteLine($"Ticket Price: GHC{ticketPrice:F2}");
        
        if (ticketPrice == discountedPrice)
        {
            Console.WriteLine("Note: Discounted price applied (Senior Citizen or Child)");
        }
    }
    else
    {
        Console.WriteLine("\nError: Please enter a valid age (positive number).");
    }
    
    Console.WriteLine("\nPress any key to return to main menu...");
    Console.ReadKey();
}
static void RunTriangleTypeIdentifier()
{
    Console.Clear();
    Console.WriteLine("Triangle Type Identifier");
    Console.WriteLine("-------------------------");
    
    Console.WriteLine("Enter the lengths of the three sides of the triangle:");
    
    if (double.TryParse(GetValidInput("First side: "), out double side1) &&
        double.TryParse(GetValidInput("Second side: "), out double side2) &&
        double.TryParse(GetValidInput("Third side: "), out double side3))
    {
        if (IsValidTriangle(side1, side2, side3))
        {
            string triangleType = DetermineTriangleType(side1, side2, side3);
            Console.WriteLine($"\nThis is a {triangleType} triangle.");
        }
        else
        {
            Console.WriteLine("\nThese sides do not form a valid triangle.");
            Console.WriteLine("The sum of any two sides must be greater than the third side.");
        }
    }
    else
    {
        Console.WriteLine("\nError: Please enter valid positive numbers for all sides.");
    }
    
    Console.WriteLine("\nPress any key to return to main menu...");
    Console.ReadKey();
}

static string GetValidInput(string prompt)
{
    string input;
    do
    {
        Console.Write(prompt);
        input = Console.ReadLine();
    } while (string.IsNullOrWhiteSpace(input));
    return input;
}

static bool IsValidTriangle(double a, double b, double c)
{
    return a > 0 && b > 0 && c > 0 && 
           a + b > c && 
           a + c > b && 
           b + c > a;
}

static string DetermineTriangleType(double a, double b, double c)
{
    if (a == b && b == c)
        return "Equilateral (all sides equal)";
    if (a == b || a == c || b == c)
        return "Isosceles (two sides equal)";
    return "Scalene (no sides equal)";
}
}