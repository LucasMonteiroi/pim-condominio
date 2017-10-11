namespace PIM.Database.Cruds
{
    using PIM.Database.Interface;
    using PIM.Database.TO;
    using System;
    using PIM.Database.Infra;
    using PIM.Database.Modelo;
    using System.Linq;
    using static PIM.Database.Infra.Utilitario;
    using System.Collections.Generic;

    public class ReservaCrud : ICrud<ReservaTO>
    {
        public void Cadastrar(EntidadePIM contexto, ReservaTO to)
        {
            Reserva entidade = new Reserva();

            to.PreencherEntidade(entidade);

            contexto.Reserva.Add(entidade);
            contexto.SaveChanges();

            to.PreencherTO(entidade);

            to.Valido = true;
            to.Mensagem = Mensagem.Cadastro("Reserva");

            return;

        }

        public ReservaTO Obter(EntidadePIM contexto, int identificador)
        {
            ReservaTO retorno = new ReservaTO();

            Reserva entidade = contexto.Reserva.FirstOrDefault(x => x.Identificador == identificador);

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

        public void Atualizar(EntidadePIM contexto, ReservaTO to)
        {
            if (to.Identificador == 0 || to == null)
            {
                to.Valido = false;
                to.Mensagem = Mensagem.Atualizacao("Reserva", false);

                return;
            }

            Reserva entidade = contexto.Reserva.FirstOrDefault(x => x.Identificador == to.Identificador);

            if (entidade == null)
            {
                to.Valido = false;
                to.Mensagem = Mensagem.Obter("Reserva", false);

                return;
            }

            to.PreencherEntidade(entidade);

            contexto.SaveChanges();

            to.PreencherTO(entidade);
            to.Valido = true;
            to.Mensagem = Mensagem.Atualizacao("Reserva", true);

            return;
        }

        public RetornoTO Remover(EntidadePIM contexto, int identificador)
        {
            RetornoTO retorno = new RetornoTO();

            Reserva entidade = contexto.Reserva.FirstOrDefault(x => x.Identificador == identificador);

            if (entidade == null)
            {
                retorno.Valido = false;
                retorno.Mensagem = Mensagem.Obter("Reserva", false);

                return retorno;
            }

            contexto.Reserva.Remove(entidade);
            contexto.SaveChanges();

            retorno.Valido = true;
            retorno.Mensagem = Mensagem.Exclusao("Reserva");

            return retorno;
        }

        public ListaReservaTO Listar(EntidadePIM contexto)
        {
            ListaReservaTO retorno = new ListaReservaTO();

            List<Reserva> listaReserva = contexto.Reserva.ToList();

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
