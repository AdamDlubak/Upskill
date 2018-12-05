using System;

namespace AbstractFactory
{
    public interface ICooler
    {
        void Process();
    }
    public class AMDCooler : ICooler
    {
        public void Process()
        {
            Console.WriteLine("Creating AMD...");
        }
    }

    public class IntelCooler : ICooler
    {
        public void Process()
        {
            Console.WriteLine("Creating Intel...");
        }
    }
}