using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortSpace
{
    class InsertSort
    {
        public static void Sort(List<int> list)
        {
            for (int i = 1; i < list.Count; i++)
            {
                int temp = list[i];
                for (int j = i - 1; j >= 0 ; j--)
                {
                    if (list[j] > temp)
                    {
                        list[j + 1] = list[j];
                        list[j] = temp;
                    }
                    else
                    {
                        break;
                    }
                }
            }
        }
    }
}
