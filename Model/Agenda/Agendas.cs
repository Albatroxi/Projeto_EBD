using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_EBD.Model.Agenda
{
    public class Agendas
    {
        public int id { get; set; }
        public int igreja_id { get; set; }
        public DateTime data { get; set; }
        public int categoria_id { get; set; }
        public int sermao_id { get; set; }
    }
}
