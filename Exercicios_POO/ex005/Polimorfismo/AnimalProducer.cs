using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfismo
{
    class AnimalProducer
    {
        public static IAnimal GetAnimal(int temp)
        {
            IAnimal animal;

            if (temp == 0)
            {
                animal = new Tiger();
            } else if (temp == 1)
            {
                animal = new Dog();
            } else
            {
                animal = new Monkey();
            }
            return animal;
        }
    }
}
