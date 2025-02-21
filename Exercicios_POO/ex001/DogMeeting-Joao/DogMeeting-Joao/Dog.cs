using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DogMeeting_Joao
{
    public class Dog {
        // CAMPO PRIVADO
        private String name;
        //PROPRIEDADE PÚBLICA
        //ASSOCIADA AO CAMPO PRIVADO
        private int age;
        public String Name {
            get { return name; }
            set { name = value;  }
        }
        public int Age {
            get => age;
            set => age = value;
        }
        // CONSTRUTOR
        public Dog (string name) {
            this.Name = name;
        }

        public Dog ()
        {

        }

        public void Bark()
        {
            Console.WriteLine("{0} latiu: Wow-wow!", name ?? "[ SEM NOME ]");
        }
    }
}
