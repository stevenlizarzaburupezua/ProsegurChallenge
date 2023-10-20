using Newtonsoft.Json;
using Swashbuckle.AspNetCore.Annotations;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prosegur.GAP.DTO.Login.Response
{
    public class LoginDTO
    {
        [Display(Order = 0)]
        [JsonProperty("logUsuario")]
        [SwaggerSchema("Usuario Login para el acceso al sistema.")]
        public string LogUsuario { get; set; }

        [Display(Order = 1)]
        [JsonProperty("contrasena")]
        [SwaggerSchema("Contraseña del usuario.")]
        public string Contrasena { get; set; }

    }
}
