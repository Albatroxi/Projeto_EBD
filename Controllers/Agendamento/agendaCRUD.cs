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
                    }
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

        public void CarregarInformacoesAgendamento(Label agendaIgreja, Label agendaData, Label agendaTema, Label agendaSermao, Label agendaEstCidadeBairro, int agendamentoIndex)
        {
            using (var context = new dbContexto())
            {
                // Obter os agendamentos mais recentes
                var agendamentos = context.Agendas
                    .OrderByDescending(a => a.data) // Ordenar por data decrescente
                    .Take(3) // Limitar para até 3 registros
                    .ToList();

                if (agendamentos.Count > agendamentoIndex)
                {
                    // Há agendamento para o índice fornecido
                    var agendamento = agendamentos[agendamentoIndex];
                    var igreja = context.Igrejas.FirstOrDefault(i => i.id == agendamento.igreja_id);
                    var categoria = context.Categorias.FirstOrDefault(c => c.id == agendamento.categoria_id);
                    var sermao = context.Sermoes.FirstOrDefault(s => s.id == agendamento.sermao_id);

                    if (igreja != null)
                    {
                        // Calcular dias restantes
                        var diasRestantes = (agendamento.data.Date - DateTime.Now.Date).Days;
                        var diasRestantesTexto = diasRestantes > 0 ? $"{diasRestantes} dias restantes" : "Hoje";

                        // Configurar a cor do texto com base no número de dias restantes
                        System.Drawing.Color corTexto = diasRestantes > 5 ? System.Drawing.Color.Green :
                                                        diasRestantes > 2 ? System.Drawing.Color.Orange :
                                                        System.Drawing.Color.Red;

                        agendaIgreja.Visible = true;
                        agendaIgreja.Text = igreja.inome;

                        agendaData.Visible = true;
                        agendaData.Text = $"{agendamento.data:dd/MM/yyyy} ({diasRestantesTexto})";
                        agendaData.ForeColor = corTexto; // Aplicar a cor
                        agendaData.Font = new System.Drawing.Font(agendaData.Font, System.Drawing.FontStyle.Bold); // Negrito

                        agendaTema.Visible = true;
                        agendaTema.Text = categoria?.nome ?? "Sem tema";

                        agendaSermao.Visible = true;
                        agendaSermao.Text = sermao?.tema ?? "Sem sermão";

                        agendaEstCidadeBairro.Visible = true;
                        agendaEstCidadeBairro.Text = $"{igreja.iestado} - {igreja.icidade} - {igreja.ibairro}";
                    }
                    else
                    {
                        // Caso não encontre a igreja associada
                        agendaIgreja.Text = "Igreja não encontrada";
                        agendaData.Visible = agendaTema.Visible = agendaSermao.Visible = agendaEstCidadeBairro.Visible = false;
                    }
                }
                else
                {
                    // Não há agendamentos disponíveis para o índice fornecido
                    if (agendamentoIndex == 0)
                    {
                        // Somente a primeira label exibirá "Sem agendamentos"
                        agendaIgreja.Visible = true;
                        agendaIgreja.Text = "Sem agendamentos";
                    }

                    // Todas as demais labels permanecem ocultas
                    agendaData.Visible = false;
                    agendaTema.Visible = false;
                    agendaSermao.Visible = false;
                    agendaEstCidadeBairro.Visible = false;
                }
            }
        }

    }
}
