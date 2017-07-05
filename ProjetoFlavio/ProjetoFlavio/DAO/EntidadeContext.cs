using Microsoft.Data.Entity;
using ProjetoFlavio.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;

namespace ProjetoFlavio.DAO
{
    public class EntidadeContext :DbContext
    {


        public DbSet<Cliente> Clientes { get; set; }

        public DbSet<ClienteEndereco> ClientesEnderecos { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string stringConexao = ConfigurationManager.ConnectionStrings["projetoConnectionString"].ConnectionString;
            optionsBuilder.UseSqlServer(stringConexao);
            base.OnConfiguring(optionsBuilder);
        }




    }
}