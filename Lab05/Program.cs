//Cody Lane
//clane15@stumail.northeaststate.edu
namespace Lab05
{
    /// <summary>
    /// Lab05 Implementation
    /// </summary>
    internal class Program
    {
        /// <summary>
        /// Program entry point
        /// </summary>
        static void Main()
        {
            float acceleration, velocity1, velocity0, time;
            string message = "Physics Acceleration Calculator";
            string ?tempInput = "";

            Console.WriteLine(message + "\n\n");
           
            Console.Write("Enter a value for velocity0 in m/s: ");
            tempInput = Console.ReadLine();
            velocity0 = Convert.ToSingle(tempInput);

            Console.Write("Enter a value for velocity1 in m/s: ");
            tempInput = Console.ReadLine();
            velocity1 = Convert.ToSingle(tempInput);

            Console.Write("Enter a value for time in seconds: ");
            tempInput = Console.ReadLine();
            time = Convert.ToSingle(tempInput);

            Console.Write("\n\n");

            acceleration = (velocity1 - velocity0) / time;

            Console.WriteLine("velocity0 = " + velocity0 + " m/s");
            Console.WriteLine("velocity1 = " + velocity1 + " m/s");
            Console.WriteLine("time = " + time);
            Console.WriteLine("acceleration = " + acceleration + " m/s^2");
        }
    }
}
