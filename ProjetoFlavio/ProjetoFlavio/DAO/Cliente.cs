﻿using ProjetoFlavio.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjetoFlavio.DAO
{
    public class ClienteDao
    {
        private EntidadeContext contexto = new EntidadeContext();

        public ClienteDao()
        {
            contexto = new EntidadeContext();
        }

        public void Salva(Cliente cliente)
        {
            //posso fazer regra de negocio
            contexto.Clientes.Add(cliente);
          //  contexto.Entry(cliente).State = Microsoft.Data.Entity.EntityState.Modified;
            contexto.SaveChanges();
            contexto.Dispose();
        }

        public void Atualiza(Cliente cliente)
        {
            contexto.Entry(cliente).State = Microsoft.Data.Entity.EntityState.Modified;
            contexto.SaveChanges();
        }

        public IList<Cliente> Lista()
        {
            
                return contexto.Clientes.Where(m => m.Status == true).ToList();
            
        }

        public Cliente busca( int id)
        {
            //var id2 = 2;
            return contexto.Clientes
                    .Where(p => p.ClienteId == id)
                    .FirstOrDefault();
        }

      

    }
}