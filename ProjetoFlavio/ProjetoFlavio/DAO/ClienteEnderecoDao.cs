using ProjetoFlavio.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjetoFlavio.DAO
{
    public class ClienteEnderecoDao
    {
        private EntidadeContext contexto = new EntidadeContext();

        public ClienteEnderecoDao()
        {
            contexto = new EntidadeContext();
        }

        public void Salva(ClienteEndereco produto)
        {
            //posso fazer regra de negocio
            contexto.ClientesEnderecos.Add(produto);
            contexto.SaveChanges();
            contexto.Dispose();
        }

    }
}