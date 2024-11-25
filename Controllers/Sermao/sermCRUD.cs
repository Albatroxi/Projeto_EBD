using Projeto_EBD.DBContexto;
using Projeto_EBD.Model.Sermoes;
using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Projeto_EBD.Controllers.Sermao
{
    public class sermCRUD
    {
        public bool addSermao(string tema, string camArquivo, int catID)
        {
            using (var context = new dbContexto())
            {
                //string categoria = cbCategoria.Text;
                //int categoriaId = (int)cbCategoria.SelectedValue; // Obtém o ID selecionado
                int categoriaId = catID; // Obtém o ID selecionado

                try
                {
                    byte[] arquivoBytes = File.ReadAllBytes(camArquivo); // Carregar o arquivo como byte[]

                    var sermao = new Sermoes
                    {
                        tema = tema,
                        arquivo = arquivoBytes,
                        id_categoria = categoriaId
                    };

                    context.Sermoes.Add(sermao);
                    context.SaveChanges(); // Salvar no banco

                    MessageBox.Show("Sermão cadastrado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    return true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Erro ao salvar o sermão: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            return false;

        }

        public bool updateSermao(int sermaoId, string camArquivo)
        {
            using (var context = new dbContexto())
            {
                try
                {
                    // Encontrar o sermão pelo ID
                    var sermao = context.Sermoes.SingleOrDefault(s => s.id == sermaoId);

                    if (sermao != null)
                    {
                        // Carregar o novo arquivo como byte[]
                        byte[] arquivoBytes = File.ReadAllBytes(camArquivo);

                        // Atualizar o arquivo do sermão
                        sermao.arquivo = arquivoBytes;

                        // Salvar as alterações no banco de dados
                        context.SaveChanges();

                        MessageBox.Show("Sermão atualizado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        return true;
                    }
                    else
                    {
                        MessageBox.Show("Sermão não encontrado!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Erro ao atualizar o sermão: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            return false;
        }

    }
}
