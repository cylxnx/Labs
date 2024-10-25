namespace Lab15
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("Hello traveler. Stay a while, and listen!\n\n");

            while (true)
            {
                string input = Deckard.Identify("As a token of my gratitude, I will identify items for you at no charge: ");

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
                else
                {
                    Deckard.Cain();
                }
            }

        }
    }
}
