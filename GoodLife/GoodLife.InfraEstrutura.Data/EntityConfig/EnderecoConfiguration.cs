

using System.Data.Entity.ModelConfiguration;
using GoodLife.Domain.Entidades.Administracao;

namespace GoodLife.InfraEstrutura.Data.EntityConfig
{
    public class EnderecoConfiguration : EntityTypeConfiguration<Endereco>
    {
        public EnderecoConfiguration()
        {
            HasKey(e => e.EnderecoId);

            Property(e => e.EstadoId)
                .IsRequired();

            Property(e => e.CidadeID)
                .IsRequired();

            HasRequired(e => e.Pessoa)
                .WithMany()
                .HasForeignKey(e => e.PessoaId);

        }
    }
}
