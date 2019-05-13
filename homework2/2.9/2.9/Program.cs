using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._9
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = new int[105];
            for(int i=2;i<=100;i++)
            {
                if(a[i]==0)//判断是否筛去
                {
                    int j = i + 1;//j从3开始
                    for(;j<=100;j++)//开始筛选
                    {
                        if(a[j]==0&&j%i==0)//未作标记且不是素数
                        {
                            a[j] = 1;//做标记，筛去该数
                        }
                    }
                }
            }
            for (int i = 2; i <= 100; i++)
                if (a[i] == 0) Console.Write(i + " ");
            Console.ReadKey();
        }
    }
}
