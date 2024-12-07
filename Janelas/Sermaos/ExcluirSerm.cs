using Projeto_EBD.Controllers.Categoria;
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
    public partial class ExcluirSerm : Form
    {
        catCRUD commCATEGCRUD = new catCRUD();

        public event Action SermaoExcluido;
        public ExcluirSerm()
        {
            InitializeComponent();

            commCATEGCRUD.CarregarCategorias(cbCat_excSerm);

            cbCat_excSerm.SelectedIndexChanged += cbCat_excSerm_SelectedIndexChanged;
        }

        private void cbCat_excSerm_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbCat_excSerm.SelectedValue is int categoriaId && categoriaId > 0)
            {
                // Chama o método para carregar os sermões no TreeView
                //CarregarSermoesNoTreeView(categoriaId);
                Console.WriteLine("RODANDO");
            }
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }
    }
}
