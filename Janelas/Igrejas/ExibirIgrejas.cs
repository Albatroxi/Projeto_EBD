using Projeto_EBD.Controllers.Categoria;
using Projeto_EBD.Controllers.Igrejas;
using Projeto_EBD.DBContexto;
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

namespace Projeto_EBD.Janelas.Igrejas
{
    public partial class ExibirIgrejas : Form
    {
        igrejTOOL commIGREJATOOL = new igrejTOOL();
        public ExibirIgrejas()
        {
            InitializeComponent();

            //Carregar as igrejas
            commIGREJATOOL.CarregarIgrejasCadastradas(cbIgrejas);

            // Inicializa as labels como ocultas
            this.label2.Visible = false;
            this.label3.Visible = false;
            this.label4.Visible = false;
            this.label5.Visible = false;
            this.label6.Visible = false;
            this.label7.Visible = false;
            this.label8.Visible = false;
            this.label9.Visible = false;
            this.label10.Visible = false;
            this.label11.Visible = false;
        }

        private void cbIgrejas_SelectedIndexChanged(object sender, EventArgs e)
        {
            Model.Igrejas.Igrejas igrejaSelecionada = (Model.Igrejas.Igrejas)cbIgrejas.SelectedItem;
            int idIgreja = igrejaSelecionada.id;

            if (cbIgrejas.SelectedItem != null)
            {
                
                // Usar o idIgreja conforme necessário

                this.label2.Visible = true;
                this.label3.Text = igrejaSelecionada.iendereco;
                this.label3.Visible = true;
                this.label4.Visible = true;
                this.label5.Text = igrejaSelecionada.ibairro;
                this.label5.Visible = true;
                this.label6.Visible = true;
                this.label7.Text = igrejaSelecionada.icidade;
                this.label7.Visible = true;
                this.label8.Visible = true;
                this.label9.Text = igrejaSelecionada.iestado;
                this.label9.Visible = true;
                this.label10.Visible = true;
                this.label11.Text = igrejaSelecionada.itelefone;
                this.label11.Visible = true;
            }
            else
            {
                MessageBox.Show("Nenhuma igreja selecionada.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
