using System;

class Program
{
    static void Main()
    {
        while (true)
        {
            Console.Write("enter a number for the day of the week (0 to exit) ");
            string input = Console.ReadLine();

            if (int.TryParse(input, out int DayOfWeek))
            {
                switch (DayOfWeek)
                {
                    case 0:
                        Console.WriteLine("Exiting the script...");
                        return;

                    case 1:
                        Console.WriteLine("Monday");
                        break;

                    case 2:
                        Console.WriteLine("Tuesday");
                        break;

                    case 3:
                        Console.WriteLine("Wednesday");
                        break;

                    case 4:
                        Console.WriteLine("Thursday");
                        break;

                    case 5:
                        Console.WriteLine("Friday");
                        break;

                    case 6:
                        Console.WriteLine("Saturday");
                        break;

                    case 7:
                        Console.WriteLine("Sunday");
                        break;

                    default:
                        Console.WriteLine("Invalid input. Please enter a number between 0 and 7.");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid number.");
            }

            Console.WriteLine();
        }
    }
}