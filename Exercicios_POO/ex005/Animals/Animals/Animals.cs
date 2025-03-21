using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    class Animals
    {
        private double peso;
        private string especie;

        public double Peso { get => peso; set => peso = value; }
        public string Especie { get => especie; set => especie = value; }

        public Animals(double peso, string especie)
        {
            this.Peso = peso;
            this.Especie = especie;
        }

        public virtual void HowToEat()
        {
            Console.WriteLine("Instruções gerais de alimentação. \n");
        }
    }
}
