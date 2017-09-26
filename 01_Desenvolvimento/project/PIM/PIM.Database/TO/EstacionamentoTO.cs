namespace PIM.Database.TO
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class EstacionamentoTO
    {
        public int Identificador { get; set; }
        public int IdApartamento { get; set; }
        public int VagasDisponiveis { get; set; }
    }

    public class ListaEstacionamentoTO
    {
        public List<EstacionamentoTO> Lista { get; set; }

        public ListaEstacionamentoTO()
        {
            Lista = new List<EstacionamentoTO>();
        }
    }
}
