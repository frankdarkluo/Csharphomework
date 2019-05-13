using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("输入一个数:");
            int x = Int32.Parse(Console.ReadLine());
            int[] A = new int[x + 5];
            for (int i = 2; i <= x; i++)
            {
                while (x % i == 0)//存在一个质数因子
                {
                    x /= i;//除至不含该质数因子为止
                    if(A[i]==0)//未做标记
                    {
                        Console.Write(i + " ");//输出该质数因子
                        A[i] = 1;//做标记，不重复输出
                    }
                }
            }
            Console.ReadKey();
        }
    }
}
