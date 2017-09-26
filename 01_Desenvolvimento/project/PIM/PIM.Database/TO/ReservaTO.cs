namespace PIM.Database.TO
{
    using System;
    using System.Collections.Generic;

    public class ReservaTO
    {
        public int Identificador { get; set; }
        public int IdTipoReserva { get; set; }
        public int IdMorador { get; set; }
        public DateTime DataReserva { get; set; }
        public string ConfirmacaoReserva { get; set; }
    }

    public class ListaReservaTO
    {
        public List<ReservaTO> Lista { get; set; }

        public ListaReservaTO()
        {
            Lista = new List<ReservaTO>();
        }
    }
}
