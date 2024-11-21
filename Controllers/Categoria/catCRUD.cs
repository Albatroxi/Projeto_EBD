using Projeto_EBD.DBContexto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_EBD.Controllers.Categoria
{
    public class catCRUD
    {
        public bool addCategoria(string catNome)
        {
            try
            {
                // Verificando se o nome não está vazio
                if (!string.IsNullOrWhiteSpace(catNome))
                {
                    // Usando o contexto do banco de dados para adicionar a pessoa
                    using (var context = new dbContexto())
                    {
                        Model.Categoria.Categorias novaCategoria = new Model.Categoria.Categorias { nome = catNome };
                        context.Categorias.Add(novaCategoria);
                        context.SaveChanges();
                    }

                    return true;

                }
                else
                {
                    // Caso o nome esteja vazio ou inválido
                    MessageBox.Show("É necessário informar um nome para a nova categoria.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao salvar o categoria: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

            return false;
        }
    }
}
