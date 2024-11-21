using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_EBD.Controllers.Categoria
{
    public class catTOOL
    {
        public void CarregarCategorias(ComboBox cbCategoria)
        {
            try
            {
                using (var context = new DBContexto.dbContexto())
                {
                    var categorias = context.Categorias.ToList();
                    // Criar um item em branco (ou "placeholder") e adicioná-lo à lista
                    categorias.Insert(0, new Model.Categoria.Categorias { id = 0, nome = "Selecione uma categoria" });

                    // Preencha o ComboBox com os nomes das categorias
                    cbCategoria.DataSource = categorias;
                    cbCategoria.DisplayMember = "nome"; // Exibe o nome da categoria
                    cbCategoria.ValueMember = "id"; // O valor será o Id da categoria

                }
            }
            catch (Exception ex)
            {
                // Tratamento genérico para outras exceções
                MessageBox.Show($"Ocorreu um erro inesperado ao carregar categorias.\nDetalhes: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
    }
}
