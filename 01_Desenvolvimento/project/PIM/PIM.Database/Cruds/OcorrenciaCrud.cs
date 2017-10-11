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

    public class OcorrenciaCrud : ICrud<OcorrenciaTO>
    {
        public void Cadastrar(EntidadePIM contexto, OcorrenciaTO to)
        {
            Ocorrencia entidade = new Ocorrencia();

            to.PreencherEntidade(entidade);

            contexto.Ocorrencia.Add(entidade);
            contexto.SaveChanges();

            to.PreencherTO(entidade);

            to.Valido = true;
            to.Mensagem = Mensagem.Cadastro("Ocorrencia");

            return;

        }

        public OcorrenciaTO Obter(EntidadePIM contexto, int identificador)
        {
            OcorrenciaTO retorno = new OcorrenciaTO();

            Ocorrencia entidade = contexto.Ocorrencia.FirstOrDefault(x => x.Identificador == identificador);

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

        public void Atualizar(EntidadePIM contexto, OcorrenciaTO to)
        {
            if (to.Identificador == 0 || to == null)
            {
                to.Valido = false;
                to.Mensagem = Mensagem.Atualizacao("Ocorrencia", false);

                return;
            }

            Ocorrencia entidade = contexto.Ocorrencia.FirstOrDefault(x => x.Identificador == to.Identificador);

            if (entidade == null)
            {
                to.Valido = false;
                to.Mensagem = Mensagem.Obter("Ocorrencia", false);

                return;
            }

            to.PreencherEntidade(entidade);

            contexto.SaveChanges();

            to.PreencherTO(entidade);
            to.Valido = true;
            to.Mensagem = Mensagem.Atualizacao("Ocorrencia", true);

            return;
        }

        public RetornoTO Remover(EntidadePIM contexto, int identificador)
        {
            RetornoTO retorno = new RetornoTO();

            Ocorrencia entidade = contexto.Ocorrencia.FirstOrDefault(x => x.Identificador == identificador);

            if (entidade == null)
            {
                retorno.Valido = false;
                retorno.Mensagem = Mensagem.Obter("Ocorrencia", false);

                return retorno;
            }

            contexto.Ocorrencia.Remove(entidade);
            contexto.SaveChanges();

            retorno.Valido = true;
            retorno.Mensagem = Mensagem.Exclusao("Ocorrencia");

            return retorno;
        }

        public ListaOcorrenciaTO Listar(EntidadePIM contexto)
        {
            ListaOcorrenciaTO retorno = new ListaOcorrenciaTO();

            List<Ocorrencia> listaOcorrencia = contexto.Ocorrencia.ToList();

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
