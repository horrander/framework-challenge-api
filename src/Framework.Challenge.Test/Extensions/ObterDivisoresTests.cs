using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Framework.Challenge.Service.Extensions;
using Xunit;

namespace Framework.Challenge.Test.Extensions
{
    public class ObterDivisoresTests
    {
        [Theory]
        [InlineData(0)]
        [InlineData(-1)]
        [InlineData(-99)]
        [InlineData(-45)]
        public void ObterDivisores_NegativosOuZero_ListaVazia(int numero)
        {
            Assert.Empty(numero.ObterDivisores());
        }

        [Theory]
        [InlineData(2)]
        [InlineData(3)]
        [InlineData(45)]
        [InlineData(99)]
        public void ObterDivisores_NumerosPositivos_RetornaDivisores(int numero)
        {
            Assert.NotEmpty(numero.ObterDivisores());
        }

        [Fact]
        public void ObterDivisores_NumeroEspecifico_RetornaDivisores()
        {
            var numeroTeste = 45;

            Assert.Collection<int>(numeroTeste.ObterDivisores(),
                x => Assert.Equal(1, x),
                x => Assert.Equal(3, x),
                x => Assert.Equal(5, x),
                x => Assert.Equal(9, x),
                x => Assert.Equal(15, x),
                x => Assert.Equal(45, x));
        }
    }
}