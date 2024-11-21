using Microsoft.Office.Interop.Word;
using Projeto_EBD.Controllers.Categoria;
using Projeto_EBD.Controllers.Ferramentas;
using Projeto_EBD.DBContexto;
using Projeto_EBD.Janelas.Categorias;
using Projeto_EBD.Janelas.Sermaos;
using System;
using System.Data;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using Application = Microsoft.Office.Interop.Word.Application;

namespace Projeto_EBD.Janelas
{
    public partial class Home : Form
    {
        private Application wordApp;
        private Document wordDocument;

        string tempFile = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, Guid.NewGuid() + ".doc");

        catTOOL commCATEGTOOL = new catTOOL();

        visualizadorTOOL commVISUTOOL = new visualizadorTOOL();

        public Home()
        {
            InitializeComponent();

            string dbPath = AppDomain.CurrentDomain.GetData("DataDirectory") + @"projEBD.sqlite";

            //Carregar as categorias
            //commCATEGTOOL.CarregarCategorias(cbCategoria);

            CarregarTreeView();

            wordApp = new Application();

            // Assinar o evento de fechamento do documento
            wordApp.DocumentBeforeClose += WordApp_DocumentBeforeClose;
        }

        private void Adicionar_Click(object sender, EventArgs e)
        {

        }

        private void Excluir_Click(object sender, EventArgs e)
        {

        }

        private void adicionarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                // Criar instância do formulário AddCat
                AdicionarCatg addCatForm = new AdicionarCatg
                {
                    StartPosition = FormStartPosition.CenterParent // Centralizar no formulário pai
                };

                // Assinar o evento para atualizar o ComboBox quando a categoria for adicionada                
                addCatForm.CategoriaAdicionada += () =>
                {
                    // Recarregar as categorias no ComboBox
                    //commCATEGTOOL.CarregarCategorias(cbCategoria);
                    CarregarTreeView();
                };
                

                // Mostrar o formulário AddCat como modal
                addCatForm.ShowDialog(this);
            }
            catch (Exception ex)
            {
                // Tratamento genérico para outras exceções
                MessageBox.Show($"Ocorreu um erro inesperado ao iniciar a adição de categoria..\nDetalhes: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        

        private void WordApp_DocumentBeforeClose(Document doc, ref bool cancel)
        {
            // Exibir a mensagem de confirmação
            var resultado = MessageBox.Show(
                "Deseja realmente fechar o aplicativo?\n" +
                "O aplicativo será atualizado com o arquivo atual.",
                "Confirmação de Saída",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button2, // "Não" como padrão
                MessageBoxOptions.DefaultDesktopOnly); // Isso força o MessageBox a aparecer na frente de todas as janelas


            if (resultado == DialogResult.No)
            {
                // Cancelar o fechamento
                cancel = true;
            }
            else
            {
                // Liberar recursos e fechar o Word
                wordApp.Quit();
                wordApp = null;


                // Mostrar a janela principal (Home) de forma thread-safe
                if (this.InvokeRequired)
                {
                    this.Invoke(new Action(() => this.Show()));
                }
                else
                {
                    this.Show();

                }
            }
        }

        private void CarregarTreeView()
        {
            using (var context = new dbContexto())
            {
                // Obter categorias com os respectivos sermões
                var categorias = context.Categorias.ToList();
                var sermaos = context.Sermoes
                         .Select(s => new { s.id, s.tema, s.id_categoria }) // Apenas os campos necessários
                         .ToList();

                // Limpa o TreeView antes de popular
                ListarALL.Nodes.Clear();

                // Adicionar categorias ao TreeView
                foreach (var categoria in categorias)
                {
                    // Criar um nó para a categoria
                    TreeNode categoriaNode = new TreeNode
                    {
                        Text = categoria.nome, // Nome da categoria
                        Tag = categoria.id    // ID da categoria
                    };

                    // Adicionar sermões vinculados como subnós
                    var sermaosDaCategoria = sermaos.Where(s => s.id_categoria == categoria.id).ToList();

                    foreach (var sermao in sermaosDaCategoria)
                    {
                        TreeNode sermaoNode = new TreeNode
                        {
                            Text = sermao.tema, // Nome do sermão
                            Tag = sermao.id     // ID do sermão
                        };

                        // Adicionar o sermão como subnó
                        categoriaNode.Nodes.Add(sermaoNode);
                    }

                    // Adicionar o nó da categoria ao TreeView
                    ListarALL.Nodes.Add(categoriaNode);
                }
            }
        }


        private void cbCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {
            //var categoriaSelecionada = cbCategoria.SelectedItem as Model.Categoria.Categorias; // Categoria é o tipo da sua classe

            //if (categoriaSelecionada.id != 0)
            //{
            //    MessageBox.Show($"Categoria: {categoriaSelecionada.nome}, ID: {categoriaSelecionada.id}");
            //}
        }

        private void adicionarSermaoStripMenuItem1_Click(object sender, EventArgs e)
        {
            try
            {
                // Criar instância do formulário AddCat
                AdicionarSerm addSermForm = new AdicionarSerm
                {
                    StartPosition = FormStartPosition.CenterParent // Centralizar no formulário pai
                };

                // Assinar o evento para atualizar o ComboBox quando a categoria for adicionada
                addSermForm.SermaoAdicionado += () =>
                {
                    // Recarregar as categorias no ComboBox
                    CarregarTreeView();
                };

                // Mostrar o formulário AddCat como modal
                addSermForm.ShowDialog(this);
            }
            catch (Exception ex)
            {
                // Tratamento genérico para outras exceções
                MessageBox.Show($"Ocorreu um erro inesperado ao iniciar a adição de sermões..\nDetalhes: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void ListarALL_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (e.Node.Nodes.Count == 0 && e.Node.Tag is int sermaoId)
            {

                Console.WriteLine("SERMAOID: " + sermaoId);

                var loadDOC = commVISUTOOL.carrDocs(sermaoId, tempFile);

                if (loadDOC == true)
                {
                    // Esconder a janela principal (Home) de forma thread-safe
                    if (this.InvokeRequired)
                    {
                        this.Invoke(new Action(() => this.Hide()));
                    }
                    else
                    {
                        this.Hide();
                    }

                    wordDocument = wordApp.Documents.Open(tempFile);
                    wordApp.Visible = true;
                }
            }
            else
            {
                Console.WriteLine("TEM NADA");
                // Caso o nó tenha filhos (categoria), não faz nada ou você pode adicionar outra ação, caso necessário
            }
        }
    }
}
