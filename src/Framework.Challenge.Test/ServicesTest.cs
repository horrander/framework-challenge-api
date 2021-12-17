using System;
using Framework.Challenge.Service.Contracts;
using Framework.Challenge.Service;
using Xunit;

namespace Framework.Challenge.Test
{
    public class ServicesTest
    {
        private readonly IDecomposicaoService _decomposicaoService;

        public ServicesTest()
        {
            _decomposicaoService = new DecomposicaoService();
        }

        [Theory]
        [InlineData(0)]
        [InlineData(-2)]
        [InlineData(-10)]
        [InlineData(-45)]
        public void DecomporNumero_NumerosMenoresOuIguaisAZero_ArgumentException(int numero)
        {
            Assert.Throws<ArgumentException>(() => _decomposicaoService.DecomporNumero(numero));
        }
    }
}
