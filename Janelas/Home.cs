using Projeto_EBD.Controllers.Ferramentas;
using Projeto_EBD.DBContexto;
using Projeto_EBD.Janelas.Agendamentos;
using Projeto_EBD.Janelas.Categorias;
using Projeto_EBD.Janelas.Igrejas;
using Projeto_EBD.Janelas.Sermaos;
using System;
using System.Data;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Projeto_EBD.Janelas
{
    public partial class Home : Form
    {

        private visualizadorTOOL commVISUTOOL; // Apenas a declaração
        string tempFile = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, Guid.NewGuid() + ".doc");


        public Home()
        {

            InitializeComponent();
            string dbPath = AppDomain.CurrentDomain.GetData("DataDirectory") + @"projEBD.sqlite";
            CarregarTreeView();
            this.FormClosing += Home_FormClosing;


            // Inicializa o visualizadorTOOL com a instância atual do formulário
            commVISUTOOL = new visualizadorTOOL(this);

        }

        private void Home_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Exibe uma mensagem antes de fechar
            var result = MessageBox.Show("Deseja realmente sair?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            // Cancela o fechamento se o usuário clicar em "Não"
            if (result == DialogResult.No)
            {
                e.Cancel = true;
            }
            else
            {
                githubTOOL getGIT = new githubTOOL();
                getGIT.EnviaDBANCO();
            }
        }


        public void retornarHome()
        {
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
            var categoriaNode = e.Node.Parent; // Supondo que a categoria está no nó pai
            if (e.Node.Nodes.Count == 0 && e.Node.Tag is int sermaoId && categoriaNode?.Tag is int categoriaId)
            {
                //Console.WriteLine("SERMAOID: " + sermaoId);

                // Verifica se há informações da categoria no pai ou no nó atual
                

                var loadDOC = commVISUTOOL.carrDocs(sermaoId, categoriaId, tempFile);

                dadosESTATICOS.sermaoID = sermaoId;
                dadosESTATICOS.tempFile = tempFile;

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
                }
            }
            else
            {
                Console.WriteLine("TEM NADA");
                // Caso o nó tenha filhos (categoria), não faz nada ou você pode adicionar outra ação, caso necessário
            }
        }

        private void cadastrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                // Criar instância do formulário AddIgreja
                AdicionarIgreja addIgrejaForm = new AdicionarIgreja
                {
                    StartPosition = FormStartPosition.CenterParent // Centralizar no formulário pai
                };

                // Assinar o evento para atualizar o ComboBox quando a categoria for adicionada
                //addSermForm.SermaoAdicionado += () =>
                //{
                // Recarregar as categorias no ComboBox
                //    CarregarTreeView();
                //};

                // Mostrar o formulário AddCat como modal
                addIgrejaForm.ShowDialog(this);
            }
            catch (Exception ex)
            {
                // Tratamento genérico para outras exceções
                MessageBox.Show($"Ocorreu um erro inesperado ao iniciar o cadastro de uma nova igreja..\nDetalhes: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void igrejasCadastradasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                // Criar instância do formulário AddIgreja
                ExibirIgrejas exibIgrejaForm = new ExibirIgrejas
                {
                    StartPosition = FormStartPosition.CenterParent // Centralizar no formulário pai
                };

                // Assinar o evento para atualizar o ComboBox quando a categoria for adicionada
                //addSermForm.SermaoAdicionado += () =>
                //{
                // Recarregar as categorias no ComboBox
                //    CarregarTreeView();
                //};

                // Mostrar o formulário ExibirIgrejas como modal
                exibIgrejaForm.ShowDialog(this);
            }
            catch (Exception ex)
            {
                // Tratamento genérico para outras exceções
                MessageBox.Show($"Ocorreu um erro inesperado ao iniciar a exibição das igrejas cadastradas.\nDetalhes: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void agendarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                // Criar instância do formulário AddIgreja
                AgendarPregacao agendaPregaForm = new AgendarPregacao
                {
                    StartPosition = FormStartPosition.CenterParent // Centralizar no formulário pai
                };

                // Assinar o evento para atualizar o ComboBox quando a categoria for adicionada
                //addSermForm.SermaoAdicionado += () =>
                //{
                // Recarregar as categorias no ComboBox
                //    CarregarTreeView();
                //};

                // Mostrar o formulário ExibirIgrejas como modal
                agendaPregaForm.ShowDialog(this);
            }
            catch (Exception ex)
            {
                // Tratamento genérico para outras exceções
                MessageBox.Show($"Ocorreu um erro inesperado ao iniciar o agendamento de pregação.\nDetalhes: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
    }
}
