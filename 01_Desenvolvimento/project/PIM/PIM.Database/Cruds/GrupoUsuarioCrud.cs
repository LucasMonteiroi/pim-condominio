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

    public class GrupoUsuarioCrud : ICrud<GrupoUsuarioTO>
    {
        public void Cadastrar(EntidadePIM contexto, GrupoUsuarioTO to)
        {
            GrupoUsuario entidade = new GrupoUsuario();

            to.PreencherEntidade(entidade);

            contexto.GrupoUsuario.Add(entidade);
            contexto.SaveChanges();

            to.PreencherTO(entidade);

            to.Valido = true;
            to.Mensagem = Mensagem.Cadastro("GrupoUsuario");

            return;

        }

        public GrupoUsuarioTO Obter(EntidadePIM contexto, int identificador)
        {
            GrupoUsuarioTO retorno = new GrupoUsuarioTO();

            GrupoUsuario entidade = contexto.GrupoUsuario.FirstOrDefault(x => x.Identificador == identificador);

            if (entidade == null)
            {
                retorno.Valido = false;
                retorno.Mensagem = Mensagem.Obter("GrupoUsuario", false);

                return retorno;
            }

            retorno.PreencherTO(entidade);

            retorno.Valido = true;
            retorno.Mensagem = Mensagem.Obter("GrupoUsuario", true);

            return retorno;
        }

        public void Atualizar(EntidadePIM contexto, GrupoUsuarioTO to)
        {
            if (to.Identificador == 0 || to == null)
            {
                to.Valido = false;
                to.Mensagem = Mensagem.Atualizacao("GrupoUsuario", false);

                return;
            }

            GrupoUsuario entidade = contexto.GrupoUsuario.FirstOrDefault(x => x.Identificador == to.Identificador);

            if (entidade == null)
            {
                to.Valido = false;
                to.Mensagem = Mensagem.Obter("GrupoUsuario", false);

                return;
            }

            to.PreencherEntidade(entidade);

            contexto.SaveChanges();

            to.PreencherTO(entidade);
            to.Valido = true;
            to.Mensagem = Mensagem.Atualizacao("GrupoUsuario", true);

            return;
        }

        public RetornoTO Remover(EntidadePIM contexto, int identificador)
        {
            RetornoTO retorno = new RetornoTO();

            GrupoUsuario entidade = contexto.GrupoUsuario.FirstOrDefault(x => x.Identificador == identificador);

            if (entidade == null)
            {
                retorno.Valido = false;
                retorno.Mensagem = Mensagem.Obter("GrupoUsuario", false);

                return retorno;
            }

            contexto.GrupoUsuario.Remove(entidade);
            contexto.SaveChanges();

            retorno.Valido = true;
            retorno.Mensagem = Mensagem.Exclusao("GrupoUsuario");

            return retorno;
        }

        public ListaGrupoUsuarioTO Listar(EntidadePIM contexto)
        {
            ListaGrupoUsuarioTO retorno = new ListaGrupoUsuarioTO();

            List<GrupoUsuario> listaGrupoUsuario = contexto.GrupoUsuario.ToList();

            if (listaGrupoUsuario == null || listaGrupoUsuario.Count == 0)
            {
                retorno.Valido = false;
                retorno.Mensagem = Mensagem.Lista("GrupoUsuario", false);

                return retorno;
            }

            GrupoUsuarioTO to;

            foreach (GrupoUsuario entidade in listaGrupoUsuario)
            {
                to = new GrupoUsuarioTO();
                to.PreencherTO(entidade);

                retorno.Lista.Add(to);
            }

            retorno.Valido = true;
            retorno.Mensagem = Mensagem.Lista("GrupoUsuario", true);

            return retorno;
        }
    }
}
