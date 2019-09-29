using KGestionator.Domain.Commons;
using KGestionator.Domain.Seguridad.Model;

namespace KGestionator.Domain.Seguridad.Repositories
{
    public interface IUsuarioRepository : IRepository<Usuario, string>
    {
        Usuario GetBy(string correo, string contraseña);
    }
}