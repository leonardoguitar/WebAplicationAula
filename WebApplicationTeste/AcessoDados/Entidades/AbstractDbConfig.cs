using System;

namespace WebApplicationTeste.AcessoDados.Entidades
{
    public abstract class AbstractDbConfig
    {
        public DateTime DtCreation { get; set; }
        public DateTime? DtLastUpdate { get; set; }
    }
}
