using System;

namespace AbstractFactory
{
    public interface IProcessor
    {
        void Process();
    }
    public class AMDProcessor : IProcessor
    {
        public void Process()
        {
            Console.WriteLine("Creating AMD...");
        }
    }

    public class IntelProcessor : IProcessor
    {
        public void Process()
        {
            Console.WriteLine("Creating Intel...");
        }
    }
}