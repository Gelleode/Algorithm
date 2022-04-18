using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortAlgorithms.Sort
{
    class SelectionSort
    {
        private static int GetSmallest(int[] arr)
        {
            int Smallest = arr[0];
            int SmallestIndex = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] < Smallest)
                {
                    Smallest = arr[i];
                    SmallestIndex = i;
                }
            }
            return SmallestIndex;
        }

        public static int[] Sort(int[] arr)
        {
            int[] result = new int[arr.Length];
            for(int i = 0; i < arr.Length; i++)
            {
                result[i] = GetSmallest(arr);
            }
            return result;
        }
    }
}
