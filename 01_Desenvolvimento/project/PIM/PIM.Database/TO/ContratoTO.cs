namespace PIM.Database.TO
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class ContratoTO
    {
        public int Identificador { get; set; }
        public string Ativo { get; set; }
        public DateTime DataContrato { get; set; }
        public int IdMorador { get; set; }
        public int IdAluguel { get; set; }
    }

    public class ListaContratoTO
    {
        public List<ContratoTO> Lista { get; set; }

        public ListaContratoTO()
        {
            Lista = new List<ContratoTO>();
        }
    }
}
