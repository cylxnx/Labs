//Cody Lane
//clane15@stumail.northeaststate.edu
namespace Lab19
{
    /// <summary>
    /// Lab 19 - Object Modeling - Television
    /// Application that simulates various actions on a television
    /// </summary>
    internal class Program
    {
        /// <summary>
        /// Program entry point
        /// </summary>
        static void Main()
        {
            Television soni = new Television();
            Television senyo = new Television();

            soni.SetChannel(128);
            senyo.Channel = 256;

            for (int i = 0; i < 267835; i++)
            {
                soni.ChannelUp();
            }

            for (int i = 12651; i > 0; i--)
            {
                senyo.ChannelDown();
            }

            for (int i = 0; i < 55; i++)
            {
                soni.VolumeUp();
            }

            for (int i = 2; i > 0; i--)
            {
                senyo.VolumeDown();
            }
            Console.WriteLine($"soni " + soni);
            Console.WriteLine($"senyo " + senyo);
        }
    }
}
