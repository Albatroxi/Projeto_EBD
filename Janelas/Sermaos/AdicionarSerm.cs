using Projeto_EBD.DBContexto;
using Projeto_EBD.Model.Sermoes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_EBD.Janelas.Sermaos
{
    public partial class AdicionarSerm : Form
    {
        // Definir o evento
        public event Action SermaoAdicionado;
        public AdicionarSerm()
        {
            InitializeComponent();
        }

        private void addSermDOCs_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "Arquivos PDF (*.pdf)|*.pdf",
                Title = "Selecione o Arquivo do Sermão"
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                camSermArquiv.Text = openFileDialog.FileName; // Exibe o caminho do arquivo selecionado
            }
        }

        private void inserSerm_Click(object sender, EventArgs e)
        {
            using (var context = new dbContexto())
            {
                string tema = lbnvSerm.Text;
                //string categoria = cbCategoria.Text;
                //int categoriaId = (int)cbCategoria.SelectedValue; // Obtém o ID selecionado
                int categoriaId = 1; // Obtém o ID selecionado

                string caminhoArquivo = camSermArquiv.Text;

                if (string.IsNullOrWhiteSpace(tema) || string.IsNullOrWhiteSpace(caminhoArquivo) || categoriaId <= 0)
                {
                    MessageBox.Show("Por favor, preencha todos os campos.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                try
                {
                    byte[] arquivoBytes = File.ReadAllBytes(caminhoArquivo); // Carregar o arquivo como byte[]

                    var sermao = new Sermoes
                    {
                        tema = tema,
                        arquivo = arquivoBytes,
                        id_categoria = categoriaId
                    };

                    context.Sermoes.Add(sermao);
                    context.SaveChanges(); // Salvar no banco

                    MessageBox.Show("Sermão cadastrado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Após a inserção, disparar o evento
                    SermaoAdicionado?.Invoke();

                    // Fechar o formulário AddCat após adicionar
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Erro ao salvar o sermão: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

    }
}
