using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace polinomios
{
    class Polinomios
    {
        private double a, b, c;

        private double x1, x2, d;

        public double A { get => a; set => a = value; }
        public double B { get => b; set => b = value; }
        public double C { get => c; set => c = value; }

        public double X1 { get => x1; set => x1 = value; }
        public double X2 { get => x2; set => x2 = value; }
        public double D { get => d; set => d = value; }

        public Polinomios (double a, double b, double c)
        {
            this.A = a;
            this.B = b;
            this.C = c;
        }

        public static void Delta (double a, double b, double c, out double d)
        {
            d = Math.Pow(b, 2) - 4 * a * c;
        }

        public void Raizes (double a, double b, double c, out double x1, out double x2)
        {
            x1 = 0;
            x2 = 0;

            Delta(a, b, c, out d);

            if (d >= 0)
            {
                x1 = (-b + Math.Sqrt(d)) / 2 * a;
                x2 = (-b - Math.Sqrt(d)) / 2 * a;
            }
        }
    }
}
