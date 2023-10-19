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
    public class RegistrarRolDTO
    {
        [Display(Order = 0)]
        [JsonProperty("transactionSuccess")]
        [SwaggerSchema("flag que indica si la operacion se realizó correctamente")]
        public bool TransactionSuccess { get; set; }

        [Display(Order = 1)]
        [JsonProperty("idRol")]
        [SwaggerSchema("Identificador del nuevo rol generado")]
        public int IdRol { get; set; }

        [Display(Order = 2)]
        [JsonProperty("nombre")]
        [SwaggerSchema("Nombre del Rol")]
        public string Nombre { get; set; }

        [Display(Order = 3)]
        [JsonProperty("descripcion")]
        [SwaggerSchema("Descripción del Rol")]
        public string Descripcion { get; set; }

    }
}
