using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recursion.Recursion
{
    class Recursiоn
    {
        public static int Sum(int[] arr)
        {
            if (arr.Length == 1)
                return 0;
            return arr[0] + Sum(arr.Skip(1).ToArray());
        }
        public static int Factorial(int num)
        {
            if (num == 1)
                return 1;
            return num * Factorial(num - 1);
        }
        public static int Count(int[] arr)
        {
            if (arr.Length == 1)
                return 1;
            return 1 + Count(arr.Skip(1).ToArray());
        }
        public static int GetMax(int[] arr)
        {
            if (arr.Length == 2)
                return arr[0]>arr[1] ? arr[0] : arr[1];
            int max = GetMax(arr.Skip(1).ToArray());
            return arr[0] > max ? arr[0] : max;
        }
    }
}
