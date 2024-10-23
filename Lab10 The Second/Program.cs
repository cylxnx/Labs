//Cody Lane
//clane15@stumail.northeaststate.edu
namespace Lab10_The_Second
{
    /// <summary>
    /// Lab 10 - Days in a Month Part The Second
    /// A slightly more complex program to determine the number of days
    /// in a month based on the month and year entered by the user.
    /// </summary>
    internal class Program
    {
        static void Main()
        {
            int year, month, days;
            string? tempInput;
            string monthName;

            //Prompts user for month and year, then converts input to integers.

            start:
            Console.Write("Enter a month in the year (e.g., 1 for Jan): ");
            tempInput = Console.ReadLine();
            month = Convert.ToInt32(tempInput);

            Console.Write("Enter a year: ");
            tempInput = Console.ReadLine();
            year = Convert.ToInt32(tempInput);

            //Uses two methods, which really just abstract switch statements, to determine the number of days in the month.
            //One method determines the number of days in the month based on the month and year entered by the user.
            //The second method gets the name of the month based on the month number.
            //I did this to attempt to make the code more readable as well as try and write more modular code.

            monthName = GetMonthName(month);
            days = GetDaysInMonth(month, year);

            Console.WriteLine($"{monthName} {year} has {days} days.");

            goto start;
        }

        /// <summary>
        /// Determines the number of days in a month based on the month and year.
        /// If the month is February, checks if the year is a leap year.
        /// </summary>
        /// <param name="month">The month.</param>
        /// <param name="year">The year.</param>
        /// <returns>The number of days in the month.</returns>
        public static int GetDaysInMonth(int month, int year)
        {
            int dayZ;

            switch (month)
            {
                case 1:
                    dayZ = 31;
                    break;
                case 2:
                    if (year % 400 == 0 || (year % 4 == 0 && year % 100 != 0))
                    {
                        dayZ = 29;
                    }
                    else
                    {
                        dayZ = 28;
                    }
                    break;
                case 3:
                    dayZ = 31;
                    break;
                case 4:
                    dayZ = 30;
                    break;
                case 5:
                    dayZ = 31;
                    break;
                case 6:
                    dayZ = 30;
                    break;
                case 7:
                    dayZ = 31;
                    break;
                case 8:
                    dayZ = 31;
                    break;
                case 9:
                    dayZ = 30;
                    break;
                case 10:
                    dayZ = 31;
                    break;
                case 11:
                    dayZ = 30;
                    break;
                case 12:
                    dayZ = 31;
                    break;
                default:
                    dayZ = -1; // Invalid month
                    break;
            }

            return dayZ;
        }

        /// <summary>
        /// Gets the name of the month based on the month number.
        /// </summary>
        /// <param name="month">The month number.</param>
        /// <returns>The name of the month.</returns>
        public static string GetMonthName(int month)
        {
            string monthName;

            switch (month)
            {
                case 1:
                    monthName = "January";
                    break;
                case 2:
                    monthName = "February";
                    break;
                case 3:
                    monthName = "March";
                    break;
                case 4:
                    monthName = "April";
                    break;
                case 5:
                    monthName = "May";
                    break;
                case 6:
                    monthName = "June";
                    break;
                case 7:
                    monthName = "July";
                    break;
                case 8:
                    monthName = "August";
                    break;
                case 9:
                    monthName = "September";
                    break;
                case 10:
                    monthName = "October";
                    break;
                case 11:
                    monthName = "November";
                    break;
                case 12:
                    monthName = "December";
                    break;
                default:
                    monthName = "Invalid month.";
                    break;
            }

            return monthName;
        }
    }



}
