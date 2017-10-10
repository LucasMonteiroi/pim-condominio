namespace PIM.Database.TO
{
    using PIM.Database.Infra;
    using PIM.Database.Modelo;
    using System;
    using System.Collections.Generic;

    public class OcorrenciaTO : RetornoTO
    {
        public int Identificador { get; set; }
        public int IdMorador { get; set; }
        public DateTime DataOcorrencia { get; set; }
        public string Motivo { get; set; }
        public string Descricao { get; set; }
        
        internal void PreencherTO(Ocorrencia entidade)
        {
            Identificador = entidade.Identificador;
            IdMorador = entidade.IdMorador;
            DataOcorrencia = entidade.DataOcorrencia;
            Motivo = entidade.Motivo;
            Descricao = entidade.Descricao;
        }

        internal void PreencherEntidade(Ocorrencia entidade)
        {
            entidade.IdMorador = IdMorador;
            entidade.DataOcorrencia = DataOcorrencia;
            entidade.Motivo = Motivo;
            entidade.Descricao = Descricao;
        }
    }

    public class ListaOcorrenciaTO
    {
        public List<OcorrenciaTO> Lista { get; set; }

        public ListaOcorrenciaTO()
        {
            Lista = new List<OcorrenciaTO>();
        }
    }
}
