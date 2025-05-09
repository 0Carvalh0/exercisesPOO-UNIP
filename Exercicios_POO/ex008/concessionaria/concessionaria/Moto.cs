using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace concessionaria
{
    public class Moto : Veiculo
    {
        private bool temCesta;

        public bool TemCesta { get => temCesta; set => temCesta = value; }

        public override void Exibir()
        {
            base.Exibir();
            Console.WriteLine($"Tem Cesta: {TemCesta}");
        }
    }
}
