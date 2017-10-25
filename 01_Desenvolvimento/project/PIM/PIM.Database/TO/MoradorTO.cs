namespace PIM.Database.TO
{
    using PIM.Database.Infra;
    using PIM.Database.DatabaseModel;
    using System.Collections.Generic;
    using System;

    public class MoradorTO : RetornoTO
    {
        public int Identificador { get; set; }
        public string Nome { get; set; }
        public string RG { get; set; }
        public string CPF { get; set; }
        public string Telefone { get; set; }
        public string Celular { get; set; }
        public DateTime? DataNascimento { get; set; }
        public string Email { get; set; }

        internal void PreencherTO(Morador entidade)
        {
            Identificador = entidade.Identificador;
            Nome = entidade.Nome;
            RG = entidade.RG;
            CPF = entidade.CPF;
            Telefone = entidade.Telefone;
            Celular = entidade.Celular;
            DataNascimento = entidade.DataNascimento;
            Email = entidade.Email;
        }

        internal void PreencherEntidade(Morador entidade)
        {
            entidade.Nome = Nome;
            entidade.RG = RG;
            entidade.CPF = CPF;
            entidade.Telefone = Telefone;
            entidade.Celular = Celular;
            entidade.Email = Email;
            entidade.DataNascimento = DataNascimento;
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
