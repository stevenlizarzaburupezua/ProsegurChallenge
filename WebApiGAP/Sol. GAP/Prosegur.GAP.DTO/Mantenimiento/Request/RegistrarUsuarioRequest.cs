using Newtonsoft.Json;
using Swashbuckle.AspNetCore.Annotations;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prosegur.GAP.DTO.Mantenimiento.Request
{
    public class RegistrarUsuarioRequest
    {
        [JsonProperty("idUsuario")]
        [SwaggerSchema("id del usuario")]
        public int IdUsuario { get; set; }

        [JsonProperty("idRol")]
        [SwaggerSchema("Rol del usuario")]
        public int IdRol { get; set; }

        [JsonProperty("logUsuario")]
        [SwaggerSchema("Usuario Login para el acceso al sistema.")]
        public string LogUsuario { get; set; }

        [JsonProperty("contrasena")]
        [SwaggerSchema("Contraseña del usuario.")]
        public string Contrasena { get; set; }

        [JsonProperty("primerNombre")]
        [SwaggerSchema("Primer nombre del usuario.")]
        public string PrimerNombre { get; set; }

        [JsonProperty("segundoNombre")]
        [SwaggerSchema("Segundo nombre del usuario.")]
        public string SegundoNombre { get; set; }

        [JsonProperty("primerApellido")]
        [SwaggerSchema("Primer apellido del usuario.")]
        public string PrimerApellido { get; set; }

        [JsonProperty("segundoApellido")]
        [SwaggerSchema("Segundo apellido del usuario.")]
        public string SegundoApellido { get; set; }

        [JsonProperty("email")]
        [SwaggerSchema("Correo electrónico del usuario.")]
        public string Email { get; set; }

        [JsonProperty("direccion")]
        [SwaggerSchema("Dirección del usuario.")]
        public string Direccion { get; set; }

        [JsonProperty("telefono")]
        [SwaggerSchema("Teléfono del usuario.")]
        public string Telefono { get; set; }

        [JsonProperty("imagen")]
        [SwaggerSchema("Imagen del usuario en base64.")]
        public string Imagen { get; set; }
    }
}
