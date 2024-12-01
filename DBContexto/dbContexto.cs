using Projeto_EBD.Model.Categoria;
using Projeto_EBD.Model.Igrejas;
using Projeto_EBD.Model.Sermoes;
using System.Data.Entity;

namespace Projeto_EBD.DBContexto
{
    public class dbContexto : DbContext
    {
        public dbContexto() : base("name=SQLiteConnection")
        {
        }
        public DbSet<Categorias> Categorias { get; set; }
        public DbSet<Sermoes> Sermoes { get; set; }
        public DbSet<Igrejas> Igrejas { get; set; }
    }
}
