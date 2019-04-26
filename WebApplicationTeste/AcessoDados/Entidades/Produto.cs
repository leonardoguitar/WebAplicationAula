using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplicationTeste.AcessoDados.Entidades;

namespace WebApplicationTeste.wwwroot.AcessoDados.Entidades
{
	public class Produto : AbstractDbConfig
    {
		public int Id { get; set; }
		public string Descricao { get; set; }
		public string Nome { get; set; }
		public decimal Preco { get; set; }
	}
}
