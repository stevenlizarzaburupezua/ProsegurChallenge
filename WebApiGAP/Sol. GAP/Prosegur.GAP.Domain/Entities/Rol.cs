using Prosegur.GAP.Domain.Seedwork;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prosegur.GAP.Domain.Entities
{
    public class Rol : Entity
    {
        [Key]
        public int ID_ROL { get; set; }

        public string ROL { get; set; }

        public string DESCRIPCION { get; set; }

        public bool FLAG_ACTIVO { get; set; }

        public DateTime FEC_REGISTRO { get; set; }

    }
}
