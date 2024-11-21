using Projeto_EBD.DBContexto;
using Projeto_EBD.Model.Sermoes;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
    }
}
