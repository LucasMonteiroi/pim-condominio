namespace PIM.Database.TO
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class OcorrenciaTO
    {
        public int Identificador { get; set; }
        public int IdMorador { get; set; }
        public DateTime DataOcorrencia { get; set; }
        public string Motivo { get; set; }
        public string Descricao { get; set; }
    }

    public class ListaOcorrenciaTO
    {
        public List<OcorrenciaTO> Lista { get; set; }

        public ListaOcorrenciaTO()
        {
            Lista = new List<OcorrenciaTO>();
        }
    }
}
