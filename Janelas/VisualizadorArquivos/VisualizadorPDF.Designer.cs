namespace Projeto_EBD.Janelas.VisualizadorArquivos
{
    partial class VisualizadorPDF
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelPdf = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // panelPdf
            // 
            this.panelPdf.Location = new System.Drawing.Point(13, 13);
            this.panelPdf.Name = "panelPdf";
            this.panelPdf.Size = new System.Drawing.Size(775, 425);
            this.panelPdf.TabIndex = 0;
            // 
            // VisualizadorPDF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelPdf);
            this.Name = "VisualizadorPDF";
            this.Text = "VisualizadorPDF";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelPdf;
    }
}