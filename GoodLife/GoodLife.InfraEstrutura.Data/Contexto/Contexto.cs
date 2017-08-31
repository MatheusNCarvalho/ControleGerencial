using System;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using GoodLife.Domain.Entidades.Administracao;
using GoodLife.InfraEstrutura.Data.EntityConfig;

namespace GoodLife.InfraEstrutura.Data.Contexto
{
    public class Contexto : DbContext 
    {
        public Contexto() :base("strDesenvolvimento")
        {
            
        }

        public DbSet<Pessoa> Pessoas { get; set; }
        public  DbSet<Pais> Paises { get; set; }
        public DbSet<Cidade> Cidades { get; set; }
        public DbSet<Endereco> Enderecos { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //Removendo conversoes
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
            modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();

            //----------- ------------
            
            //Configruando quando uma propriedade quando uma propriedade estive um nome terminando com ID
            modelBuilder.Properties()
                .Where(p => p.Name == p.ReflectedType.Name + "Id")
                .Configure(p => p.IsKey());

            modelBuilder.Properties<string>()
                .Configure(p => p.HasColumnType("varchar"));

            modelBuilder.Properties<string>()
                .Configure(p => p.HasMaxLength(100));

            modelBuilder.Configurations.Add(new PessoaConfiguration());
            modelBuilder.Configurations.Add(new EnderecoConfiguration());


        }

        public override int SaveChanges()
        {
            foreach (var entry in ChangeTracker.Entries().Where(entry => entry.Entity.GetType().GetProperty("DataCadastro")!=null))
            {

                if (entry.State == EntityState.Added)
                {
                    entry.Property("DataCadastro").CurrentValue = DateTime.Now;
                }
                if (entry.State == EntityState.Modified)
                {
                    entry.Property("DataAlteracao").CurrentValue = DateTime.Now;
                }

            }

            return base.SaveChanges();
        }
    }
}
