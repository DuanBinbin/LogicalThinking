﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortSpace
{
    class QuickSort
    {
        public static void Sort(List<int> numbers,int left,int right)
        {
            if (left < right)
            {
                int middle = numbers[(left + right) / 2];
                int i = left - 1;
                int j = right + 1;
                while (true)
                {
                    while (numbers[++i] < middle);
                    while (numbers[--j] > middle);

                    if (i >= j)
                    {
                        break;
                    }

                    Swap(numbers, i, j);
                }

                Sort(numbers, left, i - 1);
                Sort(numbers, j + 1, right);
            }
        }

        private static void Swap(List<int> numbers,int i,int j)
        {
            int number = numbers[i];
            numbers[i] = numbers[j];
            numbers[j] = number;
        }
    }
}
