using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApplicationTeste.Migrations
{
    public partial class WebApplication2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Itens_Pedidos_PedidoIdPedido",
                table: "Itens");

            migrationBuilder.DropForeignKey(
                name: "FK_Itens_Produtos_ProdutoIdProduto",
                table: "Itens");

            migrationBuilder.RenameColumn(
                name: "IdProduto",
                table: "Produtos",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "IdPedido",
                table: "Pedidos",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "ProdutoIdProduto",
                table: "Itens",
                newName: "ProdutoId");

            migrationBuilder.RenameColumn(
                name: "PedidoIdPedido",
                table: "Itens",
                newName: "PedidoId");

            migrationBuilder.RenameColumn(
                name: "IdItemPedido",
                table: "Itens",
                newName: "Id");

            migrationBuilder.RenameIndex(
                name: "IX_Itens_ProdutoIdProduto",
                table: "Itens",
                newName: "IX_Itens_ProdutoId");

            migrationBuilder.RenameIndex(
                name: "IX_Itens_PedidoIdPedido",
                table: "Itens",
                newName: "IX_Itens_PedidoId");

            migrationBuilder.AddForeignKey(
                name: "FK_Itens_Pedidos_PedidoId",
                table: "Itens",
                column: "PedidoId",
                principalTable: "Pedidos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Itens_Produtos_ProdutoId",
                table: "Itens",
                column: "ProdutoId",
                principalTable: "Produtos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Itens_Pedidos_PedidoId",
                table: "Itens");

            migrationBuilder.DropForeignKey(
                name: "FK_Itens_Produtos_ProdutoId",
                table: "Itens");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Produtos",
                newName: "IdProduto");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Pedidos",
                newName: "IdPedido");

            migrationBuilder.RenameColumn(
                name: "ProdutoId",
                table: "Itens",
                newName: "ProdutoIdProduto");

            migrationBuilder.RenameColumn(
                name: "PedidoId",
                table: "Itens",
                newName: "PedidoIdPedido");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Itens",
                newName: "IdItemPedido");

            migrationBuilder.RenameIndex(
                name: "IX_Itens_ProdutoId",
                table: "Itens",
                newName: "IX_Itens_ProdutoIdProduto");

            migrationBuilder.RenameIndex(
                name: "IX_Itens_PedidoId",
                table: "Itens",
                newName: "IX_Itens_PedidoIdPedido");

            migrationBuilder.AddForeignKey(
                name: "FK_Itens_Pedidos_PedidoIdPedido",
                table: "Itens",
                column: "PedidoIdPedido",
                principalTable: "Pedidos",
                principalColumn: "IdPedido",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Itens_Produtos_ProdutoIdProduto",
                table: "Itens",
                column: "ProdutoIdProduto",
                principalTable: "Produtos",
                principalColumn: "IdProduto",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
