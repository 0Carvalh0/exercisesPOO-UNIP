using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfismo
{
    class Tiger : IAnimal
    {
        public void sound()
        {
            Console.WriteLine("Tiger: ROARR!");
        }
    }
}
