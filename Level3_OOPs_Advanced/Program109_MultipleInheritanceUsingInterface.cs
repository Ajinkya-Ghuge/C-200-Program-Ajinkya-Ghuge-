using System;

namespace Level3_OOPs_Advanced
{
    public class Program109_MultipleInheritanceUsingInterface
    {
        public static void Run()
        {
            SmartDevice device = new SmartDevice();
            device.ConnectWifi();
            device.PlayMusic();
        }

        private interface IWifiEnabled
        {
            void ConnectWifi();
        }

        private interface IMusicPlayer
        {
            void PlayMusic();
        }

        private class SmartDevice : IWifiEnabled, IMusicPlayer
        {
            public void ConnectWifi()
            {
                Console.WriteLine("Connected to Wi-Fi.");
            }

            public void PlayMusic()
            {
                Console.WriteLine("Playing music.");
            }
        }
    }
}
