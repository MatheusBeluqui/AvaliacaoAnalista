using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Teste1
{
    internal class Fila
    {
        private Item primeiro;
        private Item ultimo;

        public Fila()
        {

            primeiro = null;
            ultimo = null;

        }

        public string RetornaLista()
        {

            Item atual = primeiro;
            string resultado = "";

            while (atual != null)
            {
                resultado += atual.Valor;
                atual = atual.Proximo;
            }

            return resultado;

        }

        public void AdicionarFinalDaFila(char value)
        {

            Item novoItem = new Item(value);

            if (ultimo == null)
            {
                primeiro = ultimo = novoItem;
            }
            else
            {
                ultimo.Proximo = novoItem;
                novoItem.Anterior = ultimo;
                ultimo = novoItem;
            }

        }
    }
}
