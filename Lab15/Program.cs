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
            const string LORE = "lore";
            const string DIABLO = "diablo";
            const string WIRT = "wirt";
            const string D4 = "d4";
            const string DECKARD = "deckard";
            const string HELP = "help";
            const string GOODBYE = "goodbye";

            Console.WriteLine(@"
                    Hello, traveler! I am Deckard Cain. The last of the Horadrim, no
                    matter what Lorath Nahr may say. I am here to help you identify items. 
                    If you are unsure of what item you would like identified, simply ask for
                    'help'. If you choose to leave, be sure to say 'goodbye', but please...");
            Console.WriteLine();
            while (true)
            {
                string input = Deckard.Cain();

                if (input.Equals(GOODBYE, StringComparison.OrdinalIgnoreCase))
                {
                    break;
                }
                else if (input.Equals(WIRT, StringComparison.OrdinalIgnoreCase))
                {
                    Deckard.Wirt();
                }
                else if (input.Equals(D4, StringComparison.OrdinalIgnoreCase))
                {
                    Deckard.Future();
                }
                else if (input.Equals(DIABLO, StringComparison.OrdinalIgnoreCase))
                {
                    Deckard.Diablo();
                }
                else if (input.Equals(LORE, StringComparison.OrdinalIgnoreCase))
                {
                    Deckard.Lore();
                }
                else if (input.Equals(DECKARD, StringComparison.OrdinalIgnoreCase))
                {
                    Deckard.Vain();
                }
                else if (input.Equals(HELP, StringComparison.OrdinalIgnoreCase))
                {
                    Deckard.Refrain();
                }
                else
                {
                    Deckard.Pain();
                }
            }

        }
    }
}
