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

        #region SelectAsync

        public async Task<Usuario> SelectLoginAsync(string logUsuario, string contrasena)
        {
            return await _context.USUARIO
                .AsNoTracking()
                .Where(u => u.LOG_USUARIO == logUsuario && u.CONTRASENA == contrasena)
                .Include(x => x.Rol)
                .FirstOrDefaultAsync();
        }

        public async Task<Usuario> SelectUserAsync(int idUsuario)
        {
            return await _context.USUARIO
                .AsNoTracking()
                .Where(x => x.ID_USUARIO == idUsuario)
                .Include(x => x.Rol)
                .FirstOrDefaultAsync();
        }

        public async Task<List<Usuario>> SelectUsersAsync()
        {
            return await All<Usuario>().ToListAsync();
        }

        #endregion

        #region InsertAsync

        public async Task<Usuario> InsertUserAsync(Usuario usuario)
        {
            await InsertAsync(usuario);
            await _context.SaveChangesAsync();
            return await SelectUserAsync(usuario.ID_USUARIO);
        }

        #endregion

        #region UpdatesAsync

        public async Task<Usuario> UpdateUserAsync(Usuario usuario)
        {
            await UpdateAsync(usuario);
            await _context.SaveChangesAsync();
            return await SelectUserAsync(usuario.ID_USUARIO);
        }

        #endregion

        #region DeleteAsync

        public async Task<Usuario> DeleteUserAsync(Usuario usuario)
        {
            await DeleteAsync(usuario);
            await _context.SaveChangesAsync();
            return new Usuario { ID_USUARIO = usuario.ID_USUARIO, LOG_USUARIO = usuario.LOG_USUARIO};
        }

        #endregion

    }
}
