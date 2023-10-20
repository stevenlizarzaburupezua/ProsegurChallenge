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
    public class RegistrarCategoriaDTO
    {
        [Display(Order = 0)]
        [JsonProperty("id")]
        [SwaggerSchema("Identificador de la categoria.")]
        public int Id { get; set; }

        [Display(Order = 1)]
        [JsonProperty("nombre")]
        [SwaggerSchema("Nombre de la categoría")]
        public string Nombre { get; set; }
    }
}
