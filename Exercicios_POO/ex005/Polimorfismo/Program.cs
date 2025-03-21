using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfismo
{
    class Program
    {
        static void Main(string[] args)
        {
            IAnimal animal = new Tiger();
            animal.sound();

            animal = new Dog();
            animal.sound();

            animal = new Monkey();
            animal.sound();

            Console.Write("\n==================================================\n\n");

            List<IAnimal> animaisDois = new List<IAnimal>()
            {
                new Tiger(),
                new Dog(),
                new Monkey()
            };

            foreach (var i in animaisDois)
            {
                i.sound();
            }

            Console.Write("\n==================================================\n\n");

            Random rand = new Random();

            int temp = rand.Next(0, 3);

            IAnimal animalTwo = AnimalProducer.GetAnimal(temp);

            Console.WriteLine($"{temp}");
            animalTwo.sound();

            temp = rand.Next(0, 3);

            Console.WriteLine("\n");

            animalTwo = AnimalProducer.GetAnimal(temp);

            Console.WriteLine($"{temp}");
            animalTwo.sound();

            Console.ReadKey();
        }
    }
}
