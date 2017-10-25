namespace PIM.Database.Cruds
{
    using PIM.Database.DatabaseModel;
    using PIM.Database.Infra;
    using PIM.Database.TO;
    using System.Collections.Generic;
    using System.Linq;
    using static PIM.Database.Infra.Utilitario;

    public class AdvertenciaCrud
    {
        private EntidadePIM _Contexto;

        public void Cadastrar(AdvertenciaTO to)
        {
            _Contexto = ControladorAcesso.ObterContexto();

            Advertencia entidade = new Advertencia();

            to.PreencherEntidade(entidade);

            _Contexto.Advertencia.Add(entidade);
            _Contexto.SaveChanges();

            to.PreencherTO(entidade);

            to.Valido = true;
            to.Mensagem = Utilitario.Mensagem.Cadastro("Advertencia");

            return;

        }

        public AdvertenciaTO Obter(int identificador)
        {
            _Contexto = ControladorAcesso.ObterContexto();

            AdvertenciaTO retorno = new AdvertenciaTO();

            Advertencia entidade = _Contexto.Advertencia.FirstOrDefault(x => x.Identificador == identificador);

            if (entidade == null)
            {
                retorno.Valido = false;
                retorno.Mensagem = Mensagem.Obter("Advertencia", false);

                return retorno;
            }

            retorno.PreencherTO(entidade);

            retorno.Valido = true;
            retorno.Mensagem = Mensagem.Obter("Advertencia", true);

            return retorno;
        }

        public void Atualizar(AdvertenciaTO to)
        {
            _Contexto = ControladorAcesso.ObterContexto();

            if (to.Identificador == 0 || to == null)
            {
                to.Valido = false;
                to.Mensagem = Mensagem.Atualizacao("Advertencia", false);

                return;
            }

            Advertencia entidade = _Contexto.Advertencia.FirstOrDefault(x => x.Identificador == to.Identificador);

            if (entidade == null)
            {
                to.Valido = false;
                to.Mensagem = Mensagem.Obter("Advertencia", false);

                return;
            }

            to.PreencherEntidade(entidade);

            _Contexto.SaveChanges();

            to.PreencherTO(entidade);
            to.Valido = true;
            to.Mensagem = Mensagem.Atualizacao("Advertencia", true);

            return;
        }

        public RetornoTO Remover(int identificador)
        {
            _Contexto = ControladorAcesso.ObterContexto();

            RetornoTO retorno = new RetornoTO();

            Advertencia entidade = _Contexto.Advertencia.FirstOrDefault(x => x.Identificador == identificador);

            if (entidade == null)
            {
                retorno.Valido = false;
                retorno.Mensagem = Mensagem.Obter("Advertencia", false);

                return retorno;
            }

            _Contexto.Advertencia.Remove(entidade);
            _Contexto.SaveChanges();

            retorno.Valido = true;
            retorno.Mensagem = Mensagem.Exclusao("Advertencia");

            return retorno;
        }

        public ListaAdvertenciaTO Listar()
        {
            _Contexto = ControladorAcesso.ObterContexto();

            ListaAdvertenciaTO retorno = new ListaAdvertenciaTO();

            List<Advertencia> listaAdvertencia = _Contexto.Advertencia.ToList();

            if (listaAdvertencia == null || listaAdvertencia.Count == 0)
            {
                retorno.Valido = false;
                retorno.Mensagem = Mensagem.Lista("Advertencia", false);

                return retorno;
            }

            AdvertenciaTO to;

            foreach (Advertencia entidade in listaAdvertencia)
            {
                to = new AdvertenciaTO();
                to.PreencherTO(entidade);

                retorno.Lista.Add(to);
            }

            retorno.Valido = true;
            retorno.Mensagem = Mensagem.Lista("Advertencia", true);

            return retorno;
        }
    }
}
