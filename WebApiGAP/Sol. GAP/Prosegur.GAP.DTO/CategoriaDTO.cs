using Newtonsoft.Json;
using Swashbuckle.AspNetCore.Annotations;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prosegur.GAP.DTO
{
    public class CategoriaDTO
    {
        [Display(Order = 0)]
        [JsonProperty("id")]
        [SwaggerSchema("id de la categoría")]
        public int Id { get; set; }

        [Display(Order = 1)]
        [JsonProperty("nombre")]
        [SwaggerSchema("Nombre de la categoría")]
        public string Nombre { get; set; }

        [Display(Order = 2)]
        [JsonProperty("flgActivo")]
        [SwaggerSchema("Flag que indica si la categoria se encuentra activa")]
        public bool FlagActivo { get; set; }

        [Display(Order = 3)]
        [JsonProperty("fechaRegistro")]
        [SwaggerSchema("Fecha del registro de la categoria")]
        public string FechaRegistro { get; set; }

    }
}
