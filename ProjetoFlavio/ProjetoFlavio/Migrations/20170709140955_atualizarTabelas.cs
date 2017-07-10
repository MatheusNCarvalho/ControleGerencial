using System;
using System.Collections.Generic;
using Microsoft.Data.Entity.Migrations;

namespace ProjetoFlavio.Migrations
{
    public partial class atualizarTabelas : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(name: "FK_Cliente_ClienteEndereco_EnderecoEnderecoId", table: "clientes");
            migrationBuilder.DropColumn(name: "EnderecoEnderecoId", table: "clientes");
            migrationBuilder.AlterColumn<string>(
                name: "Estado",
                table: "clientes_enderecos",
                nullable: false);
            migrationBuilder.AlterColumn<string>(
                name: "Cidade",
                table: "clientes_enderecos",
                nullable: false);
            migrationBuilder.AlterColumn<string>(
                name: "Cep",
                table: "clientes_enderecos",
                nullable: false);
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
            migrationBuilder.AlterColumn<string>(
                name: "Estado",
                table: "clientes_enderecos",
                nullable: true);
            migrationBuilder.AlterColumn<string>(
                name: "Cidade",
                table: "clientes_enderecos",
                nullable: true);
            migrationBuilder.AlterColumn<string>(
                name: "Cep",
                table: "clientes_enderecos",
                nullable: true);
            migrationBuilder.AddColumn<int>(
                name: "EnderecoEnderecoId",
                table: "clientes",
                nullable: true);
            migrationBuilder.AddForeignKey(
                name: "FK_Cliente_ClienteEndereco_EnderecoEnderecoId",
                table: "clientes",
                column: "EnderecoEnderecoId",
                principalTable: "clientes_enderecos",
                principalColumn: "EnderecoId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
