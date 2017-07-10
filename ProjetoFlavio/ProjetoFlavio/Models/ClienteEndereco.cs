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
        [Required]
        public string Estado { get; set; }

        [Required]
        public string Cidade { get; set; }
        [Required]
        public string Cep { get; set; }
        [Required]
        public int ClientesId { get; set; }

        public virtual Cliente Clientes { get; set; }
        
    }
}