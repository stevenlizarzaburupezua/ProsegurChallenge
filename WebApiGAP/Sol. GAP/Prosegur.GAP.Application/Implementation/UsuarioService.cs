using Prosegur.GAP.Application.Interface;
using Prosegur.GAP.Domain.Entities;
using Prosegur.GAP.Domain.Interface.Repository;
using Prosegur.GAP.Domain.Seedwork;
using Prosegur.GAP.DTO;
using Prosegur.GAP.DTO.Login.Response;
using Prosegur.GAP.DTO.Mantenimiento.Request;
using Prosegur.GAP.DTO.Mantenimiento.Response;
using Rep.Traserep.Infra.CrossCutting.Adapter;


namespace Prosegur.GAP.Application.Implementation
{
    public class UsuarioService : IUsuarioService
    {
        private readonly IUsuarioRepository _usuarioRepository;
        private readonly IUnitOfWork _unitOfWork;

        public UsuarioService(IUsuarioRepository usuarioRepository,
                              IUnitOfWork unitofWork)
        {
            _usuarioRepository = usuarioRepository;
            _unitOfWork = unitofWork;
        }

        public async Task<UsuarioDTO> GetUserAsync(int idUsuario)
        {
            return (await _usuarioRepository.SelectUserAsync(idUsuario)).ProjectedAs<UsuarioDTO>();
        }

        public async Task<IList<UsuarioDTO>> GetUsersAsync()
        {
            return (await _usuarioRepository.SelectUsersAsync()).ProjectedAs<List<UsuarioDTO>>();
        }

        public async Task<SesionDTO> GetLoginAsync(string logUsuario, string contrasena)
        {
            return (await _usuarioRepository.SelectLoginAsync(logUsuario, contrasena)).ProjectedAs<SesionDTO>();
        }

        public async Task<RegistrarUsuarioDTO> PostUserAsync(RegistrarUsuarioRequest request)
        {
            return (await _usuarioRepository.InsertUserAsync(request.ProjectedAs<Usuario>())).ProjectedAs<RegistrarUsuarioDTO>();
        }

        public async Task<ModificarUsuarioDTO> UpdateUserAsync(ModificarUsuarioRequest request)
        {
            return (await _usuarioRepository.UpdateUserAsync(request.ProjectedAs<Usuario>())).ProjectedAs<ModificarUsuarioDTO>();
        }

        public async Task<EliminarUsuarioDTO> DeleteUserAsync(EliminarUsuarioRequest request)
        {
            return (await _usuarioRepository.DeleteUserAsync(request.ProjectedAs<Usuario>())).ProjectedAs<EliminarUsuarioDTO>();
        }

    }
}
