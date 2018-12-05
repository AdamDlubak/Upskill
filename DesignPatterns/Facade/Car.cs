using System;
using static Facade.Car;

namespace Facade
{
    public class Car
    {
        public interface ICarModel
        {
            void SetModel();
        }

        public class CarModel : ICarModel
        {
            public void SetModel()
            {
                Console.WriteLine(" CarModel - SetModel");
            }
        }

        public interface ICarEngine
        {
            void SetEngine();
        }

        public class CarEngine : ICarEngine
        {
            public void SetEngine()
            {
                Console.WriteLine(" CarEngine - SetEngine");
            }
        }

        public interface ICarBody
        {
            void SetBody();
        }

        public class CarBody : ICarBody
        {
            public void SetBody()
            {
                Console.WriteLine(" CarBody - SetBody");
            }
        }

        public interface ICarAccessories
        {
            void SetAccessories();
        }

        public class CarAccessories : ICarAccessories
        {
            public void SetAccessories()
            {
                Console.WriteLine(" CarAccessories - SetAccessories");
            }
        }
    }

    public class CarFacade
    {
        private readonly ICarAccessories accessories;
        private readonly ICarBody body;
        private readonly ICarEngine engine;
        private readonly ICarModel model;

        public CarFacade(ICarAccessories accessories, ICarBody body, ICarEngine engine, ICarModel model)
        {
            this.accessories = accessories;
            this.body = body;
            this.engine = engine;
            this.model = model;
        }

        public void CreateCompleteCar()
        {
            Console.WriteLine("Creating a Car\n");
            model.SetModel();
            engine.SetEngine();
            body.SetBody();
            accessories.SetAccessories();

            Console.WriteLine("\nCar creation is completed.");
        }
    }
}
