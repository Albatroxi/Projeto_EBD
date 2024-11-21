namespace Projeto_EBD.Janelas.Categorias
{
    partial class AdicionarCatg
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
            // Declaração dos componentes
            this.insCat = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lbnvCat = new System.Windows.Forms.TextBox();
            this.SuspendLayout();

            // Configuração do botão "Inserir"
            this.insCat.Location = new System.Drawing.Point(95, 130); // Centralizado horizontalmente
            this.insCat.Name = "insCat";
            this.insCat.Size = new System.Drawing.Size(150, 45);
            this.insCat.TabIndex = 5;
            this.insCat.Text = "Inserir";
            this.insCat.UseVisualStyleBackColor = false;
            this.insCat.BackColor = System.Drawing.Color.MediumSlateBlue; // Cor de fundo
            this.insCat.FlatStyle = System.Windows.Forms.FlatStyle.Flat; // Remove bordas padrão
            this.insCat.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.insCat.ForeColor = System.Drawing.Color.White; // Cor do texto
            this.insCat.Click += new System.EventHandler(this.insCat_Click);

            // Configuração do rótulo
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkSlateGray; // Cor do texto
            this.label1.Location = new System.Drawing.Point(20, 30); // Posicionado no topo
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(285, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Digite o nome da nova categoria.";

            // Configuração da caixa de texto
            this.lbnvCat.Location = new System.Drawing.Point(15, 80); // Centralizado
            this.lbnvCat.MaxLength = 50;
            this.lbnvCat.Name = "lbnvCat";
            this.lbnvCat.Size = new System.Drawing.Size(295, 30);
            this.lbnvCat.TabIndex = 3;
            this.lbnvCat.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lbnvCat.BackColor = System.Drawing.Color.WhiteSmoke; // Cor de fundo
            this.lbnvCat.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle; // Borda fina

            // Configuração geral da janela
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(325, 200);
            this.BackColor = System.Drawing.Color.Azure; // Cor de fundo da janela
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog; // Janela fixa com borda
            this.Controls.Add(this.insCat);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbnvCat);
            this.Name = "Adicionar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen; // Centraliza na tela
            this.Text = "Adicionar Categoria";
            this.ResumeLayout(false);
            this.PerformLayout();


        }

        #endregion

        private System.Windows.Forms.Button insCat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox lbnvCat;
    }
}