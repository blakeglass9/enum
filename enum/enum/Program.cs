using System;

namespace DayOfWeekApp
{
    // Enum for the days of the week
    public enum DaysOfWeek
    {
        Sunday,
        Monday,
        Tuesday,
        Wednesday,
        Thursday,
        Friday,
        Saturday
    }

    class Program
    {
        static void Main()
        {
            // Prompt the user to enter the current day of the week
            Console.WriteLine("Please enter the current day of the week:");

            try
            {
                // Read user input
                string userInput = Console.ReadLine();

                // Attempt to parse the input into the DaysOfWeek enum
                DaysOfWeek currentDay = (DaysOfWeek)Enum.Parse(typeof(DaysOfWeek), userInput, true);

                // Display the parsed enum value
                Console.WriteLine("You entered: " + currentDay);
            }
            catch (ArgumentException)
            {
                // Handle invalid input by displaying an error message
                Console.WriteLine("Please enter an actual day of the week.");
            }
        }
    }
}
