using Microsoft.Data.Entity;
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

        public void Atualiza(ClienteEndereco endereco)
        {
            contexto.Entry(endereco).State = EntityState.Modified;            
            contexto.SaveChanges();
        }

        public ClienteEndereco BuscaPorClienteEndereco(int id)
        {
            return contexto.ClientesEnderecos.Include(c => c.Clientes).Where(ci => ci.Clientes.Status == true).First(endereco => endereco.ClientesId == id);
        }

    }
}