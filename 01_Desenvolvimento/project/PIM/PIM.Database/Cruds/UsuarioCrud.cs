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

    public class UsuarioCrud : ICrud<UsuarioTO>
    {
        public void Cadastrar(EntidadePIM contexto, UsuarioTO to)
        {
            Usuario entidade = new Usuario();

            to.PreencherEntidade(entidade);

            contexto.Usuario.Add(entidade);
            contexto.SaveChanges();

            to.PreencherTO(entidade);

            to.Valido = true;
            to.Mensagem = Mensagem.Cadastro("Usuario");

            return;

        }

        public UsuarioTO Obter(EntidadePIM contexto, int identificador)
        {
            UsuarioTO retorno = new UsuarioTO();

            Usuario entidade = contexto.Usuario.FirstOrDefault(x => x.Identificador == identificador);

            if (entidade == null)
            {
                retorno.Valido = false;
                retorno.Mensagem = Mensagem.Obter("Usuario", false);

                return retorno;
            }

            retorno.PreencherTO(entidade);

            retorno.Valido = true;
            retorno.Mensagem = Mensagem.Obter("Usuario", true);

            return retorno;
        }

        public void Atualizar(EntidadePIM contexto, UsuarioTO to)
        {
            if (to.Identificador == 0 || to == null)
            {
                to.Valido = false;
                to.Mensagem = Mensagem.Atualizacao("Usuario", false);

                return;
            }

            Usuario entidade = contexto.Usuario.FirstOrDefault(x => x.Identificador == to.Identificador);

            if (entidade == null)
            {
                to.Valido = false;
                to.Mensagem = Mensagem.Obter("Usuario", false);

                return;
            }

            to.PreencherEntidade(entidade);

            contexto.SaveChanges();

            to.PreencherTO(entidade);
            to.Valido = true;
            to.Mensagem = Mensagem.Atualizacao("Usuario", true);

            return;
        }

        public RetornoTO Remover(EntidadePIM contexto, int identificador)
        {
            RetornoTO retorno = new RetornoTO();

            Usuario entidade = contexto.Usuario.FirstOrDefault(x => x.Identificador == identificador);

            if (entidade == null)
            {
                retorno.Valido = false;
                retorno.Mensagem = Mensagem.Obter("Usuario", false);

                return retorno;
            }

            contexto.Usuario.Remove(entidade);
            contexto.SaveChanges();

            retorno.Valido = true;
            retorno.Mensagem = Mensagem.Exclusao("Usuario");

            return retorno;
        }

        public ListaUsuarioTO Listar(EntidadePIM contexto)
        {
            ListaUsuarioTO retorno = new ListaUsuarioTO();

            List<Usuario> listaUsuario = contexto.Usuario.ToList();

            if (listaUsuario == null || listaUsuario.Count == 0)
            {
                retorno.Valido = false;
                retorno.Mensagem = Mensagem.Lista("Usuario", false);

                return retorno;
            }

            UsuarioTO to;

            foreach (Usuario entidade in listaUsuario)
            {
                to = new UsuarioTO();
                to.PreencherTO(entidade);

                retorno.Lista.Add(to);
            }

            retorno.Valido = true;
            retorno.Mensagem = Mensagem.Lista("Usuario", true);

            return retorno;
        }
    }
}
