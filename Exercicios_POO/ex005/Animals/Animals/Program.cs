using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    class Program
    {
        static void Main(string[] args)
        {
            Animals dog = new Dog(25.0, "Cachorro");

            Console.WriteLine($"Espécie: {dog.Especie},\nPeso: {dog.Peso}Kg");

            dog.HowToEat();

            Animals cat = new Cat(12.0, "Gato");
            Console.WriteLine($"Espécie: {cat.Especie},\nPeso: {cat.Peso}Kg");

            cat.HowToEat();

            List<Mouse> ratinhos = new List<Mouse>();

            // Adicionando ratos à lista

            ratinhos.Add(new Mouse(3, "Whiskers"));
            ratinhos.Add(new Mouse(5, "Mittens"));
            ratinhos.Add(new Mouse(9, "Garfield"));

            // Acessando ratos da lista

            foreach (Mouse item in ratinhos)
            {
                Console.WriteLine($"Name: {item.Name},\nAge: {item.Age}");
            }
            Console.Write("{0}", ratinhos[1].Name);

            Console.ReadKey();
        }
    }
}
