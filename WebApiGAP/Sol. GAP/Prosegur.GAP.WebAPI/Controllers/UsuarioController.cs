using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Prosegur.GAP.Application.Interface;
using Prosegur.GAP.DTO;
using Prosegur.GAP.DTO.Mantenimiento.Request;
using Refit;
using Swashbuckle.AspNetCore.Annotations;

namespace Prosegur.GAP.WebAPI.Controllers
{
    [SwaggerTag("API que procesa la gestión de los usuarios")]
    [Route("api/[controller]")]
    [ApiController]
    public class UsuarioController : ControllerBase
    {
        private readonly IUsuarioService _usuarioService;

        public UsuarioController(IUsuarioService usuarioService)
        {
            _usuarioService = usuarioService;
        }

        [SwaggerOperation(
        Summary = "Servicio que consulta la información del usuario especifico",
        OperationId = "GetUserAsync")]
        [SwaggerResponse(200, "Información del usuario")]
        [SwaggerResponse(500, "Error interno en el servidor")]
        [HttpGet("get-userAsync")]
        public async Task<IActionResult> GetUserAsync(int idUsuario)
        {
            return Ok(await _usuarioService.GetUserAsync(idUsuario));
        }

        [SwaggerOperation(
        Summary = "Servicio que consulta la información de todos los usuarios",
        OperationId = "GetAllUsersAsync")]
        [SwaggerResponse(200, "Listado de usuarios")]
        [SwaggerResponse(500, "Error interno en el servidor")]
        [HttpGet("get-usersAsync")]
        public async Task<IActionResult> GetAllUsersAsync()
        {
            return Ok(await _usuarioService.GetUsersAsync());
        }

        [SwaggerOperation(
        Summary = "Servicio que registra un nuevo usuario con el rol por defecto USUARIO",
        OperationId = "PostUserAsync")]
        [SwaggerResponse(200, "Registro de un nuevo usuario exitoso")]
        [SwaggerResponse(500, "Error interno en el servidor")]
        [HttpPost("post-userAsync")]
        public async Task<IActionResult> PostUserAsync([Body] RegistrarUsuarioRequest request)
            {
            return Ok(await _usuarioService.PostUserAsync(request));
        }

        [SwaggerOperation(
        Summary = "Servicio que actualiza la información del usuario",
        OperationId = "UpdateUserAsync")]
        [SwaggerResponse(200, "Modificación de los datos del usuario exitosa")]
        [SwaggerResponse(500, "Error interno en el servidor")]
        [HttpPut("update-userAsync")]
        public async Task<IActionResult> UpdateUserAsync([FromBody] ModificarUsuarioRequest request)
        {
            return Ok(await _usuarioService.UpdateUserAsync(request));
        }

        [SwaggerOperation(
        Summary = "Servicio que elimina un usuario especifico",
        OperationId = "DeleteUserAsync")]
        [SwaggerResponse(200, "Eliminación Correcta")]
        [SwaggerResponse(500, "Error interno en el servidor")]
        [HttpPost("delete-userAsync")]
        public async Task<IActionResult> DeleteUserAsync([Body] EliminarUsuarioRequest request)
        {
            return Ok(await _usuarioService.DeleteUserAsync(request));
        }

        [SwaggerOperation(
        Summary = "Servicio valida que el usuario exista en el sistema",
        OperationId = "LogInAsync")]
        [SwaggerResponse(200, "Validación Correcta")]
        [SwaggerResponse(500, "Error interno en el servidor")]
        [HttpGet("get-loginAsync")]
        public async Task<IActionResult> GetLoginAsync(string logUsuario, string contrasena)
        {
            return Ok(await _usuarioService.GetLoginAsync(logUsuario, contrasena));
        }

    }
}
