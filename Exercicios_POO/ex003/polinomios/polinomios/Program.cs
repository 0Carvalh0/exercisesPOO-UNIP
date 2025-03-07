using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using C = System.Console;

namespace polinomios
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, c;
            char confirmar;

            do
            {
                Input(out a, out b, out c);

                Polinomios p = new Polinomios(a, b, c);

                Polinomios.Delta(a, b, c, out double d);

                p.Raizes(a, b, c, out double x1, out double x2);

                if (d >= 0)
                {
                    C.WriteLine($"x1 = {x1}");

                    C.WriteLine($"x2 = {x2}");
                }

                confirmar = C.ReadKey().KeyChar;
            } while (confirmar == 's' || confirmar == 'S');

            C.ReadKey();
        }
        private static void Input(out double a, out double b, out double c)
        {
            C.WriteLine("Digite o valor de 'A': ");
            a = double.Parse(C.ReadLine());

            C.WriteLine("Digite o valor de 'B': ");
            b = double.Parse(C.ReadLine());

            C.WriteLine("Digite o valor de 'C': ");
            c = double.Parse(C.ReadLine());
        }
    }
}
