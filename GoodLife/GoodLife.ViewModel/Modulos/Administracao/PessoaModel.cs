

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using GoodLife.ViewModel.Modulos.Administracao.Enums;


namespace GoodLife.ViewModel.Modulos.Administracao
{
    public class PessoaModel
    {
        public int ClienteId { get; set; }

        public DateTime DataCadastro { get; set; }
        public DateTime DataAlteracao { get; set; }
        public int IdUsuarioCadastrado { get; set; }
        public int IdUsuarioAlteracao { get; set; }
        public Boolean Status { get; set; }
        [Required(ErrorMessage = "Campo Nome é obrigatorio")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Campo  é obrigatorio")]
        public string CpfCnpj { get; set; }

        [Required(ErrorMessage = "Campo tipo documento Obrigatorio")]
        public TipoDocumentoModel TipoDocumento { get; set; }

        [Required(ErrorMessage = "Campo email é obrigatorio")]
        [EmailAddress(ErrorMessage = "Email invalido")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Campo celular obrigatorio")]
        public string Celular { get; set; }

       public virtual IEnumerable<EnderecoModel> Enderecos { get; set; }
    }
}
