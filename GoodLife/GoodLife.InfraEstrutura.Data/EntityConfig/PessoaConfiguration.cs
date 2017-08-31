

using System.Data.Entity.ModelConfiguration;
using GoodLife.Domain.Entidades.Administracao;

namespace GoodLife.InfraEstrutura.Data.EntityConfig
{
    //Usando o FluetyApi
    public  class PessoaConfiguration : EntityTypeConfiguration<Pessoa>
    {
        public PessoaConfiguration()
        {
            HasKey(c => c.ClienteId);

            Property(c => c.Nome)
                .IsRequired()
                .HasMaxLength(150);

            Property(c => c.Email)
                .IsRequired();

            Property(c => c.CpfCnpj)
                .IsRequired()
                .HasMaxLength(15);

            Property(c => c.TipoDocumento)
                .IsRequired();

        }
    }
}
