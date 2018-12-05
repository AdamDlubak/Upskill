namespace AbstractFactory
{

    public interface IFactory
    {
        IProcessor CreateProcessor();
        ICooler CreateCooler();
    }

    class AMDFactory : IFactory
    {
        public IProcessor CreateProcessor()
        {
            return new AMDProcessor();
        }

        public ICooler CreateCooler()
        {
            return new AMDCooler();
        }
    }

    class IntelFactory : IFactory
    {
        public IProcessor CreateProcessor()
        {
            return new IntelProcessor();
        }

        public ICooler CreateCooler()
        {
            return new IntelCooler();
        }
    }
}
