using System;

namespace Level3_OOPs_Advanced
{
    public class Program104_Inheritance
    {
        public static void Run()
        {
            Dog dog = new Dog();
            dog.Eat();
            dog.Bark();
        }

        private class Animal
        {
            public void Eat()
            {
                Console.WriteLine("Animal is eating.");
            }
        }

        private class Dog : Animal
        {
            public void Bark()
            {
                Console.WriteLine("Dog is barking.");
            }
        }
    }
}
