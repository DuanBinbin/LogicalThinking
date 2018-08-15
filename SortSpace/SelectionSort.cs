using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortSpace
{
    /// <summary>
    /// 选择排序
    /// </summary>
    class SelectionSort
    {
        public static void sort<T>(List<T> list) where T : System.IComparable<T> // 整数或者浮点数皆可使用
        {
            int i, j, min, len = list.Count;
            T temp;
            for (i = 0; i < len - 1; i++)
            {
                min = i;// 未排序序列中最小数据数组下标
                for (j = i + 1; j < len; j++)// 在未排序元素中继续寻找最小元素，并保存其下标
                {
                    if (list[min].CompareTo(list[j]) > 0)
                    {
                        min = j;
                    }
                }

                temp = list[min];// 将最小元素放到已排序序列的末尾
                list[min] = list[i];
                list[i] = temp;
            }
        }
    }
}
