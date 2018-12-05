namespace Factory
{
    public class ProductProcess
    {
        private SimpleFactory _factory;

        // Simple Factory
        public ProductProcess(SimpleFactory factory)
        {
            _factory = factory;
        }
        public void DoAction(string type)
        {
            var product = _factory.CreateProduct(type);
            product.ShowDescription();
        }


        // Static Factory
        public ProductProcess()
        {
        }

        public void StaticDoAction(string type)
        {
            var product = SimpleFactory.StaticCreateProduct(type);
            product.ShowDescription();
        }
    }

    // Factory Method
    public abstract class AbstractProductProcess
    {
        public void DoAction(string type)
        {
            var product = CreateProduct(type);
            product.ShowDescription();
        }

        protected abstract Product CreateProduct(string type);
    }

    public class PolishProductProcess : AbstractProductProcess
    {
        protected override Product CreateProduct(string type)
        {
            Product product;
            if (type == "Caffee")
            {
                product = new PolishCaffee();
            }
            else
            {
                product = new PolishTea();
            }
            return product;
        }

     
    }

    public class GermanProductProcess : AbstractProductProcess
    {
        protected override Product CreateProduct(string type)
        {
            Product product;
            if (type == "Caffee")
            {
                product = new GermanCaffee();
            }
            else
            {
                product = new GermanTea();
            }
            return product;
        }


    }
}