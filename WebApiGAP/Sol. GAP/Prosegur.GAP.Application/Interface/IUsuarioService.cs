using Prosegur.GAP.DTO;
using Prosegur.GAP.DTO.Login.Response;
using Prosegur.GAP.DTO.Mantenimiento.Request;
using Prosegur.GAP.DTO.Mantenimiento.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prosegur.GAP.Application.Interface
{
    public interface IUsuarioService
    {
        Task<IList<UsuarioDTO>> GetUsersAsync();

        Task<UsuarioDTO> GetUserAsync(int idUsuario);

        Task<RegistrarUsuarioDTO> PostUserAsync(RegistrarUsuarioRequest request);

        Task<ModificarUsuarioDTO> UpdateUserAsync(ModificarUsuarioRequest request);

        Task<EliminarUsuarioDTO> DeleteUserAsync(EliminarUsuarioRequest request);

        Task<SesionDTO> GetLoginAsync(string logUsuario, string contrasena);


    }
}
