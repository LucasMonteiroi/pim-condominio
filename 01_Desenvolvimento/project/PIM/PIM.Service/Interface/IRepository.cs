namespace PIM.Service.Interface
{
    using PIM.Database.Infra;

    internal interface IRepository<T> where T : class
    {
        void Criar(T entidadeTO);
        void Atualizar(T entidadeTO);
        T Obter(int identificador);
        RetornoTO Remover(int identificador);
    }
}
