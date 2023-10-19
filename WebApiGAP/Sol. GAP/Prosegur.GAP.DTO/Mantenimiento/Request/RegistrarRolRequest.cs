using Newtonsoft.Json;
using Swashbuckle.AspNetCore.Annotations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prosegur.GAP.DTO.Mantenimiento.Request
{
    public class RegistrarRolRequest
    {
        [JsonProperty("nombre")]
        [SwaggerSchema("Nombre del Rol")]
        public string Nombre { get; set; }

        [JsonProperty("descripcion")]
        [SwaggerSchema("Descripción del Rol")]
        public string Descripcion { get; set; }

        [JsonProperty("fechaRegistro")]
        public string FechaRegistro { get; set; }

    }
}
