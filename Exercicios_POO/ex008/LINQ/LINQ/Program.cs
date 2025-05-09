using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Pessoa> pessoas = new List<Pessoa>()
            {
                new Pessoa {Nome = "Ana", Idade = 30},
                new Pessoa {Nome = "Ricardo", Idade = 50},
                new Pessoa {Nome = "Maria", Idade = 19},
                new Pessoa {Nome = "Fabiola", Idade = 20}
            };

            var NT = from p in pessoas
                     where p.Idade >= 20 && p.Idade <= 100
                     orderby p.Nome
                     select p.Nome;

            foreach (var nome in NT)
            {
                Console.WriteLine(nome);
            }
        }
    }
}
