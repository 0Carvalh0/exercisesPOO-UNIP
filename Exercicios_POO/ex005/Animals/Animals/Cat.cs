using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    class Cat : Animals
    {
        private int soma = 9;

        public Cat(double peso, string especie) : base(peso, especie)
        {
            if (this.Peso > 10.0)
            {
                this.Warning();
            }
            else
            {
                this.Warning2();
            }
        }

        public override void HowToEat()
        {
            base.HowToEat();

            Console.WriteLine("O gato deve ser alimentado com ração para gatos.");
        }

        public void Warning()
        {
            Console.WriteLine("Gato gordo! O peso máximo é 10Kg.");
        }

        public void Warning2()
        {
            Console.WriteLine("Gato em forma!");
        }
    }
}
