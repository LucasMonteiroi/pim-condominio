namespace PIM.Database.TO
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class ColaboradorTO
    {
        public string Nome { get; set; }
        public string RG { get; set; }
        public string CPF { get; set; }
        public string Funcao { get; set; }
        public DateTime DataContrato { get; set; }
        public decimal Salario { get; set; }
    }

    public class ListaColaboradorTO
    {
        public List<ColaboradorTO> Lista { get; set; }

        public ListaColaboradorTO()
        {
            Lista = new List<ColaboradorTO>();
        }
    }
}
