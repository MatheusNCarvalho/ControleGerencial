

using System;

namespace GoodLife.Domain.Entidades.Administracao
{
    public class Estado
    {
        public int EstadoId { get; set; }

        public DateTime DataCadastro { get; set; }
        public DateTime DataAlteracao { get; set; }
        public int IdUsuarioCadastrado { get; set; }
        public int IdUsuarioAlteracao { get; set; }
        public Boolean Status { get; set; }

        public String Sigla { get; set; }

        public Pais Pais { get; set; }
        public int CodigoIBGE { get; set; }
    }
}
