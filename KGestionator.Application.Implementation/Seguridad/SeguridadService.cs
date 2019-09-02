using KGestionator.Application.Cifrado;
using KGestionator.Application.Implementation.Seguridad.Mappers;
using KGestionator.Application.Logs;
using KGestionator.Application.Seguridad;
using KGestionator.Application.Seguridad.DTOs;
using KGestionator.Domain.Planillas.Model;
using KGestionator.Domain.Planillas.Repositories;
using KGestionator.Domain.Seguridad.Model;
using KGestionator.Domain.Seguridad.Repositories;
using System;

namespace KGestionator.Application.Implementation.Seguridad
{
    public class SeguridadService : ISeguridadService
    {
        private readonly IUsuarioRepository _usuarioRepository;
        private readonly IEmpleadoRepository _empleadoRepository;
        private readonly ICifradoAdapter _cifradoAdapter;
        private readonly ILogsAdapter _logsAdapter;

        public SeguridadService(IUsuarioRepository usuarioRepository, IEmpleadoRepository empleadoRepository, ICifradoAdapter cifradoAdapter, ILogsAdapter logsAdapter)
        {
            _usuarioRepository = usuarioRepository;
            _empleadoRepository = empleadoRepository;
            _cifradoAdapter = cifradoAdapter;
            _logsAdapter = logsAdapter;
        }

        public void AgregarUsuario(UsuarioDto dto)
        {
            try
            {
                //Validar que el empleado exista
                Empleado empleado = _empleadoRepository.GetBy(dto.IdEmpleado);
                if (empleado == null) throw new Exception("Empleado no existe.");

                //Validar que el usuario no exista
                Usuario usuario = _usuarioRepository.Get(dto.Correo);
                if (usuario != null) throw new Exception("Usuario ya existe.");

                //Cifrar contraseña
                string contraseñaCifrada = _cifradoAdapter.Cifrar(dto.Contraseña);

                //Crear usuario
                Usuario nuevoUsuario = new Usuario(dto.Correo, dto.Nombre, contraseñaCifrada, dto.IdEmpleado);

                //Guardar usuario
                _usuarioRepository.Insert(nuevoUsuario);
                _logsAdapter.GuardarMensaje("Guardado exitosamente.");
            }
            catch (Exception e)
            {
                _logsAdapter.GuardarError("Error al guardar usuario.", e);
                throw new Exception("Error al guardar usuario.", e);
            }
        }

        public UsuarioDto Autenticar(CredencialesDto dto)
        {
            try
            {
                Usuario usuario = _usuarioRepository.GetBy(dto.Correo, dto.Contraseña);
                if (usuario == null) throw new Exception("Correo o contraseña no son validos.");

                return usuario.ToDto();
            }
            catch (Exception e)
            {
                throw new Exception("Error al intentar autenticar al usuario.", e);
            }
        }

        public UsuarioDto ConsultarUsuario(UsuarioDeConsultaDto dto)
        {
            try
            {
                return _usuarioRepository.Get(dto.correo).ToDto();
            }
            catch (Exception e)
            {
                throw new Exception("Error al consultar usuario.", e);
            }
        }

        public void DarBaja(UsuarioDeBajaDto dto)
        {
            try
            {
                Usuario usuario = _usuarioRepository.Get(dto.Correo);
                usuario.DarDeBaja();
                _usuarioRepository.Update(usuario);
            }
            catch (Exception e)
            {
                throw new Exception("Error al intentar dar de baja al usuario.", e);
            }
        }

        public void ModificarUsuario(UsuarioDto dto)
        {            
            try
            {
                //Obtener usuario
                Usuario usuario = _usuarioRepository.Get(dto.Correo);
                
                //Validar que el usuario exista
                if (usuario == null) throw new Exception("Usuario no existe.");
                
                //Asignar los nuevos datos
                usuario.Nombre = dto.Nombre;
                usuario.Correo = dto.Correo;
                usuario.Contraseña = dto.Contraseña;

                //Modificar el usuario
                _usuarioRepository.Update(usuario);
                _logsAdapter.GuardarMensaje("Usuario modificado exitosamente");
            }
            catch (Exception e)
            {
                _logsAdapter.GuardarError("Error al intentar modificar usuario", e);
                throw new Exception("Error al intentar modificar usuario.", e);
                //throw new UpdateUserException(ex);
            }
        }
    }
}