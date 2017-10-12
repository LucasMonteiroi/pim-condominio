namespace PIM.Database.Cruds
{
    using PIM.Database.Interface;
    using PIM.Database.TO;
    using System;
    using PIM.Database.Infra;
    using PIM.Database.DatabaseModel;
    using System.Linq;
    using static PIM.Database.Infra.Utilitario;
    using System.Collections.Generic;

    public class ReservaCrud : ICrud<ReservaTO>
    {
        private EntidadePIM _Contexto;

        public void Cadastrar(ReservaTO to)
        {
            _Contexto = ControladorAcesso.ObterContexto();

            Reserva entidade = new Reserva();

            to.PreencherEntidade(entidade);

            _Contexto.Reserva.Add(entidade);
            _Contexto.SaveChanges();

            to.PreencherTO(entidade);

            to.Valido = true;
            to.Mensagem = Mensagem.Cadastro("Reserva");

            return;

        }

        public ReservaTO Obter(int identificador)
        {
            _Contexto = ControladorAcesso.ObterContexto();

            ReservaTO retorno = new ReservaTO();

            Reserva entidade = _Contexto.Reserva.FirstOrDefault(x => x.Identificador == identificador);

            if (entidade == null)
            {
                retorno.Valido = false;
                retorno.Mensagem = Mensagem.Obter("Reserva", false);

                return retorno;
            }

            retorno.PreencherTO(entidade);

            retorno.Valido = true;
            retorno.Mensagem = Mensagem.Obter("Reserva", true);

            return retorno;
        }

        public void Atualizar(ReservaTO to)
        {
            _Contexto = ControladorAcesso.ObterContexto();

            if (to.Identificador == 0 || to == null)
            {
                to.Valido = false;
                to.Mensagem = Mensagem.Atualizacao("Reserva", false);

                return;
            }

            Reserva entidade = _Contexto.Reserva.FirstOrDefault(x => x.Identificador == to.Identificador);

            if (entidade == null)
            {
                to.Valido = false;
                to.Mensagem = Mensagem.Obter("Reserva", false);

                return;
            }

            to.PreencherEntidade(entidade);

            _Contexto.SaveChanges();

            to.PreencherTO(entidade);
            to.Valido = true;
            to.Mensagem = Mensagem.Atualizacao("Reserva", true);

            return;
        }

        public RetornoTO Remover(int identificador)
        {
            _Contexto = ControladorAcesso.ObterContexto();

            RetornoTO retorno = new RetornoTO();

            Reserva entidade = _Contexto.Reserva.FirstOrDefault(x => x.Identificador == identificador);

            if (entidade == null)
            {
                retorno.Valido = false;
                retorno.Mensagem = Mensagem.Obter("Reserva", false);

                return retorno;
            }

            _Contexto.Reserva.Remove(entidade);
            _Contexto.SaveChanges();

            retorno.Valido = true;
            retorno.Mensagem = Mensagem.Exclusao("Reserva");

            return retorno;
        }

        public ListaReservaTO Listar()
        {
            _Contexto = ControladorAcesso.ObterContexto();

            ListaReservaTO retorno = new ListaReservaTO();

            List<Reserva> listaReserva = _Contexto.Reserva.ToList();

            if (listaReserva == null || listaReserva.Count == 0)
            {
                retorno.Valido = false;
                retorno.Mensagem = Mensagem.Lista("Reserva", false);

                return retorno;
            }

            ReservaTO to;

            foreach (Reserva entidade in listaReserva)
            {
                to = new ReservaTO();
                to.PreencherTO(entidade);

                retorno.Lista.Add(to);
            }

            retorno.Valido = true;
            retorno.Mensagem = Mensagem.Lista("Reserva", true);

            return retorno;
        }
    }
}
