using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sort.Sort
{
    class QuickSort
    {
        public static IEnumerable<int> QSort(IEnumerable<int> list)
        {
            if (list.Count() <= 1) return list;
            var pivot = list.First();
            var less = list.Skip(1).Where(i => i <= pivot);
            var greater = list.Skip(1).Where(i => i > pivot);
            return QSort(less).Union(new List<int> { pivot }).Union(QSort(greater));
        }
    }
}
