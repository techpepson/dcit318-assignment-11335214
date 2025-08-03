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
            Console.WriteLine("2. [New Program 1]"); // Placeholder for future programs
            Console.WriteLine("3. [New Program 2]"); // Placeholder for future programs
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
                        // Placeholder for new program 1
                        Console.WriteLine("\nThis program is not implemented yet!");
                        Console.WriteLine("Press any key to continue...");
                        Console.ReadKey();
                        break;
                    case 3:
                        // Placeholder for new program 2
                        Console.WriteLine("\nThis program is not implemented yet!");
                        Console.WriteLine("Press any key to continue...");
                        Console.ReadKey();
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
}