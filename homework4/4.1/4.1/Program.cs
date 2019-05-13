/*使用事件机制，模拟实现一个闹钟的定时功能，可以设置闹钟
在闹钟时间到了以后，在控制台显示提示信息。*/

using System;
using System.Timers;

namespace _4._1
{
    class Clock
    {
        public delegate void AlarmClock();//声明事件委托类型
        public event AlarmClock TimeOutput;//声明一个事件
        public void Start()//定义引发事件的方法
        {
            TimeOutput();
        }
    }
    class Alarm
    {
        public void Alarmout()
        {
            Console.WriteLine("闹钟时间到了!!!");
            Console.ReadKey();
        }

    }
    class Program
    {
        static Timer t = new Timer(1000); // 定时器
        static int hour, min, second;     // 设定的时间
        static Clock clock = new Clock(); // 闹钟

        public static void SetTime()      // 设置闹钟时间
        {
            Console.WriteLine("请输入闹钟时间：(时-分-秒)");
            hour =Int32.Parse(Console.ReadLine());
            min = Int32.Parse(Console.ReadLine());
            second = Int32.Parse(Console.ReadLine());
        }
        static void Main(string[] args)
        {
            Console.WriteLine("当前时间为:" + DateTime.Now);
            Alarm alarm = new Alarm();
            SetTime();//调用设置时间函数
            clock.TimeOutput += new Clock.AlarmClock(alarm.Alarmout);// 订阅事件
            // 设置定时器
            t.Enabled = true;
            t.Elapsed += T_Elapsed;
            Console.Read();
        }
     
         private static void T_Elapsed(object sender, ElapsedEventArgs e)// 定时器函数
         {
            int []now=new int[3];
            now[0] = Int32.Parse(DateTime.Now.Hour.ToString());   //时
            now[1] = Int32.Parse(DateTime.Now.Minute.ToString()); //分
            now[2] = Int32.Parse(DateTime.Now.Second.ToString()); //秒
            if (now[0]==hour&&now[1]==min&&now[2]==second) // 关闭定时器
            {
                clock.Start();// 触发事件
                t.Enabled = false;// 关闭定时器
            }
        }

    }
}