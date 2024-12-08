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
        public bool AddAgendamento(int igrejaId, DateTime data, int categoriaId, List<int> sermoesIds)
        {
            try
            {
                // Verificando se os parâmetros fornecidos são válidos
                if (igrejaId > 0 && categoriaId > 0 && sermoesIds.Count > 0 && data != DateTime.MinValue)
                {
                    using (var context = new dbContexto())
                    {
                        // Criando o objeto Agendas
                        Model.Agenda.Agendas novoAgendamento = new Model.Agenda.Agendas
                        {
                            igreja_id = igrejaId,
                            data = data,
                            categoria_id = categoriaId
                        };

                        // Adicionando ao banco de dados
                        context.Agendas.Add(novoAgendamento);
                        context.SaveChanges();

                        // Agora associamos os sermões com o agendamento
                        foreach (var sermaoId in sermoesIds)
                        {
                            var agendamentoSermao = new Model.Agenda.Agendas
                            {
                                id = novoAgendamento.id,
                                sermao_id = sermaoId
                            };

                            // Adicionando as associações ao banco de dados
                            context.Agendas.Add(agendamentoSermao);
                        }

                        // Salvar as associações de sermões
                        context.SaveChanges();
                    }

                    // Mensagem de sucesso
                    //MessageBox.Show("Agendamento adicionado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
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


    }
}
