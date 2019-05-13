using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Simple_Factory
{
    //生产工厂  
    public class CreateFoodFactory
    {
        public static Food Cook(string type)
        {
            Food food = null;
            switch (type)
            {
                case "Noodles":
                    food = new Noodles();
                    break;
                case "Milk":
                    food = new Milk();
                    break;
            }
            return food;
        }
    }

    //生成食品的抽象类
    public abstract class Food
    {
        public abstract void PrintFood();
    }

    //生产食物
    public class Noodles : Food
    {

        public override void PrintFood()
        {
            Console.WriteLine("Noodles，Noodles");
        }
    }

    public class Milk : Food
    {
        public override void PrintFood()
        {
            Console.WriteLine("Milk，milk");
        }
    }

    //我们是一个食品生产工厂，都是生成吃的
    class Program
    {
        static void Main(string[] args)
        {
            var food1 = CreateFoodFactory.Cook("Noodles");
            food1.PrintFood();
            var food2 = CreateFoodFactory.Cook("Milk");
            food2.PrintFood();
            Console.ReadKey();
        }
    }
}