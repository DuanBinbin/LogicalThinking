using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sort
{
    class ShapeFactory
    {
        /// <summary>
        /// 输出直角三角形
        /// </summary>
        public static void DrawRightTriangle()
        {
            Console.Write("请输入一个正整数：");
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }

        /// <summary>
        /// 输出等腰三角形
        /// </summary>
        public static void DrawEquicruralTriangle()
        {
            Console.Write("请输入一个正整数：");
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                for (int k = 0; k < n - i; k++)
                {
                    Console.Write(" ");
                }
                for (int j = 1; j <= 2 * i - 1; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }

        /// <summary>
        /// 输出一个菱形  
        /// </summary>
        public static void DrawDiamond()
        {
            Console.Write("请输入一个正整数：");
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                for (int k = 0; k < n - i; k++)
                {
                    Console.Write(" ");
                }
                for (int j = 1; j <= 2 * i - 1; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            for (int i1 = 1; i1 <= n - 1; i1++)
            {
                for (int k1 = 0; k1 < i1; k1++)
                {
                    Console.Write(" ");
                }
                for (int j1 = 1; j1 <= 2 * (n - i1) - 1; j1++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }

        /// <summary>
        /// 输出一个中间为菱形的矩形
        /// </summary>
        public static void DrawRectangle()
        {
            Console.Write("请输入一个正整数：");
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                for (int k = 0; k < n - i; k++)
                {
                    Console.Write("-");
                }
                for (int j = 1; j <= 2 * i - 1; j++)
                {
                    if (Convert.ToBoolean(j & 1))
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write("-");
                    }
                }
                for (int k = 0; k < n - i; k++)
                {
                    Console.Write("-");
                }
                Console.WriteLine();
            }
            for (int i1 = 1; i1 <= n - 1; i1++)
            {
                for (int k1 = 0; k1 < i1; k1++)
                {
                    Console.Write("-");
                }
                for (int j1 = 1; j1 <= 2 * (n - i1) - 1; j1++)
                {
                    if (Convert.ToBoolean(j1 & 1))
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write("-");
                    }
                }
                for (int k1 = 0; k1 < i1; k1++)
                {
                    Console.Write("-");
                }
                Console.WriteLine();
            }
        }        
    }
}
