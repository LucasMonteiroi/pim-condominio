namespace PIM.Database.TO
{
    using System.Collections.Generic;

    public class AluguelTO
    {
        public int Identificador { get; set; }
        public decimal Valor { get; set; }
        public int IdApartamento { get; set; }
    }

    public class ListaAluguelTO
    {
        public List<AluguelTO> Lista { get; set; }

        public ListaAluguelTO()
        {
            Lista = new List<AluguelTO>();
        }
    }
}
