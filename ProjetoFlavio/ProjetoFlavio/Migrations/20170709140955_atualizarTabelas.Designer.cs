using System;
using Microsoft.Data.Entity;
using Microsoft.Data.Entity.Infrastructure;
using Microsoft.Data.Entity.Metadata;
using Microsoft.Data.Entity.Migrations;
using ProjetoFlavio.DAO;

namespace ProjetoFlavio.Migrations
{
    [DbContext(typeof(EntidadeContext))]
    [Migration("20170709140955_atualizarTabelas")]
    partial class atualizarTabelas
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.0-rc1-16348")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ProjetoFlavio.Models.Cliente", b =>
                {
                    b.Property<int>("ClienteId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Celular")
                        .IsRequired();

                    b.Property<string>("CpfCnpj")
                        .IsRequired();

                    b.Property<string>("Email")
                        .IsRequired();

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasAnnotation("MaxLength", 100);

                    b.Property<bool>("Status");

                    b.HasKey("ClienteId");

                    b.HasAnnotation("Relational:TableName", "clientes");
                });

            modelBuilder.Entity("ProjetoFlavio.Models.ClienteEndereco", b =>
                {
                    b.Property<int>("EnderecoId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Bairro");

                    b.Property<string>("Cep")
                        .IsRequired();

                    b.Property<string>("Cidade")
                        .IsRequired();

                    b.Property<int>("ClientesId");

                    b.Property<string>("Estado")
                        .IsRequired();

                    b.Property<string>("Logradouro");

                    b.HasKey("EnderecoId");

                    b.HasAnnotation("Relational:TableName", "clientes_enderecos");
                });

            modelBuilder.Entity("ProjetoFlavio.Models.ClienteEndereco", b =>
                {
                    b.HasOne("ProjetoFlavio.Models.Cliente")
                        .WithMany()
                        .HasForeignKey("ClientesId");
                });
        }
    }
}
