using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InversionOfControlTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Greeting greeting = new Greeting();
            Console.WriteLine("Animal Greetings");
            Console.WriteLine(greeting.Greets());
            Console.ReadLine();
        }
    }
}
