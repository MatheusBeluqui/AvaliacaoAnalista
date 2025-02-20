using FluentAssertions;
using Teste2.Services;

namespace UnitTests
{
    public class UnitTest2
    {
        [Theory]
        [InlineData(1, new int[] { 1 })]
        [InlineData(2, new int[] { 1, 1 })]
        [InlineData(3, new int[] { 1, 1, 2 })]
        [InlineData(5, new int[] { 1, 1, 2, 3, 5 })]
        [InlineData(10, new int[] { 1, 1, 2, 3, 5, 8, 13, 21, 34, 55 })]
        [InlineData(19, new int[] { 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, 377, 610, 987, 1597, 2584, 4181 })]
        public void Deve_Gerar_Sequencia_De_Fibonacci_Corretamente(int n, int[] expected)
        {
            var result = FibonacciService.GerarFibonacci(n);
            result.Should().Equal(expected);
        }

        [Theory]
        [InlineData("10", true)]
        [InlineData("1", true)]
        [InlineData("19", true)]
        [InlineData("0", false)]
        [InlineData("-5", false)]
        [InlineData("20", false)]
        [InlineData("abc", false)]
        [InlineData("1.5", false)]
        [InlineData("", false)]
        public void Deve_Validar_Entrada_Corretamente(string input, bool expected)
        {
            bool result = FibonacciService.ValidarEntrada(input, out _);
            result.Should().Be(expected);
        }

        [Fact]
        public void Deve_Retornar_Lista_Vazia_Se_Numero_For_Zero()
        {
            var result = FibonacciService.GerarFibonacci(0);
            result.Should().BeEmpty();
        }

        [Fact]
        public void Deve_Retornar_Lista_Vazia_Se_Numero_For_Negativo()
        {
            var result = FibonacciService.GerarFibonacci(-5);
            result.Should().BeEmpty();
        }

        [Fact]
        public void Deve_Retornar_Lista_Vazia_Se_Numero_For_Maior_Que_19()
        {
            var result = FibonacciService.GerarFibonacci(20);
            result.Should().BeEmpty();
        }
    }
}
