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
    public class EliminarUsuarioRequest
    {
        [JsonProperty("id")]
        [SwaggerSchema("Identificador del usuario.")]
        public int Id { get; set; }

        [JsonProperty("logUsuario")]
        [SwaggerSchema("Usuario Login para el acceso al sistema.")]
        public string LogUsuario { get; set; }
    }
}
