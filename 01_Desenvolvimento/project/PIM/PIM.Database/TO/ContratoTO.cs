namespace PIM.Database.TO
{
    using PIM.Database.Infra;
    using PIM.Database.DatabaseModel;
    using System;
    using System.Collections.Generic;

    public class ContratoTO : RetornoTO
    {
        public int Identificador { get; set; }
        public string Descricao { get; set; }
        public DateTime DataContrato { get; set; }
        public int IdMorador { get; set; }
        public decimal Valor { get; set; }
        public int Parcelas { get; set; }
        public string TipoContrato { get; set; }

        internal void PreencherTO(Contrato entidade)
        {
            Identificador = entidade.Identificador;
            Descricao = entidade.Descricao;
            DataContrato = entidade.DataContrato;
            IdMorador = entidade.IdMorador;
            Valor = entidade.Valor;
            Parcelas = entidade.Parcelas;
            TipoContrato = entidade.TipoContrato;
        }

        internal void PreencherEntidade(Contrato entidade)
        {
            entidade.Descricao = Descricao;
            entidade.DataContrato = DataContrato;
            entidade.IdMorador = IdMorador;
            entidade.Valor = Valor;
            entidade.Parcelas = Parcelas;
            entidade.TipoContrato = TipoContrato;
        }
    }

    public class ListaContratoTO : RetornoTO
    {
        public List<ContratoTO> Lista { get; set; }

        public ListaContratoTO()
        {
            Lista = new List<ContratoTO>();
        }
    }
}
