/*
 Você deve implementar nessa aplicação console uma lógica que satisfaça os seguintes requisitos:
    1 - A aplicação deve solicitar ao usuário que ele digite uma string alfanumérica.
    2 - A aplicação deve remover todos os valores duplicados próximos, de forma que não hajam letras/números iguais juntos.
    Exemplo: AAABCCDDD -> Retorno : ABCD
 */


namespace Teste1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Programa para resolver caracteres proximos duplicados");
            Console.WriteLine("Digite o valor alfanúmerico");
            string? valor = Console.ReadLine();
            Console.WriteLine("Como quer que o problema seja resolvido? Digite 1 para o modo interativo ou 2 para o modo recursivo");
            string? opcao = Console.ReadLine();
            string? resultado = opcao switch
            {
                "1" => ResolverModoInterativo(valor),
                "2" => ResolverModoRecursivo(valor),
                _ => throw new ArgumentException("Opção invalida. Por favor digitar 1 ou 2")
            };
            Console.WriteLine(resultado);
        }

        private static string? ResolverModoRecursivo(string? valor)
        {
            if (string.IsNullOrEmpty(valor) || valor.Length == 1)
                return valor;

            if (valor[0] == valor[1])
                return ResolverModoRecursivo(valor.Substring(1));

            return valor[0] + ResolverModoRecursivo(valor.Substring(1));

        }

        private static string? ResolverModoInterativo(string? valor)
        {
            if (string.IsNullOrEmpty(valor))
                return valor;

            char caractere = valor[0];
            string resultado = caractere.ToString();

            for (int i = 1; i < valor.Length; i++)
            {
                if (valor[i] != caractere)
                {
                    resultado += valor[i];
                    caractere = valor[i];
                }
            }

            return resultado;
        }
    }
}