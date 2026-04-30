using System;

namespace Level3_OOPs_Advanced
{
    public class Program117_AbstractClassVsInterface
    {
        public static void Run()
        {
            SmartAppliance appliance = new SmartAppliance();
            appliance.TurnOn();
            appliance.Connect();
        }

        private abstract class Appliance
        {
            public void TurnOn()
            {
                Console.WriteLine("Appliance turned on using shared abstract-class logic.");
            }
        }

        private interface IConnectable
        {
            void Connect();
        }

        private class SmartAppliance : Appliance, IConnectable
        {
            public void Connect()
            {
                Console.WriteLine("Device connected using interface contract.");
            }
        }
    }
}
