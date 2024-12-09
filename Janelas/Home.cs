using Projeto_EBD.Controllers.Agendamento;
using Projeto_EBD.Controllers.Ferramentas;
using Projeto_EBD.Controllers.Sermao;
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
        agendaCRUD commAGENDACRUD = new agendaCRUD();

        private visualizadorTOOL commVISUTOOL; // Apenas a declaração
        string tempFile = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, Guid.NewGuid() + ".doc");


        public Home()
        {

            InitializeComponent();
            string dbPath = AppDomain.CurrentDomain.GetData("DataDirectory") + @"projEBD.sqlite";
            CarregarTreeView();
            this.FormClosing += Home_FormClosing;

            agendaIgreja_1.Visible = false;
            agendaIgreja_2.Visible = false;
            agendaIgreja_3.Visible = false;

            agendaData_1.Visible = false;
            agendaData_2.Visible = false;
            agendaData_3.Visible = false;

            agendaTema_1.Visible = false;
            agendaTema_2.Visible = false;
            agendaTema_3.Visible = false;

            agendaSermao_1.Visible = false;
            agendaSermao_2.Visible = false;
            agendaSermao_3.Visible = false;

            agendaEstCidadeBairro_1.Visible = false;
            agendaEstCidadeBairro_2.Visible = false;
            agendaEstCidadeBairro_3.Visible = false;

            commAGENDACRUD.CarregarInformacoesAgendamento(agendaIgreja_1, agendaData_1, agendaTema_1, agendaSermao_1, agendaEstCidadeBairro_1, 0);
            commAGENDACRUD.CarregarInformacoesAgendamento(agendaIgreja_2, agendaData_2, agendaTema_2, agendaSermao_2, agendaEstCidadeBairro_2, 1);
            commAGENDACRUD.CarregarInformacoesAgendamento(agendaIgreja_3, agendaData_3, agendaTema_3, agendaSermao_3, agendaEstCidadeBairro_3, 2);


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

        // Função para resetar as labels
        public void ResetarLabels(params Label[] labels)
        {
            foreach (var label in labels)
            {
                label.Visible = false; // Ocultar a label
                label.Text = string.Empty; // Limpar o texto
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
                AgendarSerm agendaSermForm = new AgendarSerm
                {
                    StartPosition = FormStartPosition.CenterParent // Centralizar no formulário pai
                };

                // Assinar o evento para atualizar o ComboBox quando a categoria for adicionada
                agendaSermForm.SermaoAgendado += () =>
                {
                    //Recarregar as labels de agendamentos
                    ResetarLabels(
                        agendaIgreja_1, agendaIgreja_2, agendaIgreja_3,
                        agendaData_1, agendaData_2, agendaData_3,
                        agendaTema_1, agendaTema_2, agendaTema_3,
                        agendaSermao_1, agendaSermao_2, agendaSermao_3,
                        agendaEstCidadeBairro_1, agendaEstCidadeBairro_2, agendaEstCidadeBairro_3
                        );

                    commAGENDACRUD.CarregarInformacoesAgendamento(agendaIgreja_1, agendaData_1, agendaTema_1, agendaSermao_1, agendaEstCidadeBairro_1, 0);
                    commAGENDACRUD.CarregarInformacoesAgendamento(agendaIgreja_2, agendaData_2, agendaTema_2, agendaSermao_2, agendaEstCidadeBairro_2, 1);
                    commAGENDACRUD.CarregarInformacoesAgendamento(agendaIgreja_3, agendaData_3, agendaTema_3, agendaSermao_3, agendaEstCidadeBairro_3, 2);

                };

                // Mostrar o formulário ExibirIgrejas como modal
                agendaSermForm.ShowDialog(this);
            }
            catch (Exception ex)
            {
                // Tratamento genérico para outras exceções
                MessageBox.Show($"Ocorreu um erro inesperado ao iniciar o agendamento de sermão.\nDetalhes: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void excluirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                // Criar instância do formulário AddIgreja
                ExcluirCatg excluiCatgForm = new ExcluirCatg
                {
                    StartPosition = FormStartPosition.CenterParent // Centralizar no formulário pai
                };

                // Assinar o evento para atualizar o ComboBox quando a categoria for adicionada
                excluiCatgForm.CategoriaExcluida += () =>
                {
                // Recarregar as categorias no ComboBox
                    CarregarTreeView();
                };

                // Mostrar o formulário ExibirIgrejas como modal
                excluiCatgForm.ShowDialog(this);
            }
            catch (Exception ex)
            {
                // Tratamento genérico para outras exceções
                MessageBox.Show($"Ocorreu um erro inesperado ao iniciar a exclusão de uma categoria.\nDetalhes: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void excluirToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            try
            {
                // Criar instância do formulário AddIgreja
                ExcluirSerm excluiSermForm = new ExcluirSerm
                {
                    StartPosition = FormStartPosition.CenterParent // Centralizar no formulário pai
                };

                // Assinar o evento para atualizar o ComboBox quando a categoria for adicionada
                excluiSermForm.SermaoExcluido += () =>
                {
                    // Recarregar as categorias no ComboBox
                    CarregarTreeView();
                };

                // Mostrar o formulário ExibirIgrejas como modal
                excluiSermForm.ShowDialog(this);
            }
            catch (Exception ex)
            {
                // Tratamento genérico para outras exceções
                MessageBox.Show($"Ocorreu um erro inesperado ao iniciar a exclusão de sermões.\nDetalhes: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
    }
}
