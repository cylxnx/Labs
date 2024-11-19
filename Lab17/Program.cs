namespace Lab17
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="array"></param>
        /// <returns></returns>
        static float Sum(float[] array)
        {
            return Sum(array);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="array"></param>
        /// <returns></returns>
        static float Average(float[] array)
        {
            return Sum(array) / array.Length;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="array"></param>
        /// <returns></returns>
        static float Min(float[] array)
        {
            float min = array[0];
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] < min)
                {
                    min = array[i];
                }
            }
            return min;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="array"></param>
        /// <returns></returns>
        static float Max(float[] array)
        {
            float max = array[0];
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] > max)
                {
                    max = array[i];
                }
            }
            return max;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="array"></param>
        /// <param name="index1"></param>
        /// <param name="index2"></param>
        /// <returns></returns>
        static float[] Swap(float[] array, int index1, int index2)
        {
            float temp = array[index1];
            array[index1] = array[index2];
            array[index2] = temp;
            return array;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="numValues"></param>
        /// <returns></returns>
        static int[] Fibonacci(int numValues)
        {
            int[] fib = new int[numValues];
            fib[0] = 0;
            fib[1] = 1;
            for (int i = 2; i < numValues; i++)
            {
                fib[i] = fib[i - 1] + fib[i - 2];
            }
            return fib;
        }
    }
}
