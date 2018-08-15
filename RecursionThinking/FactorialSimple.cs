using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace RecursionThinking
{
    /// <summary>
    /// 阶乘
    /// 说明：阶乘(!)是小于某个数的所有正整数的乘积；
    /// 注意：0既不是正整数,又不是负整数;0是整数；
    /// 公式：阶乘递归方式为：0!=1，n!=(n-1)!×n。
    /// </summary>
    public class FactorialSimple
    {
        /// <summary>
        /// 利用数组实现阶乘
        /// </summary>
        /// <param name="number">正整数</param>
        /// <returns></returns>
        public static long FactorialWithArray(int number)
        {
            if (number == 0)
            {
                return 1;
            }

            long result = 1;

            for (int i = number; i > 0 ; i--)
            {
                result *= i;
            }

            return result;
        }

        /// <summary>
        /// 利用递归思想实现
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
        public static long FactorialWithRecursion(int number)
        {
            if (number == 0)
            {
                return 1;
            }
            return number * FactorialWithRecursion(number - 1);
        }
    }
}
