using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_EBD.Model.Sermoes
{
    public class Sermoes
    {
        public int id { get; set; }
        public string tema { get; set; }
        public byte[] arquivo { get; set; }
        public int id_categoria { get; set; }
    }
}
