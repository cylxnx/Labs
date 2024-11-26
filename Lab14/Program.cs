//Cody Lane
//clane15@stumail.northeaststate.edu
namespace Lab14
{
    /// <summary>
    /// Lab 14: Four For Loops
    /// Demonstrates four for loops
    /// </summary>
    internal class Program
    {
        /// <summary>
        /// Program entry point
        /// </summary>
        static void Main()
        {
            Console.Write("Loop 1: ");
            for (int i = 11; i < 220; i += 11)
            {
                Console.Write(i + " ");
            }

            Console.Write("\nLoop 2: ");
            for (int i = 68; i >= 32; i -= 2)
            {
                Console.Write(i + " ");
            }

            Console.Write("\nLoop 3: ");
            for (int i = 1; i < 400; i++)
            {
                if (i % 2 == 0 && i % 13 == 0)
                {
                    Console.Write(i + " ");
                }
            }

            Console.Write("\nLoop 4: ");
            int term1 = 0, term2 = 1, spiralOut;
            for (int i = 1; i <= 20; i++)
            {
                if (i == 1)
                {
                    Console.Write(term1 + " ");
                    continue;
                }
                if (i == 2)
                {
                    Console.Write(term2 + " ");
                    continue;
                }
                spiralOut = term1 + term2;
                Console.Write(spiralOut + " ");
                term1 = term2;
                term2 = spiralOut;
            }
            
        }
    }
}
