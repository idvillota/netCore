using InversionOfControlTest.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InversionOfControlTest
{
    class Greeting
    {
        IAnimalGreeting animalGreeting;

        public Greeting()
        {
            animalGreeting = AnimalGreetingFactory.GetAnimalFactory("Dog");
        }

        public string Greets()
        {
            return animalGreeting.Greeting();
        }
    }
}
