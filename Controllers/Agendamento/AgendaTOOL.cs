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
        public void ColetarIdMarcado(TreeNode node, ref int sermaoId)
        {
            // Verifica se o nó está marcado e possui um ID associado no campo Tag
            if (node.Checked && node.Tag is int idSelecionado)
            {
                // Atribui o ID do sermão ao parâmetro, caso seja marcado
                sermaoId = idSelecionado;
            }

            // Itera recursivamente pelos nós filhos
            foreach (TreeNode childNode in node.Nodes)
            {
                ColetarIdMarcado(childNode, ref sermaoId);
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
