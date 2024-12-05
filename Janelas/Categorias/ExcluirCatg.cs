using Projeto_EBD.Controllers.Categoria;
using System.Windows.Forms;

namespace Projeto_EBD.Janelas.Categorias
{
    public partial class ExcluirCatg : Form
    {
        catCRUD commCATEGCRUD = new catCRUD();
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
    }
}
