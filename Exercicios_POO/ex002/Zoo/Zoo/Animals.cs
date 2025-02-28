using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo
{
    public class Animals
    {
        private double peso;
        private String especie;

        public double Peso { get => peso; set => peso = value; }
        public string Especie { get => especie; set => especie = value; }

        // CONSTRUTOR
        public Animals(double peso, String especie)
        {
            this.Peso = peso;

            this.Especie = especie;
        }

        public virtual void HowToEat()
        {
            Console.WriteLine("Instruções gerais: ");
        }
    }
}
