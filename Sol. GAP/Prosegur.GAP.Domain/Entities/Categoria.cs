using Prosegur.GAP.Domain.Seedwork;
using System.ComponentModel.DataAnnotations;

namespace Prosegur.GAP.Domain.Entities
{
    public class Categoria : Entity
    {
        [Key]
        public int ID_CATEGORIA { get; set; }

        public string NOMBRE { get; set; }

        public bool FLAG_ACTIVO { get; set; }

        public DateTime FEC_REGISTRO { get; set; }
    }
}
