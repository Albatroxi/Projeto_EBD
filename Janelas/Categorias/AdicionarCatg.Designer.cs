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
            this.insCat = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lbnvCat = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // insCat
            // 
            this.insCat.Location = new System.Drawing.Point(85, 112);
            this.insCat.Name = "insCat";
            this.insCat.Size = new System.Drawing.Size(136, 39);
            this.insCat.TabIndex = 5;
            this.insCat.Text = "Inserir";
            this.insCat.UseVisualStyleBackColor = true;
            this.insCat.Click += new System.EventHandler(this.insCat_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(35, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(241, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Digite o nome da nova categoria.";
            // 
            // lbnvCat
            // 
            this.lbnvCat.Location = new System.Drawing.Point(12, 86);
            this.lbnvCat.MaxLength = 50;
            this.lbnvCat.Name = "lbnvCat";
            this.lbnvCat.Size = new System.Drawing.Size(296, 20);
            this.lbnvCat.TabIndex = 3;
            // 
            // Adicionar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(325, 214);
            this.Controls.Add(this.insCat);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbnvCat);
            this.Name = "Adicionar";
            this.Text = "Adicionar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button insCat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox lbnvCat;
    }
}