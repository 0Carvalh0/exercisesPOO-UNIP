using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zoologico
{
    public class Cachorro : Animal
    {
        public string Raca { get; set; }

        public Cachorro(string nome, string raca) : base(nome)
        {
            this.Raca = raca;
            Console.WriteLine($"Cachorro construído com raça: {Raca}");
        }

        public Cachorro() : base("Sem Nome")
        {
            Raca = "Indefinida";
            Console.WriteLine("Cachorro construído sem nome especificado.");
        }
    }
}
