

using System.Collections;
using System.Collections.Generic;
using GoodLife.Domain.Entidades.Administracao;

namespace GoodLife.Domain.Interfaces
{
    public interface IEnderecoRepositorio: IRepositorioBase<Endereco>
    {
        IEnumerable<Endereco> BuscarPorNome(string nome);
    }
}
