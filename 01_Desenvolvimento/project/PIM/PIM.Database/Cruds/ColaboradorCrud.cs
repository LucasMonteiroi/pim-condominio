namespace PIM.Database.Cruds
{
    using PIM.Database.Infra;
    using PIM.Database.DatabaseModel;
    using PIM.Database.TO;
    using System.Collections.Generic;
    using System.Linq;
    using static PIM.Database.Infra.Utilitario;

    public class ColaboradorCrud 
    {
        private EntidadePIM _Contexto;

        public void Cadastrar(ColaboradorTO to)
        {
            _Contexto = ControladorAcesso.ObterContexto();

            Colaborador entidade = new Colaborador();

            to.PreencherEntidade(entidade);

            _Contexto.Colaborador.Add(entidade);
            _Contexto.SaveChanges();

            to.PreencherTO(entidade);

            to.Valido = true;
            to.Mensagem = Utilitario.Mensagem.Cadastro("Colaborador");

            return;

        }

        public ColaboradorTO Obter(int identificador)
        {
            _Contexto = ControladorAcesso.ObterContexto();

            ColaboradorTO retorno = new ColaboradorTO();

            Colaborador entidade = _Contexto.Colaborador.FirstOrDefault(x => x.Identificador == identificador);

            if (entidade == null)
            {
                retorno.Valido = false;
                retorno.Mensagem = Mensagem.Obter("Colaborador", false);

                return retorno;
            }

            retorno.PreencherTO(entidade);

            retorno.Valido = true;
            retorno.Mensagem = Mensagem.Obter("Colaborador", true);

            return retorno;
        }

        public void Atualizar(ColaboradorTO to)
        {
            _Contexto = ControladorAcesso.ObterContexto();

            if (to.Identificador == 0 || to == null)
            {
                to.Valido = false;
                to.Mensagem = Mensagem.Atualizacao("Colaborador", false);

                return;
            }

            Colaborador entidade = _Contexto.Colaborador.FirstOrDefault(x => x.Identificador == to.Identificador);

            if (entidade == null)
            {
                to.Valido = false;
                to.Mensagem = Mensagem.Obter("Colaborador", false);

                return;
            }

            to.PreencherEntidade(entidade);

            _Contexto.SaveChanges();

            to.PreencherTO(entidade);
            to.Valido = true;
            to.Mensagem = Mensagem.Atualizacao("Colaborador", true);

            return;
        }

        public RetornoTO Remover(int identificador)
        {
            _Contexto = ControladorAcesso.ObterContexto();

            RetornoTO retorno = new RetornoTO();

            Colaborador entidade = _Contexto.Colaborador.FirstOrDefault(x => x.Identificador == identificador);

            if (entidade == null)
            {
                retorno.Valido = false;
                retorno.Mensagem = Mensagem.Obter("Colaborador", false);

                return retorno;
            }

            _Contexto.Colaborador.Remove(entidade);
            _Contexto.SaveChanges();

            retorno.Valido = true;
            retorno.Mensagem = Mensagem.Exclusao("Colaborador");

            return retorno;
        }

        public ListaColaboradorTO Listar()
        {
            _Contexto = ControladorAcesso.ObterContexto();

            ListaColaboradorTO retorno = new ListaColaboradorTO();

            List<Colaborador> listaColaborador = _Contexto.Colaborador.ToList();

            if (listaColaborador == null || listaColaborador.Count == 0)
            {
                retorno.Valido = false;
                retorno.Mensagem = Mensagem.Lista("Colaborador", false);

                return retorno;
            }

            ColaboradorTO to;

            foreach (Colaborador entidade in listaColaborador)
            {
                to = new ColaboradorTO();
                to.PreencherTO(entidade);

                retorno.Lista.Add(to);
            }

            retorno.Valido = true;
            retorno.Mensagem = Mensagem.Lista("Colaborador", true);

            return retorno;
        }
    }
}
