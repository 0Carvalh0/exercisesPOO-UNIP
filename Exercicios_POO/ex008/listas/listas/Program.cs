using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace listas
{
    public class Program
    {
        static void Main(string[] args)
        {
            int[] numerosArray = new int[5];
            numerosArray[0] = 10;
            int primeiroNumero = numerosArray[0];

            List<string> nomes = new List<string>();
            nomes.Add("N sei");
            nomes.Add("Carlos");
            nomes.Remove("Carlos");
            int numerodeNomes = nomes.Count;
        }
    }
}
