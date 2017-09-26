namespace PIM.Database.TO
{
    using System.Collections.Generic;

    public class DependenteTO
    {
        public int Identificador { get; set; }
        public string Nome { get; set; }
        public string RG { get; set; }
        public string CPF { get; set; }
        public string Telefone { get; set; }
        public int IdMorador { get; set; }
    }

    public class ListaDependenteTO
    {
        public List<DependenteTO> Lista { get; set; }

        public ListaDependenteTO()
        {
            Lista = new List<DependenteTO>();
        }
    }
}