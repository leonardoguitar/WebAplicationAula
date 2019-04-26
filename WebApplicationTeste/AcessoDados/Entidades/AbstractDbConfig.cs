using System;

namespace WebApplicationTeste.AcessoDados.Entidades
{
    public abstract class AbstractDbConfig
    {
        //Classe para definir atributos em comum nas tabelas
        public DateTime DtCreation { get; set; }
        public DateTime? DtLastUpdate { get; set; }
    }
}
