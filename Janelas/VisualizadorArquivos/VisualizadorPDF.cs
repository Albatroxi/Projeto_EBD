using PdfiumViewer;
using Projeto_EBD.DBContexto;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_EBD.Janelas.VisualizadorArquivos
{
    public partial class VisualizadorPDF : Form
    {
        public VisualizadorPDF(byte[] arquivoPdf)
        {
            InitializeComponent();

            ExibirPdf(arquivoPdf);
        }

        private void ExibirPdf(byte[] arquivoPdf)
        {
            // Converte o byte[] em um MemoryStream
            using (var stream = new MemoryStream(arquivoPdf))
            {
                // Carrega o PDF no controle PdfViewer
                var pdfViewer = new PdfViewer
                {
                    Document = PdfiumViewer.PdfDocument.Load(stream),
                    Dock = DockStyle.Fill
                };

                // Limpa o painel e adiciona o controle PdfViewer
                panelPdf.Controls.Clear();
                panelPdf.Controls.Add(pdfViewer);
            }
        }
    }
}
