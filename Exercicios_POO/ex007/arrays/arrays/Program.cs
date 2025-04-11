using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using C = System.Console;

namespace arrays
{
    public class Program
    {
        static void Main(string[] args)
        {
            C.Title = "Arrays";
            String confirma;
            int[] vetor = new int[4];

            CarregarVetor(vetor);
            C.WriteLine("Componentes do vetor 1: ");
            ListarVetor(vetor);

            C.WriteLine($"\nO vetor1 tem {vetor.Length} elementos.");

            C.WriteLine("\nVetor 1 em ordem: ");
            
            Array.Sort(vetor);
            ListarVetor(vetor);

            C.WriteLine("\n\nDeseja copiar em outro vetor e limpar a tela?");
            C.Write("Digite sim: ");
            confirma = C.ReadLine();

            if(confirma == "sim")
            {
                C.Clear();
                C.WriteLine("\nAgora vamos copiar em outro vetor: ");
                int[] vetor2 = vetor.ToArray();

                C.Write("Vetor 2 listado: ");
                ListarVetor(vetor2);
                C.Write("\n\nVetor 2 em ordem crescente: ");
                Array.Sort(vetor2);
                ListarVetor(vetor2);

                C.Write("\n\nInvertendo o 2: ");
                Array.Reverse(vetor2);

                ListarVetor(vetor2);

                C.Write("\n\nVetor 1: ");

                ListarVetor(vetor);
                confirma = "";
            }

            C.WriteLine("\n\nDeseja continuar e limpar a tela?");
            C.Write("Digite sim: ");
            confirma = C.ReadLine();

            if(confirma == "sim")
            {
                C.Clear();
                ListarVetor(vetor);
                C.WriteLine("\nEsse vetor possui os seguintes números pares: ");
                ExtrairPares(vetor);

                C.WriteLine("\nEsse vetor possui os seguintes números primos: ");
                ExtrairPrimos(vetor, 2, out int total);
            }

            C.WriteLine("\n\n================= FIM! =================");

            C.ReadKey();
        }

        private static void CarregarVetor(int[] vetor)
        {
        Label:
            C.Clear();
            try
            {
                for (int i = 0; i < vetor.Length; i++)
                {
                    C.WriteLine("Inserir valor: ");
                    vetor[i] = int.Parse(C.ReadLine());
                }
            } catch (FormatException)
            {
                goto Label;
            }
        }

        private static void ListarVetor(int[] v)
        {
            foreach (int i in v)
            {
                C.Write($"{i}, ");
            }
        }

        private static void ExtrairPares(int[] v)
        {
            var numPares = v.Where(x => x % 2 == 0);

            foreach (int c in numPares)
            {
                C.Write($"{c}, ");
            }
        }

        private static void ExtrairPrimos(int[] v, int limite, out int total)
        {
            total = 0;
            var numPrimos = v.Where(x => isPrimo(x) && x >= limite);

            foreach (int c in numPrimos)
            {
                total++;
            }

            int[] vetor = numPrimos.ToArray();
            Array.Sort(vetor);
            ListarVetor(vetor);
        }

        private static bool isPrimo(int x)
        {
            int soma = 0;

            for(int i = 1; i <= x; i++)
            {
                if (x % i == 0)
                {
                    soma++;
                }
            }
            if (soma == 2)
            {
                return true;
            } else
            {
                return false;
            }
        }
    }
}
