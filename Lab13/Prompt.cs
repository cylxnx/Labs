//Cody Lane
//clane15@stumail.northeaststate.edu
namespace Lab13P
{
    /// <summary>
    /// Provides prompting methods for the console
    /// </summary>
    internal static class Prompt
    {

        /// <summary>
        /// Prompts the user for a boolean value and returns it
        /// </summary>
        /// <param name="message">message to print with prompt</param>
        /// <returns>user input as a bool</returns>
        public static bool ForBool(string message)
        {
            Console.Write(message);
            string? input = Console.ReadLine();
            return Convert.ToBoolean(input);
        }

        /// <summary>
        /// Prompts the user for a char value and returns it
        /// </summary>
        /// <param name="message">message to print with prompt</param>
        /// <returns>user input as a char</returns>
        public static char ForChar(string message)
        {
            Console.Write(message);
            string? input = Console.ReadLine();
            return Convert.ToChar(input);
        }

        /// <summary>
        /// Prompts the user for a string value and returns it
        /// </summary>
        /// <param name="message">message to print with prompt</param>
        /// <returns>user input</returns>
        public static string ForString(string message)
        {
            Console.Write(message);
            string? input = Console.ReadLine();
            return input;
        }

        /// <summary>
        /// Prompts the user for an int value and returns it
        /// </summary>
        /// <param name="message">message to print with prompt</param>
        /// <returns>user input as an int</returns>
        public static int ForInt(string message)
        {
            Console.Write(message);
            string? input = Console.ReadLine();
            return Convert.ToInt32(input);
        }

        /// <summary>
        /// Prompts the user for a float value and returns it
        /// </summary>
        /// <param name="message">message to print with prompt</param>
        /// <returns>user input as a float</returns>
        public static float ForFloat(string message)
        {
            Console.Write(message);
            string? input = Console.ReadLine();
            return Convert.ToSingle(input);
        }

        /// <summary>
        /// Prompts the user for a double value and returns it
        /// </summary>
        /// <param name="message">message to print with prompt</param>
        /// <returns>user input as a double</returns>
        public static double ForDouble(string message)
        {
            Console.Write(message);
            string? input = Console.ReadLine();
            return Convert.ToDouble(input);
        }

        /// <summary>
        /// Prompts the user for a decimal value and returns it
        /// </summary>
        /// <param name="message">message to print with prompt</param>
        /// <returns>user input as a decimal</returns>
        public static decimal ForDecimal(string message)
        {
            Console.Write(message);
            string? input = Console.ReadLine();
            return Convert.ToDecimal(input);
        }

        /// <summary>
        /// Prompts the user for a long value and returns it
        /// </summary>
        /// <param name="message">message to print with prompt</param>
        /// <returns>user input as a long</returns>
        public static long ForLong(string message)
        {
            Console.Write(message);
            string? input = Console.ReadLine();
            return Convert.ToInt64(input);
        }

        /// <summary>
        /// Prompts the user for a short value and returns it
        /// </summary>
        /// <param name="message">message to print with prompt</param>
        /// <returns>user input as a short</returns>
        public static short ForShort(string message)
        {
            Console.Write(message);
            string? input = Console.ReadLine();
            return Convert.ToInt16(input);
        }

        /// <summary>
        /// Prompts the user for a byte value and returns it
        /// </summary>
        /// <param name="message">message to print with prompt</param>
        /// <returns>user input as a byte</returns>
        public static byte ForByte(string message)
        {
            Console.Write(message);
            string? input = Console.ReadLine();
            return Convert.ToByte(input);
        }

        /// <summary>
        /// Prompts the user for a sbyte value and returns it
        /// </summary>
        /// <param name="message">message to print with prompt</param>
        /// <returns>user input as a sbyte</returns>
        public static sbyte ForSByte(string message)
        {
            Console.Write(message);
            string? input = Console.ReadLine();
            return Convert.ToSByte(input);
        }

        /// <summary>
        /// Prompts the user for an uint value and returns it
        /// </summary>
        /// <param name="message">message to print with prompt</param>
        /// <returns>user input as an uint</returns>
        public static uint ForUInt(string message)
        {
            Console.Write(message);
            string? input = Console.ReadLine();
            return Convert.ToUInt32(input);
        }

        /// <summary>
        /// Prompts the user for a ushort value and returns it
        /// </summary>
        /// <param name="message">message to print with prompt</param>
        /// <returns>user input as a ushort</returns>
        public static ushort ForUShort(string message)
        {
            Console.Write(message);
            string? input = Console.ReadLine();
            return Convert.ToUInt16(input);
        }

        /// <summary>
        /// Prompts the user for a ulong value and returns it
        /// </summary>
        /// <param name="message">message to print with prompt</param>
        /// <returns>user input as a ulong</returns>
        public static ulong ForULong(string message)
        {
            Console.Write(message);
            string? input = Console.ReadLine();
            return Convert.ToUInt64(input);
        }
    }
}
