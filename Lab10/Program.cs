//Cody Lane
//clane15@stumail.northeaststate.edu
namespace Lab10
{
    /// <summary>
    /// Lab 10 - Days in a Month
    /// Simple program to determine the number of days in a month
    /// based on the month and year entered by the user.
    /// </summary>
    internal class Program
    {
        /// <summary>
        /// Program entry point
        /// </summary>
        static void Main()
        {
            int year, month;
            string? tempInput;
            int dayZ;
            string monthName;

            //Prompts user for month and year, then converts input to integers.

            Console.Write("Enter a month in the year (e.g., 1 for Jan): ");
            tempInput = Console.ReadLine();
            month = Convert.ToInt32(tempInput);

            Console.Write("Enter a year: ");
            tempInput = Console.ReadLine();
            year = Convert.ToInt32(tempInput);

            //Switch statement to determine the number of days in the month
            //based on the month and year entered by the user.
            //If the month is February, checks if the year is a leap year.


            switch (month)
            {
                case 1:
                    monthName = "January";
                    dayZ = 31;
                    Console.WriteLine($"{monthName} {year} has {dayZ} days.");
                    break;
                case 2:
                    monthName = "February";
                    if (year % 400 == 0 || year % 4 == 0 && year % 100 != 0)
                    {
                        dayZ = 29;
                        Console.WriteLine($"{monthName} {year} has {dayZ} days.");
                    }
                    else
                    {
                        dayZ = 28;
                        Console.WriteLine($"{monthName} {year} has {dayZ} days.");
                    }
                    break;
                case 3:
                    monthName = "March";
                    dayZ = 31;
                    Console.WriteLine($"{monthName} {year} has {dayZ} days.");
                    break;
                case 4:
                    monthName = "April";
                    dayZ = 30;
                    Console.WriteLine($"{monthName} {year} has {dayZ} days.");
                    break;
                case 5:
                    monthName = "May";
                    dayZ = 31;
                    Console.WriteLine($"{monthName} {year} has {dayZ} days.");
                    break;
                case 6:
                    monthName = "June";
                    dayZ = 30;
                    Console.WriteLine($"{monthName} {year} has {dayZ} days.");
                    break;
                case 7:
                    monthName = "July";
                    dayZ = 31;
                    Console.WriteLine($"{monthName} {year} has {dayZ} days.");
                    break;
                case 8:
                    monthName = "August";
                    dayZ = 31;
                    Console.WriteLine($"{monthName} {year} has {dayZ} days.");
                    break;
                case 9:
                    monthName = "September";
                    dayZ = 30;
                    Console.WriteLine($"{monthName} {year} has {dayZ} days.");
                    break;
                case 10:
                    monthName = "October";
                    dayZ = 31;
                    Console.WriteLine($"{monthName} {year} has {dayZ} days.");
                    break;
                case 11:
                    monthName = "November";
                    dayZ = 30;
                    Console.WriteLine($"{monthName} {year} has {dayZ} days.");
                    break;
                case 12:
                    monthName = "December";
                    dayZ = 31;
                    Console.WriteLine($"{monthName} {year} has {dayZ} days.");
                    break;
                default:
                    break;
            }



        }



    }

}

