using Projeto_EBD.DBContexto;
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
                Filter = "Arquivos Word (*.doc;*.docx)|*.doc;*.docx",
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
                    // Lê o arquivo como bytes
                    byte[] arquivoBytes = File.ReadAllBytes(caminhoArquivo);

                    // Cria uma nova instância de Sermao
                    var sermao = new Model.Sermoes.Sermoes
                    {
                        tema = tema,
                        id_categoria = categoriaId,
                        arquivo = arquivoBytes
                    };

                    // Adiciona o sermão ao contexto e salva
                    context.Sermoes.Add(sermao);
                    context.SaveChanges();

                    MessageBox.Show("Sermão cadastrado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Limpa os campos do formulário
                    lbnvSerm.Clear();
                    //cbCategoria.SelectedIndex = -1;
                    //txtArquivo.Clear();

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
