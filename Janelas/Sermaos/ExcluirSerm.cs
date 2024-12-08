using Projeto_EBD.Controllers.Categoria;
using Projeto_EBD.Controllers.Sermao;
using Projeto_EBD.DBContexto;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using TreeView = System.Windows.Forms.TreeView;

namespace Projeto_EBD.Janelas.Sermaos
{
    public partial class ExcluirSerm : Form
    {
        catCRUD commCATEGCRUD = new catCRUD();
        sermCRUD commSERMCRUD = new sermCRUD();
        sermTOOL commSERMTOOL = new sermTOOL();

        public event Action SermaoExcluido;
        public ExcluirSerm()
        {
            InitializeComponent();

            commCATEGCRUD.CarregarCategorias(cbCat_excSerm);

            cbCat_excSerm.SelectedIndexChanged += cbCat_excSerm_SelectedIndexChanged;

            // Configura o evento AfterCheck para o TreeView
            treeView1.CheckBoxes = true;
            //treeView1.AfterCheck += treeView1_AfterCheck;

            // Assinar o evento para atualizar o ComboBox quando a categoria for adicionada
            SermaoExcluido += () =>
            {
                // Recarregar as sermoes no treeview por categoria selecionada
                commSERMTOOL.CarregarSermoesNoTreeView(treeView1);
            };
        }

        private void cbCat_excSerm_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbCat_excSerm.SelectedValue is int categoriaId && categoriaId > 0)
            {
                // Limpa os nós existentes antes de carregar novos
                treeView1.Nodes.Clear();

                // Chama o método para carregar os sermões no TreeView
                var resultado = commSERMCRUD.CarregarSermoesNoTreeView(categoriaId, treeView1);

                if (!resultado)
                {
                    MessageBox.Show("Nenhum sermão encontrado para a categoria selecionada.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }


        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }


        private void btExcCatCancela_Click(object sender, EventArgs e)
        {
            foreach (TreeNode node in treeView1.Nodes)
            {
               commSERMTOOL.MarcarOuDesmarcarNos(node, true); // Marca todos os nós
            }
        }
        private void btDesmarcarTudo_Click(object sender, EventArgs e)
        {
            commSERMTOOL.DesmarcarTodos(treeView1);
        }
        private void btExcCat_Click(object sender, EventArgs e)
        {
            // Lista para armazenar os IDs dos sermões marcados
            var idsParaExcluir = new List<int>();

            // Salvar a categoria selecionada antes de excluir os sermões
            int categoriaId = cbCat_excSerm.SelectedValue is int selectedCategoryId ? selectedCategoryId : 0;

            // Itera pelos nós do TreeView para capturar os IDs marcados
            foreach (TreeNode node in treeView1.Nodes)
            {
                commSERMTOOL.ColetarIdsMarcadoseExclui(node, idsParaExcluir);
            }

            // Verifica se há IDs para excluir
            if (idsParaExcluir.Any())
            {
                // Confirmação do usuário
                var confirmacao = MessageBox.Show("Tem certeza que deseja excluir os sermões selecionados?",
                                                  "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (confirmacao == DialogResult.Yes)
                {
                    // Itera pela lista de IDs e exclui cada sermão
                    foreach (var id in idsParaExcluir)
                    {
                        commSERMCRUD.ExcluirSermao(id);
                    }

                    SermaoExcluido?.Invoke();

                    // Atualiza o TreeView após a exclusão
                    treeView1.Nodes.Clear();

                    // Recarregar os sermões no TreeView com a categoria selecionada
                    if (categoriaId > 0)
                    {
                        commSERMCRUD.CarregarSermoesNoTreeView(categoriaId, treeView1);
                    }

                    MessageBox.Show("Os sermões selecionados foram excluídos com sucesso.", "Sucesso",
                                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Nenhum sermão foi selecionado para exclusão.", "Aviso",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

    }
}
