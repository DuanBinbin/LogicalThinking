using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortSpace
{
    class BubbleSort
    {
        public static void Sort(List<int> data)
        {
            for (int i = 0; i < data.Count - 1; i++)
            {
                for (int j = 0; j < data.Count - 1 - i; j++)
                {
                    if (data[j] > data[j + 1])
                    {
                        data[j] = data[j] + data[j + 1];
                        data[j + 1] = data[j] - data[j + 1];
                        data[j] = data[j] - data[j + 1];
                    }
                }
            }
        }
    }
}
