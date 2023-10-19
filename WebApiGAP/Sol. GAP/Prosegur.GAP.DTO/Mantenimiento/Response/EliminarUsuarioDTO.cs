using Newtonsoft.Json;
using Swashbuckle.AspNetCore.Annotations;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prosegur.GAP.DTO.Mantenimiento.Response
{
    public class EliminarUsuarioDTO
    {
        [Display(Order = 0)]
        [JsonProperty("id")]
        [SwaggerSchema("Identificador del usuario.")]
        public int Id { get; set; }

        [Display(Order = 1)]
        [JsonProperty("logUsuario")]
        [SwaggerSchema("Usuario Login para el acceso al sistema.")]
        public string LogUsuario { get; set; }
    }
}
