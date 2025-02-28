using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo
{
    public class Cat:Animals
    {
        public Cat(double peso, String especie):base(peso,especie)
        {
            if(this.Peso > 10)
            {
                this.Warning();
            }
        }

        public void Warning() {
            Console.Write("\n[ATENÇÃO] Gato acima do Peso!\n");
        }

        public override void HowToEat()
        {
            base.HowToEat();

            Console.Write("Dê ração Golden de frango p/ o gato!");
        }
    }
}
