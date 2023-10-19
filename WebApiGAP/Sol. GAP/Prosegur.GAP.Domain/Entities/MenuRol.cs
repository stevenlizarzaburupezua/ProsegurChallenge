using System.ComponentModel.DataAnnotations.Schema;

namespace Prosegur.GAP.Domain.Entities
{
    public class MenuRol
    {
        public int ID_MENUROL { get; set; }

        [ForeignKey("Menu")]
        public int ID_MENU { get; set; }

        [ForeignKey("Rol")]
        public int ID_ROL { get; set; }

        public virtual Rol Rol { get; set; }

        public virtual Menu Menu { get; set; }

    }
}
