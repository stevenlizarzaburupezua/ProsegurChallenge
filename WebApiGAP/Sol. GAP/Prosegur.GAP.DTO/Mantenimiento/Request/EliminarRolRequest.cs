using Newtonsoft.Json;
using Swashbuckle.AspNetCore.Annotations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prosegur.GAP.DTO.Mantenimiento.Request
{
    public class EliminarRolRequest
    {
        [JsonProperty("id")]
        [SwaggerSchema("Identificador del rol.")]
        public int Id { get; set; }

        [JsonProperty("nombre")]
        [SwaggerSchema("Nombre del Rol")]
        public string Nombre { get; set; }
    }
}
