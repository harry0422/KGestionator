using KGestionator.Domain.Planillas.Model;

namespace KGestionator.Domain.Planillas.Repositories
{
    public interface IEmpleadoRepository
    {
        Empleado GetBy(string idEmpleado);
    }
}