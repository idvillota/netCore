using InversionOfControlTest.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InversionOfControlTest
{
    class DogGreeting : IAnimalGreeting
    {
        public string Greeting()
        {
            return "Hi GUAU GUAU...";
        }
    }
}
