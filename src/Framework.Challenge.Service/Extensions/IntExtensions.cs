using System.Collections.Generic;
using System.Linq;

namespace Framework.Challenge.Service.Extensions
{
    public static class IntExtensions
    {
        /// <summary>
        /// Testa se o número é primo
        /// </summary>
        /// <returns>True caso o número seja primo</returns>
        public static bool EPrimo(this int numero)
        {
            //Número 1 não é considerado primo pois só é divisivel por si.
            if (numero <= 1)
                return false;

            var divisores = ObterDivisores(numero);

            return divisores.Count() == 2;
        }

        /// <summary>
        /// Obtem os divisores de um número, avaliando se o resto da divisão com um possível divisor é 0
        /// </summary>
        /// <returns>List de divisores</returns>
        public static List<int> ObterDivisores(this int numero)
        {
            if (numero <= 0)
                return new List<int>();

            var possiveisDivisores = Enumerable.Range(1, numero);
            var divisores = new List<int>();

            foreach (var divisor in possiveisDivisores)
            {
                if (numero % divisor == 0)
                {
                    divisores.Add(divisor);
                }
            }

            return divisores;
        }
    }
}