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
    public class ModificarRolRequest
    {
        [JsonProperty("id")]
        [SwaggerSchema("Identificador del rol.")]
        public int Id { get; set; }

        [JsonProperty("nombre")]
        [SwaggerSchema("Nombre del Rol")]
        public string Nombre { get; set; }

        [JsonProperty("descripcion")]
        [SwaggerSchema("Descripción del Rol")]
        public string Descripcion { get; set; }

        [JsonProperty("flgActivo")]
        [SwaggerSchema("Flag que indica si el rol se encuentra activo")]
        public bool FlagActivo { get; set; }
    }
}
