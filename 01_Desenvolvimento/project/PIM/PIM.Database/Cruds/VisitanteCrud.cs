namespace PIM.Database.Cruds
{
    using PIM.Database.DatabaseModel;
    using PIM.Database.Infra;
    using PIM.Database.TO;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using static PIM.Database.Infra.Utilitario;

    public class VisitanteCrud
    {
        private EntidadePIM _Contexto;

        public void Cadastrar(VisitanteTO to)
        {
            _Contexto = ControladorAcesso.ObterContexto();

            Visitante entidade = new Visitante();

            to.PreencherEntidade(entidade);

            _Contexto.Visitante.Add(entidade);
            _Contexto.SaveChanges();

            to.PreencherTO(entidade);

            to.Valido = true;
            to.Mensagem = Utilitario.Mensagem.Cadastro("Visitante");

            return;

        }

        public VisitanteTO Obter(int identificador)
        {
            _Contexto = ControladorAcesso.ObterContexto();

            VisitanteTO retorno = new VisitanteTO();

            Visitante entidade = _Contexto.Visitante.FirstOrDefault(x => x.Identificador == identificador);

            if (entidade == null)
            {
                retorno.Valido = false;
                retorno.Mensagem = Mensagem.Obter("Visitante", false);

                return retorno;
            }

            retorno.PreencherTO(entidade);

            retorno.Valido = true;
            retorno.Mensagem = Mensagem.Obter("Visitante", true);

            return retorno;
        }

        public void Atualizar(VisitanteTO to)
        {
            _Contexto = ControladorAcesso.ObterContexto();

            if (to.Identificador == 0 || to == null)
            {
                to.Valido = false;
                to.Mensagem = Mensagem.Atualizacao("Visitante", false);

                return;
            }

            Visitante entidade = _Contexto.Visitante.FirstOrDefault(x => x.Identificador == to.Identificador);

            if (entidade == null)
            {
                to.Valido = false;
                to.Mensagem = Mensagem.Obter("Visitante", false);

                return;
            }

            to.PreencherEntidade(entidade);

            _Contexto.SaveChanges();

            to.PreencherTO(entidade);
            to.Valido = true;
            to.Mensagem = Mensagem.Atualizacao("Visitante", true);

            return;
        }

        public RetornoTO Remover(int identificador)
        {
            _Contexto = ControladorAcesso.ObterContexto();

            RetornoTO retorno = new RetornoTO();

            Visitante entidade = _Contexto.Visitante.FirstOrDefault(x => x.Identificador == identificador);

            if (entidade == null)
            {
                retorno.Valido = false;
                retorno.Mensagem = Mensagem.Obter("Visitante", false);

                return retorno;
            }

            _Contexto.Visitante.Remove(entidade);
            _Contexto.SaveChanges();

            retorno.Valido = true;
            retorno.Mensagem = Mensagem.Exclusao("Visitante");

            return retorno;
        }

        public ListaVisitanteTO Listar()
        {
            _Contexto = ControladorAcesso.ObterContexto();

            ListaVisitanteTO retorno = new ListaVisitanteTO();

            List<Visitante> listaVisitante = _Contexto.Visitante.ToList();

            if (listaVisitante == null || listaVisitante.Count == 0)
            {
                retorno.Valido = false;
                retorno.Mensagem = Mensagem.Lista("Visitante", false);

                return retorno;
            }

            VisitanteTO to;

            foreach (Visitante entidade in listaVisitante)
            {
                to = new VisitanteTO();
                to.PreencherTO(entidade);

                retorno.Lista.Add(to);
            }

            retorno.Valido = true;
            retorno.Mensagem = Mensagem.Lista("Visitante", true);

            return retorno;
        }
    }
}
