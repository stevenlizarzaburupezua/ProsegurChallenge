using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prosegur.GAP.Domain.Entities
{
    public class PedidoDetalle
    {
        public int ID_DETALLE_PEDIDO { get; set; }

        [ForeignKey("Pedido")]
        public int ID_PEDIDO { get; set; }

        [ForeignKey("Producto")]
        public int ID_PRODUCTO { get; set; }

        public int CANTIDAD { get; set; }

        public decimal PRECIO { get; set; }

        public decimal TOTAL { get; set; }

        public virtual Pedido Pedido { get; set; }

        public virtual Producto Producto { get; set; }
    }
}
