using Projeto_EBD.Controllers.Categoria;
using Projeto_EBD.Controllers.Sermao;
using System;
using System.Windows.Forms;

namespace Projeto_EBD.Janelas.Categorias
{
    public partial class ExcluirCatg : Form
    {
        catCRUD commCATEGCRUD = new catCRUD();
        sermCRUD commSERMAOCRUD = new sermCRUD();

        public event Action CategoriaExcluida;
        public ExcluirCatg()
        {
            InitializeComponent();

            commCATEGCRUD.CarregarCategorias(cbCat_exc);
        }

        private void btExcCatCancela_Click(object sender, System.EventArgs e)
        {
            DialogResult result = MessageBox.Show("Tem certeza que deseja desistir de excluir uma categoria?", "Cancelar exclusão", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                // Realizar ações de cancelamento, por exemplo, fechar o formulário
                this.Close();
            }
            // Se o usuário clicar em "No", a ação de cancelamento não será realizada
        }

        private void btExcCat_Click(object sender, System.EventArgs e)
        {
            // Verifica se alguma categoria foi selecionada (ignora o placeholder)
            if (cbCat_exc.SelectedValue != null && (int)cbCat_exc.SelectedValue != 0)
            {
                // Obtém o nome da categoria selecionada
                string categoriaSelecionada = cbCat_exc.Text;

                // Obtém o ID da categoria selecionada
                int idCategoriaSelecionada = (int)cbCat_exc.SelectedValue;

                var resultado = commSERMAOCRUD.BuscarSermoesPorCategoria(idCategoriaSelecionada);

                if (resultado)
                {
                    // Atualiza o ComboBox após exclusão
                    commCATEGCRUD.CarregarCategorias(cbCat_exc);

                    // Após a inserção, disparar o evento
                    CategoriaExcluida?.Invoke();
                }
            }
            else
            {
                MessageBox.Show("Por favor, selecione uma categoria válida!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
