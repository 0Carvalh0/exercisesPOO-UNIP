using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using File = System.IO.File;
using C = System.Console;

namespace arquivos
{
    class Program
    {
        static void Main(string[] args)
        {
            string retorno;

            do
            {
                C.Title = "Diretórios e Arquivos";

                C.WriteLine("Digite o nome do arquivo ou diretório em C: ");

                String arquivo = C.ReadLine();

                String target = string.Format(@"C:\{0}", arquivo + ".txt");

                if (File.Exists(target))
                {
                    C.WriteLine("\n File {0} existe em C:", target);
                }
                else
                {
                    C.WriteLine("\n File {0} não existe em C.", target);
                }

                if (Directory.Exists(target))
                {
                    C.WriteLine("\n Directory {0} existe. ", target);
                }
                else
                {
                    C.WriteLine("\n Directory {0} não existe.", target);
                }
                Console.ReadKey();

                C.WriteLine("Deseja retornar? Digite [s] ou [S]: ");
                retorno = C.ReadLine();
                C.Clear();
            } while (retorno == "S" || retorno == "s");
        }
    }
}
