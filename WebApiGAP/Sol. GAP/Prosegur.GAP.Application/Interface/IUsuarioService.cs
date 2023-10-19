using Prosegur.GAP.DTO;
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

        Task<TransactionResponse> PostUserAsync(RegistrarUsuarioRequest request);

        Task<TransactionResponse> UpdateUserAsync(ModificarUsuarioRequest request);

        Task<TransactionResponse> DeleteUserAsync(EliminarUsuarioRequest request);


    }
}
