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
    public class RegistrarCategoriaRequest
    {
        [JsonProperty("nombre")]
        [SwaggerSchema("Nombre de la categoría")]
        public string Nombre { get; set; }

        [JsonProperty("flgActivo")]
        [SwaggerSchema("Flag que indica si la categoria se encuentra activa")]
        public bool FlagActivo { get; set; }

        [JsonProperty("fechaRegistro")]
        public string FechaRegistro { get; set; }
    }
}
