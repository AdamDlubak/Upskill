using System;
using System.Collections.Generic;

namespace NullObject
{
    class Program
    {
        // Only logic examples below, without fully correct implementation

        // Example 1 - User
        public class User
        {
            public string Name { get; set; }
        }
        public class Repository
        {
            public List<User> GetUsersWhereLastNameContaines(string lastname)
            {
                List<User> users = null; // some code that can generate null
                return users ?? new List<User>();
            }
        }

        // Example 2 - Basket
        public class Basket
        {
            public List<int> Items { get; set; }
            public decimal TotalPrice { get; set; }

            public Basket()
            {
                Items = new List<int>();
                TotalPrice = 0m;
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Hello Null Object Design Pattern Test!");
            Console.ReadKey();
        }
    }
}
