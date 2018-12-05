using System;

namespace AbstractFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            new Computer("PC0001", new AMDFactory());
            new Computer("PC0002", new IntelFactory());
        }
    }
}
