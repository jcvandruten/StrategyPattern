using System;

namespace StrategyPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            //initial branch

            //premise: a Duck game where code development undergoes many updates via adding new Ducks and Duck behavior on a frequent basis.

            //adding the fly() functionality to ducks...
            //ducks can already quack(), swim(), and display()

            //also, ducks are sub-classed into different types: MallardDuck, RedheadDuck, and RubberDuck
            //so adding fly() doesn't make sense for a RubberDuck.

            //you COULD override fly(), just like how quack() already works in RubberDuck (since RubberDucks don't quack() they *squeak*)
            //However, considering the future if, say, a WoodDuck type is added then it can neither fly() nor quack() and we're poised to
            //repeat the overriding code-writing, again.

            //Consider not using inheritance: not using the sub-classing of fly() from the parent Duck class and overriding in the sub-class.
            //Instead, consider an interface.

            //The Flyable() interface has a fly() method and only Ducks that need to fly will implement that interface. Same goes for a Quackable() interface.
            //In this case, the fly() behavior may further depend on the type of duck and still require maintenance at the interface level whenever a change
            //must be made to the fly() behavior. As many other duck types is using this interface code, this potentially can lead to issues for ALL ducks
            //if something goes wrong within the interface.

            //We need a way to impact as little other code as possible.

            //Therefore, we pull the Duck behavior out of the Duck class.

            //

            
        }
    }
}
