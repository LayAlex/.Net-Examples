using System;

namespace Polymorphism
{
    abstract class FlyingEntity
    {
        abstract public void Fly();
    }

    class Airplane : FlyingEntity
    {
        public override void Fly()
        {
            Console.WriteLine("Reactive Engine Working....");
        }
    }

    class Bird : FlyingEntity
    {
        public override void Fly()
        {
            Console.WriteLine("Wings up and down.. up and down...");
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            var airplane = new Airplane();
            var bird = new Bird();

            var flyingEntities = new FlyingEntity[] { airplane, bird };

            for (var i = 0; i < flyingEntities.Length; i++)
            {
                flyingEntities[i].Fly();
            }

            Console.ReadKey();
        }
    }
}
