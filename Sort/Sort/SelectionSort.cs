using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sort.Sort
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
        private static int GetSmallest(List<int> arr)
        {
            int Smallest = arr[0];
            int SmallestIndex = 0;
            for (int i = 0; i < arr.Count; i++)
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
            for (int i = 0; i < arr.Length; i++)
            {
                int SmallestIndex = GetSmallest(arr);
                result[i] = arr[SmallestIndex];
                arr[SmallestIndex] = int.MaxValue;
            }
            return result;
        }
        public static int[] Sort(List<int> arr)
        {
            int[] result = new int[arr.Count];
            for (int i = 0; i < result.Length; i++)
            {
                int SmallestIndex = GetSmallest(arr);
                result[i] = arr[SmallestIndex];
                arr.RemoveAt(SmallestIndex);
            }
            return result;
        }
    }
}
