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
    public class RolDTO
    {
        [Display(Order = 0)]
        [JsonProperty("id")]
        [SwaggerSchema("Identificador del rol.")]
        public int Id { get; set; }

        [Display(Order = 1)]
        [JsonProperty("nombre")]
        [SwaggerSchema("Nombre del Rol")]
        public string Nombre { get; set; }

        [Display(Order = 2)]
        [JsonProperty("descripcion")]
        [SwaggerSchema("Descripción del Rol")]
        public string Descripcion { get; set; }

        [Display(Order = 3)]
        [JsonProperty("flgActivo")]
        [SwaggerSchema("Flag que indica si el rol se encuentra activo")]
        public bool FlagActivo { get; set; }

        [Display(Order = 4)]
        [JsonProperty("fechaRegistro")]
        [SwaggerSchema("Fecha que indica el registro del rol")]
        public DateTime FechaRegistro { get; set; }

        [Display(Order = 5)]
        [JsonProperty("fechaRegistroCadena")]
        [SwaggerSchema("Fecha que indica el registro del rol en formato dd/MM/yyyyy")]
        public string FechaRegistroCadena { get => FechaRegistro.ToString("dd/MM/yyyyy"); }

    }
}
