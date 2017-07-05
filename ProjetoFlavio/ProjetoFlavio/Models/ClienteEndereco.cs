using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjetoFlavio.Models
{
    [Table("clientes_enderecos")]
    public class ClienteEndereco
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int EnderecoId { get; set; }
        public string Logradouro { get; set; }
        public string Bairro { get; set; }
        public string Estado { get; set; }
        public string Cidade { get; set; }
        public string Cep { get; set; }

        public int ClientesId { get; set; }
       // public virtual Cliente Clientes { get; set; }
        
    }
}