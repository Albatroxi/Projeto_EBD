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

        public void CarregarCategorias(ComboBox cbCategorias)
        {
            try
            {
                using (var context = new DBContexto.dbContexto())
                {
                    var categorias = context.Categorias.ToList();
                    // Criar um item em branco (ou "placeholder") e adicioná-lo à lista
                    categorias.Insert(0, new Model.Categoria.Categorias { id = 0, nome = "Selecione uma Categoria" });

                    // Preencha o ComboBox com os nomes das igreja
                    cbCategorias.DataSource = categorias;
                    cbCategorias.DisplayMember = "nome"; // Exibe o nome da igreja
                    cbCategorias.ValueMember = "id"; // O valor será o Id da igreja

                }
            }
            catch (Exception ex)
            {
                // Tratamento genérico para outras exceções
                MessageBox.Show($"Ocorreu um erro inesperado ao carregar as informações de Categorias.\nDetalhes: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        public bool ExcluirCategoria(int idCategoria)
        {
            try
            {
                using (var context = new DBContexto.dbContexto())
                {
                    // Localiza a categoria pelo ID
                    var categoria = context.Categorias.FirstOrDefault(c => c.id == idCategoria);
                    if (categoria != null)
                    {
                        // Remove a categoria
                        context.Categorias.Remove(categoria);

                        // Salva as alterações no banco de dados
                        context.SaveChanges();

                        MessageBox.Show("Categoria excluída com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        return true;
                    }
                    else
                    {
                        MessageBox.Show("Categoria não encontrada. Verifique o ID.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao excluir a categoria.\nDetalhes: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return false;
        }

    }
}
