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

    public class GrupoUsuarioCrud : ICrud<GrupoUsuarioTO>
    {
        private EntidadePIM _Contexto;

        public void Cadastrar(GrupoUsuarioTO to)
        {
            _Contexto = ControladorAcesso.ObterContexto();

            GrupoUsuario entidade = new GrupoUsuario();

            to.PreencherEntidade(entidade);

            _Contexto.GrupoUsuario.Add(entidade);
            _Contexto.SaveChanges();

            to.PreencherTO(entidade);

            to.Valido = true;
            to.Mensagem = Mensagem.Cadastro("GrupoUsuario");

            return;

        }

        public GrupoUsuarioTO Obter(int identificador)
        {
            _Contexto = ControladorAcesso.ObterContexto();

            GrupoUsuarioTO retorno = new GrupoUsuarioTO();

            GrupoUsuario entidade = _Contexto.GrupoUsuario.FirstOrDefault(x => x.Identificador == identificador);

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

        public void Atualizar(GrupoUsuarioTO to)
        {
            _Contexto = ControladorAcesso.ObterContexto();

            if (to.Identificador == 0 || to == null)
            {
                to.Valido = false;
                to.Mensagem = Mensagem.Atualizacao("GrupoUsuario", false);

                return;
            }

            GrupoUsuario entidade = _Contexto.GrupoUsuario.FirstOrDefault(x => x.Identificador == to.Identificador);

            if (entidade == null)
            {
                to.Valido = false;
                to.Mensagem = Mensagem.Obter("GrupoUsuario", false);

                return;
            }

            to.PreencherEntidade(entidade);

            _Contexto.SaveChanges();

            to.PreencherTO(entidade);
            to.Valido = true;
            to.Mensagem = Mensagem.Atualizacao("GrupoUsuario", true);

            return;
        }

        public RetornoTO Remover(int identificador)
        {
                        _Contexto = ControladorAcesso.ObterContexto();

            RetornoTO retorno = new RetornoTO();

            GrupoUsuario entidade = _Contexto.GrupoUsuario.FirstOrDefault(x => x.Identificador == identificador);

            if (entidade == null)
            {
                retorno.Valido = false;
                retorno.Mensagem = Mensagem.Obter("GrupoUsuario", false);

                return retorno;
            }

            _Contexto.GrupoUsuario.Remove(entidade);
            _Contexto.SaveChanges();

            retorno.Valido = true;
            retorno.Mensagem = Mensagem.Exclusao("GrupoUsuario");

            return retorno;
        }

        public ListaGrupoUsuarioTO Listar()
        {
            _Contexto = ControladorAcesso.ObterContexto();

            ListaGrupoUsuarioTO retorno = new ListaGrupoUsuarioTO();

            List<GrupoUsuario> listaGrupoUsuario = _Contexto.GrupoUsuario.ToList();

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
