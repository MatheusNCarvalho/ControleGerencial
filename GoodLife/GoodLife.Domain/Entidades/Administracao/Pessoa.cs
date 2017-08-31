using System;
using System.Collections;
using System.Collections.Generic;
using GoodLife.Domain.Enum;
using System.ComponentModel.DataAnnotations;

namespace GoodLife.Domain.Entidades.Administracao
{
    public class Pessoa
    {
       [Key]
        public int ClienteId { get; set; }

        public DateTime DataCadastro { get; set; }
        public DateTime DataAlteracao { get; set; }
        public int IdUsuarioCadastrado { get; set; }
        public int IdUsuarioAlteracao { get; set; }
        public Boolean Status { get; set; }

        public string Nome { get; set; }

        
        public string CpfCnpj { get; set; }

        public TipoDocumento TipoDocumento { get; set; }

     
        public string Email { get; set; }
      
        public string Celular { get; set; }

        public virtual IEnumerable<Endereco> Enderecos { get; set; }
 


    }
}
