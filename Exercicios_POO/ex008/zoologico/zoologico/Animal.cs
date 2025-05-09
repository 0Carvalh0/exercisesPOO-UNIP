using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zoologico
{
    public class Animal
    {
        public string Nome { get; set; }

        public Animal(string nome)
        {
            this.Nome = nome;
            Console.WriteLine($"Animal construído com nome: {Nome}");
        }
    }
}
