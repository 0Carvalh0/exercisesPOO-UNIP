using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bichos
{
    public class Monkey : IAnimals
    {
        public void sound()
        {
            Console.WriteLine("Barulho!");
        }
    }
}
