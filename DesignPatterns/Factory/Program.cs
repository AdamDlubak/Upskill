namespace Factory
{
    class Program
    {
        static void Main(string[] args)
        {

            // Simple Factory
            var productProcess = new ProductProcess(new SimpleFactory());
            productProcess.DoAction("Caffee");
            productProcess.DoAction("Tea");

            // Static Factory
            var staticProductProcess = new ProductProcess();
            staticProductProcess.StaticDoAction("Caffee");
            staticProductProcess.StaticDoAction("Tea");

            // Factory Method
            AbstractProductProcess factory;

            factory = new PolishProductProcess();
            factory.DoAction("Caffee"); 

            factory = new GermanProductProcess();
            factory.DoAction("Tea");
        }
    }
}
