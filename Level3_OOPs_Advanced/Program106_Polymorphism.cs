using System;

namespace Level3_OOPs_Advanced
{
    public class Program106_Polymorphism
    {
        public static void Run()
        {
            Animal[] animals =
            {
                new Dog(),
                new Cat()
            };

            foreach (Animal animal in animals)
            {
                animal.MakeSound();
            }
        }

        private abstract class Animal
        {
            public abstract void MakeSound();
        }

        private class Dog : Animal
        {
            public override void MakeSound() => Console.WriteLine("Dog says: Woof");
        }

        private class Cat : Animal
        {
            public override void MakeSound() => Console.WriteLine("Cat says: Meow");
        }
    }
}
