namespace Lab16
{
    internal class Program
    {
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
            Console.WriteLine("D4: " + ArrayToString(d4Rolls));
            Console.WriteLine("D6: " + ArrayToString(d6Rolls));
            Console.WriteLine("D8: " + ArrayToString(d8Rolls));
            Console.WriteLine("D10: " + ArrayToString(d10Rolls));
            Console.WriteLine("D12: " + ArrayToString(d12Rolls));
            Console.WriteLine("D20: " + ArrayToString(d20Rolls));
        }

        static int RollDice(int sides)
        {
            Random random = new Random();
            return random.Next(1, sides + 1);
        }

        static void RollDice(int[] diceRolls, int sides)
        {
            for (int i = 0; i < diceRolls.Length; i++)
            {
                diceRolls[i] = RollDice(sides);
            }
        }

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
