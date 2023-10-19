using Microsoft.EntityFrameworkCore;
using Prosegur.GAP.Domain.Entities;
using Prosegur.GAP.Domain.Interface.Repository;
using Prosegur.GAP.Repository.Context;
using Prosegur.GAP.Repository.Seedwork;

namespace Prosegur.GAP.Repository.Repositories
{
    public class UsuarioRepository : BaseRepository, IUsuarioRepository
    {
        private GAPDBContext _context;
      
        public UsuarioRepository(GAPDBContext dbContext) : base(dbContext)
        {
            _context = dbContext;
        }

        public async Task<Usuario> GetUserAsync(int idUsuario)
        {
            return await All<Usuario>().FirstOrDefaultAsync(u => u.ID_USUARIO == idUsuario);
        }

        public async Task<List<Usuario>> GetUsersAsync()
        {
            return await All<Usuario>().ToListAsync();
        }

        public async Task InsertUserAsync(Usuario usuario)
        {
            await InsertAsync(usuario);
        }

        public async Task UpdateUserAsync(Usuario usuario)
        {
            await UpdateAsync(usuario);
        }

        public async Task DeleteUserAsync(Usuario usuario)
        {
            await DeleteAsync(usuario);
        }

    }
}
