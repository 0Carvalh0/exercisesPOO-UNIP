using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculadora
{
    public class Calculadora
    {
        public bool Dividir(int a, int b, out int r)
        {
            if (b == 0)
            {
                r = 0;
                return false;
            }
            r = a / b;
            return true;
        }
    }
}
