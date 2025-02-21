using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace DogMeeting_Joao
{
    public class Cat:Dog
    {
        private String raca;
        private String nome;
        private float price;

        public string Raca { get => raca; set => raca = value; }
        public string Nome { get => nome; set => nome = value; }
        public float Preco { get => price; set => price = value; }

        public Cat (float price)
        {
            if (price <= 2000)
            {
                this.Preco = price;
            } else {
                // (float) == 0.8 é um Double, então eu forço o programa para que o Preco seja do tipo Float
                this.Preco = (float)(0.8 * price);
            }
        }

        public Cat ()
        {

        }

        public Cat (String nome)
        {
            this.Nome = nome;
        }

        public Cat (String nome, String raca, float preco)
        {
            this.Nome = nome;
            this.Raca = raca;
            this.Preco = preco;
        }

        public float desconto(float Preco, float price)
        {
            return (price - this.Preco);
        }

        public void Miau()
        {
            Console.WriteLine("{0} miou: Miau!", nome ?? "[ SEM NOME ]");
        }
    }
}
