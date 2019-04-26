using System;
using System.Collections.Generic;
using WebApplicationTeste.AcessoDados.Entidades;

namespace WebApplicationTeste.wwwroot.AcessoDados.Entidades
{
	public class Pedido : AbstractDbConfig
    {
		public int Id { get; set; }
		public DateTime DataPedido { get; set; }
		public ICollection<ItemPedido> ItensPedidos { get; set; }
	}
}
