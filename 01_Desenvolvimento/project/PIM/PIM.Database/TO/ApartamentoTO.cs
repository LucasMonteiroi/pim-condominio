namespace PIM.Database.TO
{
    using System.Collections.Generic;

    public class ApartamentoTO
    {
        public int Identificador { get; set; }
        public int Bloco { get; set; }
        public string Numero { get; set; }
        public int MoradorAlocado { get; set; }
    }

    public class ListaApartamentoTO
    {
        public List<ApartamentoTO> Lista { get; set; }

        public ListaApartamentoTO()
        {
            Lista = new List<ApartamentoTO>();
        }
    }
}
