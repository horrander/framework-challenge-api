using Framework.Challenge.Service.Extensions;
using Xunit;

namespace Framework.Challenge.Test.Extensions
{
    public class EPrimoTests
    {

        [Theory]
        [InlineData(0)]
        [InlineData(-1)]
        [InlineData(-45)]
        [InlineData(-0)]
        [InlineData(-99)]
        public void EPrimo_NumeroNegativoOuZero_False(int numero)
        {
            Assert.False(numero.EPrimo());
        }

        [Theory]
        [InlineData(1)]
        [InlineData(10)]
        [InlineData(6)]
        [InlineData(4)]
        [InlineData(98)]
        public void EPrimo_NumeroPositivoNaoPrimo_False(int numero)
        {
            Assert.False(numero.EPrimo());
        }

        [Theory]
        [InlineData(2)]
        [InlineData(3)]
        [InlineData(5)]
        [InlineData(7)]
        [InlineData(11)]
        public void EPrimo_NumeroPositivoPrimo_True(int numero)
        {
            Assert.True(numero.EPrimo());
        }
    }
}