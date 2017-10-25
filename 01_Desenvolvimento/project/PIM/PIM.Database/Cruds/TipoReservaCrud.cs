namespace PIM.Database.Cruds
{
    using PIM.Database.TO;
    using PIM.Database.Infra;
    using PIM.Database.DatabaseModel;
    using System.Linq;
    using static PIM.Database.Infra.Utilitario;
    using System.Collections.Generic;

    public class TipoReservaCrud
    {
        private EntidadePIM _Contexto;

        public void Cadastrar(TipoReservaTO to)
        {
            _Contexto = ControladorAcesso.ObterContexto();

            TipoReserva entidade = new TipoReserva();

            to.PreencherEntidade(entidade);

            _Contexto.TipoReserva.Add(entidade);
            _Contexto.SaveChanges();

            to.PreencherTO(entidade);

            to.Valido = true;
            to.Mensagem = Mensagem.Cadastro("TipoReserva");

            return;

        }

        public TipoReservaTO Obter(int identificador)
        {
            _Contexto = ControladorAcesso.ObterContexto();

            TipoReservaTO retorno = new TipoReservaTO();

            TipoReserva entidade = _Contexto.TipoReserva.FirstOrDefault(x => x.Identificador == identificador);

            if (entidade == null)
            {
                retorno.Valido = false;
                retorno.Mensagem = Mensagem.Obter("TipoReserva", false);

                return retorno;
            }

            retorno.PreencherTO(entidade);

            retorno.Valido = true;
            retorno.Mensagem = Mensagem.Obter("TipoReserva", true);

            return retorno;
        }

        public void Atualizar(TipoReservaTO to)
        {
            _Contexto = ControladorAcesso.ObterContexto();

            if (to.Identificador == 0 || to == null)
            {
                to.Valido = false;
                to.Mensagem = Mensagem.Atualizacao("TipoReserva", false);

                return;
            }

            TipoReserva entidade = _Contexto.TipoReserva.FirstOrDefault(x => x.Identificador == to.Identificador);

            if (entidade == null)
            {
                to.Valido = false;
                to.Mensagem = Mensagem.Obter("TipoReserva", false);

                return;
            }

            to.PreencherEntidade(entidade);

            _Contexto.SaveChanges();

            to.PreencherTO(entidade);
            to.Valido = true;
            to.Mensagem = Mensagem.Atualizacao("TipoReserva", true);

            return;
        }

        public RetornoTO Remover(int identificador)
        {
            _Contexto = ControladorAcesso.ObterContexto();

            RetornoTO retorno = new RetornoTO();

            TipoReserva entidade = _Contexto.TipoReserva.FirstOrDefault(x => x.Identificador == identificador);

            if (entidade == null)
            {
                retorno.Valido = false;
                retorno.Mensagem = Mensagem.Obter("TipoReserva", false);

                return retorno;
            }

            _Contexto.TipoReserva.Remove(entidade);
            _Contexto.SaveChanges();

            retorno.Valido = true;
            retorno.Mensagem = Mensagem.Exclusao("TipoReserva");

            return retorno;
        }

        public ListaTipoReservaTO Listar()
        {
            _Contexto = ControladorAcesso.ObterContexto();

            ListaTipoReservaTO retorno = new ListaTipoReservaTO();

            List<TipoReserva> listaTipoReserva = _Contexto.TipoReserva.ToList();

            if (listaTipoReserva == null || listaTipoReserva.Count == 0)
            {
                retorno.Valido = false;
                retorno.Mensagem = Mensagem.Lista("TipoReserva", false);

                return retorno;
            }

            TipoReservaTO to;

            foreach (TipoReserva entidade in listaTipoReserva)
            {
                to = new TipoReservaTO();
                to.PreencherTO(entidade);

                retorno.Lista.Add(to);
            }

            retorno.Valido = true;
            retorno.Mensagem = Mensagem.Lista("TipoReserva", true);

            return retorno;
        }
    }
}
