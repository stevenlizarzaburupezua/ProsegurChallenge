using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prosegur.GAP.Domain.Entities
{
    public class Menu
    {
        [Key]
        public int ID_MENU { get; set; }

        public string NOMBRE { get; set; }

        public string IMG { get; set; }

        public string PATH { get; set; }

    }
}
