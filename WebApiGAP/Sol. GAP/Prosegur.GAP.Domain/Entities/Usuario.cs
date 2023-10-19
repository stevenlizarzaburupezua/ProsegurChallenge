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
    public class Usuario : Entity
    {
        [Key]
        public int ID_USUARIO { get; set; }

        [ForeignKey("Rol")]
        public int ID_ROL { get; set; }

        public string LOG_USUARIO { get; set; }

        public string CONTRASENA { get; set; }

        public string PRIMER_NOMBRE { get; set; }

        public string SEGUNDO_NOMBRE { get; set; }  

        public string PRIMER_APELLIDO { get; set; }

        public string SEGUNDO_APELLIDO { get; set; }

        public string EMAIL { get; set; }

        public string DIRECCION { get; set; }

        public string TELEFONO { get; set; }

        public bool FLAG_ACTIVO { get; set; }

        public byte[]? IMG_USUARIO { get; set; }

        public DateTime FEC_REGISTRO { get; set; }


        public virtual Rol Rol { get; set; }
    }
}
