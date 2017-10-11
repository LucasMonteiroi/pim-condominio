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

    public class TipoReservaCrud : ICrud<TipoReservaTO>
    {
        public void Cadastrar(EntidadePIM contexto, TipoReservaTO to)
        {
            TipoReserva entidade = new TipoReserva();

            to.PreencherEntidade(entidade);

            contexto.TipoReserva.Add(entidade);
            contexto.SaveChanges();

            to.PreencherTO(entidade);

            to.Valido = true;
            to.Mensagem = Mensagem.Cadastro("TipoReserva");

            return;

        }

        public TipoReservaTO Obter(EntidadePIM contexto, int identificador)
        {
            TipoReservaTO retorno = new TipoReservaTO();

            TipoReserva entidade = contexto.TipoReserva.FirstOrDefault(x => x.Identificador == identificador);

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

        public void Atualizar(EntidadePIM contexto, TipoReservaTO to)
        {
            if (to.Identificador == 0 || to == null)
            {
                to.Valido = false;
                to.Mensagem = Mensagem.Atualizacao("TipoReserva", false);

                return;
            }

            TipoReserva entidade = contexto.TipoReserva.FirstOrDefault(x => x.Identificador == to.Identificador);

            if (entidade == null)
            {
                to.Valido = false;
                to.Mensagem = Mensagem.Obter("TipoReserva", false);

                return;
            }

            to.PreencherEntidade(entidade);

            contexto.SaveChanges();

            to.PreencherTO(entidade);
            to.Valido = true;
            to.Mensagem = Mensagem.Atualizacao("TipoReserva", true);

            return;
        }

        public RetornoTO Remover(EntidadePIM contexto, int identificador)
        {
            RetornoTO retorno = new RetornoTO();

            TipoReserva entidade = contexto.TipoReserva.FirstOrDefault(x => x.Identificador == identificador);

            if (entidade == null)
            {
                retorno.Valido = false;
                retorno.Mensagem = Mensagem.Obter("TipoReserva", false);

                return retorno;
            }

            contexto.TipoReserva.Remove(entidade);
            contexto.SaveChanges();

            retorno.Valido = true;
            retorno.Mensagem = Mensagem.Exclusao("TipoReserva");

            return retorno;
        }

        public ListaTipoReservaTO Listar(EntidadePIM contexto)
        {
            ListaTipoReservaTO retorno = new ListaTipoReservaTO();

            List<TipoReserva> listaTipoReserva = contexto.TipoReserva.ToList();

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
