using System;

namespace GoodLife.Domain.Entidades.Administracao
{
    public class Pais
    {
        public int PaisId  { get; set; }
        public DateTime DataCadastro { get; set; }
        public DateTime DataAlteracao { get; set; }
        public int IdUsuarioCadastrado { get; set; }
        public int IdUsuarioAlteracao { get; set; }
        public Boolean Status { get; set; }
        public String Nome { get; set; }
        public  String teste { get; set; }
        public String teste2 { get; set; }
    }
}
