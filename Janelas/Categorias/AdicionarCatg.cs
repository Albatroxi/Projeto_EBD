using Projeto_EBD.Controllers.Categoria;
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
        catCRUD commCATEG = new catCRUD();

        // Definir o evento
        public event Action CategoriaAdicionada;
        public AdicionarCatg()
        {
            InitializeComponent();
        }

        private void insCat_Click(object sender, EventArgs e)
        {

            bool resultado = commCATEG.addCategoria(lbnvCat.Text);

            if (resultado)
            {
                // Categoria adicionada com sucesso
                MessageBox.Show("Categoria adicionada com sucesso.");

                // Após a inserção, disparar o evento
                CategoriaAdicionada?.Invoke();

                this.Close();
            }
        }
    }
}