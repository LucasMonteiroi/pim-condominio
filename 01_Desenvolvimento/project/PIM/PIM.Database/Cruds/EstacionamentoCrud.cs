namespace PIM.Database.Cruds
{
    using PIM.Database.Infra;
    using PIM.Database.Interface;
    using PIM.Database.DatabaseModel;
    using PIM.Database.TO;
    using System.Collections.Generic;
    using System.Linq;
    using static PIM.Database.Infra.Utilitario;

    public class EstacionamentoCrud : ICrud<EstacionamentoTO>
    {
        private EntidadePIM _Contexto;

        public void Cadastrar(EstacionamentoTO to)
        {
            _Contexto = ControladorAcesso.ObterContexto();

            Estacionamento entidade = new Estacionamento();

            to.PreencherEntidade(entidade);

            _Contexto.Estacionamento.Add(entidade);
            _Contexto.SaveChanges();

            to.PreencherTO(entidade);

            to.Valido = true;
            to.Mensagem = Utilitario.Mensagem.Cadastro("Estacionamento");

            return;

        }

        public EstacionamentoTO Obter(int identificador)
        {
            _Contexto = ControladorAcesso.ObterContexto();

            EstacionamentoTO retorno = new EstacionamentoTO();

            Estacionamento entidade = _Contexto.Estacionamento.FirstOrDefault(x => x.Identificador == identificador);

            if (entidade == null)
            {
                retorno.Valido = false;
                retorno.Mensagem = Mensagem.Obter("Estacionamento", false);

                return retorno;
            }

            retorno.PreencherTO(entidade);

            retorno.Valido = true;
            retorno.Mensagem = Mensagem.Obter("Estacionamento", true);

            return retorno;
        }

        public void Atualizar(EstacionamentoTO to)
        {
            _Contexto = ControladorAcesso.ObterContexto();

            if (to.Identificador == 0 || to == null)
            {
                to.Valido = false;
                to.Mensagem = Mensagem.Atualizacao("Estacionamento", false);

                return;
            }

            Estacionamento entidade = _Contexto.Estacionamento.FirstOrDefault(x => x.Identificador == to.Identificador);

            if (entidade == null)
            {
                to.Valido = false;
                to.Mensagem = Mensagem.Obter("Estacionamento", false);

                return;
            }

            to.PreencherEntidade(entidade);

            _Contexto.SaveChanges();

            to.PreencherTO(entidade);
            to.Valido = true;
            to.Mensagem = Mensagem.Atualizacao("Estacionamento", true);

            return;
        }

        public RetornoTO Remover(int identificador)
        {
            _Contexto = ControladorAcesso.ObterContexto();

            RetornoTO retorno = new RetornoTO();

            Estacionamento entidade = _Contexto.Estacionamento.FirstOrDefault(x => x.Identificador == identificador);

            if (entidade == null)
            {
                retorno.Valido = false;
                retorno.Mensagem = Mensagem.Obter("Estacionamento", false);

                return retorno;
            }

            _Contexto.Estacionamento.Remove(entidade);
            _Contexto.SaveChanges();

            retorno.Valido = true;
            retorno.Mensagem = Mensagem.Exclusao("Estacionamento");

            return retorno;
        }

        public ListaEstacionamentoTO Listar()
        {
            _Contexto = ControladorAcesso.ObterContexto();

            ListaEstacionamentoTO retorno = new ListaEstacionamentoTO();

            List<Estacionamento> listaEstacionamento = _Contexto.Estacionamento.ToList();

            if (listaEstacionamento == null || listaEstacionamento.Count == 0)
            {
                retorno.Valido = false;
                retorno.Mensagem = Mensagem.Lista("Estacionamento", false);

                return retorno;
            }

            EstacionamentoTO to;

            foreach (Estacionamento entidade in listaEstacionamento)
            {
                to = new EstacionamentoTO();
                to.PreencherTO(entidade);

                retorno.Lista.Add(to);
            }

            retorno.Valido = true;
            retorno.Mensagem = Mensagem.Lista("Estacionamento", true);

            return retorno;
        }
    }
}
