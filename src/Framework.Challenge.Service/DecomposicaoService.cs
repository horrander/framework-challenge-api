using System;
using Framework.Challenge.Service.Contracts;
using Framework.Challenge.Service.Models;

namespace Framework.Challenge.Service
{
    public class DecomposicaoService : IDecomposicaoService
    {
        public Decomposicao DecomporNumero(int numero)
        {
            if(numero <= 0)
                throw new ArgumentException("O número a ser decomposto deve ser maior que 0");

            return new Decomposicao(numero);
        }
    }
}