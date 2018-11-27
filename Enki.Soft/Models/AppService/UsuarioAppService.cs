using System;
using System.Collections.Generic;
using System.Linq;
using ENKI.SOFT.Models.DTOs;
using ENKI.SOFT.Models.Entidades;
using ENKI.SOFT.Models.Repositorio;

namespace ENKI.SOFT.Models.AppService
{
    public class UsuarioAppService : IUsuarioAppService
    {
        private readonly IRepositoryGenerico<Usuario> _usuarioRepositorio;
        public UsuarioAppService(IRepositoryGenerico<Usuario> usuarioRepositorio)
        {
            if(usuarioRepositorio == null) throw new ArgumentNullException("Usuario repositorio");

            _usuarioRepositorio = usuarioRepositorio;
        }
        public IEnumerable<UsuarioDTO> ObtenerUsuarios()
        {
            var usuario = _usuarioRepositorio.GetAll();

            return usuario.Select(c => new UsuarioDTO{UsuarioId = c.UsuarioId, Nombre = c.Nombre, Contrasena = c.Contrasena }).ToList();
        }
        public void Dispose()
        {
            if(_usuarioRepositorio != null) _usuarioRepositorio.Dispose();
        }
    }
}