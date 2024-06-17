using System;

namespace OOPInheritance
{
    class Animal
    {
        public virtual void MakeSound()
        {
            Console.WriteLine("Some generic sound");
        }
    }

    class Dog : Animal
    {
        public override void MakeSound()
        {
            Console.WriteLine("Bark");
        }
    }

    class Cat : Animal
    {
        public override void MakeSound()
        {
            Console.WriteLine("Meow");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Animal myAnimal = new Animal();
            Dog myDog = new Dog();
            Cat myCat = new Cat();

            myAnimal.MakeSound(); // Outputs: Some generic sound
            myDog.MakeSound();    // Outputs: Bark
            myCat.MakeSound();    // Outputs: Meow
        }
    }
}
