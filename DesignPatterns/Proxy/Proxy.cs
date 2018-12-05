using System;

namespace Proxy
{
    public class Proxy : IWorker
    {
        private IWorker _exampleClass;
        private string Password { get; }

        public Proxy(string password)
        {
            Password = password;
        }

        private void CreateInstanceExampleClass()
        {
            _exampleClass = new Worker();
        }

        public void DoSomeThing()
        {
            if (Password == "root")
            {
                CreateInstanceExampleClass();
                _exampleClass.DoSomeThing();
            }
            else
            {
                Console.WriteLine("Wrong password");
            }
        }
    }
}