namespace GoodLife.InfraEstrutura.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Cidade : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Cidades",
                c => new
                    {
                        CidadeId = c.Int(nullable: false, identity: true),
                        DataCadastro = c.DateTime(nullable: false),
                        DataAlteracao = c.DateTime(nullable: false),
                        IdUsuarioCadastrado = c.Int(nullable: false),
                        IdUsuarioAlteracao = c.Int(nullable: false),
                        Status = c.Boolean(nullable: false),
                        Estados_EstadoId = c.Int(),
                        Pais_PaisId = c.Int(),
                    })
                .PrimaryKey(t => t.CidadeId)
                .ForeignKey("dbo.Estadoes", t => t.Estados_EstadoId)
                .ForeignKey("dbo.Pais", t => t.Pais_PaisId)
                .Index(t => t.Estados_EstadoId)
                .Index(t => t.Pais_PaisId);
            
            CreateTable(
                "dbo.Estadoes",
                c => new
                    {
                        EstadoId = c.Int(nullable: false, identity: true),
                        DataCadastro = c.DateTime(nullable: false),
                        DataAlteracao = c.DateTime(nullable: false),
                        IdUsuarioCadastrado = c.Int(nullable: false),
                        IdUsuarioAlteracao = c.Int(nullable: false),
                        Status = c.Boolean(nullable: false),
                        Sigla = c.String(),
                        CodigoIBGE = c.Int(nullable: false),
                        Pais_PaisId = c.Int(),
                    })
                .PrimaryKey(t => t.EstadoId)
                .ForeignKey("dbo.Pais", t => t.Pais_PaisId)
                .Index(t => t.Pais_PaisId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Cidades", "Pais_PaisId", "dbo.Pais");
            DropForeignKey("dbo.Cidades", "Estados_EstadoId", "dbo.Estadoes");
            DropForeignKey("dbo.Estadoes", "Pais_PaisId", "dbo.Pais");
            DropIndex("dbo.Estadoes", new[] { "Pais_PaisId" });
            DropIndex("dbo.Cidades", new[] { "Pais_PaisId" });
            DropIndex("dbo.Cidades", new[] { "Estados_EstadoId" });
            DropTable("dbo.Estadoes");
            DropTable("dbo.Cidades");
        }
    }
}
