using System;

namespace OOPInterfaces
{
    interface IMovable
    {
        void Move();
    }

    class Car : IMovable
    {
        public void Move()
        {
            Console.WriteLine("Car is moving");
        }
    }

    class Bicycle : IMovable
    {
        public void Move()
        {
            Console.WriteLine("Bicycle is moving");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            IMovable myCar = new Car();
            IMovable myBicycle = new Bicycle();

            myCar.Move();      // Output: Car is moving
            myBicycle.Move();  // Output: Bicycle is moving
        }
    }
}
