using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace @interface
{
    class Menu : IAcao
    {
        public string Mensagem { get; set; }

        public void Executar()
        {
            Console.WriteLine($"Item de menu selecionado: {Mensagem}");
        }
    }
}
