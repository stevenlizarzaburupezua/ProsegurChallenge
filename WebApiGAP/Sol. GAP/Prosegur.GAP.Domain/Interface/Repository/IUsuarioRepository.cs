using Prosegur.GAP.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prosegur.GAP.Domain.Interface.Repository
{
    public interface IUsuarioRepository
    {
        Task<Usuario> SelectUserAsync(int idUsuario);

        Task<List<Usuario>> SelectUsersAsync();

        Task<Usuario> SelectLoginAsync(string logUsuario, string contrasena);

        Task<Usuario> InsertUserAsync(Usuario usuario);

        Task<Usuario> UpdateUserAsync(Usuario usuario);

        Task<Usuario> DeleteUserAsync(Usuario usuario);

    }
}
