namespace PIM.Database.TO
{
    using PIM.Database.DatabaseModel;
    using PIM.Database.Infra;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class AdvertenciaTO : RetornoTO
    {
        public int Identificador { get; set; }
        public decimal Valor { get; set; }
        public string Pago { get; set; }
        public int IdOcorrencia { get; set; }

        public void PreencherTO(Advertencia entidade)
        {
            Identificador = entidade.Identificador;
            Valor = entidade.Valor;
            Pago = entidade.Pago;
            IdOcorrencia = entidade.IdOcorrencia;
        }

        public void PreencherEntidade(Advertencia entidade)
        {
            entidade.Valor = Valor;
            entidade.Pago = Pago;
            entidade.IdOcorrencia = IdOcorrencia;
        }
    }

    public class ListaAdvertenciaTO : RetornoTO
    {
        public List<AdvertenciaTO> Lista { get; set; }

        public ListaAdvertenciaTO()
        {
            Lista = new List<AdvertenciaTO>();
        }
    }
}
