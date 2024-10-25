//Cody Lane
//clane15@stumail.northeaststate.edu
using Lab13P;

namespace Lab13
{
    /// <summary>
    /// Demonstrates using programmer defined static classes
    /// </summary>
    internal static class Program
    {
        /// <summary>
        /// Program entry point
        /// </summary>
        static void Main()
        {
            #region declare variables
            bool a;
            byte b;
            sbyte c;
            char d;
            decimal e;
            double f;
            float g;
            int h;
            uint i;
            long j;
            ulong k;
            short l;
            ushort m;
            string n;
            #endregion

            #region prompt for values
            a = Prompt.ForBool("Enter a boolean: ");
            b = Prompt.ForByte("Enter a byte: ");
            c = Prompt.ForSByte("Enter a sbyte: ");
            d = Prompt.ForChar("Enter a char: ");
            e = Prompt.ForDecimal("Enter a decimal: ");
            f = Prompt.ForDouble("Pardon me, may I have a double?: ");
            g = Prompt.ForFloat("Enter a float: ");
            h = Prompt.ForInt("Enter an int: ");
            i = Prompt.ForUInt("Enter an uint: ");
            j = Prompt.ForLong("Enter a long: ");
            k = Prompt.ForULong("Enter a ulong: ");
            l = Prompt.ForShort("Enter a short: ");
            m = Prompt.ForUShort("Enter a ushort: ");
            n = Prompt.ForString("Enter a string: ");
            #endregion

            #region print values
            Console.WriteLine("a = " + a);
            Console.WriteLine("b = " + b);
            Console.WriteLine("c = " + c);
            Console.WriteLine("d = " + d);
            Console.WriteLine("e = " + e);
            Console.WriteLine("f = " + f);
            Console.WriteLine("g = " + g);
            Console.WriteLine("h = " + h);
            Console.WriteLine("i = " + i);
            Console.WriteLine("j = " + j);
            Console.WriteLine("k = " + k);
            Console.WriteLine("l = " + l);
            Console.WriteLine("m = " + m);
            Console.WriteLine("n = " + n);
            #endregion
        }
    }
}
