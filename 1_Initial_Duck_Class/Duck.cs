using System;

namespace StrategyPattern._1_Initial_Duck_Class
{
    public class Duck
    {
        public virtual void quack()
        {
            Console.WriteLine("Quack. Quack.");
        }

        public void swim()
        {
            Console.WriteLine("Swim. Swim.");
        }

        public virtual void display()
        {
            Console.WriteLine("I am a Duck!");
        }

        public virtual void fly()
        {
            Console.WriteLine("I am flying like a Duck!");
        }
    }
}
