using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    class Dog : Animals
    {
        public Dog(double peso, string especie) : base(peso, especie)
        {

        }

        public override void HowToEat()
        {
            base.HowToEat();

            Console.WriteLine("O cachorro deve ser alimentado com ração para cães.");
        }
    }
}
