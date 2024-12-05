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

namespace Projeto_EBD.Janelas.Agendamentos
{
    public partial class AgendarPregacao : Form
    {
        igrejCRUD commIGREJACRUD = new igrejCRUD();
        catCRUD commCATEGORIACRUD = new catCRUD();
        public AgendarPregacao()
        {
            InitializeComponent();

            commIGREJACRUD.CarregarIgrejasCadastradas(cbIgrejas_agenda);
            commCATEGORIACRUD.CarregarCategorias(cbCategorias_agenda);
        }

        private void cbIgrejas_agenda_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Verifica se há algum item selecionado
            if (cbIgrejas_agenda.SelectedItem != null)
            {
                // Cast do item selecionado para o tipo Igreja
                Model.Igrejas.Igrejas igrejaSelecionada = (Model.Igrejas.Igrejas)cbIgrejas_agenda.SelectedItem;

                // Acessa o ID da igreja
                int idIgreja = igrejaSelecionada.id;

                if (idIgreja != 0)
                {
                    // Acessa o nome da igreja
                    string nomeIgreja = igrejaSelecionada.inome;

                    // Exibe os valores (ID e nome)
                    MessageBox.Show($"Igreja Selecionada:\nID: {idIgreja}\nNome: {nomeIgreja}",
                                    "Igreja Selecionada",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);

                    // Usar idIgreja e nomeIgreja conforme necessário
                }
            }
            else
            {
                MessageBox.Show("Nenhuma igreja selecionada.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

    }
}
