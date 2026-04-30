using System;

namespace Level3_OOPs_Advanced
{
    public class Program149_Attributes
    {
        public static void Run()
        {
            Type type = typeof(DemoService);
            object[] attributes = type.GetCustomAttributes(typeof(DeveloperInfoAttribute), false);

            foreach (DeveloperInfoAttribute attribute in attributes)
            {
                Console.WriteLine($"Developer: {attribute.Name}");
            }
        }

        [AttributeUsage(AttributeTargets.Class)]
        private class DeveloperInfoAttribute : Attribute
        {
            public DeveloperInfoAttribute(string name)
            {
                Name = name;
            }

            public string Name { get; }
        }

        [DeveloperInfo("Ajinkya")]
        private class DemoService
        {
        }
    }
}
