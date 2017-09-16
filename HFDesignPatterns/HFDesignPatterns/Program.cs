using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HFDesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
        }
        public class Duck
        {
            QuackBehavior quackBehavior;
            //mais
            public void performQuack()
            {
                quackBehavior.quack();
            }
        }
        public class MallardDuck : Duck
        {
            public MallardDuck()
            {
                quackBehavior = new Quack();
                flyBehavior = new FlyWithWings();
            }
        }

    }
}
