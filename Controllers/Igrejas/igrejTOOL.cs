using System;
using System.Linq;
using System.Windows.Forms;

namespace Projeto_EBD.Controllers.Igrejas
{
    public class igrejTOOL
    {
        public void CarregarIgrejasCadastradas(ComboBox cbIgrejas)
        {
            try
            {
                using (var context = new DBContexto.dbContexto())
                {
                    var igrejas = context.Igrejas.ToList();
                    // Criar um item em branco (ou "placeholder") e adicioná-lo à lista
                    igrejas.Insert(0, new Model.Igrejas.Igrejas { id = 0, inome = "Selecione uma Igreja" });

                    // Preencha o ComboBox com os nomes das igreja
                    cbIgrejas.DataSource = igrejas;
                    cbIgrejas.DisplayMember = "inome"; // Exibe o nome da igreja
                    cbIgrejas.ValueMember = "id"; // O valor será o Id da igreja

                }
            }
            catch (Exception ex)
            {
                // Tratamento genérico para outras exceções
                MessageBox.Show($"Ocorreu um erro inesperado ao carregar as informações de igrejas.\nDetalhes: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
    }
}
