using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfismo
{
    class Monkey : IAnimal
    {
        public void sound()
        {
            Console.WriteLine("Faz barulho.");
        }
    }
}
