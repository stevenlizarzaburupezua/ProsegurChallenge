using Microsoft.AspNetCore.Mvc;
using Prosegur.GAP.Application.Interface;
using Prosegur.GAP.DTO.Mantenimiento.Request;
using Swashbuckle.AspNetCore.Annotations;

namespace Prosegur.GAP.WebAPI.Controllers
{
    [SwaggerTag("API que procesa la gestión de los roles")]
    [Route("api/[controller]")]
    [ApiController]
    public class RolController : ControllerBase
    {
        private readonly IRolService _rolService;

        public RolController(IRolService rolService)
        {
            _rolService = rolService;
        }

        [SwaggerOperation(
        Summary = "Servicio que consulta la información del rol especifico",
        OperationId = "GetRolAsync")]
        [SwaggerResponse(200, "Información del rol")]
        [SwaggerResponse(500, "Error interno en el servidor")]
        [HttpGet("get-rolAsync")]
        public async Task<IActionResult> GetRolAsync(int idRol)
        {
            return Ok(await _rolService.GetRolAsync(idRol));
        }

        [SwaggerOperation(
        Summary = "Servicio que consulta la información de todos los roles",
        OperationId = "GetAllRolesAsync")]
        [SwaggerResponse(200, "Listado de roles")]
        [SwaggerResponse(500, "Error interno en el servidor")]
        [HttpGet("get-rolesAsync")]
        public async Task<IActionResult> GetAllRolesAsync()
        {
            return Ok(await _rolService.GetRolesAsync());
        }

        [SwaggerOperation(
        Summary = "Servicio que registra un nuevo rol",
        OperationId = "PostRolAsync")]
        [SwaggerResponse(200, "Registro de un nuevo rol exitoso")]
        [SwaggerResponse(500, "Error interno en el servidor")]
        [HttpPost("post-rolAsync")]
        public async Task<IActionResult> PostRolAsync([FromBody] RegistrarRolRequest request)
        {
            return Ok(await _rolService.PostRolAsync(request));
        }

        [SwaggerOperation(
        Summary = "Servicio que actualiza la información de un rol especifico",
        OperationId = "UpdateRolAsync")]
        [SwaggerResponse(200, "Modificación de los datos del rol Exitosa")]
        [SwaggerResponse(500, "Error interno en el servidor")]
        [HttpPut("update-rolAsync")]
        public async Task<IActionResult> UpdateRolAsync([FromBody] ModificarRolRequest request)
        {
            return Ok(await _rolService.UpdateRolAsync(request));
        }

        [SwaggerOperation(
        Summary = "Servicio que elimina un rol especifico",
        OperationId = "DeleteRolAsync")]
        [SwaggerResponse(200, "Eliminación Correcta")]
        [SwaggerResponse(500, "Error interno en el servidor")]
        [HttpDelete("delete-rolAsync")]
        public async Task<IActionResult> DeleteRolAsync([FromBody] EliminarRolRequest request)
        {
            return Ok(await _rolService.DeleteRolAsync(request));
        }

    }
}
