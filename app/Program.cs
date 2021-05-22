using library;
using System;

namespace app
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var start = new Start();

            Console.WriteLine(string.Format("Hello World! {0}", start.Multiply(2, 2)));
        }
    }
}
