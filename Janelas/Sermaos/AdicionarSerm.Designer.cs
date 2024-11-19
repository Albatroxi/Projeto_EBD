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
            this.SuspendLayout();
            // 
            // lbnvSerm
            // 
            this.lbnvSerm.Location = new System.Drawing.Point(12, 86);
            this.lbnvSerm.Name = "lbnvSerm";
            this.lbnvSerm.Size = new System.Drawing.Size(301, 20);
            this.lbnvSerm.TabIndex = 0;
            // 
            // inserSerm
            // 
            this.inserSerm.Location = new System.Drawing.Point(91, 196);
            this.inserSerm.Name = "inserSerm";
            this.inserSerm.Size = new System.Drawing.Size(136, 39);
            this.inserSerm.TabIndex = 1;
            this.inserSerm.Text = "Inserir";
            this.inserSerm.UseVisualStyleBackColor = true;
            this.inserSerm.Click += new System.EventHandler(this.inserSerm_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(56, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(190, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Digite o nome do sermão.";
            // 
            // addSermDOCs
            // 
            this.addSermDOCs.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.addSermDOCs.Location = new System.Drawing.Point(176, 121);
            this.addSermDOCs.Name = "addSermDOCs";
            this.addSermDOCs.Size = new System.Drawing.Size(75, 23);
            this.addSermDOCs.TabIndex = 6;
            this.addSermDOCs.Text = ".PDF";
            this.addSermDOCs.UseVisualStyleBackColor = true;
            this.addSermDOCs.Click += new System.EventHandler(this.addSermDOCs_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Adicionar arquivo do Sermão";
            // 
            // camSermArquiv
            // 
            this.camSermArquiv.AutoSize = true;
            this.camSermArquiv.Location = new System.Drawing.Point(12, 155);
            this.camSermArquiv.Name = "camSermArquiv";
            this.camSermArquiv.Size = new System.Drawing.Size(0, 13);
            this.camSermArquiv.TabIndex = 8;
            // 
            // AdicionarSerm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(339, 247);
            this.Controls.Add(this.camSermArquiv);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.addSermDOCs);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.inserSerm);
            this.Controls.Add(this.lbnvSerm);
            this.Name = "AdicionarSerm";
            this.Text = "Adicionar";
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
    }
}