using Microsoft.Office.Interop.Word;
using Projeto_EBD.DBContexto;
using Projeto_EBD.Janelas.Categorias;
using Projeto_EBD.Janelas.Sermaos;
using Projeto_EBD.Model.Categoria;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_EBD.Janelas
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();

            string dbPath = AppDomain.CurrentDomain.GetData("DataDirectory") + @"projEBD.sqlite";
            //MessageBox.Show($"Banco de dados será armazenado em: {dbPath}");

            //Carregar as categorias
            CarregarCategorias(cbCategoria);

            CarregarTreeView();

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
                    CarregarCategorias(cbCategoria);
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

        public void CarregarCategorias(ComboBox cbCategoria)
        {
            try
            {
                using(var context = new DBContexto.dbContexto())
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
            var categoriaSelecionada = cbCategoria.SelectedItem as Model.Categoria.Categorias; // Categoria é o tipo da sua classe

            if (categoriaSelecionada.id != 0)
            {
                MessageBox.Show($"Categoria: {categoriaSelecionada.nome}, ID: {categoriaSelecionada.id}");
            }
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
            // Verifica se o nó selecionado é uma subcategoria (um sermão ou subnó, sem filhos)
            if (e.Node.Nodes.Count == 0 && e.Node.Tag is int sermaoId)
            {
                // Obtém o sermão selecionado pela ID
                using (var context = new dbContexto())
                {
                    var sermao = context.Sermoes
                    .Where(s => s.id == sermaoId)  // Filtro para pegar o sermão específico
                    .Select(s => new { s.id, s.tema, s.arquivo })  // Seleciona apenas os campos id e tema
                    .FirstOrDefault();

                    // Imprime o conteúdo em hexadecimal
                    Console.WriteLine(BitConverter.ToString(sermao.arquivo));

                    if (sermao != null)
                    {
                        // Exibe a MessageBox com o nome do sermão e a ID
                        MessageBox.Show($"Sermão: {sermao.tema}\nID do Sermão: {sermao.id}", "Informações do Sermão");
                    }
                }
            }
            else if (e.Node.Nodes.Count > 0)
            {
                // Caso o nó tenha filhos (categoria), não faz nada ou você pode adicionar outra ação, caso necessário
            }
        }
    }
}
