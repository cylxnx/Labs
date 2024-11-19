//Cody Lane
//clane15@stumail.northeaststate.edu
namespace Lab17
{
    internal class Program
    {
        static void Main()
        {
            float[] array = new float[20];
            Random random = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = (float)(random.NextDouble() * 100);
            }

            Console.WriteLine(ArrayFunc.ArrayToString(array));
            Console.WriteLine("Sum: " + ArrayFunc.Sum(array));
            Console.WriteLine("Average: " + ArrayFunc.Average(array));
            Console.WriteLine("Min: " + ArrayFunc.Min(array));
            Console.WriteLine("Max: " + ArrayFunc.Max(array));
            Console.WriteLine("Swapped: " + ArrayFunc.ArrayToString(ArrayFunc.Swap(array, 0, 19)));
            Console.WriteLine("Fibonacci: " + ArrayFunc.ArrayToString(ArrayFunc.Fibonacci(30)));
        }
        
    }
}
