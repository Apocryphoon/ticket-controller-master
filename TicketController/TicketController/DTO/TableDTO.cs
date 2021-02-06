using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketController.DTO
{
    public class TableDTO
    {
        public int id { get; set; }
        public string id_cliente { get; set; }
        public string nm_cliente { get; set; }
        public string ds_status { get; set; }
        public DateTime dt_create { get; set; }
        public bool ds_visible { get; set; }
        public string ds_obs { get; set; }
        public string nm_responsavel { get; set; }
    }
}
