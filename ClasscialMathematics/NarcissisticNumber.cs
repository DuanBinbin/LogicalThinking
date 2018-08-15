using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasscialMathematics
{
    class NarcissisticNumber
    {
        public static void Execute(int number)
        {
            for (int i = 100; i < number; i++)
            {
                int a = i / 100 % 10;
                int b = i / 10 % 10;
                int c = i % 10;

                if (i == a * a * a + b * b *b + c* c*c)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
