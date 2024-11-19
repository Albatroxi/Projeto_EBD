using Projeto_EBD.DBContexto;
using Projeto_EBD.Model.Categoria;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_EBD.Janelas.Categorias
{
    public partial class AdicionarCatg : Form
    {
        // Definir o evento
        public event Action CategoriaAdicionada;
        public AdicionarCatg()
        {
            InitializeComponent();
        }

        private void insCat_Click(object sender, EventArgs e)
        {
            try
            {
                // Pegando o valor da Label lbnvCat
                string nvCat = lbnvCat.Text;

                // Verificando se o nome não está vazio
                if (!string.IsNullOrWhiteSpace(nvCat))
                {
                    // Usando o contexto do banco de dados para adicionar a pessoa
                    using (var context = new dbContexto())
                    {
                        Model.Categoria.Categorias novaCategoria = new Model.Categoria.Categorias { nome = nvCat };
                        context.Categorias.Add(novaCategoria);
                        context.SaveChanges();
                    }

                    // Após a inserção, disparar o evento
                    CategoriaAdicionada?.Invoke();

                    // Fechar o formulário AddCat após adicionar
                    this.Close();

                    // Mensagem de sucesso
                    MessageBox.Show("Categoria cadastrada com sucesso!");
                }
                else
                {
                    // Caso o nome esteja vazio ou inválido
                    MessageBox.Show("É necessário informar um nome para a nova categoria.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao salvar o categoria: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
    }
}
