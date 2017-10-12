namespace PIM.Database.Interface
{
    using PIM.Database.Infra;
    using PIM.Database.DatabaseModel;

    public interface ICrud<T> where T : class
    {
        void Cadastrar(T to);
        T Obter(int identificador);
        void Atualizar(T to);
        RetornoTO Remover(int identificador);
    }
}
