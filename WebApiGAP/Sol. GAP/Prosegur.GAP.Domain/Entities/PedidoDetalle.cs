using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prosegur.GAP.Domain.Entities
{
    public class PedidoDetalle
    {
        [Key]
        public int ID_DETALLE_PEDIDO { get; set; }

        [ForeignKey("Pedido")]
        public int ID_PEDIDO { get; set; }

        [ForeignKey("Producto")]
        public int ID_PRODUCTO { get; set; }

        [ForeignKey("EstadoPedido")]
        public int ID_ESTADO_PEDIDO { get; set; }

        public string METODO_PAGO { get; set; }

        public string DIRECCION_ENVIO { get; set; }

        public string INFORMACION_ENVIO { get; set; }

        public int CANTIDAD { get; set; }

        public decimal PRECIO { get; set; }

        public decimal TOTAL { get; set; }

        public virtual Pedido Pedido { get; set; }

        public virtual Producto Producto { get; set; }

        public virtual EstadoPedido EstadoPedido { get; set; }
    }
}
