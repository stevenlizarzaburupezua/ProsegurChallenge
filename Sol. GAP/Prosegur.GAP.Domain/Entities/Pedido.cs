using Prosegur.GAP.Domain.Seedwork;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prosegur.GAP.Domain.Entities
{
    public class Pedido : Entity  
    {
        [Key]
        public int ID_PEDIDO { get; set; }

        public string NUMERO_DOCUMENTO { get; set; }

        public string TIPO_PAGO { get; set; }

        public decimal TOTAL { get; set; }

        public DateTime FECHA_REGISTRO { get; set; }


    }
}
