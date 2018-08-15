using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortSpace
{
    /// <summary>
    /// 归并排序
    /// </summary>
    class MergeSort
    {

        public static List<int> sort(List<int> list)
        {
            if (list.Count <= 1)
            {
                return list;
            }

            int mid = list.Count / 2;
            List<int> left = new List<int>();   //定义左侧List
            List<int> right = new List<int>();  //定义右侧List

            // 以下两个循环把list分为左右两个List
            for (int i = 0; i < mid; i++)
            {
                left.Add(list[i]);
            }
            for (int j = mid; j < list.Count; j++)
            {
                right.Add(list[j]);
            }

            left = sort(left);
            right = sort(right);
            return merge(left, right);
        }

        /// <summary>
        /// 合并两个已经排好序的List
        /// </summary>
        /// <param name="left">左侧List</param>
        /// <param name="right">右侧List</param>
        /// <returns></returns>
        private static List<int> merge(List<int> left,List<int> right)
        {
            List<int> temp = new List<int>();
            while (left.Count > 0 && right.Count > 0)
            {
                if (left[0] <= right[0])
                {
                    temp.Add(left[0]);
                    left.RemoveAt(0);
                }
                else
                {
                    temp.Add(right[0]);
                    right.RemoveAt(0);
                }
            }

            if (left.Count > 0)
            {
                for (int i = 0; i < left.Count; i++)
                {
                    temp.Add(left[i]);
                }
            }

            if (right.Count > 0)
            {
                for (int i = 0; i < right.Count; i++)
                {
                    temp.Add(right[i]);
                }
            }

            return temp;
        }

    }
}
