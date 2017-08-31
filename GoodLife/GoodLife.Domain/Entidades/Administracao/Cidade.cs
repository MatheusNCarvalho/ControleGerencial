
using System;

namespace GoodLife.Domain.Entidades.Administracao
{
    public class Cidade
    {
        public int CidadeId { get; set; }
        public DateTime DataCadastro { get; set; }
        public DateTime DataAlteracao { get; set; }
        public int IdUsuarioCadastrado { get; set; }
        public int IdUsuarioAlteracao { get; set; }
        public Boolean Status { get; set; }
        public Pais Pais { get; set; }
        public int EstadoId { get; set; }
        public virtual Estado Estados { get; set; }
    }
}
