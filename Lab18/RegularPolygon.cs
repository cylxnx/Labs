//Cody Lane
//clane15@stumail.northeaststate.edu
namespace Lab18
{
    /// <summary>
    /// Lab 18 - Object Modeling - Regular Polygon
    /// Class for the regular polygon object
    /// </summary>
    public class RegularPolygon
    {
        /// <summary>
        /// Number of polygonal sides
        /// </summary>
        public uint NumSides { get; set; }

        /// <summary>
        /// Length of sides
        /// </summary>
        public double SideLength { get; set; }

        /// <summary>
        /// Area of rectangle
        /// </summary>
        public double Area 
        {
            get { return NumSides * Math.Pow(SideLength, 2) / (4 * Math.Tan(Math.PI / NumSides)); } 
        }

        /// <summary>
        /// Perimeter of polygon
        /// </summary>
        public double Perimeter 
        {
            get { return NumSides * SideLength; } 
        }

        /// <summary>
        /// Default constructor
        /// </summary>
        public RegularPolygon()
        {
            NumSides = 3;
            SideLength = 1;
        }

        /// <summary>
        /// Paramaterized constructor
        /// </summary>
        /// <param name="numSides">sides of polygon</param>
        /// <param name="SideLength">length of sides</param>
        public RegularPolygon(uint numSides, double SideLength)
        {
            this.NumSides = numSides;
            this.SideLength = SideLength;
        }
    }
}

