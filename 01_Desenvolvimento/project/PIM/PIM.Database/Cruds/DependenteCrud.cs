namespace PIM.Database.Cruds
{
    using PIM.Database.Infra;
    using PIM.Database.DatabaseModel;
    using PIM.Database.TO;
    using System.Collections.Generic;
    using System.Linq;
    using static PIM.Database.Infra.Utilitario;

    public class DependenteCrud
    {
        private EntidadePIM _Contexto;

        public void Cadastrar(DependenteTO to)
        {
            _Contexto = ControladorAcesso.ObterContexto();

            Dependente entidade = new Dependente();

            to.PreencherEntidade(entidade);

            _Contexto.Dependente.Add(entidade);
            _Contexto.SaveChanges();

            to.PreencherTO(entidade);

            to.Valido = true;
            to.Mensagem = Utilitario.Mensagem.Cadastro("Dependente");

            return;

        }

        public DependenteTO Obter(int identificador)
        {
            _Contexto = ControladorAcesso.ObterContexto();

            DependenteTO retorno = new DependenteTO();

            Dependente entidade = _Contexto.Dependente.FirstOrDefault(x => x.Identificador == identificador);

            if (entidade == null)
            {
                retorno.Valido = false;
                retorno.Mensagem = Mensagem.Obter("Dependente", false);

                return retorno;
            }

            retorno.PreencherTO(entidade);

            retorno.Valido = true;
            retorno.Mensagem = Mensagem.Obter("Dependente", true);

            return retorno;
        }

        public void Atualizar(DependenteTO to)
        {
            _Contexto = ControladorAcesso.ObterContexto();

            if (to.Identificador == 0 || to == null)
            {
                to.Valido = false;
                to.Mensagem = Mensagem.Atualizacao("Dependente", false);

                return;
            }

            Dependente entidade = _Contexto.Dependente.FirstOrDefault(x => x.Identificador == to.Identificador);

            if (entidade == null)
            {
                to.Valido = false;
                to.Mensagem = Mensagem.Obter("Dependente", false);

                return;
            }

            to.PreencherEntidade(entidade);

            _Contexto.SaveChanges();

            to.PreencherTO(entidade);
            to.Valido = true;
            to.Mensagem = Mensagem.Atualizacao("Dependente", true);

            return;
        }

        public RetornoTO Remover(int identificador)
        {
            _Contexto = ControladorAcesso.ObterContexto();

            RetornoTO retorno = new RetornoTO();

            Dependente entidade = _Contexto.Dependente.FirstOrDefault(x => x.Identificador == identificador);

            if (entidade == null)
            {
                retorno.Valido = false;
                retorno.Mensagem = Mensagem.Obter("Dependente", false);

                return retorno;
            }

            _Contexto.Dependente.Remove(entidade);
            _Contexto.SaveChanges();

            retorno.Valido = true;
            retorno.Mensagem = Mensagem.Exclusao("Dependente");

            return retorno;
        }

        public ListaDependenteTO Listar()
        {
            _Contexto = ControladorAcesso.ObterContexto();

            ListaDependenteTO retorno = new ListaDependenteTO();

            List<Dependente> listaDependente = _Contexto.Dependente.ToList();

            if (listaDependente == null || listaDependente.Count == 0)
            {
                retorno.Valido = false;
                retorno.Mensagem = Mensagem.Lista("Dependente", false);

                return retorno;
            }

            DependenteTO to;

            foreach (Dependente entidade in listaDependente)
            {
                to = new DependenteTO();
                to.PreencherTO(entidade);

                retorno.Lista.Add(to);
            }

            retorno.Valido = true;
            retorno.Mensagem = Mensagem.Lista("Dependente", true);

            return retorno;
        }
    }
}
