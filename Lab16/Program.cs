//Cody Lane
//clane15@stumail.northeaststate.edu
namespace Lab16
{
    /// <summary>
    /// Lab 16 - Dungeons & Dragons & Dice
    /// An application that simulates rolling each type of die used in
    /// Dungeons & Dragons
    /// </summary>
    internal class Program
    {
        /// <summary>
        /// Program entry point
        /// </summary>
        static void Main()
        {
            int[] d4Rolls = new int[4];
            int[] d6Rolls = new int[6];
            int[] d8Rolls = new int[8];
            int[] d10Rolls = new int[10];
            int[] d12Rolls = new int[12];
            int[] d20Rolls = new int[20];
            RollDice(d4Rolls, 4);
            RollDice(d6Rolls, 6);
            RollDice(d8Rolls, 8);
            RollDice(d10Rolls, 10);
            RollDice(d12Rolls, 12);
            RollDice(d20Rolls, 20);
            Console.WriteLine("D4: " + ArrayToString(d4Rolls) + "\n");
            Console.WriteLine("D6: " + ArrayToString(d6Rolls) + "\n");
            Console.WriteLine("D8: " + ArrayToString(d8Rolls) + "\n");
            Console.WriteLine("D10: " + ArrayToString(d10Rolls) + "\n");
            Console.WriteLine("D12: " + ArrayToString(d12Rolls) + "\n");
            Console.WriteLine("D20: " + ArrayToString(d20Rolls) + "\n");
        }
        /// <summary>
        /// Uses Random to simulate a dice roll and returns the result
        /// as an integer
        /// </summary>
        /// <param name="sides">number of sides on the dice</param>
        /// <returns>dice roll as an int</returns>
        static int RollDice(int sides)
        {
            Random random = new Random();
            return random.Next(1, sides + 1);
        }
        /// <summary>
        /// Uses RollDice to populate an array with dice rolls
        /// </summary>
        /// <param name="diceRolls">dice roll array</param>
        /// <param name="sides">number of sides on the dice</param>
        static void RollDice(int[] diceRolls, int sides)
        {
            if (diceRolls == null) return;
            for (int i = 0; i < diceRolls.Length; i++)
            {
                diceRolls[i] = RollDice(sides);
            }
        }
        /// <summary>
        /// Prints the contents of the dice roll array as a string
        /// </summary>
        /// <param name="array">dice roll array</param>
        /// <returns>contents of the array as a string</returns>
        static string ArrayToString(int[] array)
        {
            string result = "";
            for (int i = 0; i < array.Length; i++)
            {
                result += array[i] + " ";
            }
            return result;
        }
    }
}
