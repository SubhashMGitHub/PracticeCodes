using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Test
    {
        public virtual void Display()
        {
            Console.WriteLine("This is a virtual method!!!");
        }
    }
    class Program:Test
    {
        public override void Display()
        {
            Console.WriteLine("This is a override method!!!");
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Run time polymorphism example...");
            Program obj = new Program();
            obj.Display();
            Console.ReadKey();
        }
    }
}
