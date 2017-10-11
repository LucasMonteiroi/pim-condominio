namespace PIM.Database.Cruds
{
    using PIM.Database.Infra;
    using PIM.Database.Interface;
    using PIM.Database.Modelo;
    using PIM.Database.TO;
    using System.Collections.Generic;
    using System.Linq;
    using static PIM.Database.Infra.Utilitario;

    public class ApartamentoCrud : ICrud<ApartamentoTO>
    {
        public void Cadastrar(EntidadePIM contexto, ApartamentoTO to)
        {
            Apartamento entidade = new Apartamento();

            to.PreencherEntidade(entidade);

            contexto.Apartamento.Add(entidade);
            contexto.SaveChanges();

            to.PreencherTO(entidade);

            to.Valido = true;
            to.Mensagem = Utilitario.Mensagem.Cadastro("Apartamento");

            return;

        }

        public ApartamentoTO Obter(EntidadePIM contexto, int identificador)
        {
            ApartamentoTO retorno = new ApartamentoTO();

            Apartamento entidade = contexto.Apartamento.FirstOrDefault(x => x.Identificador == identificador);

            if (entidade == null)
            {
                retorno.Valido = false;
                retorno.Mensagem = Mensagem.Obter("Apartamento", false);

                return retorno;
            }

            retorno.PreencherTO(entidade);

            retorno.Valido = true;
            retorno.Mensagem = Mensagem.Obter("Apartamento", true);

            return retorno;
        }

        public void Atualizar(EntidadePIM contexto, ApartamentoTO to)
        {
            if (to.Identificador == 0 || to == null)
            {
                to.Valido = false;
                to.Mensagem = Mensagem.Atualizacao("Apartamento", false);

                return;
            }

            Apartamento entidade = contexto.Apartamento.FirstOrDefault(x => x.Identificador == to.Identificador);

            if (entidade == null)
            {
                to.Valido = false;
                to.Mensagem = Mensagem.Obter("Apartamento", false);

                return;
            }

            to.PreencherEntidade(entidade);

            contexto.SaveChanges();

            to.PreencherTO(entidade);
            to.Valido = true;
            to.Mensagem = Mensagem.Atualizacao("Apartamento", true);

            return;
        }

        public RetornoTO Remover(EntidadePIM contexto, int identificador)
        {
            RetornoTO retorno = new RetornoTO();

            Apartamento entidade = contexto.Apartamento.FirstOrDefault(x => x.Identificador == identificador);

            if (entidade == null)
            {
                retorno.Valido = false;
                retorno.Mensagem = Mensagem.Obter("Apartamento", false);

                return retorno;
            }

            contexto.Apartamento.Remove(entidade);
            contexto.SaveChanges();

            retorno.Valido = true;
            retorno.Mensagem = Mensagem.Exclusao("Apartamento");

            return retorno;
        }

        public ListaApartamentoTO Listar(EntidadePIM contexto)
        {
            ListaApartamentoTO retorno = new ListaApartamentoTO();

            List<Apartamento> listaApartamento = contexto.Apartamento.ToList();

            if (listaApartamento == null || listaApartamento.Count == 0)
            {
                retorno.Valido = false;
                retorno.Mensagem = Mensagem.Lista("Apartamento", false);

                return retorno;
            }

            ApartamentoTO to;

            foreach (Apartamento entidade in listaApartamento)
            {
                to = new ApartamentoTO();
                to.PreencherTO(entidade);

                retorno.Lista.Add(to);
            }

            retorno.Valido = true;
            retorno.Mensagem = Mensagem.Lista("Apartamento", true);

            return retorno;
        }
    }

}
