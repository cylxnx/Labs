//Cody Lane
//clane15@stumail.northeaststate.edu
namespace Lab12
{
    /// <summary>
    /// Lab 12 - the !(Britney Spears) Lab
    /// A program dedicated to Artis Leon Ivey Jr. aka Coolio. RIP.
    /// ...which demonstrates a void return type method with no parameters
    /// </summary>
    internal static class Program
    {
        /// <summary>
        /// Program entry point
        /// </summary>
        static void Main()
        {

            Console.WriteLine("  Cool I/O v. 1.0");
            Console.WriteLine("\n\n\nGangsta's Paradise by Coolio");
            Console.WriteLine("\nPress any key to play the song.");
            Console.ReadKey();
            PlayCoolIO();
        } 

        /// <summary>
        /// Method which plays Coolio - Gangsta's Paradise
        /// using console beeps.
        /// </summary>
        static void PlayCoolIO()
        {
            if (OperatingSystem.IsWindows())
            {
                Console.Beep(415, 500);
                Thread.Sleep(500);
                Console.Beep(415, 500);
                Thread.Sleep(500);
                Console.Beep(415, 500);
                Thread.Sleep(500);
                Console.Beep(415, 500);
                Thread.Sleep(500);
                Console.Beep(369, 500);
                Thread.Sleep(500);
                Console.Beep(369, 500);
                Thread.Sleep(500);
                Console.Beep(369, 400);
                Thread.Sleep(100);
                Console.Beep(392, 200);
                Console.Beep(262, 800);
                Thread.Sleep(500);
                Console.Beep(415, 500);
                Thread.Sleep(500);
                Console.Beep(415, 500);
                Thread.Sleep(500);
                Console.Beep(415, 500);
                Thread.Sleep(500);
                Console.Beep(415, 500);
                Thread.Sleep(500);
                Console.Beep(369, 500);
                Thread.Sleep(500);
                Console.Beep(369, 500);
                Thread.Sleep(500);
                Console.Beep(369, 400);
                Thread.Sleep(100);
                Console.Beep(392, 200);
                Console.Beep(262, 800);

                Console.WriteLine("\nThank you for joining me on this Fantastic Voyage.\n\nPress any key to exit.");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("This program only works on Windows.");
            }
        }
    }

}        
    





