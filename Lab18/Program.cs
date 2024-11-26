//Cody Lane
//clane15@stumail.northeaststate.edu
namespace Lab18
{
    /// <summary>
    /// Lab 18 - Object Modeling - Regular Polygon
    /// Application that simulates using regular polygon
    /// objects to calculate values.
    /// </summary>
    internal class Program
    {
        /// <summary>
        /// Program entry point
        /// </summary>
        static void Main()
        {
            RegularPolygon regularPolygon1 = new RegularPolygon();
            RegularPolygon regularPolygon2 = new RegularPolygon(6, 4.0);
            RegularPolygon regularPolygon3 = new RegularPolygon();  
            regularPolygon3.SideLength = 1.25;
            regularPolygon3.NumSides = 12;

            Console.WriteLine(@$"regularPolygon1
            numSides = {regularPolygon1.NumSides}
            sideLength = {regularPolygon1.SideLength}
            perimeter = {regularPolygon1.Perimeter}  
            area = {regularPolygon1.Area}");
            Console.WriteLine();
            Console.WriteLine(@$"regularPolygon2
            numSides = {regularPolygon2.NumSides}
            sideLength = {regularPolygon2.SideLength}
            perimeter = {regularPolygon2.Perimeter}  
            area = {regularPolygon2.Area}");
            Console.WriteLine();
            Console.WriteLine(@$"regularPolygon3
            numSides = {regularPolygon3.NumSides}
            sideLength = {regularPolygon3.SideLength}
            perimeter = {regularPolygon3.Perimeter}  
            area = {regularPolygon3.Area}");
        }
    }
}
