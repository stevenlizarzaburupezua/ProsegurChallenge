using Prosegur.GAP.Domain.Seedwork;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Prosegur.GAP.Domain.Entities
{
    public class Producto : Entity
    {
        [Key]
        public int ID_PRODUCTO { get; set; }

        public string NOMBRE { get; set; }

        public string DESCRIPCION { get; set; }

        [ForeignKey("Categoria")]
        public int ID_CATEGORIA { get; set; }

        public int STOCK { get; set; }

        public decimal PRECIO { get; set; }

        public bool FLAG_ACTIVO { get; set; }

        public DateTime FEC_REGISTRO { get; set; }

        public virtual Categoria Categoria { get; set; }

    }
}
