namespace PIM.Database.TO
{
    using PIM.Database.Infra;
    using PIM.Database.DatabaseModel;
    using System.Collections.Generic;

    public class MoradorTO : RetornoTO
    {
        public int Identificador { get; set; }
        public string Nome { get; set; }
        public string RG { get; set; }
        public string CPF { get; set; }
        public string Telefone { get; set; }
        public string Celular { get; set; }

        internal void PreencherTO(Morador entidade)
        {
            Identificador = entidade.Identificador;
            Nome = entidade.Nome;
            RG = entidade.RG;
            CPF = entidade.CPF;
            Telefone = entidade.Telefone;
            Celular = entidade.Celular;
        }

        internal void PreencherEntidade(Morador entidade)
        {
            entidade.Nome = Nome;
            entidade.RG = RG;
            entidade.CPF = CPF;
            entidade.Telefone = Telefone;
            entidade.Celular = Celular;
        }
    }

    public class ListaMoradorTO : RetornoTO
    {
        public List<MoradorTO> Lista { get; set; }

        public ListaMoradorTO()
        {
            Lista = new List<MoradorTO>();
        }
    }
}
