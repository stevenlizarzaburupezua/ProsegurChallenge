using Prosegur.GAP.Application.Interface;
using Prosegur.GAP.Domain.Entities;
using Prosegur.GAP.Domain.Interface.Repository;
using Prosegur.GAP.Domain.Seedwork;
using Prosegur.GAP.DTO;
using Prosegur.GAP.DTO.Mantenimiento.Request;
using Prosegur.GAP.DTO.Mantenimiento.Response;
using Rep.Traserep.Infra.CrossCutting.Adapter;

namespace Prosegur.GAP.Application.Implementation
{
    public class RolService : IRolService
    {
        private readonly IRolRepository _rolRepository;
        private readonly IUnitOfWork _unitOfWork;

        public RolService(IRolRepository rolRepository,
                          IUnitOfWork unitOfWork)
        {
            _rolRepository = rolRepository;
            _unitOfWork = unitOfWork;
        }

        public async Task<RolDTO> GetRolAsync(int idRol)
        {
            return (await _rolRepository.GetRolAsync(idRol)).ProjectedAs<RolDTO>();
        }

        public async Task<IList<RolDTO>> GetRolesAsync()
        {
            return (await _rolRepository.GetRolesAsync()).ProjectedAs<List<RolDTO>>();
        }

        public async Task<TransactionResponse> PostRolAsync(RegistrarRolRequest request)
        {
            await _rolRepository.InsertRolAsync(request.ProjectedAs<Rol>());
            await _unitOfWork.SaveAsync();

            return new TransactionResponse { Success = true };
        }

        public async Task<TransactionResponse> UpdateRolAsync(ModificarRolRequest request)
        {
            await _rolRepository.UpdateRolAsync(request.ProjectedAs<Rol>());
            await _unitOfWork.SaveAsync();

            return new TransactionResponse { Success = true};
        }

        public async Task<TransactionResponse> DeleteRolAsync(EliminarRolRequest request)
        {
            await _rolRepository.DeleteRolAsync(request.ProjectedAs<Rol>());
            await _unitOfWork.SaveAsync();

            return new TransactionResponse { Success = true };
        }

    }
}
