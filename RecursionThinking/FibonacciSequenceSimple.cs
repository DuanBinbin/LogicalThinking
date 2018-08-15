using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecursionThinking
{
    

    public class FibonacciSequenceSimple
    {
        /// <summary>
        /// 使用递归思想实现斐波那切数列
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
        public static long FibonacciWithRecursion(int number)
        {
            if (number <= 0)
            {
                throw new ArgumentOutOfRangeException();
            }

            if (number == 1 || number == 2)
            {
                return 1;
            }

            return FibonacciWithRecursion(number - 1) + FibonacciWithRecursion(number - 2);
        }

        /// <summary>
        /// 使用For循环实现斐波那切数列
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
        public static long FibonacciWithForLoop(int number)
        {
            if (number == 0)
            {
                throw new ArgumentOutOfRangeException();
            }

            int a = 1, b = 1;

            for (int i = 3; i <= number; i++)
            {
                b = a + b;
                a = b - a;                
            }

            return b;
        }
    }
}
