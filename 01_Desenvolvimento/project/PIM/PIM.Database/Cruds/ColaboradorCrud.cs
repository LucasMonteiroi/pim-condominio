namespace PIM.Database.Cruds
{
    using PIM.Database.Infra;
    using PIM.Database.Interface;
    using PIM.Database.Modelo;
    using PIM.Database.TO;
    using System.Collections.Generic;
    using System.Linq;
    using static PIM.Database.Infra.Utilitario;

    public class ColaboradorCrud : ICrud<ColaboradorTO>
    {
        public void Cadastrar(EntidadePIM contexto, ColaboradorTO to)
        {
            Colaborador entidade = new Colaborador();

            to.PreencherEntidade(entidade);

            contexto.Colaborador.Add(entidade);
            contexto.SaveChanges();

            to.PreencherTO(entidade);

            to.Valido = true;
            to.Mensagem = Utilitario.Mensagem.Cadastro("Colaborador");

            return;

        }

        public ColaboradorTO Obter(EntidadePIM contexto, int identificador)
        {
            ColaboradorTO retorno = new ColaboradorTO();

            Colaborador entidade = contexto.Colaborador.FirstOrDefault(x => x.Identificador == identificador);

            if (entidade == null)
            {
                retorno.Valido = false;
                retorno.Mensagem = Mensagem.Obter("Colaborador", false);

                return retorno;
            }

            retorno.PreencherTO(entidade);

            retorno.Valido = true;
            retorno.Mensagem = Mensagem.Obter("Colaborador", true);

            return retorno;
        }

        public void Atualizar(EntidadePIM contexto, ColaboradorTO to)
        {
            if (to.Identificador == 0 || to == null)
            {
                to.Valido = false;
                to.Mensagem = Mensagem.Atualizacao("Colaborador", false);

                return;
            }

            Colaborador entidade = contexto.Colaborador.FirstOrDefault(x => x.Identificador == to.Identificador);

            if (entidade == null)
            {
                to.Valido = false;
                to.Mensagem = Mensagem.Obter("Colaborador", false);

                return;
            }

            to.PreencherEntidade(entidade);

            contexto.SaveChanges();

            to.PreencherTO(entidade);
            to.Valido = true;
            to.Mensagem = Mensagem.Atualizacao("Colaborador", true);

            return;
        }

        public RetornoTO Remover(EntidadePIM contexto, int identificador)
        {
            RetornoTO retorno = new RetornoTO();

            Colaborador entidade = contexto.Colaborador.FirstOrDefault(x => x.Identificador == identificador);

            if (entidade == null)
            {
                retorno.Valido = false;
                retorno.Mensagem = Mensagem.Obter("Colaborador", false);

                return retorno;
            }

            contexto.Colaborador.Remove(entidade);
            contexto.SaveChanges();

            retorno.Valido = true;
            retorno.Mensagem = Mensagem.Exclusao("Colaborador");

            return retorno;
        }

        public ListaColaboradorTO Listar(EntidadePIM contexto)
        {
            ListaColaboradorTO retorno = new ListaColaboradorTO();

            List<Colaborador> listaColaborador = contexto.Colaborador.ToList();

            if (listaColaborador == null || listaColaborador.Count == 0)
            {
                retorno.Valido = false;
                retorno.Mensagem = Mensagem.Lista("Colaborador", false);

                return retorno;
            }

            ColaboradorTO to;

            foreach (Colaborador entidade in listaColaborador)
            {
                to = new ColaboradorTO();
                to.PreencherTO(entidade);

                retorno.Lista.Add(to);
            }

            retorno.Valido = true;
            retorno.Mensagem = Mensagem.Lista("Colaborador", true);

            return retorno;
        }
    }
}
