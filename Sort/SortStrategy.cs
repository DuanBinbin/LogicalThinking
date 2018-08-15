using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sort
{
    class SortStrategy
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="data"></param>
        public static void BubbleSortFromBig(int[] data)
        {
            for (int i = 0; i < data.Length - 1; i++)
            {
                for (int j = data.Length - 1; j > i; j--)
                {
                    if (data[j] > data[j - 1])
                    {
                        data[j] = data[j] + data[j - 1];
                        data[j - 1] = data[j] - data[j - 1];
                        data[j] = data[j] - data[j - 1];
                    }
                }
            }
        }


        /// <summary>
        /// 冒泡排序(从小到大)
        /// </summary>
        /// <param name="data"></param>
        public static void BubbleSortFromSmall(int[] data)
        {
            for (int i = 0; i < data.Length - 1; i++)
            {
                for (int j = 0; j < data.Length - 1 - i; j++)
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

        /// <summary>
        /// 冒泡排序(从小到大)
        /// </summary>
        /// <param name="data"></param>
        public static void BubbleSortFromSmall(List<int> data)
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

        /// <summary>
        /// 相加结果不等于14
        /// </summary>
        /// <typeparam name="T">泛型</typeparam>
        /// <param name="arr">数组</param>
        public static void AddResultUnequal14(List<int> data)
        {
            int i, j, minIndex, len = data.Count;
            int temp;
            List<int> removeValueList = new List<int>();

            for (i = 0; i < len - 1; i++)
            {
                minIndex = i;
                
                for (j = i + 1; j < len; j++)
                {

                    if (data[minIndex] + data[j] == 14)
                    {
                        removeValueList.Add(data[minIndex]);
                        removeValueList.Add(data[j]);
                    }

                    if (data[minIndex].CompareTo(data[j]) > 0)
                    {
                        minIndex = j;
                    }
                }

                temp = data[minIndex];
                data[minIndex] = data[i];
                data[i] = temp;
            }

            Console.WriteLine("-------remove value ------------");

            foreach (int item in removeValueList)
            {
                Console.WriteLine("remove value = {0}", item);
                data.Remove(item);
            }

            BubbleSortFromSmall(data);
        }

        /// <summary>
        /// 使得数组中任意相邻两个不相等
        /// </summary>
        /// <param name="data"></param>
        public static void RuleSort(List<int> data)
        {
            for (int i = 0; i < data.Count - 1; i++)
            {
                if (data[i] == data[i + 1])
                {
                    data.RemoveAt(i + 1);
                }
            }
        }

        /// <summary>
        /// 选择排序
        /// </summary>
        /// <typeparam name="T">泛型</typeparam>
        /// <param name="arr">数组</param>
        public static void SelectionSort<T>(T[] arr) where T : System.IComparable<T>
        {
            int i, j, minIndex, len = arr.Length;
            T temp;
            for (i = 0; i < len - 1; i++)
            {
                minIndex = i;
                for (j = i + 1; j < len; j++)
                {
                    if (arr[minIndex].CompareTo(arr[j]) > 0)
                    {
                        minIndex = j;
                    }                        
                }                    
                temp = arr[minIndex];
                arr[minIndex] = arr[i];
                arr[i] = temp;
            }
        }

        /// <summary>
        /// 希尔排序
        /// </summary>
        public static void ShellSort()
        {

        }

        /// <summary>
        /// 快速排序
        /// </summary>
        public static void QuickSort()
        {

        }

        /// <summary>
        /// 插入排序
        /// </summary>
        public static void InsertSort()
        {

        }

        /// <summary>
        /// 归并排序（迭代版）
        /// </summary>
        public static void MergeSortWithTopDown()
        {

        }

        /// <summary>
        /// 归并排序（递归版）
        /// </summary>
        public static void MergeSortWithRecursive()
        {

        }
    }
}
