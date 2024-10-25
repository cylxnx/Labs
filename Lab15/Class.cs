namespace Lab15
{
    /// <summary>
    /// Deckard Cain, the Horadric Scholar
    /// </summary>
    public static class Deckard
    {
        /// <summary>
        /// The Horadric Scholar, Deckard Cain, queries the user for input
        /// </summary>
        /// <param name="message"></param>
        /// <returns>user input string</returns>
        public static string Identify(string message)
        {
            Console.Write(message);
            return Console.ReadLine();
        }
        /// <summary>
        /// Deckard shares the story of Wirt
        /// </summary>
        public static void Wirt()
        {
            Console.WriteLine(@"
                    The story of Wirt is a frightening and tragic one. 
                    He was taken from the arms of his mother and dragged into the labyrinth by
                    the small, foul demons that wield wicked spears. There were many other children 
                    taken that day, including the son of King Leoric. The Knights of the palace 
                    went below, but never returned. The Blacksmith found the boy, but only after the 
                    foul beasts had begun to torture him for their sadistic pleasures.");
            Console.WriteLine();
        }
        /// <summary>
        /// Deckard shares his outlook and plans for the future
        /// </summary>
        public static void Future()
        {
            Console.WriteLine(@"
                    No, I am not slated to return for Diablo 4. 
                            I am going into comedy.");
            Console.WriteLine();
        }
        /// <summary>
        /// Deckard's opinion of Diablo
        /// </summary>
        public static void Diablo()
        {
            Console.WriteLine(@"
                    Diablo still roams free in Hell, marshalling his demonic forces. 
                    Only when he is beaten will our world finally have peace.");
            Console.WriteLine();
        }
        /// <summary>
        /// Deckard shares the lore of King Leoric
        /// </summary>
        public static void Lore()
        {
            Console.WriteLine(@"
                    The tragic fall of Leoric was a harsh blow to this land. 
                    The people always loved the King, and now they live in mortal fear of him. 
                    The question that I keep asking myself is how he could have fallen so far from the Light, 
                    as Leoric had always been the holiest of men. Only the vilest powers of Hell 
                    could so utterly destroy a man from within...");
            Console.WriteLine();
        }
        /// <summary>
        /// Deckard's response to unknown input
        /// </summary>
        public static void Cain()
        {
            Console.WriteLine("\nI don’t know what you mean. Soo.. stay a while and listen.\n");
        }

    }
}








      

