using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortSpace
{
    class Program
    {
        static List<int> targetList = new List<int> { 1, 6, 2, 3, 12, 8, 7 };

        static void Main(string[] args)
        {
            //List<int> afterList = MergeSort.sort(targetList);
            //foreach (int item in afterList)
            //{
            //    Console.WriteLine(item);
            //}

            //ShellSort.sort(targetList);
            //InsertSort.sort(targetList);
            //SelectionSort.sort(targetList);
            //QuickSort.Sort(targetList, 0, targetList.Count - 1);
            BubbleSort.Sort(targetList);
            foreach (int item in targetList)
            {
                Console.WriteLine(item);
            }             
        }





    }
}
