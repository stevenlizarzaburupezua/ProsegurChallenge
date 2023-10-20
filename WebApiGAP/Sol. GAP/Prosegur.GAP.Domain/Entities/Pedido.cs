using Prosegur.GAP.Domain.Seedwork;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prosegur.GAP.Domain.Entities
{
    public class Pedido : Entity
    {
        [Key]
        public int ID_PEDIDO { get; set; }

        public int ID_CLIENTE { get; set; }

        public int ID_PRODUCTO { get; set; }

        [ForeignKey("PedidoDetalle")]
        public int ID_DETALLE_PEDIDO { get; set; }

        public string NOTAS_CLIENTE { get; set; }

        public DateTime FECHA_PEDIDO { get; set; }

        public DateTime FECHA_ENTREGA_ESTIMADA { get; set; }
            
        public virtual PedidoDetalle PedidoDetalle { get; set; }

    }
}
