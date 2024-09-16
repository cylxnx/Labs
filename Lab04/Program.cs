//Cody Lane
//clane15@stumail.northeaststate.edu
namespace Lab04
{
    /// <summary>
    /// Lab04 Implementation
    /// </summary>
    internal class Program
    {
        /// <summary>
        /// Program entry point
        /// </summary>
        static void Main()
        {
            float acceleration, velocity1, velocity0, time;
            
            velocity0 = 5.6f;
            velocity1 = 10.5f;
            time = 0.5f;

            acceleration = (velocity1 - velocity0) / time;

            Console.WriteLine("velocity0 = " + velocity0 + " m/s");
            Console.WriteLine("velocity1 = " + velocity1 + " m/s");
            Console.WriteLine("time = " + time);
            Console.WriteLine("acceleration = " + acceleration + " m/s^2");
            
            
        }
    }
}
