using Microsoft.EntityFrameworkCore;
using Prosegur.GAP.Domain.Entities;
using Prosegur.GAP.Domain.Interface.Repository;
using Prosegur.GAP.Domain.Seedwork;
using Prosegur.GAP.Repository.Context;
using Prosegur.GAP.Repository.Seedwork;

namespace Prosegur.GAP.Repository.Repositories
{
    public class RolRepository : BaseRepository, IRolRepository
    {
        private GAPDBContext _context;

        public RolRepository(GAPDBContext dbContext) : base(dbContext)
        {
            _context = dbContext;
        }

        public async Task<Rol> GetRolAsync(int idRol)
        {
            return await All<Rol>().FirstOrDefaultAsync(u => u.ID_ROL == idRol);
        }

        public async Task<List<Rol>> GetRolesAsync()
        {
            return await All<Rol>().ToListAsync();
        }

        public async Task InsertRolAsync(Rol rol)
        {
            await InsertAsync(rol);
        }

        public async Task UpdateRolAsync(Rol rol)
        {
            await UpdateAsync(rol);
        }

        public async Task DeleteRolAsync(Rol rol)
        {
            await DeleteAsync(rol);
        }

    }
}
