namespace PIM.Database.TO
{
    using PIM.Database.DatabaseModel;
    using PIM.Database.Infra;
    using System.Collections.Generic;

    public class VisitanteTO : RetornoTO
    {
        public int Identificador { get; set; }
        public string Nome { get; set; }
        public int IdMorador { get; set; }

        public void PreencherTO(Visitante entidade)
        {
            Identificador = entidade.Identificador;
            Nome = entidade.Nome;
            IdMorador = entidade.IdMorador;
        }

        public void PreencherEntidade(Visitante entidade)
        {
            entidade.Nome = Nome;
            entidade.IdMorador = IdMorador;
        }
    }

    public class ListaVisitanteTO : RetornoTO
    {
        public List<VisitanteTO> Lista { get; set; }

        public ListaVisitanteTO()
        {
            Lista = new List<VisitanteTO>();
        }
    }
}
