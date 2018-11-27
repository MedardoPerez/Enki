using System;
using System.Collections.Generic;
using ENKI.SOFT.Models.DTOs;

namespace ENKI.SOFT.Models.AppService
{
    public interface IUsuarioAppService : IDisposable
    {
        IEnumerable<UsuarioDTO> ObtenerUsuarios();
    }
}