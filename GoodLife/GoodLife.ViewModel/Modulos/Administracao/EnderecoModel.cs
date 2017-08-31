
using System;

namespace GoodLife.ViewModel.Modulos.Administracao
{
    public class EnderecoModel
    {
        public int EnderecoId { get; set; }
        public DateTime DataCadastro { get; set; }
        public DateTime DataAlteracao { get; set; }
        public int IdUsuarioCadastrado { get; set; }
        public int IdUsuarioAlteracao { get; set; }
        public Boolean Status { get; set; }

        public int Cep { get; set; }
        public String Logradouro { get; set; }
        public String Bairro { get; set; }
        public Pais Pais { get; set; }
        public int EstadoId { get; set; }
        public virtual Estado Estados { get; set; }
        public int CidadeID { get; set; }
        public virtual Cidade Cidades { get; set; }

        public int PessoaId { get; set; }
        public virtual PessoaModel Pessoa { get; set; }

    }
}
