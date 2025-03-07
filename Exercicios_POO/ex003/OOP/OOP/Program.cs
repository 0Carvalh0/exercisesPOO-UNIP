using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using C = System.Console;

namespace OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            float valorInicial, taxa;
            int numPrestacoes;
            string retorno;
            do
            {
                Label:
                try
                {
                    InputValores(out valorInicial, out numPrestacoes, out taxa);
                }
                catch (Exception)
                {
                    C.Write("[ERRO!] Erro de entrada\n\n");
                    goto Label;
                }

                CalcularDivida(valorInicial, numPrestacoes, taxa, out float montante, out float prestacao, out float juros);

                C.WriteLine($"Montante da divida: {montante:C}");

                C.WriteLine($"Valor de cada prestação: {prestacao:C}");

                C.WriteLine($"Valor do juros: {juros:C}");

                C.ReadKey();

                C.WriteLine("Deseja retornar? Digite [s] ou [S]: ");
                retorno = C.ReadLine();
                C.Clear();
            } while (retorno == "s" || retorno == "S");
        }

        private static void InputValores(out float valorInicial, out int numPrestacoes, out float taxa)
        {
            C.Write("Digite o valor inicial: ");
            valorInicial = float.Parse(C.ReadLine());
            C.Write("Digite o número de prestações: ");
            numPrestacoes = int.Parse(C.ReadLine());
            C.Write("Digite a taxa: ");
            taxa = float.Parse(C.ReadLine());
        }

        private static void CalcularDivida(float valorInicial, int numPrestacoes, float taxa, out float montante, out float prestacao, out float juros)
        {
            montante = valorInicial * (1 + taxa * numPrestacoes);

            prestacao = montante / numPrestacoes;

            juros = montante - valorInicial;
        }
    }
}
