namespace PIM.Database.TO
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class TipoReservaTO
    {
        public int Identificador { get; set; }
        public string TipoReserva { get; set; }
    }

    public class ListaTipoReservaTO
    {
        public List<TipoReservaTO> Lista { get; set; }

        public ListaTipoReservaTO()
        {
            Lista = new List<TipoReservaTO>();
        }
    }
}
