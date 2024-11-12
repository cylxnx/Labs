namespace Lab15
{
    /// <summary>
    /// Lab 15 - Deckard Cain, the Horadric Scholar
    /// Simulates Deckard Cain from Diablo I, II, and (kind of) III.
    /// </summary>
    internal class Program
    {
        /// <summary>
        /// Program entry point
        /// </summary>
        static void Main()
        {
            Console.WriteLine(@"
                    Hello, traveler! I am Deckard Cain. The last of the Horadrim, no
                    matter what Lorath Nahr may say. I am here to help you identify items. 
                    If you are unsure of what item you would like identified, simply ask for
                    'help'. If you choose to leave, be sure to say 'bye', but please...");
            Console.WriteLine();
            while (true)
            {
                string input = Deckard.Cain();

                if (input.Equals("bye", StringComparison.OrdinalIgnoreCase))
                {
                    break;
                }
                else if (input.Equals("wirt", StringComparison.OrdinalIgnoreCase))
                {
                    Deckard.Wirt();
                }
                else if (input.Equals("d4", StringComparison.OrdinalIgnoreCase))
                {
                    Deckard.Future();
                }
                else if (input.Equals("diablo", StringComparison.OrdinalIgnoreCase))
                {
                    Deckard.Diablo();
                }
                else if (input.Equals("lore", StringComparison.OrdinalIgnoreCase))
                {
                    Deckard.Lore();
                }
                else if (input.Equals("deckard", StringComparison.OrdinalIgnoreCase))
                {
                    Deckard.Vain();
                }
                else if (input.Equals("help", StringComparison.OrdinalIgnoreCase))
                {
                    Deckard.Plain();
                }
                else
                {
                    Deckard.Pain();
                }
            }

        }
    }
}
