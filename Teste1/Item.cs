using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Teste1
{
    internal class Item
    {

        public char Valor { get; set; }
        public Item Proximo { get; set; }
        public Item Anterior { get; set; }

        public Item(char value)
        {

            Valor = value;
            Proximo = null;
            Anterior = null;

        }

    }
}
