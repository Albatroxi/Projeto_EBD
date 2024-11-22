using Projeto_EBD.Controllers.Categoria;
using Projeto_EBD.Controllers.Sermao;
using System;
using System.Windows.Forms;

namespace Projeto_EBD.Janelas.Sermaos
{
    public partial class AdicionarSerm : Form
    {
        catTOOL commCATEGTOOL = new catTOOL();

        sermTOOL commSERMTOOL = new sermTOOL();
        sermCRUD commCRUD = new sermCRUD();

        // Definir o evento
        public event Action SermaoAdicionado;
        public AdicionarSerm()
        {
            InitializeComponent();

            //Carregar as categorias
            commCATEGTOOL.CarregarCategorias(cbCategoriaaddSERM);
        }

        private void addSermDOCs_Click(object sender, EventArgs e)
        {
            string fileUploadNome = commSERMTOOL.carregarArquivoSermao();

            camSermArquiv.Text = fileUploadNome; // Exibe o caminho do arquivo selecionado
        }

        private void inserSerm_Click(object sender, EventArgs e)
        {
            string tema = lbnvSerm.Text;
            string caminhoArquivo = camSermArquiv.Text;
            int categoriaId = 1;

            if (string.IsNullOrWhiteSpace(tema) || string.IsNullOrWhiteSpace(caminhoArquivo) || categoriaId <= 0)
            {
                MessageBox.Show("Por favor, preencha todos os campos.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var categoriaSelecionada = cbCategoriaaddSERM.SelectedItem as Model.Categoria.Categorias; // Categoria é o tipo da sua classe

            bool resultado =  commCRUD.addSermao(tema, caminhoArquivo, categoriaSelecionada.id);

            if (resultado)
            {
                // Após a inserção, disparar o evento
                SermaoAdicionado?.Invoke();

                // Fechar o formulário AddCat após adicionar
                this.Close();
            }
        }

        private void cbCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
