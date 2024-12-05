using Projeto_EBD.DBContexto;
using Projeto_EBD.Model.Igrejas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_EBD.Controllers.Igrejas
{
    public class igrejCRUD
    {
        public bool adicionarIgreja(string nome, string end, string bairro, string estado, string cidade, string tigreja, string tel)
        {
            try
            {
                // Verificar se os campos são válidos
                if (string.IsNullOrWhiteSpace(nome))
                {
                    MessageBox.Show("O nome da igreja é obrigatório.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }

                if (string.IsNullOrWhiteSpace(end))
                {
                    MessageBox.Show("O endereço da igreja é obrigatório.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }

                if (string.IsNullOrWhiteSpace(bairro))
                {
                    MessageBox.Show("O bairro da igreja é obrigatório.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }

                if (string.IsNullOrWhiteSpace(estado))
                {
                    MessageBox.Show("O estado da igreja é obrigatório.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }

                if (string.IsNullOrWhiteSpace(cidade))
                {
                    MessageBox.Show("A cidade da igreja é obrigatória.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }

                if (string.IsNullOrWhiteSpace(tigreja))
                {
                    MessageBox.Show("O tipo da igreja é obrigatório.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }

                if (string.IsNullOrWhiteSpace(tel))
                {
                    MessageBox.Show("O telefone da liderança é obrigatório.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }

                // Inserir no banco de dados
                using (var context = new dbContexto())
                {
                    Model.Igrejas.Igrejas novaIgreja = new Model.Igrejas.Igrejas
                    {
                        inome = nome,
                        iendereco = end,
                        ibairro = bairro,
                        iestado = estado,
                        icidade = cidade,
                        itipo = tigreja,
                        itelefone = tel
                    };

                    context.Igrejas.Add(novaIgreja);
                    context.SaveChanges();
                }

                //MessageBox.Show("Igreja adicionada com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao salvar a igreja: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

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
