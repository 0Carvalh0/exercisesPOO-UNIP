using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace concessionaria
{
    public class Carro
    {
        private string _marca;
        private string _modelo;

        public string Marca { get => _marca; set => _marca = value; }
        public string Modelo { get => _modelo; set => _modelo = value; }

        public string Cor { get; set; }

        public void Ligar()
        {
            Console.WriteLine($"O carro {Marca} {Modelo} está ligado.");
        }
    }
}
