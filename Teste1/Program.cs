using System;

namespace Teste1
{
    class Program
    {
        //TODO
        /* 
         * Desenvolva um método que receba a string "abbcbbb". O retorno desse método deverá ser "abcb", 
         * logo o próximo caracter não deverá ser igual ao anterior, o método deve ser capaz de tratar qualquer string.
        */

        public static string retiraLetrasRepetidas(string palavra)
        {
            string palavraNova = "";
            int aux = 1;

            palavraNova += palavra[0];

            for (int i = 1; i < palavra.Length; i++)
            {
                if (palavraNova[i - aux] == palavra[i])
                {
                    aux++;
                    continue;
                }
                palavraNova += palavra[i];
            }

            return palavraNova;
        }

        static void Main(String[] args)
        {
            while (true)
            {
                Console.WriteLine("Digite a palavra: ");
                Console.WriteLine(retiraLetrasRepetidas(Console.ReadLine()));
            }
        }
    }
}
