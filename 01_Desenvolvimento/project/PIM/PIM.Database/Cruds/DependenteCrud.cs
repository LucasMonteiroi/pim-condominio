namespace PIM.Database.Cruds
{
    using PIM.Database.Infra;
    using PIM.Database.Interface;
    using PIM.Database.Modelo;
    using PIM.Database.TO;
    using System.Collections.Generic;
    using System.Linq;
    using static PIM.Database.Infra.Utilitario;

    public class DependenteCrud : ICrud<DependenteTO>
    {
        public void Cadastrar(EntidadePIM contexto, DependenteTO to)
        {
            Dependente entidade = new Dependente();

            to.PreencherEntidade(entidade);

            contexto.Dependente.Add(entidade);
            contexto.SaveChanges();

            to.PreencherTO(entidade);

            to.Valido = true;
            to.Mensagem = Utilitario.Mensagem.Cadastro("Dependente");

            return;

        }

        public DependenteTO Obter(EntidadePIM contexto, int identificador)
        {
            DependenteTO retorno = new DependenteTO();

            Dependente entidade = contexto.Dependente.FirstOrDefault(x => x.Identificador == identificador);

            if (entidade == null)
            {
                retorno.Valido = false;
                retorno.Mensagem = Mensagem.Obter("Dependente", false);

                return retorno;
            }

            retorno.PreencherTO(entidade);

            retorno.Valido = true;
            retorno.Mensagem = Mensagem.Obter("Dependente", true);

            return retorno;
        }

        public void Atualizar(EntidadePIM contexto, DependenteTO to)
        {
            if (to.Identificador == 0 || to == null)
            {
                to.Valido = false;
                to.Mensagem = Mensagem.Atualizacao("Dependente", false);

                return;
            }

            Dependente entidade = contexto.Dependente.FirstOrDefault(x => x.Identificador == to.Identificador);

            if (entidade == null)
            {
                to.Valido = false;
                to.Mensagem = Mensagem.Obter("Dependente", false);

                return;
            }

            to.PreencherEntidade(entidade);

            contexto.SaveChanges();

            to.PreencherTO(entidade);
            to.Valido = true;
            to.Mensagem = Mensagem.Atualizacao("Dependente", true);

            return;
        }

        public RetornoTO Remover(EntidadePIM contexto, int identificador)
        {
            RetornoTO retorno = new RetornoTO();

            Dependente entidade = contexto.Dependente.FirstOrDefault(x => x.Identificador == identificador);

            if (entidade == null)
            {
                retorno.Valido = false;
                retorno.Mensagem = Mensagem.Obter("Dependente", false);

                return retorno;
            }

            contexto.Dependente.Remove(entidade);
            contexto.SaveChanges();

            retorno.Valido = true;
            retorno.Mensagem = Mensagem.Exclusao("Dependente");

            return retorno;
        }

        public ListaDependenteTO Listar(EntidadePIM contexto)
        {
            ListaDependenteTO retorno = new ListaDependenteTO();

            List<Dependente> listaDependente = contexto.Dependente.ToList();

            if (listaDependente == null || listaDependente.Count == 0)
            {
                retorno.Valido = false;
                retorno.Mensagem = Mensagem.Lista("Dependente", false);

                return retorno;
            }

            DependenteTO to;

            foreach (Dependente entidade in listaDependente)
            {
                to = new DependenteTO();
                to.PreencherTO(entidade);

                retorno.Lista.Add(to);
            }

            retorno.Valido = true;
            retorno.Mensagem = Mensagem.Lista("Dependente", true);

            return retorno;
        }
    }
}
