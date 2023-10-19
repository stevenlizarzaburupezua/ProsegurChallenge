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
        Task<Usuario> GetUserAsync(int idUsuario);

        Task<List<Usuario>> GetUsersAsync();

        Task InsertUserAsync(Usuario usuario);

        Task UpdateUserAsync(Usuario usuario);

        Task DeleteUserAsync(Usuario usuario);
    }
}
