using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Projeto_EBD.Controllers.Sermao
{
    public class sermTOOL
    {
        public string carregarArquivoSermao()
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "Arquivos do Word (*.doc;*.docx)|*.doc;*.docx",
                Title = "Selecione o Arquivo do Sermão"
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                //camSermArquiv.Text = openFileDialog.FileName; // Exibe o caminho do arquivo selecionado
                return openFileDialog.FileName;
            }

            return null;
        }

        public void ExibirSelecionados(TreeView treeView)
        {
            foreach (TreeNode node in treeView.Nodes)
            {
                ExibirNosMarcados(node);
            }
        }

        private void ExibirNosMarcados(TreeNode node)
        {
            // Verifica se o nó está marcado
            if (node.Checked)
            {
                // Obtém o ID armazenado no campo Tag
                if (node.Tag is int sermaoId)
                {
                    Console.WriteLine($"ID do Sermão: {sermaoId}");
                }
            }

            // Chama recursivamente para os nós filhos
            foreach (TreeNode childNode in node.Nodes)
            {
                ExibirNosMarcados(childNode);
            }
        }

        // Função para desmarcar todos os nós do TreeView
        public void DesmarcarTodos(TreeView treeView)
        {
            foreach (TreeNode node in treeView.Nodes)
            {
                MarcarOuDesmarcarNos(node, false); // Desmarca todos os nós
            }
        }

        // Função auxiliar para percorrer nós e aplicar a marcação/desmarcação
        public void MarcarOuDesmarcarNos(TreeNode node, bool check)
        {
            node.Checked = check; // Define o estado do checkbox do nó atual

            // Aplica o mesmo estado para os nós filhos (se houver)
            foreach (TreeNode childNode in node.Nodes)
            {
                MarcarOuDesmarcarNos(childNode, check);
            }
        }

        public void ColetarIdsMarcados(TreeNode node, List<int> idsParaExcluir)
        {
            // Verifica se o nó está marcado e possui um ID associado no campo Tag
            if (node.Checked && node.Tag is int sermaoId)
            {
                idsParaExcluir.Add(sermaoId);
            }

            // Itera recursivamente pelos nós filhos
            foreach (TreeNode childNode in node.Nodes)
            {
                ColetarIdsMarcados(childNode, idsParaExcluir);
            }
        }

    }
}
