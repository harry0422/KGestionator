using KGestionator.Domain.Seguridad.Model;

namespace KGestionator.Domain.Seguridad.Repositories
{
    public interface IUsuarioRepository
    {
        Usuario Get(string correo);
        Usuario GetBy(string correo, string contraseña);
        void Insert(Usuario usuario);
        void Update(Usuario usuario);
    }
}