using System;

namespace Schulzy.TrafficSimulation.Launcher
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            if (args == null)
                throw new ArgumentNullException(nameof(args));
            
            Console.WriteLine("Hello World!");
            Console.ReadKey();
        }
    }
}