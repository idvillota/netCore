using InversionOfControlTest.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InversionOfControlTest
{
    class CatGreeting : IAnimalGreeting
    {
        public string Greeting()
        {
            return "Hi MIAU...";
        }
    }
}
