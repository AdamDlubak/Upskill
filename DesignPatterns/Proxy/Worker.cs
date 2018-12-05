using System;

namespace Proxy
{
    interface IWorker
    {
        void DoSomeThing();
    }

    public class Worker : IWorker
    {
        public void DoSomeThing()
        {
            Console.WriteLine("Do something");
        }
    }
}