using Prosegur.GAP.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Prosegur.GAP.DTO.Mantenimiento.Request;
using Prosegur.GAP.DTO.Mantenimiento.Response;

namespace Prosegur.GAP.Application.Interface
{
    public interface IRolService
    {
        Task<RolDTO> GetRolAsync(int idRol);

        Task<IList<RolDTO>> GetRolesAsync();

        Task<TransactionResponse> PostRolAsync(RegistrarRolRequest request);

        Task<TransactionResponse> UpdateRolAsync(ModificarRolRequest request);

        Task<TransactionResponse> DeleteRolAsync(EliminarRolRequest request);
    }
}
