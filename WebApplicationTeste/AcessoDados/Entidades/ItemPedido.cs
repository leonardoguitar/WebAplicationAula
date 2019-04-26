using WebApplicationTeste.AcessoDados.Entidades;

namespace WebApplicationTeste.wwwroot.AcessoDados.Entidades
{
	public class ItemPedido : AbstractDbConfig
    {
		public int Id { get; set; }
		public Produto Produto { get; set; }
		public int Quantidate { get; set; }
	}
}
