//Name: Cody Lane
//Email: clane15@stumail.northeaststate.edu
//Project: Lab08
namespace Lab08
{
    /// <summary>
    /// Temperature Converter
    /// </summary>
    internal class Program
    {
        /// <summary>
        /// Program entry point
        /// </summary>
        static void Main()
        {
            string? temperatureType;
            string? inputString;
            double temperature;
            double convertedTemperature;
            
            Console.WriteLine("Temperature Converter (F to C) or (C to F):\n\n");
            Console.Write("Enter a value for temperature: ");
            inputString = Console.ReadLine();
            temperature = Convert.ToDouble(inputString);

            Console.Write("Specify the type for temperature entered (C or F): ");
            temperatureType = Console.ReadLine();

            if (temperatureType.ToUpper() == "C")
            {
                convertedTemperature = (temperature * 9 / 5) + 32;
                Console.WriteLine("\n" + temperature + "C = " + convertedTemperature + "F");
            }
            else if (temperatureType.ToUpper() == "F") 
            {
                convertedTemperature = (temperature - 32) * 5 / 9;
                Console.WriteLine("\n" + temperature + "F = " + convertedTemperature + "C");
            }
            else
            {
                Console.WriteLine(temperatureType + " is not a valid temperature type");
            }
            
            Console.WriteLine("\nPress Any Key To Exit");
            Console.ReadKey();
        }
    }
}
