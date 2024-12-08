using Projeto_EBD.DBContexto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_EBD.Controllers.Agendamento
{
    public class agendaCRUD
    {
        public bool AddAgendamento(int igrejaId, DateTime data, int categoriaId, int sermaoId)
        {
            try
            {
                // Verificando se os parâmetros fornecidos são válidos
                if (igrejaId > 0 && categoriaId > 0 && sermaoId > 0 && data != DateTime.MinValue)
                {
                    using (var context = new dbContexto())
                    {

                        // Criando o objeto Agendamento
                        Model.Agenda.Agendas novoAgendamento = new Model.Agenda.Agendas
                        {
                            igreja_id = igrejaId,
                            data = data,
                            categoria_id = categoriaId,
                            sermao_id = sermaoId  // ID do sermão
                        };

                        // Adicionando o agendamento ao banco de dados
                        context.Agendas.Add(novoAgendamento);
                        context.SaveChanges();

                        // Verificando se o agendamento foi salvo com sucesso e obteve um ID válido
                        if (novoAgendamento.id <= 0)
                        {
                            MessageBox.Show("Erro ao criar o agendamento. O ID não foi gerado corretamente.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return false;
                        }

                        /*
                        // Agora associamos o sermão com o agendamento em uma tabela de relacionamento
                        var agendamentoSermao = new Model.Agenda.Agendas // Tabela de associação
                        {
                            id = novoAgendamento.id,  // ID do agendamento
                            igreja_id = igrejaId,
                            data = data,
                            categoria_id = categoriaId,
                            sermao_id = sermaoId  // ID do sermão
                        };
                        */

                        // Adicionando a associação ao banco de dados
                        //context.Agendas.Add(agendamentoSermao); // Adiciona na tabela de relacionamento
                        //context.SaveChanges();
                    }

                    // Mensagem de sucesso
                    // MessageBox.Show("Agendamento adicionado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return true;
                }
                else
                {
                    // Caso algum dado seja inválido
                    MessageBox.Show("Todos os campos são obrigatórios. Verifique os dados fornecidos.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                // Tratamento de erros
                MessageBox.Show($"Erro ao adicionar o agendamento: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return false;
        }

        public void CarregarInformacoesAgendamento(Label agendaIgreja_1, Label agendaData_1, Label agendaTema_1)
        {
            // Obter o agendamento mais recente ou o agendamento desejado
            using (var context = new dbContexto())
            {
                // Exemplo de obter o primeiro agendamento encontrado (ou qualquer critério desejado)
                var agendamento = context.Agendas.FirstOrDefault();

                if (agendamento != null)
                {
                    // Obter a igreja associada ao agendamento
                    var igreja = context.Igrejas.FirstOrDefault(i => i.id == agendamento.igreja_id);

                    var igrejaAgenda = context.Agendas.FirstOrDefault(i => i.igreja_id == agendamento.igreja_id);

                    var igrejaAgendaCategoria = context.Categorias.FirstOrDefault(i => i.id == agendamento.igreja_id);

                    if (igreja != null)
                    {
                        // Exibir as informações da igreja nas labels
                        agendaIgreja_1.Visible = true;
                        agendaIgreja_1.Text = igreja.inome;

                        agendaData_1.Visible = true;
                        agendaData_1.Text = igrejaAgenda.data.ToString("dd/MM/yyyy"); // Formato de data (exemplo: 08/12/2024)

                        agendaTema_1.Visible = true;
                        agendaTema_1.Text = igrejaAgendaCategoria.nome;

                    }
                    else
                    {
                        // Caso não encontre a igreja
                        MessageBox.Show("Igreja não encontrada para o agendamento.");
                    }
                }
                else
                {
                    // Caso não haja agendamento
                    MessageBox.Show("Nenhum agendamento encontrado.");
                }
            }
        }
    }
}
