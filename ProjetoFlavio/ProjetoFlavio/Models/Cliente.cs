using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Web.Mvc;

namespace ProjetoFlavio.Models
{
    [Table("clientes")]
    public class Cliente
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ClienteId { get; set; }

        [Required(ErrorMessage ="Preencha o nome Completo")]
        [MaxLength(100, ErrorMessage ="O nome deve ter até {1} caracteres.")]
        public string Nome { get; set; }

        [Required(ErrorMessage ="Preencha o CPF ou CNPJ.")]
        [Remote("ValidaCPFCNPJ","Clientes",ErrorMessage="Esse CPF/CNPJ já esta cadastrado.")]
        public string CpfCnpj { get; set; }

        
        public bool Status { get; set; }


        [Required]
        public string Email { get; set; }
        [Required]
        public string Celular { get; set; }

        public virtual ClienteEndereco Endereco {get;set;}


    }
}