namespace PIM.Database.Cruds
{
    using PIM.Database.Infra;
    using PIM.Database.Interface;
    using PIM.Database.DatabaseModel;
    using PIM.Database.TO;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using static PIM.Database.Infra.Utilitario;

    public class ContratoCrud : ICrud<ContratoTO>
    {
        private EntidadePIM _Contexto;

        public void Cadastrar(ContratoTO to)
        {
            _Contexto = ControladorAcesso.ObterContexto();

            Contrato entidade = new Contrato();

            to.PreencherEntidade(entidade);

            _Contexto.Contrato.Add(entidade);
            _Contexto.SaveChanges();

            to.PreencherTO(entidade);

            to.Valido = true;
            to.Mensagem = Utilitario.Mensagem.Cadastro("Contrato");

            return;

        }

        public ContratoTO Obter(int identificador)
        {
            _Contexto = ControladorAcesso.ObterContexto();

            ContratoTO retorno = new ContratoTO();

            Contrato entidade = _Contexto.Contrato.FirstOrDefault(x => x.Identificador == identificador);

            if (entidade == null)
            {
                retorno.Valido = false;
                retorno.Mensagem = Mensagem.Obter("Contrato", false);

                return retorno;
            }

            retorno.PreencherTO(entidade);

            retorno.Valido = true;
            retorno.Mensagem = Mensagem.Obter("Contrato", true);

            return retorno;
        }

        public void Atualizar(ContratoTO to)
        {
            _Contexto = ControladorAcesso.ObterContexto();

            if (to.Identificador == 0 || to == null)
            {
                to.Valido = false;
                to.Mensagem = Mensagem.Atualizacao("Contrato", false);

                return;
            }

            Contrato entidade = _Contexto.Contrato.FirstOrDefault(x => x.Identificador == to.Identificador);

            if (entidade == null)
            {
                to.Valido = false;
                to.Mensagem = Mensagem.Obter("Contrato", false);

                return;
            }

            to.PreencherEntidade(entidade);

            _Contexto.SaveChanges();

            to.PreencherTO(entidade);
            to.Valido = true;
            to.Mensagem = Mensagem.Atualizacao("Contrato", true);

            return;
        }

        public RetornoTO Remover(int identificador)
        {
            _Contexto = ControladorAcesso.ObterContexto();

            RetornoTO retorno = new RetornoTO();

            Contrato entidade = _Contexto.Contrato.FirstOrDefault(x => x.Identificador == identificador);

            if (entidade == null)
            {
                retorno.Valido = false;
                retorno.Mensagem = Mensagem.Obter("Contrato", false);

                return retorno;
            }

            _Contexto.Contrato.Remove(entidade);
            _Contexto.SaveChanges();

            retorno.Valido = true;
            retorno.Mensagem = Mensagem.Exclusao("Contrato");

            return retorno;
        }

        public ListaContratoTO Listar()
        {
            _Contexto = ControladorAcesso.ObterContexto();

            ListaContratoTO retorno = new ListaContratoTO();

            List<Contrato> listaContrato = _Contexto.Contrato.ToList();

            if (listaContrato == null || listaContrato.Count == 0)
            {
                retorno.Valido = false;
                retorno.Mensagem = Mensagem.Lista("Contrato", false);

                return retorno;
            }

            ContratoTO to;

            foreach (Contrato entidade in listaContrato)
            {
                to = new ContratoTO();
                to.PreencherTO(entidade);

                retorno.Lista.Add(to);
            }

            retorno.Valido = true;
            retorno.Mensagem = Mensagem.Lista("Contrato", true);

            return retorno;
        }
    }
}
