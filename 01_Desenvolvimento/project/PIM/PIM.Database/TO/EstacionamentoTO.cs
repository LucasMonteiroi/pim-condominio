namespace PIM.Database.TO
{
    using PIM.Database.Infra;
    using PIM.Database.DatabaseModel;
    using System.Collections.Generic;

    public class EstacionamentoTO : RetornoTO
    {
        public int Identificador { get; set; }
        public int IdApartamento { get; set; }
        public int VagasDisponiveis { get; set; }

        internal void PreencherTO(Estacionamento entidade)
        {
            Identificador = entidade.Identificador;
            IdApartamento = entidade.IdApartamento;
            VagasDisponiveis = entidade.VagasDisponiveis;
        }

        internal void PreencherEntidade(Estacionamento entidade)
        {
            entidade.IdApartamento = IdApartamento;
            entidade.VagasDisponiveis = VagasDisponiveis;
        }
    }

    public class ListaEstacionamentoTO : RetornoTO
    {
        public List<EstacionamentoTO> Lista { get; set; }

        public ListaEstacionamentoTO()
        {
            Lista = new List<EstacionamentoTO>();
        }
    }
}
