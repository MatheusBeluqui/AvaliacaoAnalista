using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teste1
{
    internal class Processador
    {
        public static string RemoveCharacteresDuplicados(string input)
        {

            Fila fila = new Fila();
            char? valorAnterior = null;

            foreach (var valor in input)
            {
                if (valorAnterior == null || valorAnterior != valor)
                {
                    fila.AdicionarFinalDaFila(valor);
                    valorAnterior = valor;
                }
            }

            return fila.RetornaLista();

        }
    }
}
