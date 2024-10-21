//Cody Lane
//clane15@stumail.northeaststate.edu
namespace Lab10
{
    /// <summary>
    /// Lab 10 Implementation
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
            int days;
            string monthLabel;

            Console.Write("Enter a month in the year (e.g., 1 for Jan): ");
            tempInput = Console.ReadLine();
            month = Convert.ToInt16(tempInput);
            
            Console.Write("Enter a year: ");
            tempInput = Console.ReadLine();
            year = Convert.ToInt16(tempInput);

            switch (month)
            {
                case 1:
                    monthLabel = "January";
                    days = 31;
                    break;
                case 2:
                    monthLabel = "February";
                    if (year % 400 == 0 || year % 4 && year % 100 != 0)
                    {
                        days = 29;
                    }
                    else
                    { 
                        days = 28;
                    }
                    break;
                case 3:
                    monthLabel = "March";
                    days = 31;
                    break;
                case 4:
                    monthLabel = "April";
                    days = 30;
                    break;
                case 5:
                    monthLabel = "May";
                    days = 31;
                    break;
                case 6:
                    monthLabel = "June";
                    days = 30;
                    break;
                case 7:
                    monthLabel = "July";
                    days = 31;
                    break;
                case 8:
                    monthLabel = "August";
                    days = 31;
                    break;
                case 9:
                    monthLabel = "September";
                    days = 30;
                    break;
                case 10:
                    monthLabel = "October";
                    days = 31;
                    break;
                case 11:
                    monthLabel = "November";
                    days = 30;
                    break;
                case 12:
                    monthLabel = "December";
                    days = 31;
                    break;
            }

            string message = $"{monthLabel}{year}has{days}days";
            Console.WriteLine(message);

            
        




                











            }


        }
    }
}
