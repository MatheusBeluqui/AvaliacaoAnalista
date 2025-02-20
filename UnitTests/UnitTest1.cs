using FluentAssertions;
using System.Text.RegularExpressions;
using Teste1.Core;

namespace UnitTests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData("AAABCCDDD", "ABCD")] 
        [InlineData("AABBCC", "ABC")]
        [InlineData("AAA", "A")]
        [InlineData("ABABAB", "ABABAB")]
        [InlineData("1112233", "123")]
        [InlineData("A1A1A1", "A1A1A1")]
        [InlineData("ABCD", "ABCD")]
        public void Deve_Remover_Duplicatas_Consecutivas_Corretamente(string input, string expected)
        {
            string result = input.RemoverDuplicatasProximas();
            result.Should().Be(expected);
        }

        [Fact]
        public void Deve_Retornar_String_Vazia_Se_Entrada_For_Vazia()
        {
            string input = "";
            string result = input.RemoverDuplicatasProximas();
            result.Should().Be("");
        }

        [Fact]
        public void Deve_Manter_String_Se_Nao_Houver_Duplicatas_Consecutivas()
        {
            string input = "ABCDE";
            string result = input.RemoverDuplicatasProximas();
            result.Should().Be("ABCDE");
        }

        [Fact]
        public void Deve_Remover_Duplicatas_Em_Strings_Numericas_Grandes()
        {
            string input = "1111222233334444";
            string result = input.RemoverDuplicatasProximas();
            result.Should().Be("1234");
        }

        [Fact]
        public void Deve_Suportar_Strings_Longas_Sem_Quebrar()
        {
            string input = new string('A', 5000) + new string('B', 5000);
            string result = input.RemoverDuplicatasProximas();
            result.Should().Be("AB");
        }

        [Fact]
        public void Deve_Lidar_Corretamente_Com_Mistura_De_Letras_E_Numeros()
        {
            string input = "A1111BBBCCCDDD222EEE";
            string result = input.RemoverDuplicatasProximas();
            result.Should().Be("A1BCD2E");
        }

        [Theory]
        [InlineData("AA!!B@C123", false)]
        [InlineData("123456", true)]
        [InlineData("ABCdef", true)]
        [InlineData("A1B2C3", true)]
        [InlineData("A B C", false)]
        public void Deve_Validar_Entrada_Corretamente(string input, bool expected)
        {
            bool result = Regex.IsMatch(input, @"^[a-zA-Z0-9]+$");
            result.Should().Be(expected);
        }
    }
}