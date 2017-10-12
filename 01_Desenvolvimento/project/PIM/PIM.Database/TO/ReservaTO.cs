namespace PIM.Database.TO
{
    using PIM.Database.Infra;
    using PIM.Database.DatabaseModel;
    using System;
    using System.Collections.Generic;

    public class ReservaTO : RetornoTO
    {
        public int Identificador { get; set; }
        public int IdTipoReserva { get; set; }
        public int IdMorador { get; set; }
        public DateTime DataReserva { get; set; }
        public string ConfirmacaoReserva { get; set; }

        internal void PreencherTO(Reserva entidade)
        {
            Identificador = entidade.Identificador;
            IdTipoReserva = entidade.IdTipoReserva;
            IdMorador = entidade.IdMorador;
            DataReserva = entidade.DataReserva;
            ConfirmacaoReserva = entidade.ConfirmacaoReserva;
        }

        internal void PreencherEntidade(Reserva entidade)
        {
            entidade.IdTipoReserva = IdTipoReserva;
            entidade.IdMorador = IdMorador;
            entidade.DataReserva = DataReserva;
            entidade.ConfirmacaoReserva = ConfirmacaoReserva;
        }
    }

    public class ListaReservaTO : RetornoTO
    {
        public List<ReservaTO> Lista { get; set; }

        public ListaReservaTO()
        {
            Lista = new List<ReservaTO>();
        }
    }
}
