using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace concessionaria
{
    public class Veiculo
    {
        private string marca;
        private string modelo;

        public string Marca { get => marca; set => marca = value; }
        public string Modelo { get => modelo; set => modelo = value; }

        public virtual void Exibir()
        {
            Console.WriteLine($"Veiculo {Marca} {Modelo}");
        }
    }
}
