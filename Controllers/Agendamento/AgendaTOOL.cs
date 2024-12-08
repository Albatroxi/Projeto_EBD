using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_EBD.Controllers.Agendamento
{
    public class AgendaTOOL
    {
        public void ColetarIdsMarcados(TreeNode node, List<int> idsSelecionados)
        {
            // Verifica se o nó está marcado e possui um ID associado no campo Tag
            if (node.Checked && node.Tag is int sermaoId)
            {
                idsSelecionados.Add(sermaoId);
            }

            // Itera recursivamente pelos nós filhos
            foreach (TreeNode childNode in node.Nodes)
            {
                ColetarIdsMarcados(childNode, idsSelecionados);
            }
        }

        public bool VerificarSeDataEhAtual(DateTime dataSelecionada)
        {
            // Obtém a data atual do sistema sem a hora
            DateTime dataAtual = DateTime.Today;

            // Compara a data selecionada com a data atual
            return dataSelecionada.Date == dataAtual;
        }

    }
}
