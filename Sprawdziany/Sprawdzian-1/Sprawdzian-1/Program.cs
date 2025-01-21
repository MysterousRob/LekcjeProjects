namespace ConsoleApp1
{
    internal class Program
    {
        // Main entry point of the program
        static void Main(string[] args)
        {
            Console.WriteLine("Rozpoczynam sprawdzian)");
            Zadanie_5_6(); // Call the main method to handle task selection and execution
            Console.WriteLine("Kończę sprawdzian.");
        }

        // Zadanie 1: Print numbers divisible by 3 from b to a (descending order)
        static void Zadanie_1()
        {
            Console.WriteLine("Rozpoczynam zadanie 1");
            int a = 11;
            int b = 123;

            // Loop through the range from b to a
            for (int i = b; i >= a; i--)
            {
                // Check if the current number is divisible by 3
                if (i % 3 == 0)
                {
                    Console.WriteLine(i); // Print the number
                }
            }

            Console.WriteLine("Kończę zadanie 1");
        }

        // Zadanie 2: Print a triangle of $ symbols with the given number of rows
        static void PrintTriangle(int rows)
        {
            // Loop through rows to build the triangle
            for (int i = 1; i <= rows; i++)
            {
                // Create a string with (2 * i - 1) $ symbols for each row
                string line = new string('$', 2 * i - 1);
                // Pad the string to align the triangle in the center
                Console.WriteLine(line.PadLeft(rows + i - 1));
            }
        }

        // Zadanie 2: Main method to execute the triangle printing
        static void Zadanie_2(int rows)
        {
            Console.WriteLine("Rozpoczynam zadanie 2");
            PrintTriangle(rows); // Call the PrintTriangle method to display the triangle
            Console.WriteLine("Kończę zadanie 2");
        }

        // Zadanie 3: Display a greeting based on the time of day and the current day of the week
        static void Zadanie_3()
        {
            Console.WriteLine("Rozpoczynam zadanie 3");
            DateTime today = DateTime.Now; // Get the current date and time
            string dayOfWeek = today.DayOfWeek.ToString(); // Get the name of the current day
            int dayNumber = (int)today.DayOfWeek; // Get the number of the current day (0 for Sunday, 1 for Monday, etc.)

            // Check if it's before or after 12:00 (noon) to decide the greeting
            string greeting = today.Hour < 12 ?
                $"Dzień dobry, dzisiaj {dayOfWeek}, czyli {dayNumber} dzień tygodnia" :
                $"Dobry wieczór, dzisiaj {dayOfWeek}, czyli {dayNumber} dzień tygodnia";

            Console.WriteLine(greeting); // Output the greeting
            Console.WriteLine("Kończę zadanie 3");
        }

        // Zadanie 4: Find and return the number with the maximum absolute value from an array
        static double Zadanie_4(double[] numbers)
        {
            double maxAbsValue = numbers[0]; // Start with the first number in the array
            foreach (var number in numbers)
            {
                // Compare the absolute values and update maxAbsValue if necessary
                if (Math.Abs(number) > Math.Abs(maxAbsValue))
                {
                    maxAbsValue = number;
                }
            }
            return maxAbsValue; // Return the number with the largest absolute value
        }

        // Zadanie 5 & 6: Main loop for task selection and execution
        static void Zadanie_5_6()
        {
            Console.WriteLine("Rozpoczynam pętlę.");

            int taskNumber = -1; // Initialize task number
            while (taskNumber != 0)
            {
                // Ask the user to input a task number
                Console.WriteLine("Podaj numer zadania od 1 do 4, które mam wyświetlić.");

                try
                {
                    taskNumber = int.Parse(Console.ReadLine()); // Try to parse the user input to an integer

                    // Use a switch statement to execute the correct task based on the user input
                    switch (taskNumber)
                    {
                        case 1:
                            Zadanie_1(); // Call Zadanie_1 to execute task 1
                            break;
                        case 2:
                            Zadanie_2(10); // Call Zadanie_2 with 10 rows for the triangle
                            break;
                        case 3:
                            Zadanie_3(); // Call Zadanie_3 to execute task 3
                            break;
                        case 4:
                            // Provide an array of numbers to be processed in Zadanie_4
                            double[] numbers = { 1.5, -2.22, 4.56, -7, 8.01, 0.0 };
                            double maxValue = Zadanie_4(numbers); // Call Zadanie_4 to find the max absolute value
                            Console.WriteLine("The max absolute value is: " + maxValue);
                            break;
                        case 0:
                            Console.WriteLine("Kończę program."); // Exit the program
                            break;
                        default:
                            // If the user enters an invalid number, prompt them to try again
                            Console.WriteLine("Nie ma takiego zadania, wybierz ponownie.");
                            break;
                    }
                }
                catch (FormatException)
                {
                    // Handle invalid input that can't be converted to an integer
                    Console.WriteLine("Nieprawidłowy numer. Podaj liczbę całkowitą.");
                }
            }

            Console.WriteLine("Kończę pętlę.");
        }
    }
}
