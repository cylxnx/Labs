namespace Lab15
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine(@"
                    Hello, traveler! I am Deckard Cain, the last of the Horadrim.
                    I am here to help you identify items. Type 'bye' to leave.");
            Console.WriteLine();
            while (true)
            {
                string input = Deckard.Cain();

                if (input.Equals("bye", StringComparison.CurrentCultureIgnoreCase))
                {
                    break;
                }
                else if (input.Equals("wirt", StringComparison.CurrentCultureIgnoreCase))
                {
                    Deckard.Wirt();
                }
                else if (input.Equals("d4", StringComparison.CurrentCultureIgnoreCase))
                {
                    Deckard.Future();
                }
                else if (input.Equals("diablo", StringComparison.CurrentCultureIgnoreCase))
                {
                    Deckard.Diablo();
                }
                else if (input.Equals("lore", StringComparison.CurrentCultureIgnoreCase))
                {
                    Deckard.Lore();
                }
                else if (input.Equals("deckard", StringComparison.CurrentCultureIgnoreCase))
                {
                    Deckard.Vain();
                }
                else
                {
                    Deckard.Pain();
                }
            }

        }
    }
}
