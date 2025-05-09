using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculadora
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Calculadora c = new Calculadora();
            int res;
            if (c.Dividir(10, 2, out res))
            {
                Console.WriteLine($"O resultado da divisão é: {res}");
            } else
            {
                Console.WriteLine("Não foi possível dividir por zero.");
            }
        }
    }
}
