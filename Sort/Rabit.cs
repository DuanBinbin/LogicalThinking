using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sort
{
    class Rabit
    {
        /// <summary>
        /// 有一对幼兔，幼兔一个月后长成小兔，小兔一个月后长成成兔并生下一对幼兔，
        /// 问n个月后一共有多少对兔子（假如兔子没有死亡）
        /// </summary>
        public static void calculateRabitCount()
        {
            Console.Write("请输入第n个月，求每个月兔子的总数：");
            int n = int.Parse(Console.ReadLine());
            int childhood = 1;
            int youth = 0;
            int adult = 0;
            int sum = 0;
            if (n == 1)
            {
                sum = childhood + youth + adult;
                Console.WriteLine("第{0}个月的幼兔数量为：{1}", n, childhood);
                Console.WriteLine("第{0}个月的小兔数量为：{1}", n, youth);
                Console.WriteLine("第{0}个月的成兔数量为：{1}", n, adult);
                Console.WriteLine("第{0}个月的总兔数量为：{1}", n, sum);
            }
            else
            {
                for (int i = 2; i <= n; i++)
                {
                    adult = adult + youth;
                    youth = childhood;
                    childhood = adult;
                    sum = childhood + youth + adult;
                    Console.WriteLine("第{0}个月的幼兔数量为：{1}", i, childhood);
                    Console.WriteLine("第{0}个月的小兔数量为：{1}", i, youth);
                    Console.WriteLine("第{0}个月的成兔数量为：{1}", i, adult);
                    Console.WriteLine("第{0}个月的总兔数量为：{1}", i, sum);
                    Console.WriteLine();
                }
            }
        }
    }
}
