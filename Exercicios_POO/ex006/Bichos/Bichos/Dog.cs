using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bichos
{
    class Dog : IAnimals
    {
        public void sound()
        {
            Console.WriteLine("AU AU!");   
        }
    }
}
