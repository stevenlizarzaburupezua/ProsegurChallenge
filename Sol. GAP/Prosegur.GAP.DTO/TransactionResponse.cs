using Swashbuckle.AspNetCore.Annotations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prosegur.GAP.DTO
{
    public class TransactionResponse
    {
        [SwaggerSchema("Flag que indica que la transacción es correcta.")]
        public bool Success { get; set; }

        [SwaggerSchema("Código del error.")]
        public string Codigo { get; set; }

        [SwaggerSchema("Mensaje de validación o error.")]
        public string Mensaje { get; set; }

        public object Data { get; set; }

    }



}
