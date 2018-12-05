using System;
using static Facade.Car;

namespace Facade
{
    class Program
    {
        static void Main(string[] args)
        {
            var facade = new CarFacade(new CarAccessories(), new CarBody(), new CarEngine(), new CarModel());

            facade.CreateCompleteCar();
            Console.ReadKey();
        }
    }
}
