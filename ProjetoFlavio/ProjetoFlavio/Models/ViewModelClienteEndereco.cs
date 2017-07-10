using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProjetoFlavio.Models
{
    public class ViewModelClienteEndereco
    {

        public ViewModelClienteEndereco( ClienteEndereco ClienteEndereco)
        {
            this.Clientes = ClienteEndereco.Clientes;
            this.ClientesEnderecos = ClienteEndereco;
        }

        public ViewModelClienteEndereco()
        {
            this.Clientes = Clientes;
            this.ClientesEnderecos = ClientesEnderecos;
        }


        public Cliente Clientes { get; set; }
        public ClienteEndereco ClientesEnderecos { get; set; }
        
    }
}