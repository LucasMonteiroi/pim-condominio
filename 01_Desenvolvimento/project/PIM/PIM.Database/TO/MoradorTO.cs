namespace PIM.Database.TO
{
    using System.Collections.Generic;

    public class MoradorTO
    {
        public int Identificador { get; set; }
        public string Nome { get; set; }
        public string RG { get; set; }
        public string CPF { get; set; }
        public string Telefone { get; set; }
        public string Celular { get; set; }
    }

    public class ListaMoradorTO
    {
        public List<MoradorTO> Lista { get; set; }

        public ListaMoradorTO()
        {
            Lista = new List<MoradorTO>();
        }
    }
}
