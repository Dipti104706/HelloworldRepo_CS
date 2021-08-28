using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{ /// <summary>
/// Testing hello world sample project
/// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Test();
            Laptop laptop = new Laptop();
            Laptop.Run();
            Console.Read();
        }
        public static void Test()
        {
            Console.WriteLine("Testing");
        }
    }
}
