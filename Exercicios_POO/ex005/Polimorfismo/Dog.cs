using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfismo
{
    class Dog : IAnimal
    {
        public void sound()
        {
            Console.WriteLine("AU AU!");
        }
    }
}
