using System;

namespace StrategyPattern._1_Initial_Duck_Class
{
    public class DecoyDuck : Duck
    {

        public override void quack()
        {
            //do nothing
        }

        public override void display()
        {
            Console.WriteLine("I am a DecoyDuck!");
        }

        public override void fly()
        {
            //do nothing
        }
    }
}
