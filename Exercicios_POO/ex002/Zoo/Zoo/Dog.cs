using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo
{
    public class Dog:Animals
    {
        public Dog(double peso, String especie) : base(peso, especie)
        {
        }

        public override void HowToEat()
        {
            base.HowToEat();

            Console.Write("Dê ração Golden de frango p/ o dog!");
        }
    }
}
