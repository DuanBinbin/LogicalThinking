using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sort
{
    class Program
    {
        static List<int> numberIntList = new List<int> { 1, 0, 0, 1, 1, 0, 0, 1 };
        static List<int> numberIntList2 = new List<int> { 0, 0, 1, 1, 0, 0, 1 };
        static List<int> numberIntList3 = new List<int> { 2, 0, 1, 1, 0, 0, 1, 5,1,1};
        static List<int> numberIntList4 = new List<int> { 1, 6, 2, 3, 12, 8, 7 };
        static int[] numberIntList5 =  { 1, 6, 2, 6, 8, 3, 12, 8, 7 };

        static void Main(string[] args)
        {
            //SortStrategy.RuleSort(numberIntList2);
            //SortStrategy.AddResultUnequal14(numberIntList4);

            //Console.WriteLine("------执行结果-------");

            //foreach (int item in numberIntList4)
            //{
            //    Console.WriteLine(item);
            //}

            //ShapeFactory.DrawDiamond();
            //ShapeFactory.DrawRectangle();
            ShapeFactory.DrawRightTriangle();
            ShapeFactory.DrawEquicruralTriangle();
            //Rabit.calculateRabitCount();
            //SortStrategy.SelectionSort(numberIntList5);           
        }

        //冒泡排序(从小到大)
        public static void RuleSort(List<int> data)
        {
            for (int i = 0; i < data.Count - 1; i++)
            {
                for (int j = 0; j < data.Count - 1 - i; j++)
                {
                    if (data[j] == data[j + 1])
                    {
                        data.RemoveAt(j + 1);
                    }                    
                }
            }
        }

        /// <summary>
        /// 该方法主要是熟悉For循环结构
        /// </summary>
        public static void ForStructure()
        {
            int i = 0;
            for (i++; i++ < 10; i++)
                ;
            Console.WriteLine(++i);
        }
    }
}
