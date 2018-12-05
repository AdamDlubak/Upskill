namespace Factory
{
    public class SimpleFactory
    {
        public Product CreateProduct(string type)
        {
            Product product;
            if (type == "Caffee")
            {
                product = new Caffee();
            }
            else 
            {
                product = new Tea();
            }

            return product;
        }

        public static Product StaticCreateProduct(string type)
        {
            Product product;
            if (type == "Caffee")
            {
                product = new Caffee();
            }
            else
            {
                product = new Tea();
            }

            return product;
        }
    }
}