//Cody Lane
//clane15@stumail.northeaststate.edu
namespace Lab17
{
    /// <summary>
    /// This class contains methods for working with arrays
    /// </summary>
    public class ArrayFunc
    {
        /// <summary>
        /// Determines the sum of the elements in a float array
        /// and returns the result as a single float
        /// </summary>
        /// <param name="array">input array</param>
        /// <returns>floating point number</returns>
        public static float Sum(float[] array)
        {
            float sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                sum += array[i];
            }
            return sum;
        }
        /// <summary>
        /// Determines the average of the elements in a float array
        /// and returns the result as a single float
        /// </summary>
        /// <param name="array">input array</param>
        /// <returns>floating point number</returns>
        public static float Average(float[] array)
        {
            return Sum(array) / array.Length;
        }
        /// <summary>
        /// Determines the minimum value in a float array
        /// and returns the result as a single float
        /// </summary>
        /// <param name="array">input array</param>
        /// <returns>floating point number</returns>
        public static float Min(float[] array)
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
        /// Determines the maximum value in a float array
        /// and returns the result as a single float
        /// </summary>
        /// <param name="array">input array</param>
        /// <returns>floating point number</returns>
        public static float Max(float[] array)
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
        /// Swaps the values at two indices in a float array
        /// and returns the modified array
        /// </summary>
        /// <param name="array">input array</param>
        /// <param name="index1">1st index value for swap</param>
        /// <param name="index2">2nd index value for swap</param>
        /// <returns>float array with indices swapped according to values provided</returns>
        public static float[] Swap(float[] array, int index1, int index2)
        {
            float temp = array[index1];
            array[index1] = array[index2];
            array[index2] = temp;
            return array;
        }
        /// <summary>
        /// Calculates the Fibonacci sequence up to a specified number of values
        /// </summary>
        /// <param name="numValues">Fibonacci terms to calculate</param>
        /// <returns>Fibonacci sequence calculation to numValues</returns>
        public static int[] Fibonacci(int numValues)
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
        /// <summary>
        /// Converts a float array to a string
        /// for display purposes
        /// </summary>
        /// <param name="array">input array</param>
        /// <returns>string</returns>
        public static string ArrayToString(float[] array)
        {
            string result = "";
            for (int i = 0; i < array.Length; i++)
            {
                result += array[i] + " ";
            }
            return result;
        }
        /// <summary>
        /// Converts an int array to a string
        /// for display purposes
        /// </summary>
        /// <param name="array">input array</param>
        /// <returns>string</returns>
        public static string ArrayToString(int[] array)
        {
            string result = "";
            for (int i = 0; i < array.Length; i++)
            {
                result += array[i] + " ";
            }
            return result;

        }
    }
}

