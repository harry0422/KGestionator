using KGestionator.Domain.Seguridad.Model;

namespace KGestionator.Domain.Seguridad.Repositories
{
    public interface IUsuarioRepository
    {
        Usuario Get(string correo);
        void Insert(Usuario usuario);
    }
}