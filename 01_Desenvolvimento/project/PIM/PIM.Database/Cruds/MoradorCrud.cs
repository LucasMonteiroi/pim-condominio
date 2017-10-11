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

    public class MoradorCrud : ICrud<MoradorTO>
    {
        public void Cadastrar(EntidadePIM contexto, MoradorTO to)
        {
            Morador entidade = new Morador();

            to.PreencherEntidade(entidade);

            contexto.Morador.Add(entidade);
            contexto.SaveChanges();

            to.PreencherTO(entidade);

            to.Valido = true;
            to.Mensagem = Mensagem.Cadastro("Morador");

            return;

        }

        public MoradorTO Obter(EntidadePIM contexto, int identificador)
        {
            MoradorTO retorno = new MoradorTO();

            Morador entidade = contexto.Morador.FirstOrDefault(x => x.Identificador == identificador);

            if (entidade == null)
            {
                retorno.Valido = false;
                retorno.Mensagem = Mensagem.Obter("Morador", false);

                return retorno;
            }

            retorno.PreencherTO(entidade);

            retorno.Valido = true;
            retorno.Mensagem = Mensagem.Obter("Morador", true);

            return retorno;
        }

        public void Atualizar(EntidadePIM contexto, MoradorTO to)
        {
            if (to.Identificador == 0 || to == null)
            {
                to.Valido = false;
                to.Mensagem = Mensagem.Atualizacao("Morador", false);

                return;
            }

            Morador entidade = contexto.Morador.FirstOrDefault(x => x.Identificador == to.Identificador);

            if (entidade == null)
            {
                to.Valido = false;
                to.Mensagem = Mensagem.Obter("Morador", false);

                return;
            }

            to.PreencherEntidade(entidade);

            contexto.SaveChanges();

            to.PreencherTO(entidade);
            to.Valido = true;
            to.Mensagem = Mensagem.Atualizacao("Morador", true);

            return;
        }

        public RetornoTO Remover(EntidadePIM contexto, int identificador)
        {
            RetornoTO retorno = new RetornoTO();

            Morador entidade = contexto.Morador.FirstOrDefault(x => x.Identificador == identificador);

            if (entidade == null)
            {
                retorno.Valido = false;
                retorno.Mensagem = Mensagem.Obter("Morador", false);

                return retorno;
            }

            contexto.Morador.Remove(entidade);
            contexto.SaveChanges();

            retorno.Valido = true;
            retorno.Mensagem = Mensagem.Exclusao("Morador");

            return retorno;
        }

        public ListaMoradorTO Listar(EntidadePIM contexto)
        {
            ListaMoradorTO retorno = new ListaMoradorTO();

            List<Morador> listaMorador = contexto.Morador.ToList();

            if (listaMorador == null || listaMorador.Count == 0)
            {
                retorno.Valido = false;
                retorno.Mensagem = Mensagem.Lista("Morador", false);

                return retorno;
            }

            MoradorTO to;

            foreach (Morador entidade in listaMorador)
            {
                to = new MoradorTO();
                to.PreencherTO(entidade);

                retorno.Lista.Add(to);
            }

            retorno.Valido = true;
            retorno.Mensagem = Mensagem.Lista("Morador", true);

            return retorno;
        }
    }
}
