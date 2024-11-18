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

            //string dbPath = AppDomain.CurrentDomain.GetData("DataDirectory") + @"projEBD.sqlite";
            //MessageBox.Show($"Banco de dados será armazenado em: {dbPath}");

            //Carregar as categorias
            CarregarCategorias(cbCategoria);
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
                //addCatForm.SermaoAdicionado += () =>
                //{
                    // Recarregar as categorias no ComboBox
                //    CarregarCategorias(cbCategoria);
                //};

                // Mostrar o formulário AddCat como modal
                addSermForm.ShowDialog(this);
            }
            catch (Exception ex)
            {
                // Tratamento genérico para outras exceções
                MessageBox.Show($"Ocorreu um erro inesperado ao iniciar a adição de sermões..\nDetalhes: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
    }
}
