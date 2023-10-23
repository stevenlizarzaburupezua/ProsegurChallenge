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
    public class ModificarUsuarioDTO
    {
        [Display(Order = 0)]
        [JsonProperty("transactionSuccess")]
        [SwaggerSchema("flag que indica si la operacion se realizó correctamente")]
        public bool TransactionSuccess { get; set; }

        [Display(Order = 1)]
        [JsonProperty("id")]
        [SwaggerSchema("Identificador del usuario.")]
        public int Id { get; set; }

        [Display(Order = 2)]
        [JsonProperty("idRol")]
        [SwaggerSchema("ID Rol del Usuario")]
        public int IdRol { get; set; }

        [Display(Order = 3)]
        [JsonProperty("logUsuario")]
        [SwaggerSchema("Usuario Login para el acceso al sistema.")]
        public string LogUsuario { get; set; }

        [Display(Order = 4)]
        [JsonProperty("contrasena")]
        [SwaggerSchema("Contraseña del usuario.")]
        public string Contrasena { get; set; }

        [Display(Order = 5)]
        [JsonProperty("primerNombre")]
        [SwaggerSchema("Primer nombre del usuario.")]
        public string PrimerNombre { get; set; }

        [Display(Order = 6)]
        [JsonProperty("segundoNombre")]
        [SwaggerSchema("Segundo nombre del usuario.")]
        public string SegundoNombre { get; set; }

        [Display(Order = 7)]
        [JsonProperty("primerApellido")]
        [SwaggerSchema("Primer apellido del usuario.")]
        public string PrimerApellido { get; set; }

        [Display(Order = 8)]
        [JsonProperty("segundoApellido")]
        [SwaggerSchema("Segundo apellido del usuario.")]
        public string SegundoApellido { get; set; }

        [Display(Order = 9)]
        [JsonProperty("email")]
        [SwaggerSchema("Correo electrónico del usuario.")]
        public string Email { get; set; }

        [Display(Order = 10)]
        [JsonProperty("direccion")]
        [SwaggerSchema("Dirección del usuario.")]
        public string Direccion { get; set; }

        [Display(Order = 11)]
        [JsonProperty("telefono")]
        [SwaggerSchema("Teléfono del usuario.")]
        public string Telefono { get; set; }

        [Display(Order = 12)]
        [JsonProperty("flgActivo")]
        [SwaggerSchema("Flag que indica si el usuario se encuentra activo.")]
        public bool FlagActivo { get; set; }

        [Display(Order = 13)]
        [JsonProperty("flgAdministrador")]
        [SwaggerSchema("Flag que indica si el usuario tiene privilegios de administrador.")]
        public bool FlagAdministrador { get; set; }

        [Display(Order = 14)]
        [JsonProperty("imagen")]
        [SwaggerSchema("Imagen del usuario en base64.")]
        public byte[]? Imagen { get; set; }

    }
}
