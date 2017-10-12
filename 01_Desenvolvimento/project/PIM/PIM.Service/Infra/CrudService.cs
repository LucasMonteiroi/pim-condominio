namespace PIM.Service.Infra
{
    using System;

    internal static class CrudService<T> where T :class
    {
        internal static T ObterInstancia()
        {
            return (T)Activator.CreateInstance(typeof(T));
        }
    }
}
