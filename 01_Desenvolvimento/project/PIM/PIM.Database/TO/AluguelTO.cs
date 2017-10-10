namespace PIM.Database.TO
{
    using PIM.Database.Infra;
    using PIM.Database.Modelo;
    using System.Collections.Generic;

    public class AluguelTO : RetornoTO
    {
        public int Identificador { get; set; }
        public decimal Valor { get; set; }

        internal void PreencherTO(Aluguel entidade)
        {
            Identificador = entidade.Identificador;
            Valor = entidade.Valor;
        }

        internal void PreencherEntidade(Aluguel entidade)
        {
            entidade.Valor = Valor;
        }
    }

    public class ListaAluguelTO
    {
        public List<AluguelTO> Lista { get; set; }

        public ListaAluguelTO()
        {
            Lista = new List<AluguelTO>();
        }
    }
}
