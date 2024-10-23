//Cody Lane
//clane15@stumail.northeaststate.edu
namespace Lab11
{
    /// <summary>
    /// Lab 11 - Regular Polygons
    /// A program to calculate the area of a regular polygon 
    /// based on the number of sides and the length of each side.
    /// </summary>
    internal class Program
    {
        /// <summary>
        /// Program entry point
        /// </summary>
        static void Main()
        {
            Console.WriteLine("Polynumerator\n");

            ///Prompts user for the number of sides and the length of each side, then converts input to integers.
            ///If the number of sides is less than 3 or the length of each side is less than 0, the program exits.
            
            Console.Write("Enter the number of sides: ");
            int numSides = int.Parse(Console.ReadLine());
            if (numSides < 3)
            {
                Console.WriteLine($"Number of sides must be greater than {numSides}. Exiting.");
                Environment.Exit(0);
            }

            Console.Write("Enter the length of each side: ");
            double sideLength = double.Parse(Console.ReadLine());
            if (sideLength < 0)
            {
                Console.WriteLine($"Length of each side must be greater than {sideLength}. Exiting.");
                Environment.Exit(0);
            }

            Console.WriteLine($"The area of the polygon is: {CalculateRegularPolygonArea(numSides, sideLength)}");

        }

        /// <summary>
        /// Calculates the area of a regular polygon.
        /// </summary>
        /// <param name="numSides">The number of sides of the polygon.</param>
        /// <param name="sideLength">The length of each side of the polygon.</param>
        /// <returns>The area of the regular polygon.</returns>
        static double CalculateRegularPolygonArea(int numSides, double sideLength)
        {
            double peri = numSides * sideLength;
            double angle = 360.0 / numSides;
            double rad = Math.PI / numSides;
            double inrad = sideLength / (2.0 * Math.Tan(rad));
            double area = peri * inrad / 2.0;

            return area;
        }
    }







}


