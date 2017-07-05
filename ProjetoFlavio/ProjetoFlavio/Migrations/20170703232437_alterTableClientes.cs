using System;
using System.Collections.Generic;
using Microsoft.Data.Entity.Migrations;

namespace ProjetoFlavio.Migrations
{
    public partial class alterTableClientes : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "DataNascimento",
                table: "clientes",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
            migrationBuilder.AddColumn<bool>(
                name: "Status",
                table: "clientes",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(name: "DataNascimento", table: "clientes");
            migrationBuilder.DropColumn(name: "Status", table: "clientes");
        }
    }
}
