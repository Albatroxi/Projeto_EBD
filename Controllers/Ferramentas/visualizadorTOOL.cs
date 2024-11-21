using Microsoft.Office.Interop.Word;
using Projeto_EBD.DBContexto;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Application = Microsoft.Office.Interop.Word.Application;

namespace Projeto_EBD.Controllers.Ferramentas
{
    public class visualizadorTOOL
    {
        private Application wordApp;
        private Document wordDocument;
        public bool carrDocs(int sermaoID, string tempFile)
        {
            // Obtém o sermão selecionado pela ID
            using (var context = new dbContexto())
            {
                var sermao = context.Sermoes
                    .Where(s => s.id == sermaoID)  // Filtro para pegar o sermão específico
                    .Select(s => new { s.id, s.tema, s.arquivo })  // Seleciona apenas os campos id e tema
                    .FirstOrDefault();

                if (sermao != null)
                {
                    try
                    {
                        // Criar um fluxo na memória
                        using (MemoryStream stream = new MemoryStream(sermao.arquivo))
                        {
                            // Ler o conteúdo do stream e abrir no Word
                            File.WriteAllBytes(tempFile, sermao.arquivo);

                            // Tornar o arquivo temporário oculto
                            //File.SetAttributes(tempFile, FileAttributes.Hidden);

                            return true;
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Erro ao abrir o documento: {ex.Message}");
                    }

                }

            }
            return false;
        }
    }
}
