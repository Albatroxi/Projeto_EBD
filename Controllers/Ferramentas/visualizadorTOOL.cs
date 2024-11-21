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
                    .Where(s => s.id == sermaoID)
                    .Select(s => new { s.id, s.tema, s.arquivo })
                    .FirstOrDefault();

                if (sermao != null)
                {
                    try
                    {
                        // Criar um fluxo na memória
                        File.WriteAllBytes(tempFile, sermao.arquivo);

                        // Inicializar uma nova instância do Word
                        wordApp = new Application();
                        wordApp.Visible = false;

                        // Abrir o documento
                        wordDocument = wordApp.Documents.Open(tempFile);
                        wordApp.Visible = true;

                        return true;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Erro ao abrir o documento: {ex.Message}");
                    }
                    finally
                    {
                        // Liberar o documento e o aplicativo Word
                        if (wordDocument != null)
                        {
                            wordDocument.Close(false);
                            System.Runtime.InteropServices.Marshal.ReleaseComObject(wordDocument);
                            wordDocument = null;
                        }
                        if (wordApp != null)
                        {
                            wordApp.Quit();
                            System.Runtime.InteropServices.Marshal.ReleaseComObject(wordApp);
                            wordApp = null;
                        }
                        GC.Collect();
                        GC.WaitForPendingFinalizers();
                    }
                }
            }

            return false;
        }
    }
}
