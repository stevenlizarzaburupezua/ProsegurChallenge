using Newtonsoft.Json;
using Swashbuckle.AspNetCore.Annotations;
using System.ComponentModel.DataAnnotations;

namespace Prosegur.GAP.DTO.Mantenimiento.Response
{
    public class EliminarRolDTO
    {
        [Display(Order = 0)]
        [JsonProperty("transactionSuccess")]
        [SwaggerSchema("flag que indica si la operacion se realizó correctamente")]
        public bool TransactionSuccess { get; set; }

        [Display(Order = 1)]
        [JsonProperty("id")]
        [SwaggerSchema("Identificador del rol.")]
        public int Id { get; set; }

        [Display(Order = 2)]
        [JsonProperty("nombre")]
        [SwaggerSchema("Nombre del Rol")]
        public string Nombre { get; set; }
    }
}
