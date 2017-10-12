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

    public class OcorrenciaCrud : ICrud<OcorrenciaTO>
    {
        private EntidadePIM _Contexto;

        public void Cadastrar(OcorrenciaTO to)
        {
            _Contexto = ControladorAcesso.ObterContexto();

            Ocorrencia entidade = new Ocorrencia();

            to.PreencherEntidade(entidade);

            _Contexto.Ocorrencia.Add(entidade);
            _Contexto.SaveChanges();

            to.PreencherTO(entidade);

            to.Valido = true;
            to.Mensagem = Mensagem.Cadastro("Ocorrencia");

            return;

        }

        public OcorrenciaTO Obter(int identificador)
        {
            _Contexto = ControladorAcesso.ObterContexto();

            OcorrenciaTO retorno = new OcorrenciaTO();

            Ocorrencia entidade = _Contexto.Ocorrencia.FirstOrDefault(x => x.Identificador == identificador);

            if (entidade == null)
            {
                retorno.Valido = false;
                retorno.Mensagem = Mensagem.Obter("Ocorrencia", false);

                return retorno;
            }

            retorno.PreencherTO(entidade);

            retorno.Valido = true;
            retorno.Mensagem = Mensagem.Obter("Ocorrencia", true);

            return retorno;
        }

        public void Atualizar(OcorrenciaTO to)
        {
            _Contexto = ControladorAcesso.ObterContexto();

            if (to.Identificador == 0 || to == null)
            {
                to.Valido = false;
                to.Mensagem = Mensagem.Atualizacao("Ocorrencia", false);

                return;
            }

            Ocorrencia entidade = _Contexto.Ocorrencia.FirstOrDefault(x => x.Identificador == to.Identificador);

            if (entidade == null)
            {
                to.Valido = false;
                to.Mensagem = Mensagem.Obter("Ocorrencia", false);

                return;
            }

            to.PreencherEntidade(entidade);

            _Contexto.SaveChanges();

            to.PreencherTO(entidade);
            to.Valido = true;
            to.Mensagem = Mensagem.Atualizacao("Ocorrencia", true);

            return;
        }

        public RetornoTO Remover(int identificador)
        {
            _Contexto = ControladorAcesso.ObterContexto();

            RetornoTO retorno = new RetornoTO();

            Ocorrencia entidade = _Contexto.Ocorrencia.FirstOrDefault(x => x.Identificador == identificador);

            if (entidade == null)
            {
                retorno.Valido = false;
                retorno.Mensagem = Mensagem.Obter("Ocorrencia", false);

                return retorno;
            }

            _Contexto.Ocorrencia.Remove(entidade);
            _Contexto.SaveChanges();

            retorno.Valido = true;
            retorno.Mensagem = Mensagem.Exclusao("Ocorrencia");

            return retorno;
        }

        public ListaOcorrenciaTO Listar()
        {
            _Contexto = ControladorAcesso.ObterContexto();

            ListaOcorrenciaTO retorno = new ListaOcorrenciaTO();

            List<Ocorrencia> listaOcorrencia = _Contexto.Ocorrencia.ToList();

            if (listaOcorrencia == null || listaOcorrencia.Count == 0)
            {
                retorno.Valido = false;
                retorno.Mensagem = Mensagem.Lista("Ocorrencia", false);

                return retorno;
            }

            OcorrenciaTO to;

            foreach (Ocorrencia entidade in listaOcorrencia)
            {
                to = new OcorrenciaTO();
                to.PreencherTO(entidade);

                retorno.Lista.Add(to);
            }

            retorno.Valido = true;
            retorno.Mensagem = Mensagem.Lista("Ocorrencia", true);

            return retorno;
        }
    }
}
