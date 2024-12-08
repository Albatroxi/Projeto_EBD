using Projeto_EBD.Controllers.Agendamento;
using Projeto_EBD.Controllers.Categoria;
using Projeto_EBD.Controllers.Igrejas;
using Projeto_EBD.Controllers.Sermao;
using Projeto_EBD.Model.Igrejas;
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

namespace Projeto_EBD.Janelas.Agendamentos
{
    public partial class AgendarSerm : Form
    {
        catCRUD commCATEGCRUD = new catCRUD();
        sermTOOL commSERMTOOL = new sermTOOL();
        sermCRUD commSERMCRUD = new sermCRUD();
        igrejCRUD commIGREJACRUD = new igrejCRUD();
        AgendaTOOL commAGENDATOOL = new AgendaTOOL();
        agendaCRUD commAGENDACRUD = new agendaCRUD();

        public event Action SermaoAgendado;

        public AgendarSerm()
        {
            InitializeComponent();

            // Inicializa o TreeView vazio
            treeView_agendSerm.Nodes.Clear();

            // Carregar as categorias
            commCATEGCRUD.CarregarCategorias(cbCat_agendSerm);

            // Carregar as igrejas
            commIGREJACRUD.CarregarIgrejasCadastradas(cbIgrejas_agendSerm);

            // Associa o evento SelectedIndexChanged ao ComboBox
            cbCat_agendSerm.SelectedIndexChanged += cbCat_agendSerm_SelectedIndexChanged;

            // Em seu formulário ou inicialização do TreeView
            treeView_agendSerm.AfterCheck += TreeView_AfterCheck;

        }

        private int? valorSelecionadoAnterior = null;

        private void cbCat_agendSerm_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbCat_agendSerm.SelectedValue is int categoriaId && categoriaId > 0)
            {
                // Evita execução desnecessária se o valor selecionado não mudou
                if (valorSelecionadoAnterior == categoriaId)
                    return;

                // Atualiza o valor anterior
                valorSelecionadoAnterior = categoriaId;

                // Limpa o TreeView antes de carregar novos itens
                treeView_agendSerm.Nodes.Clear();

                // Chama o método para carregar os sermões no TreeView com base na categoria selecionada
                var resultado = commSERMCRUD.CarregarSermoesNoTreeView(categoriaId, treeView_agendSerm);

                if (!resultado)
                {
                    MessageBox.Show("Nenhum sermão encontrado para a categoria selecionada.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
            }
            else
            {
                // Limpa o TreeView caso nenhuma categoria válida seja selecionada
                treeView_agendSerm.Nodes.Clear();
                valorSelecionadoAnterior = null;
            }
        }


        private void btCancAgendamento_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Tem certeza que deseja desistir de agendar um sermão ?", "Cancelar cadastramento", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                // Realizar ações de cancelamento, por exemplo, fechar o formulário
                this.Close();
            }
            // Se o usuário clicar em "No", a ação de cancelamento não será realizada
        }

        private void btAgendar_Click(object sender, EventArgs e)
        {
            // Capturar o item selecionado no ComboBox da Igreja
            Model.Igrejas.Igrejas igrejaSelecionada = (Model.Igrejas.Igrejas)cbIgrejas_agendSerm.SelectedItem;
            int idIgreja = igrejaSelecionada.id;

            // Capturar o item selecionado no ComboBox da Categoria
            Model.Categoria.Categorias categoriaSelecionada = (Model.Categoria.Categorias)cbCat_agendSerm.SelectedItem;
            int idCategoria = categoriaSelecionada.id;

            // Capturar a data selecionada no MonthCalendar
            DateTime dataSelecionada = dataAgendaSerm.SelectionStart;

            // Lista para armazenar os IDs selecionados
            List<int> idsSermaosSelecionados = new List<int>();

            // Itera pelos nós do TreeView para capturar os IDs marcados
            foreach (TreeNode node in treeView_agendSerm.Nodes)
            {
                commAGENDATOOL.ColetarIdsMarcados(node, idsSermaosSelecionados);
            }

            // Se não houver sermões selecionados
            if (idsSermaosSelecionados.Count == 0)
            {
                MessageBox.Show(
                    "É necessário informar o sermão que será aplicado.",
                    "Aviso",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return; // Impede que o código continue caso nenhum sermão seja selecionado
            }

            // Verifica se a Igreja foi selecionada
            if (idIgreja == 0)
            {
                MessageBox.Show(
                    "É necessário informar o local do sermão.",
                    "Aviso",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return; // Impede que o código continue caso o local não esteja selecionado
            }

            // Chama a função para verificar se a data é a atual
            if (commAGENDATOOL.VerificarSeDataEhAtual(dataSelecionada))
            {
                MessageBox.Show("A data selecionada é a data atual.", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            // Verifica se a Categoria foi selecionada
            if (idCategoria == 0)
            {
                MessageBox.Show(
                    "É necessário informar um tema para o sermão.",
                    "Aviso",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return; // Impede que o código continue caso a categoria não seja selecionada
            }

            // Chama a função AddAgendamento, passando a lista de IDs selecionados
            var resultado = commAGENDACRUD.AddAgendamento(idIgreja, dataSelecionada, idCategoria, idsSermaosSelecionados);

            if (resultado == true)
            {
                MessageBox.Show("Agendamento adicionado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Limpar os campos após o sucesso
                cbIgrejas_agendSerm.SelectedIndex = 0; // Limpa a seleção do ComboBox da Igreja
                cbCat_agendSerm.SelectedIndex = 0; // Limpa a seleção do ComboBox da Categoria
                dataAgendaSerm.SelectionStart = DateTime.Now; // Limpa a data selecionada no Calendar
                treeView_agendSerm.Nodes.Clear(); // Limpa todos os nós do TreeView
            }
        }


        private void TreeView_AfterCheck(object sender, TreeViewEventArgs e)
        {
            // Contar o número de nós marcados
            int itensMarcados = 0;

            foreach (TreeNode node in treeView_agendSerm.Nodes)
            {
                itensMarcados += node.Checked ? 1 : 0;
                itensMarcados += CountCheckedNodes(node); // Verifica filhos
            }

            // Se o número de itens marcados for maior que 2, desmarque o último nó marcado
            if (itensMarcados > 2)
            {
                // Desmarcar o nó que foi alterado
                e.Node.Checked = false;
                MessageBox.Show("Somente 2 itens podem ser selecionados.", "Limite de Seleção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // Função recursiva para contar os nós filhos marcados
        private int CountCheckedNodes(TreeNode parentNode)
        {
            int count = 0;
            foreach (TreeNode childNode in parentNode.Nodes)
            {
                count += childNode.Checked ? 1 : 0;
                count += CountCheckedNodes(childNode); // Verifica filhos recursivamente
            }
            return count;
        }


    }

}
