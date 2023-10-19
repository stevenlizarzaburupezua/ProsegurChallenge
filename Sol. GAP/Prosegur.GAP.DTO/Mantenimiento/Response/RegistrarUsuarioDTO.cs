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
    public class RegistrarUsuarioDTO
    {
        [JsonProperty("transactionSuccess")]
        [SwaggerSchema("flag que indica si la operacion se realizó correctamente")]
        public bool TransactionSuccess { get; set; }

        [Display(Order = 0)]
        [JsonProperty("logUsuario")]
        [SwaggerSchema("Usuario Login para el acceso al sistema.")]
        public string LogUsuario { get; set; }

        [Display(Order = 1)]
        [JsonProperty("contrasena")]
        [SwaggerSchema("Contraseña del usuario.")]
        public string Contrasena { get; set; }

        [Display(Order = 2)]
        [JsonProperty("primerNombre")]
        [SwaggerSchema("Primer nombre del usuario.")]
        public string PrimerNombre { get; set; }

        [Display(Order = 3)]
        [JsonProperty("segundoNombre")]
        [SwaggerSchema("Segundo nombre del usuario.")]
        public string SegundoNombre { get; set; }

        [Display(Order = 4)]
        [JsonProperty("primerApellido")]
        [SwaggerSchema("Primer apellido del usuario.")]
        public string PrimerApellido { get; set; }

        [Display(Order = 5)]
        [JsonProperty("segundoApellido")]
        [SwaggerSchema("Segundo apellido del usuario.")]
        public string SegundoApellido { get; set; }

        [Display(Order = 6)]
        [JsonProperty("email")]
        [SwaggerSchema("Correo electrónico del usuario.")]
        public string Email { get; set; }

        [Display(Order = 7)]
        [JsonProperty("direccion")]
        [SwaggerSchema("Dirección del usuario.")]
        public string Direccion { get; set; }

        [Display(Order = 8)]
        [JsonProperty("telefono")]
        [SwaggerSchema("Teléfono del usuario.")]
        public string Telefono { get; set; }

        [Display(Order = 9)]
        [JsonProperty("imagen")]
        [SwaggerSchema("Imagen del usuario en base64.")]
        public string Imagen { get; set; }

    }
}
