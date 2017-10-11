namespace PIM.Database.TO
{
    using PIM.Database.Infra;
    using PIM.Database.Modelo;
    using System.Collections.Generic;

    public class DependenteTO : RetornoTO
    {
        public int Identificador { get; set; }
        public string Nome { get; set; }
        public string RG { get; set; }
        public string CPF { get; set; }
        public string Telefone { get; set; }
        public int IdMorador { get; set; }

        internal void PreencherTO(Dependente entidade)
        {
            Identificador = entidade.Identificador;
            Nome = entidade.Nome;
            RG = entidade.RG;
            CPF = entidade.CPF;
            Telefone = entidade.Telefone;
            IdMorador = entidade.IdMorador;
        }

        internal void PreencherEntidade(Dependente entidade)
        {
            entidade.Nome = Nome;
            entidade.RG = RG;
            entidade.CPF = CPF;
            entidade.Telefone = Telefone;
            entidade.IdMorador = IdMorador;
        }
    }

    public class ListaDependenteTO : RetornoTO
    {
        public List<DependenteTO> Lista { get; set; }

        public ListaDependenteTO()
        {
            Lista = new List<DependenteTO>();
        }
    }
}