using System;

namespace Level3_OOPs_Advanced
{
    public class Program105_MethodOverriding
    {
        public static void Run()
        {
            Shape shape = new Circle();
            shape.Draw();
        }

        private class Shape
        {
            public virtual void Draw()
            {
                Console.WriteLine("Drawing a generic shape.");
            }
        }

        private class Circle : Shape
        {
            public override void Draw()
            {
                Console.WriteLine("Drawing a circle.");
            }
        }
    }
}
