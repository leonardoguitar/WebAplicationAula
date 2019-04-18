﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebApplicationTeste.wwwroot.AcessoDados;

namespace WebApplicationTeste.Migrations
{
    [DbContext(typeof(MyWebAppContext))]
    [Migration("20190417225329_WebApplication")]
    partial class WebApplication
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.4-servicing-10062")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("WebApplicationTeste.wwwroot.AcessoDados.Entidades.ItemPedido", b =>
                {
                    b.Property<int>("IdItemPedido")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("PedidoIdPedido");

                    b.Property<int?>("ProdutoIdProduto");

                    b.Property<int>("Quantidate");

                    b.HasKey("IdItemPedido");

                    b.HasIndex("PedidoIdPedido");

                    b.HasIndex("ProdutoIdProduto");

                    b.ToTable("Itens");
                });

            modelBuilder.Entity("WebApplicationTeste.wwwroot.AcessoDados.Entidades.Pedido", b =>
                {
                    b.Property<int>("IdPedido")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("DataPedido");

                    b.HasKey("IdPedido");

                    b.ToTable("Pedidos");
                });

            modelBuilder.Entity("WebApplicationTeste.wwwroot.AcessoDados.Entidades.Produto", b =>
                {
                    b.Property<int>("IdProduto")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Descricao");

                    b.Property<string>("Nome");

                    b.Property<decimal>("Preco");

                    b.HasKey("IdProduto");

                    b.ToTable("Produtos");
                });

            modelBuilder.Entity("WebApplicationTeste.wwwroot.AcessoDados.Entidades.ItemPedido", b =>
                {
                    b.HasOne("WebApplicationTeste.wwwroot.AcessoDados.Entidades.Pedido")
                        .WithMany("ItensPedidos")
                        .HasForeignKey("PedidoIdPedido");

                    b.HasOne("WebApplicationTeste.wwwroot.AcessoDados.Entidades.Produto", "Produto")
                        .WithMany()
                        .HasForeignKey("ProdutoIdProduto");
                });
#pragma warning restore 612, 618
        }
    }
}