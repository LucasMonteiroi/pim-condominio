namespace PIM.Database.TO
{
    using PIM.Database.Infra;
    using PIM.Database.DatabaseModel;
    using System.Collections.Generic;

    public class TipoReservaTO : RetornoTO
    {
        public int Identificador { get; set; }
        public string Tipo { get; set; }

        internal void PreencherTO(TipoReserva entidade)
        {
            Identificador = entidade.Identificador;
            Tipo = entidade.Tipo;
        }

        internal void PreencherEntidade(TipoReserva entidade)
        {
            entidade.Tipo = Tipo;
        }
    }

    public class ListaTipoReservaTO : RetornoTO
    {
        public List<TipoReservaTO> Lista { get; set; }

        public ListaTipoReservaTO()
        {
            Lista = new List<TipoReservaTO>();
        }
    }
}
