using Projeto_EBD.Model.Categoria;
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
            // Chamada para garantir a criação do banco
            //VerificarECriarBanco();
        }

        private void VerificarECriarBanco()
        {
            if (!Database.Exists())
            {
                // Cria o banco de dados com base no modelo
                Database.Create();
            }
        }

        public DbSet<Categorias> Categorias { get; set; }


    }
}
