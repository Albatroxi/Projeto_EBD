using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_EBD.Janelas.Sermaos
{
    public partial class AdicionarSerm : Form
    {
        // Definir o evento
        public event Action SermaoAdicionado;
        public AdicionarSerm()
        {
            InitializeComponent();
        }

        private void addSermDOCs_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "Arquivos Word (*.doc;*.docx)|*.doc;*.docx",
                Title = "Selecione o Arquivo do Sermão"
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                camSermArquiv.Text = openFileDialog.FileName; // Exibe o caminho do arquivo selecionado
            }
        }

        private void inserSerm_Click(object sender, EventArgs e)
        {

        }
    }
}
