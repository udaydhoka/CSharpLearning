using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snippets
{
    static class OnArrays
    {
        ///sorting an array ascending

        public static void ArraySort()
        {
            int[] arr = { 3, 4, 1, 9, 2, 7, 0, 6 };
            int temp = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i] > arr[j]) //for desc change > to < 
                    {
                        temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }
                }

            }
            foreach (var item in arr)
            {
                Console.Write(item + "\t");
            }
        }

        ///reverse an array
        ///

        public static void ArrayReverse()
        {
            int[] arr = { 1, 2, 3, 4, 5, 6 };
            int temp1 = 0, temp2 = 0;
            for (int i = 0, j = arr.Length -1; i < j; i++, j--)
            {
                temp1 = arr[i];
                temp2 = arr[j];
                arr[j] = temp1;                
                arr[i] = temp2;
                
            }
            foreach (var item in arr)
            {
                Console.WriteLine(item);
            }
            
        }

        ///right circular rotataion of an array           

        public static void RightCircularRotationOfArray()
        {
            int[] arr = { 1, 2, 3, 4, 5 };
            int order = 1;
            while (order > 0)
            {
                int temp = arr[arr.Length - 1];
                for (int i = arr.Length - 1; i > 0; i--)
                {
                    arr[i] = arr[i - 1];
                }
                arr[0] = temp;
                order--;
            }
            foreach (var item in arr)
            {
                Console.WriteLine(item + " ");
            }
        }

        ///left circular rotation of an array
        ///
        public static void LeftCircularRotationOfArray()
        {
            int[] arr = { 1, 2, 3, 4, 5 };
            int n = 2; //order to shift
            while (n > 0)
            {
                int temp = arr[0];
                for (int i = 0; i < arr.Length - 1; i++)
                {
                    arr[i] = arr[i + 1];
                }
                arr[arr.Length - 1] = temp;
                n--;
            }
            foreach (var item in arr)
            {
                Console.WriteLine(item + " ");
            }
        }        

        ///finding largest number in array
        ///
        public static void ArrayLargeNumber()
        {
            int[] arr = { 100, 3, 4, 98, 33433 };
            int max = arr[0];

            foreach (var item in arr)
            {
                if (item > max)
                    max = item;
            }
            Console.WriteLine(max);
        }

        ///finding second largest number in a array
        
        public static void ArraySecondLargeNumber()
        {
            int[] arr = { 3, 6, 8, 1, 4, 7, 2 };
            int max1 = int.MinValue;
            int max2 = int.MinValue;

            foreach (int i in arr)
            {
                if (i > max1)
                {
                    max2 = max1;
                    max1 = i;
                }
                else if (i >= max2 && i != max1)
                {
                    max2 = i;
                }
            }
            Console.WriteLine(max2); 
        }

        //finding third largest number in a array

        public static void ArrayThirdLargestNumber()
        {
            int[] arr = new int[] { 3, 5, 9, 0, 7, 1, 8, 2 };

            int max1 = int.MinValue;
            int max2 = int.MinValue;
            int max3 = int.MinValue;

            foreach (var item in arr)
            {
                if( item > max1)
                {
                    max3 = max2;
                    max2 = max1;
                    max1 = item;
                }
                else if(item >= max2 && item != max1)
                {
                    max3 = max2;
                    max2 = item;
                }
                else if(item >= max3 && item != max2 && item != max1)
                {
                    max3 = item;
                }

            }
            Console.WriteLine(max3); 
        }


        //finding second smallest number in a array
        public static void ArraySecondSmallNumber()
        {
            int[] arr = { 3, 6, 8, 1, 4, 7, 2 };
            int min1 = int.MaxValue;
            int min2 = int.MaxValue;

            foreach (int i in arr)
            {
                if (i < min1)
                {
                    min2 = min1;
                    min1 = i;
                }
                else if (i <= min2 && i != min1)
                {
                    min2 = i;
                }
            }
            Console.WriteLine(min2);
        }

        // 2D to 1D Conversions
        internal static void MultiToSingle()
        {
            int[,] array = { { 1, 2, 3 }, { 4, 5, 6 } };
            int index = 0;
            int width = array.GetLength(0);
            int height = array.GetLength(1);
            int[] single = new int[width * height];
            for (int x = 0; x < width; x++)
            {
                for (int y = 0; y < height; y++)
                {
                    single[index] = array[x, y];
                    Console.Write(single[index] + " ");
                    index++;
                }
            }
        }

        // 1D to 2D
        internal static void SingleToMulti(int[] array, int row, int column)
        {
            int index = 0;
            int[,] multi = new int[row, column];

            for (int y = 0; y < row; y++)
            {
                for (int x = 0; x < column; x++)
                {
                    multi[y, x] = array[index];
                    index++;
                    Console.Write(multi[y, x] + " ");
                }
                Console.WriteLine();
            }
        }

        ///return distinct elements in an array
        
        public static void ArrayDistinctElement()
        {
            int[] arr = { 1, 3, 5, 3, 5, 3, 3, 5 };

            Dictionary<int, int> dict = new Dictionary<int, int>();

            foreach (var item in arr)
            {
                if (dict.ContainsKey(item))
                    continue;
                else
                    dict.Add(item, item);
            }
            
            foreach(var x in dict.Keys)
            {
                Console.WriteLine(x);
            }
        }


        /// array missing number 
        /// 
        public static void ArrayMissingNumber()
        {
            int[] arr = { 7, 3, 4, 1, 2, 6 };
            
            int total = (arr.Length + 1)*(arr.Length + 2) / 2;

            int sum = arr.Sum();

            Console.WriteLine($"Missing number = {total - sum}");
        }
    }
}
