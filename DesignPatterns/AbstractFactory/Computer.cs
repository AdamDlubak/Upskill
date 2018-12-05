using System;

namespace AbstractFactory
{
    public class Computer
    {

            private string _serialNumber;
            private IProcessor _processor;
            private ICooler _cooler;

            public Computer(string serialNumber, IFactory factory)
            {
                _serialNumber = serialNumber;
                _processor = factory.CreateProcessor();
                _cooler = factory.CreateCooler();
                Process();
            }

            private void Process()
            {
                Console.WriteLine("Start constructing computer with serial number: " + _serialNumber);
                _processor.Process();
                _cooler.Process();
                Console.WriteLine("Finished constructing computer with serial number: " + _serialNumber);
                Console.ReadKey();
            }
        
    }
}