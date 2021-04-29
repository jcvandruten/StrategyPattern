using System;

namespace StrategyPattern._1_Initial_Duck_Class
{
    public class RubberDuck : Duck
    {

        public override void quack()
        {
            Console.WriteLine("Squeak. Squeak. Squeak. Squeak.");
        }

        public override void display()
        {
            Console.WriteLine("I am a RubberDuck!");
        }

        public override void fly()
        {
            //do nothing
        }
    }
}
