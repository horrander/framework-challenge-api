using System.Linq;
using System;
using System.Collections.Generic;
using Framework.Challenge.Service.Extensions;

namespace Framework.Challenge.Service.Models
{
    public class Decomposicao
    {
        public int Valor {get; private set;}
        public IList<int> Divisores { get; private set; }
        public IList<int> NumerosPrimos { get; private set;}

        public Decomposicao(int valor)
        {
            if(valor <= 0)
                throw new ArgumentException("O número a ser decomposto deve ser superior a 0");

            Valor = valor;
            ObterDivisores();
            ObterNumerosPrimos();
        }

        private void ObterDivisores()
        {
            Divisores = Valor.ObterDivisores();
        }

        private void ObterNumerosPrimos()
        {
            NumerosPrimos = new List<int>();

            foreach (var divisor in Divisores)
            {
                if(divisor.EPrimo())
                {
                    NumerosPrimos.Add(divisor);
                }
            }
        }
    }
}