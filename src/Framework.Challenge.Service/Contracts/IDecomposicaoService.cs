using Framework.Challenge.Service.Models;

namespace Framework.Challenge.Service.Contracts
{
    public interface IDecomposicaoService
    {
        Decomposicao DecomporNumero(int numero);
    }
}