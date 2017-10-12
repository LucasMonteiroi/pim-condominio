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

    public class MoradorCrud : ICrud<MoradorTO>
    {
        private EntidadePIM _Contexto;

        public void Cadastrar(MoradorTO to)
        {
            _Contexto = ControladorAcesso.ObterContexto();

            Morador entidade = new Morador();

            to.PreencherEntidade(entidade);

            _Contexto.Morador.Add(entidade);
            _Contexto.SaveChanges();

            to.PreencherTO(entidade);

            to.Valido = true;
            to.Mensagem = Mensagem.Cadastro("Morador");

            return;

        }

        public MoradorTO Obter(int identificador)
        {
            _Contexto = ControladorAcesso.ObterContexto();

            MoradorTO retorno = new MoradorTO();

            Morador entidade = _Contexto.Morador.FirstOrDefault(x => x.Identificador == identificador);

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

        public void Atualizar(MoradorTO to)
        {
            _Contexto = ControladorAcesso.ObterContexto();

            if (to.Identificador == 0 || to == null)
            {
                to.Valido = false;
                to.Mensagem = Mensagem.Atualizacao("Morador", false);

                return;
            }

            Morador entidade = _Contexto.Morador.FirstOrDefault(x => x.Identificador == to.Identificador);

            if (entidade == null)
            {
                to.Valido = false;
                to.Mensagem = Mensagem.Obter("Morador", false);

                return;
            }

            to.PreencherEntidade(entidade);

            _Contexto.SaveChanges();

            to.PreencherTO(entidade);
            to.Valido = true;
            to.Mensagem = Mensagem.Atualizacao("Morador", true);

            return;
        }

        public RetornoTO Remover(int identificador)
        {
            _Contexto = ControladorAcesso.ObterContexto();

            RetornoTO retorno = new RetornoTO();

            Morador entidade = _Contexto.Morador.FirstOrDefault(x => x.Identificador == identificador);

            if (entidade == null)
            {
                retorno.Valido = false;
                retorno.Mensagem = Mensagem.Obter("Morador", false);

                return retorno;
            }

            _Contexto.Morador.Remove(entidade);
            _Contexto.SaveChanges();

            retorno.Valido = true;
            retorno.Mensagem = Mensagem.Exclusao("Morador");

            return retorno;
        }

        public ListaMoradorTO Listar()
        {
            _Contexto = ControladorAcesso.ObterContexto();

            ListaMoradorTO retorno = new ListaMoradorTO();

            List<Morador> listaMorador = _Contexto.Morador.ToList();

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
