using System.Text;
using static System.Console;

namespace grasp.arrays
{
    /// <summary>
    /// Uses arrays
    /// </summary>
    public class UsingArrays
    {
        /// <summary>
        /// Simple array use
        /// </summary>
        public void Simple()
        {
            //single-dimensional array. 10 ints.
            int[] array1 = new int[10];

            //this line would result in an
            //exception: System.IndexOutOfRangeException: Index was outside the bounds of the array.
            //the array is only allocated for 10 possible values (0 - 9 indices).
            //array1[14] = 29;

            var display = string.Join(",", array1);

            WriteLine($"array1={display}\n\n");

            // set new array element values.
            int[] array2 = new int[] { 1, 3, 5, 7, 9 };

            display = string.Join(",", array2);

            WriteLine($"array2={display}\n\n");

            // another way to declare arrays.
            int[] array3 = { 1, 2, 3, 4, 5, 6 };

            display = string.Join(",", array3);

            WriteLine($"array3={display}\n\n");

            // 2 dimensional array.
            int[,] multiDimensionalArray1 = new int[2, 3];

            display = string.Join(",", multiDimensionalArray1);

            var stringBuilder = new StringBuilder();

            foreach (var s in multiDimensionalArray1)
            {
                stringBuilder.AppendLine(string.Join(",", s));
            }

            display = stringBuilder.ToString();

            WriteLine($"multiDimensionalArray1={display}\n\n");

            // another way for 2 dimensional array.
            int[,] multiDimensionalArray2 = { { 1, 2, 3 }, { 4, 5, 6 } };

            display = string.Join(",", multiDimensionalArray2);

            stringBuilder = new StringBuilder();

            foreach (var s in multiDimensionalArray2)
            {
                stringBuilder.AppendLine(string.Join(",", s));
            }

            display = stringBuilder.ToString();

            WriteLine($"multiDimensionalArray2={display}\n\n");

            // jagged array.
            int[][] jaggedArray = new int[6][];
            
            jaggedArray[0] = new int[4] { 1, 2, 3, 4 };
            jaggedArray[1] = new int[] { -9, 2, 3 };
            jaggedArray[2] = new int[] { -1, 8, 20 };
            jaggedArray[3] = new int[] { -19, 2, 7 };
            jaggedArray[4] = new int[] { -32, 100, 3 };
            jaggedArray[5] = new int[] { 43, 200, 3 };

            stringBuilder = new StringBuilder();

            foreach(var s in jaggedArray)
            {
                stringBuilder.AppendLine(string.Join(",", s));
            }

            display = stringBuilder.ToString();

            WriteLine($"jaggedArray={display}\n\n");
        }
    }
}
