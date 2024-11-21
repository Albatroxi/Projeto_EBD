namespace Projeto_EBD.Janelas.Sermaos
{
    partial class AdicionarSerm
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
            this.lbnvSerm = new System.Windows.Forms.TextBox();
            this.inserSerm = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.addSermDOCs = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.camSermArquiv = new System.Windows.Forms.Label();
            this.cbCategoriaaddSERM = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lbnvSerm
            // 
            this.lbnvSerm.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lbnvSerm.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbnvSerm.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lbnvSerm.Location = new System.Drawing.Point(12, 59);
            this.lbnvSerm.Name = "lbnvSerm";
            this.lbnvSerm.Size = new System.Drawing.Size(301, 29);
            this.lbnvSerm.TabIndex = 0;
            // 
            // inserSerm
            // 
            this.inserSerm.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.inserSerm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.inserSerm.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.inserSerm.ForeColor = System.Drawing.Color.White;
            this.inserSerm.Location = new System.Drawing.Point(91, 196);
            this.inserSerm.Name = "inserSerm";
            this.inserSerm.Size = new System.Drawing.Size(150, 45);
            this.inserSerm.TabIndex = 1;
            this.inserSerm.Text = "Inserir";
            this.inserSerm.UseVisualStyleBackColor = false;
            this.inserSerm.Click += new System.EventHandler(this.inserSerm_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label1.Location = new System.Drawing.Point(65, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(242, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "Digite o nome do sermão.";
            // 
            // addSermDOCs
            // 
            this.addSermDOCs.BackColor = System.Drawing.Color.SteelBlue;
            this.addSermDOCs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addSermDOCs.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.addSermDOCs.ForeColor = System.Drawing.Color.White;
            this.addSermDOCs.Location = new System.Drawing.Point(184, 136);
            this.addSermDOCs.Name = "addSermDOCs";
            this.addSermDOCs.Size = new System.Drawing.Size(113, 30);
            this.addSermDOCs.TabIndex = 6;
            this.addSermDOCs.Text = ".DOC/.DOCX";
            this.addSermDOCs.UseVisualStyleBackColor = true;
            this.addSermDOCs.Click += new System.EventHandler(this.addSermDOCs_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label2.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label2.Location = new System.Drawing.Point(25, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 21);
            this.label2.TabIndex = 7;
            this.label2.Text = "Carregar arquivo";
            // 
            // camSermArquiv
            // 
            this.camSermArquiv.AutoSize = true;
            this.camSermArquiv.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.camSermArquiv.ForeColor = System.Drawing.Color.Gray;
            this.camSermArquiv.Location = new System.Drawing.Point(12, 169);
            this.camSermArquiv.Name = "camSermArquiv";
            this.camSermArquiv.Size = new System.Drawing.Size(0, 19);
            this.camSermArquiv.TabIndex = 8;
            // 
            // cbCategoriaaddSERM
            // 
            this.cbCategoriaaddSERM.AccessibleName = "cbCategoria";
            this.cbCategoriaaddSERM.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cbCategoriaaddSERM.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.cbCategoriaaddSERM.FormattingEnabled = true;
            this.cbCategoriaaddSERM.Location = new System.Drawing.Point(69, 94);
            this.cbCategoriaaddSERM.Name = "cbCategoriaaddSERM";
            this.cbCategoriaaddSERM.Size = new System.Drawing.Size(200, 29);
            this.cbCategoriaaddSERM.TabIndex = 10;
            this.cbCategoriaaddSERM.SelectedIndexChanged += new System.EventHandler(this.cbCategoria_SelectedIndexChanged);
            // 
            // AdicionarSerm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(339, 247);
            this.Controls.Add(this.cbCategoriaaddSERM);
            this.Controls.Add(this.camSermArquiv);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.addSermDOCs);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.inserSerm);
            this.Controls.Add(this.lbnvSerm);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "AdicionarSerm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Adicionar Sermão";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox lbnvSerm;
        private System.Windows.Forms.Button inserSerm;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button addSermDOCs;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label camSermArquiv;
        private System.Windows.Forms.ComboBox cbCategoriaaddSERM;
    }
}