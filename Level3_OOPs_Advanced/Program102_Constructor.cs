using System;

namespace Level3_OOPs_Advanced
{
    public class Program102_Constructor
    {
        public static void Run()
        {
            Car car = new Car("Tesla", 2024);
            car.Display();
        }

        private class Car
        {
            private readonly string brand;
            private readonly int year;

            public Car(string brand, int year)
            {
                this.brand = brand;
                this.year = year;
            }

            public void Display()
            {
                Console.WriteLine($"Brand: {brand}");
                Console.WriteLine($"Year: {year}");
            }
        }
    }
}
