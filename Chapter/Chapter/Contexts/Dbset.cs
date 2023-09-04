using Chapter.Models;

namespace Chapter.Contexts
{
    public class Dbset<T>
    {
        internal Usuario Find(int id)
        {
            throw new NotImplementedException();
        }

        internal Usuario First(Func<object, bool> value)
        {
            throw new NotImplementedException();
        }

        internal Usuario FirstOrDefault(Func<object, bool> value)
        {
            throw new NotImplementedException();
        }

        internal void Remove(Usuario usuarioEncontrado)
        {
            throw new NotImplementedException();
        }

        internal List<Usuario> ToList()
        {
            throw new NotImplementedException();
        }

        internal object Update(Usuario? usuarioEncontrado)
        {
            throw new NotImplementedException();
        }
    }
}