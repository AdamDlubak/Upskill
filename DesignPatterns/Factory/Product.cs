using System;

namespace Factory
{
    public abstract class Product
    {
        public string Description { get; set; }

        public void ShowDescription()
        {
            Console.WriteLine(Description);
            Console.ReadKey();
        }
    }

    public class Caffee : Product
    {
        public Caffee()
        {
            Description = "This is a caffee";
        }
    }

    public class Tea : Product
    {
        public Tea()
        {
            Description = "This is a tea";
        }

    }

    public class PolishCaffee : Product
    {
        public PolishCaffee()
        {
            Description = "This is a polish caffee";
        }
    }

    public class PolishTea : Product
    {
        public PolishTea()
        {
            Description = "This is a polish tea";
        }

    }

    public class GermanCaffee : Product
    {
        public GermanCaffee()
        {
            Description = "This is a german caffee";
        }
    }

    public class GermanTea : Product
    {
        public GermanTea()
        {
            Description = "This is a german tea";
        }

    }
}