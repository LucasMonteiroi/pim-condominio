namespace PIM.Database.TO
{
    using PIM.Database.Infra;
    using PIM.Database.Modelo;
    using System;
    using System.Collections.Generic;

    public class ColaboradorTO : RetornoTO
    {
        public int Identificador { get; set; }
        public string Nome { get; set; }
        public string RG { get; set; }
        public string CPF { get; set; }
        public string Funcao { get; set; }
        public DateTime? DataContrato { get; set; }
        public decimal? Salario { get; set; }

        internal void PreencherTO(Colaborador entidade)
        {
            Identificador = entidade.Identificador;
            Nome = entidade.Nome;
            RG = entidade.RG;
            CPF = entidade.CPF;
            Funcao = entidade.Funcao;
            DataContrato = entidade.DataContrato;
            Salario = entidade.Salario;
        }

        internal void PreencherEntidade(Colaborador entidade)
        {
            entidade.Nome = Nome;
            entidade.RG = RG;
            entidade.CPF = CPF;
            entidade.Funcao = Funcao;
            entidade.DataContrato = DataContrato;
            entidade.Salario = Salario;
        }
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
