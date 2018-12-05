using System;

namespace Proxy
{
    class Program
    {
        static void Main(string[] args)
        {
            var password = Console.ReadLine();

            var proxy = new Proxy(password);
            proxy.DoSomeThing();

            Console.ReadKey();
        }
    }
}
