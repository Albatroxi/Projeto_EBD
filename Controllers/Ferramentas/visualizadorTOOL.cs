using Microsoft.Office.Interop.Word;
using Projeto_EBD.Controllers.Sermao;
using Projeto_EBD.DBContexto;
using Projeto_EBD.Janelas;
using System;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Application = Microsoft.Office.Interop.Word.Application;

namespace Projeto_EBD.Controllers.Ferramentas
{
    public class visualizadorTOOL
    {
        private Application wordApp;
        private Document wordDocument;
        private Form homeForm; // Referência à janela principal

        public visualizadorTOOL(Form home)
        {
            this.homeForm = home; // Recebe a referência da janela principal

        }

        public bool carrDocs(int sermaoID, int categoriaID, string tempFile)
        {
            // Obtém o sermão selecionado pela ID e CategoriaID
            using (var context = new dbContexto())
            {
                var sermao = context.Sermoes
                    .Where(s => s.id == sermaoID && s.id_categoria == categoriaID)
                    .Select(s => new { s.id, s.tema, s.arquivo })
                    .FirstOrDefault();

                if (sermao != null)
                {
                    try
                    {
                        // Criar um fluxo na memória
                        File.WriteAllBytes(tempFile, sermao.arquivo);

                        // Torna o arquivo oculto
                        //FileInfo fileInfo = new FileInfo(tempFile);
                        //fileInfo.Attributes = FileAttributes.Hidden;

                        // Inicializar uma nova instância do Word
                        wordApp = new Application();
                        wordApp.Visible = false;

                        // Assinar o evento DocumentBeforeClose
                        wordApp.DocumentBeforeClose += WordApp_DocumentBeforeClose;

                        // Abrir o documento
                        wordDocument = wordApp.Documents.Open(tempFile);
                        wordApp.Visible = true;

                        return true;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Erro ao abrir o documento: {ex.Message}");
                    }
                }
            }

            return false;
        }


        private void WordApp_DocumentBeforeClose(Document doc, ref bool cancel)
        {
            // Exibir a mensagem de confirmação
            var resultado = MessageBox.Show(
                "Deseja realmente fechar o aplicativo?\n" +
                "O aplicativo será atualizado com o arquivo atual.",
                "Confirmação de Saída",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button2); // "Não" como padrão

            if (resultado == DialogResult.No)
            {
                // Cancelar o fechamento e garantir que o Word continue visível
                cancel = true;
                wordApp.Visible = true;
            }
            else
            {
                try
                {
                    // Fechar o documento e salvar as alterações
                    doc.Close(true);  // Salva as alterações antes de fechar o documento

                    // Esperar um pouco para garantir que o arquivo tenha sido liberado
                    System.Threading.Thread.Sleep(500);  // Aguarda meio segundo

                    // Fechar o Word completamente
                    wordApp.Quit();  // Fecha o aplicativo Word

                    // Liberar os recursos do objeto Word
                    Marshal.ReleaseComObject(doc);
                    Marshal.ReleaseComObject(wordApp);

                    sermCRUD getSermCRUD = new sermCRUD();
                    getSermCRUD.updateSermao(dadosESTATICOS.sermaoID, dadosESTATICOS.tempFile);

                    // Mostrar a janela principal
                    if (homeForm != null)
                    {
                        homeForm.Invoke((MethodInvoker)(() => homeForm.Show()));
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Erro ao atualizar o sermão: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
