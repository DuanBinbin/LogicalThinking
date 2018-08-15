using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortSpace
{
    /// <summary>
    /// 希尔排序
    /// </summary>
    class ShellSort
    {
        public static void sort(List<int> list)
        {
            int mid = list.Count / 2;
            int i, j, temp;
            while (mid >= 1)
            {
                for (i = 0; i < list.Count; i++)
                {
                    temp = list[i];
                    j = i - mid;
                    while (j >= 0 && list[j] < temp)
                    {
                        list[j + mid] = list[j];
                        j = j - mid;
                    }
                    list[j + mid] = temp;
                }
                mid = mid / 2;
            }
            list.Reverse();
        }
    }
}
