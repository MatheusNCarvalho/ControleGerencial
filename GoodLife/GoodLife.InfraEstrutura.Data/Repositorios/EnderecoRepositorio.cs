

using System.Collections.Generic;
using System.Linq;
using GoodLife.Domain.Entidades.Administracao;
using GoodLife.Domain.Interfaces;

namespace GoodLife.InfraEstrutura.Data.Repositorios
{
    public class EnderecoRepositorio : RepositorioBase<Endereco>, IEnderecoRepositorio
    {
        public IEnumerable<Endereco> BuscarPorNome(string nome)
        {
            return Db.Enderecos.Where(e => e.Logradouro == nome);
        }
    }
}
