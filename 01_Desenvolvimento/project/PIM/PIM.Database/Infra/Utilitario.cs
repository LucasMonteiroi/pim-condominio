namespace PIM.Database.Infra
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public static class Utilitario
    {
        #region --- Mensagem ---

        public static class Mensagem
        {
            internal static string Cadastro(string _Classe)
            {
                return string.Format("{0} cadastrado(a) com sucesso.", _Classe);
            }

            internal static string Obter(string _Classe, bool _Valido)
            {
                if (_Valido)
                    return string.Format("{0} obtido(a) com sucesso.", _Classe);
                else
                    return string.Format("Não existe {0} cadastrado(a) de acordo com o parâmetro informado.", _Classe);
            }

            internal static string Atualizacao(string _Classe, bool _Valido)
            {
                if (_Valido)
                {
                    return string.Format("{0} atualizado(a) com sucesso!", _Classe);
                }
                else
                {
                    return string.Format("Necessário informar o identificador de {0}.", _Classe);
                }
            }

            internal static string Exclusao(string _Classe)
            {
                return string.Format("{0} removido(a) com sucesso!");
            }

            internal static string Lista(string _Classe, bool _Valido)
            {
                if (_Valido)
                {
                    return string.Format("{0} listadas com sucesso.", _Classe);
                }
                else
                {
                    return string.Format("Não existem {0} cadastradas na base de dados.", _Classe);
                }
            }
        }

        #endregion --- Mensagem ---
    }
}
