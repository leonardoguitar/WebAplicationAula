using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApplicationTeste.Migrations
{
    public partial class WebApplication : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Pedidos_Pedidos_PedidoIdPedido",
                table: "Pedidos");

            migrationBuilder.DropIndex(
                name: "IX_Pedidos_PedidoIdPedido",
                table: "Pedidos");

            migrationBuilder.DropColumn(
                name: "PedidoIdPedido",
                table: "Pedidos");

            migrationBuilder.AddColumn<int>(
                name: "PedidoIdPedido",
                table: "Itens",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Itens_PedidoIdPedido",
                table: "Itens",
                column: "PedidoIdPedido");

            migrationBuilder.AddForeignKey(
                name: "FK_Itens_Pedidos_PedidoIdPedido",
                table: "Itens",
                column: "PedidoIdPedido",
                principalTable: "Pedidos",
                principalColumn: "IdPedido",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Itens_Pedidos_PedidoIdPedido",
                table: "Itens");

            migrationBuilder.DropIndex(
                name: "IX_Itens_PedidoIdPedido",
                table: "Itens");

            migrationBuilder.DropColumn(
                name: "PedidoIdPedido",
                table: "Itens");

            migrationBuilder.AddColumn<int>(
                name: "PedidoIdPedido",
                table: "Pedidos",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Pedidos_PedidoIdPedido",
                table: "Pedidos",
                column: "PedidoIdPedido");

            migrationBuilder.AddForeignKey(
                name: "FK_Pedidos_Pedidos_PedidoIdPedido",
                table: "Pedidos",
                column: "PedidoIdPedido",
                principalTable: "Pedidos",
                principalColumn: "IdPedido",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
