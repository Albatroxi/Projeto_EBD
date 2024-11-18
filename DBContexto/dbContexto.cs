using Projeto_EBD.Model.Categoria;
using Projeto_EBD.Model.Sermoes;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_EBD.DBContexto
{
    public class dbContexto : DbContext
    {
        public dbContexto() : base("name=SQLiteConnection")
        {
        }
        public DbSet<Categorias> Categorias { get; set; }

        public DbSet<Sermoes> Sermoes { get; set; }
    }
}
