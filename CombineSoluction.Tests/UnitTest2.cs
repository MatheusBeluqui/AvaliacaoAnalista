using Program = Teste2.Program;

namespace CombineSoluction.Tests
{
    public class UnitTest2
    {

        [Fact]
        public void QuantidadeNegativa()
        {
            string[] args = new string[] { };
            string entrada = "-1";
            string valorEsperado = "Valor passado não pode ser menor que zero";

            string? saida = Program.Run(entrada);

            // Verificar se o resultado é o esperado
            Assert.Equal(valorEsperado, saida);
        }

        [Fact]
        public void QuantidadeZerada()
        {
            string[] args = new string[] { };
            string entrada = "0";
            string valorEsperado = "Valor passado não pode ser zero";

            string? saida = Program.Run(entrada);

            // Verificar se o resultado é o esperado
            Assert.Equal(valorEsperado, saida);
        }

        [Fact]
        public void QuantidadeTemQueSerMenorQueVinte()
        {
            string[] args = new string[] { };
            string entrada = "20";
            string valorEsperado = "Valor passado não pode ser maior que 20";

            string? saida = Program.Run(entrada);

            // Verificar se o resultado é o esperado
            Assert.Equal(valorEsperado, saida);
        }

        [Fact]
        public void SaidaComCincoNumerosSequenciaFibonacci()
        {
            string[] args = new string[] { };
            string entrada = "5";
            string valorEsperado = "1,1,2,3,5";

            string? saida = Program.Run(entrada);

            // Verificar se o resultado é o esperado
            Assert.Equal(valorEsperado, saida);
        }

        [Fact]
        public void SaidaComDezNumerosSequenciaFibonacci()
        {
            string[] args = new string[] { };
            string entrada = "10";
            string valorEsperado = "1,1,2,3,5,8,13,21,34,55";

            string? saida = Program.Run(entrada);

            // Verificar se o resultado é o esperado
            Assert.Equal(valorEsperado, saida);
        }
    }
}
