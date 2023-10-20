using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prosegur.GAP.Domain.Entities
{
    public class EstadoPedido
    {
        [Key]
        public int ID_ESTADO { get; set; }

        public string ESTADO { get; set; }

        public string DESCRIPCION { get; set; }
    }
}
