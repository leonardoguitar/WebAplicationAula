using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApplicationTeste.Migrations
{
    public partial class WebApplication3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "DtCreation",
                table: "Produtos",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "DtLastUpdate",
                table: "Produtos",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DtCreation",
                table: "Pedidos",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "DtLastUpdate",
                table: "Pedidos",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DtCreation",
                table: "Itens",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "DtLastUpdate",
                table: "Itens",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DtCreation",
                table: "Produtos");

            migrationBuilder.DropColumn(
                name: "DtLastUpdate",
                table: "Produtos");

            migrationBuilder.DropColumn(
                name: "DtCreation",
                table: "Pedidos");

            migrationBuilder.DropColumn(
                name: "DtLastUpdate",
                table: "Pedidos");

            migrationBuilder.DropColumn(
                name: "DtCreation",
                table: "Itens");

            migrationBuilder.DropColumn(
                name: "DtLastUpdate",
                table: "Itens");
        }
    }
}
