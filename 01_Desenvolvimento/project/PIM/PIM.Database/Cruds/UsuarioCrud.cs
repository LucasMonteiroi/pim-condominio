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

    public class UsuarioCrud : ICrud<UsuarioTO>
    {
        private EntidadePIM _Contexto;

        public void Cadastrar(UsuarioTO to)
        {
            _Contexto = ControladorAcesso.ObterContexto();

            Usuario entidade = new Usuario();

            to.PreencherEntidade(entidade);

            _Contexto.Usuario.Add(entidade);
            _Contexto.SaveChanges();

            to.PreencherTO(entidade);

            to.Valido = true;
            to.Mensagem = Mensagem.Cadastro("Usuario");

            return;

        }

        public UsuarioTO Obter(int identificador)
        {
            _Contexto = ControladorAcesso.ObterContexto();

            UsuarioTO retorno = new UsuarioTO();

            Usuario entidade = _Contexto.Usuario.FirstOrDefault(x => x.Identificador == identificador);

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

        public void Atualizar(UsuarioTO to)
        {
            _Contexto = ControladorAcesso.ObterContexto();

            if (to.Identificador == 0 || to == null)
            {
                to.Valido = false;
                to.Mensagem = Mensagem.Atualizacao("Usuario", false);

                return;
            }

            Usuario entidade = _Contexto.Usuario.FirstOrDefault(x => x.Identificador == to.Identificador);

            if (entidade == null)
            {
                to.Valido = false;
                to.Mensagem = Mensagem.Obter("Usuario", false);

                return;
            }

            to.PreencherEntidade(entidade);

            _Contexto.SaveChanges();

            to.PreencherTO(entidade);
            to.Valido = true;
            to.Mensagem = Mensagem.Atualizacao("Usuario", true);

            return;
        }

        public RetornoTO Remover(int identificador)
        {
            _Contexto = ControladorAcesso.ObterContexto();

            RetornoTO retorno = new RetornoTO();

            Usuario entidade = _Contexto.Usuario.FirstOrDefault(x => x.Identificador == identificador);

            if (entidade == null)
            {
                retorno.Valido = false;
                retorno.Mensagem = Mensagem.Obter("Usuario", false);

                return retorno;
            }

            _Contexto.Usuario.Remove(entidade);
            _Contexto.SaveChanges();

            retorno.Valido = true;
            retorno.Mensagem = Mensagem.Exclusao("Usuario");

            return retorno;
        }

        public ListaUsuarioTO Listar()
        {
            _Contexto = ControladorAcesso.ObterContexto();

            ListaUsuarioTO retorno = new ListaUsuarioTO();

            List<Usuario> listaUsuario = _Contexto.Usuario.ToList();

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
