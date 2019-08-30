using KGestionator.Application.Cifrado;
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

        public SeguridadService(IUsuarioRepository usuarioRepository, IEmpleadoRepository empleadoRepository, ICifradoAdapter cifradoAdapter)
        {
            _usuarioRepository = usuarioRepository;
            _empleadoRepository = empleadoRepository;
            _cifradoAdapter = cifradoAdapter;
        }

        public bool AgregarUsuario(UsuarioDto dto)
        {
            //Validar que el empleado exista
            Empleado empleado = _empleadoRepository.GetBy(dto.IdEmpleado);
            if (empleado == null) throw new Exception("");

            //Validar que el usuario no exista
            Usuario usuario = _usuarioRepository.Get(dto.Correo);
            if (usuario != null) throw new Exception("");

            //Cifrar contraseña
            string contraseñaCifrada = _cifradoAdapter.Cifrar(dto.Contraseña);

            //Crear usuario
            Usuario nuevoUsuario = new Usuario(dto.Correo, dto.Nombre, contraseñaCifrada, dto.IdEmpleado);
            //Guardar usuario
            _usuarioRepository.Insert(nuevoUsuario);
            
            //Guardar Log
            throw new System.NotImplementedException();
        }

        public UsuarioAutenticadoDto Autenticar(CredencialesDto dto)
        {
            throw new System.NotImplementedException();
        }

        public UsuarioDto ConsultarUsuario(UsuarioDeConsultaDto dto)
        {
            throw new System.NotImplementedException();
        }

        public bool DarBaja(UsuarioDeBajaDto dto)
        {
            throw new System.NotImplementedException();
        }

        public bool ModificarUsuario(UsuarioDto dto)
        {
            throw new System.NotImplementedException();
        }
    }
}