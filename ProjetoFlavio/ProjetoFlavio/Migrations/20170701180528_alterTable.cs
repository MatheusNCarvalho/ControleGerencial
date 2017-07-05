using System;
using System.Collections.Generic;
using Microsoft.Data.Entity.Migrations;

namespace ProjetoFlavio.Migrations
{
    public partial class alterTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(name: "FK_ClienteEndereco_Cliente_ClientesId", table: "clientes_enderecos");
            migrationBuilder.DropColumn(name: "EnderecosId", table: "clientes");
            migrationBuilder.AddForeignKey(
                name: "FK_ClienteEndereco_Cliente_ClientesId",
                table: "clientes_enderecos",
                column: "ClientesId",
                principalTable: "clientes",
                principalColumn: "ClienteId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(name: "FK_ClienteEndereco_Cliente_ClientesId", table: "clientes_enderecos");
            migrationBuilder.AddColumn<int>(
                name: "EnderecosId",
                table: "clientes",
                nullable: false,
                defaultValue: 0);
            migrationBuilder.AddForeignKey(
                name: "FK_ClienteEndereco_Cliente_ClientesId",
                table: "clientes_enderecos",
                column: "ClientesId",
                principalTable: "clientes",
                principalColumn: "ClienteId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
