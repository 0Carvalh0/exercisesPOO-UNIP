using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bichos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Polimorfismo";

            IAnimals animal = new Tiger();
            animal.sound();
            animal = new Dog();
            animal.sound();
            animal = new Monkey();
            animal.sound();

            Console.WriteLine("-----------------------------------------------");

            List<IAnimals> animalsDois = new List<IAnimals>
            {
                new Tiger(),
                new Dog(),
                new Monkey()
            };

            foreach ( var a in animalsDois)
            {
                a.sound();
            }

            Console.WriteLine("-----------------------------------------------");

            Console.WriteLine("***Sons de diferentes animais randomizados.***");
            Random random = new Random();

            int temp = random.Next(0, 3);
            IAnimals animalTwo = AnimalProducer.GetAnimal(temp);
            animalTwo.sound();

            temp = random.Next(0, 3);
            animalTwo = AnimalProducer.GetAnimal(temp);
            animalTwo.sound();

            temp = random.Next(0, 3);
            animalTwo = AnimalProducer.GetAnimal(temp);
            animalTwo.sound();

            Console.ReadKey();
        }
    }
}
