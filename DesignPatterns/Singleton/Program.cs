using System;

namespace Singleton
{
    class Program
    {
        public class Shop
        {
            private static Shop _instance = new Shop(243);

            public int NumberOfProducts { get; set; }

            public static Shop GetInstance()
            {
                return _instance;
            }

            private Shop(int productsNumber)
            {
                NumberOfProducts = productsNumber;
            }
        }

        static void Main(string[] args)
        {
            var instance = Shop.GetInstance();

            Console.WriteLine(instance.NumberOfProducts);
            Console.ReadKey();
        }
    }
}
