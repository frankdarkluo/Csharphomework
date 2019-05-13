using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._7
{
    class Program
    {

        static void Main(string[] args)
        {
            int[] a = new int[10];
            int sum =0;
            for (int i = 0; i < 10; i++)
                a[i] = Int32.Parse(Console.ReadLine());
            int max = a[0], min = a[0];
            for (int i = 0; i < 10; i++)
            {
                sum += a[i];//求和
                if (max > a[i]) max = a[i];//求最大值
                if (min < a[i]) max = a[i];//求最小值
            }
            double avr = sum / 10.0;//求平均值
            Console.WriteLine("数组最大值为" + max);
            Console.WriteLine("数组最小值为" + min);
            Console.WriteLine("数组的平均值为" + avr);
            Console.WriteLine("数组所有元素的和为" + sum);
            Console.ReadKey();
        }
    }
}
