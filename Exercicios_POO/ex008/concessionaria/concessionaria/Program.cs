using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace concessionaria
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Carro c1 = new Carro();

            c1.Marca = "Toyota";
            c1.Modelo = "Corolla";
            c1.Cor = "Prata";
            c1.Ligar();
            Console.WriteLine($"A cor do meu carro {c1.Marca} {c1.Modelo} é: {c1.Cor}");
            
        }
    }
}
