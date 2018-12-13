using InversionOfControlTest.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InversionOfControlTest
{
    class AnimalGreetingFactory
    {
        public static IAnimalGreeting GetAnimalFactory(string animalType)
        {
            IAnimalGreeting animalGreeting = null;
            switch (animalType)
            {
                case "Dog":
                    animalGreeting = new DogGreeting();
                    break;
                case "Cat":
                    animalGreeting = new CatGreeting();
                    break;
            }

            return animalGreeting;
        }
    }
}
