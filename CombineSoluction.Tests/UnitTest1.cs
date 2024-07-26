using Program = Teste1.Program;

namespace CombineSoluction.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void A_RepetidaTresVezes()
        {
            string[] args = new string[] { };
            string entrada = "AAAB";
            string valorEsperado = "AB";

            string? saida = Program.Run(entrada);

            // Verificar se o resultado é o esperado
            Assert.Equal(valorEsperado, saida);
        }

        [Fact]
        public void StringVazia()
        {
            string[] args = new string[] { };
            string entrada = "";
            string valorEsperado = "";

            string? saida = Program.Run(entrada);

            // Verificar se o resultado é o esperado
            Assert.Equal(valorEsperado, saida);
        }

        [Fact]
        public void StringComNumeros()
        {
            string[] args = new string[] { };
            string entrada = "AABBNN88899900";
            string valorEsperado = "ABN890";

            string? saida = Program.Run(entrada);

            // Verificar se o resultado é o esperado
            Assert.Equal(valorEsperado, saida);
        }

        [Fact]
        public void LetraComCaracteresEspeciais()
        {
            string[] args = new string[] { };
            string entrada = "AA_++";
            string valorEsperado = "A_+";

            string? saida = Program.Run(entrada);

            // Verificar se o resultado é o esperado
            Assert.Equal(valorEsperado, saida);
        }

        [Fact]
        public void LetrasMinusculas()
        {
            string[] args = new string[] { };
            string entrada = "aabbbnneee";
            string valorEsperado = "abne";

            string? saida = Program.Run(entrada);

            // Verificar se o resultado é o esperado
            Assert.Equal(valorEsperado, saida);
        }

        [Fact]
        public void LetrasMinusculasComMaiusculas()
        {
            string[] args = new string[] { };
            string entrada = "qqwwPPPPlbnm";
            string valorEsperado = "qwPlbnm";

            string? saida = Program.Run(entrada);

            // Verificar se o resultado é o esperado
            Assert.Equal(valorEsperado, saida);
        }

        [Fact]
        public void LetrasMinusculasComMaiusculasNumeros()
        {
            string[] args = new string[] { };
            string entrada = "qqwwPPPPlbnm88899555";
            string valorEsperado = "qwPlbnm895";

            string? saida = Program.Run(entrada);

            // Verificar se o resultado é o esperado
            Assert.Equal(valorEsperado, saida);
        }
    }
}