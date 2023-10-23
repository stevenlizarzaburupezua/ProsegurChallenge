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
    public class ReporteDTO
    {
        [Display(Order = 0)]
        [JsonProperty("numeroDocumento")]
        [SwaggerSchema("Numero de Documento del")]
        public int Id { get; set; }

        [Display(Order = 1)]
        [JsonProperty("nombre")]
        [SwaggerSchema("Nombre del producto")]
        public string Nombre { get; set; }

        [Display(Order = 2)]
        [JsonProperty("descripcion")]
        [SwaggerSchema("Descripción del producto")]
        public string Descripcion { get; set; }

        [Display(Order = 3)]
        [JsonProperty("idCategoria")]
        [SwaggerSchema("Id de la categoría del producto")]
        public int IdCategoria { get; set; }

        [Display(Order = 4)]
        [JsonProperty("stock")]
        [SwaggerSchema("Stock del producto")]
        public int Stock { get; set; }

        [Display(Order = 5)]
        [JsonProperty("precio")]
        [SwaggerSchema("Precio del producto")]
        public decimal Precio { get; set; }

        [Display(Order = 6)]
        [JsonProperty("flgActivo")]
        [SwaggerSchema("Flag que indica si la categoria se encuentra activa")]
        public bool FlagActivo { get; set; }

        [Display(Order = 7)]
        [JsonProperty("fechaRegistro")]
        [SwaggerSchema("Fecha de registro del producto")]
        public string FechaRegistro { get; set; }
    }
}
