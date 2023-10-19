using Prosegur.GAP.Application.Interface;
using Prosegur.GAP.Domain.Entities;
using Prosegur.GAP.Domain.Interface.Repository;
using Prosegur.GAP.Domain.Seedwork;
using Prosegur.GAP.DTO;
using Prosegur.GAP.DTO.Mantenimiento.Request;
using Prosegur.GAP.DTO.Mantenimiento.Response;
using Prosegur.GAP.Infrastructure.CrossCutting.MapperProfile;
using Prosegur.GAP.Repository.Repositories;
using Prosegur.GAP.Repository.UnitofWork;
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
            return (await _usuarioRepository.GetUserAsync(idUsuario)).ProjectedAs<UsuarioDTO>();
        }

        public async Task<IList<UsuarioDTO>> GetUsersAsync()
        {
            return (await _usuarioRepository.GetUsersAsync()).ProjectedAs<List<UsuarioDTO>>();
        }

        public async Task<TransactionResponse> PostUserAsync(RegistrarUsuarioRequest request)
        {
            await _usuarioRepository.InsertUserAsync(request.ProjectedAs<Usuario>());
            await _unitOfWork.SaveAsync();

            return new TransactionResponse { Success = true };
        }

        public async Task<TransactionResponse> UpdateUserAsync(ModificarUsuarioRequest request)
        {
            await _usuarioRepository.UpdateUserAsync(request.ProjectedAs<Usuario>());
            await _unitOfWork.SaveAsync();

            return new TransactionResponse { Success = true };
        }

        public async Task<TransactionResponse> DeleteUserAsync(EliminarUsuarioRequest request)
        {
            await _usuarioRepository.DeleteUserAsync(request.ProjectedAs<Usuario>());
            await _unitOfWork.SaveAsync();

            return new TransactionResponse { Success = true };
        }

    }
}
