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
    public class SesionDTO
    {
        [Display(Order = 0)]
        [JsonProperty("idUsuario")]
        [SwaggerSchema("Identificador del usuario.")]
        public int IdUsuario { get; set; }

        [Display(Order = 1)]
        [JsonProperty("nombreCompleto")]
        [SwaggerSchema("Nombre completo del usuario.")]
        public string NombreCompleto { get; set; }

        [Display(Order = 2)]
        [JsonProperty("logUsuario")]
        [SwaggerSchema("Usuario Login para el acceso al sistema.")]
        public string LogUsuario { get; set; }

        [Display(Order = 3)]
        [JsonProperty("rol")]
        [SwaggerSchema("Rol del Usuario")]
        public string Rol { get; set; }

    }
}
