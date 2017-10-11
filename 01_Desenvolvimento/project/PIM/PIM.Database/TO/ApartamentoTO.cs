namespace PIM.Database.TO
{
    using PIM.Database.Infra;
    using PIM.Database.Modelo;
    using System.Collections.Generic;

    public class ApartamentoTO : RetornoTO
    {
        public int Identificador { get; set; }
        public int Bloco { get; set; }
        public string Numero { get; set; }
        public int IdContrato { get; set; }

        internal void PreencherTO(Apartamento entidade)
        {
            Identificador = entidade.Identificador;
            Bloco = entidade.Bloco;
            Numero = entidade.Numero;
            IdContrato = entidade.IdContrato;
        }

        internal void PreencherEntidade(Apartamento entidade)
        {
            entidade.Bloco = Bloco;
            entidade.Numero = Numero;
            entidade.IdContrato = IdContrato;
        }
    }

    public class ListaApartamentoTO : RetornoTO
    {
        public List<ApartamentoTO> Lista { get; set; }

        public ListaApartamentoTO()
        {
            Lista = new List<ApartamentoTO>();
        }
    }
}
