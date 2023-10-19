using Prosegur.GAP.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prosegur.GAP.Domain.Interface.Repository
{
    public interface IRolRepository
    {
        Task<Rol> GetRolAsync(int idRol);

        Task<List<Rol>> GetRolesAsync();

        Task InsertRolAsync(Rol rol);

        Task UpdateRolAsync(Rol rol);

        Task DeleteRolAsync(Rol rol);
    }
}
