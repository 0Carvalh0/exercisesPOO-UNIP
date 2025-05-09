using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace excecoes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // QUAIS AS PRINCIPAIS EXCEÇÕES DO C#
            try
            {
                int[] numeros = { 1, 2, 3 };
                int res;
                Console.WriteLine(numeros[5]);

                res = numeros[0] / 0;
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine($"Erro de índice: {ex.Message}");
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine($"Impossivel dividir: {ex.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ocorreu um erro geral: {ex.Message}");
            }
            finally
            {
                Console.WriteLine("Bloco finally executado");
            }
        }
    }
}
