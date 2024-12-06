namespace Projeto_EBD.Janelas.Categorias
{
    partial class ExcluirCatg
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
            this.cbCat_exc = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btExcCatCancela = new System.Windows.Forms.Button();
            this.btExcCat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cbCat_exc
            // 
            this.cbCat_exc.FormattingEnabled = true;
            this.cbCat_exc.Location = new System.Drawing.Point(53, 54);
            this.cbCat_exc.Name = "cbCat_exc";
            this.cbCat_exc.Size = new System.Drawing.Size(202, 21);
            this.cbCat_exc.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label1.Location = new System.Drawing.Point(59, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(187, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Informe a categoria";
            // 
            // btExcCatCancela
            // 
            this.btExcCatCancela.BackColor = System.Drawing.Color.Crimson;
            this.btExcCatCancela.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btExcCatCancela.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btExcCatCancela.ForeColor = System.Drawing.Color.White;
            this.btExcCatCancela.Location = new System.Drawing.Point(193, 120);
            this.btExcCatCancela.Name = "btExcCatCancela";
            this.btExcCatCancela.Size = new System.Drawing.Size(120, 40);
            this.btExcCatCancela.TabIndex = 6;
            this.btExcCatCancela.Text = "Cancelar";
            this.btExcCatCancela.UseVisualStyleBackColor = false;
            this.btExcCatCancela.Click += new System.EventHandler(this.btExcCatCancela_Click);
            // 
            // btExcCat
            // 
            this.btExcCat.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btExcCat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btExcCat.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btExcCat.ForeColor = System.Drawing.Color.White;
            this.btExcCat.Location = new System.Drawing.Point(13, 120);
            this.btExcCat.Name = "btExcCat";
            this.btExcCat.Size = new System.Drawing.Size(120, 40);
            this.btExcCat.TabIndex = 5;
            this.btExcCat.Text = "Excluir";
            this.btExcCat.UseVisualStyleBackColor = false;
            this.btExcCat.Click += new System.EventHandler(this.btExcCat_Click);
            // 
            // ExcluirCatg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(325, 200);
            this.Controls.Add(this.btExcCatCancela);
            this.Controls.Add(this.btExcCat);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbCat_exc);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "ExcluirCatg";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Excluir uma categoria";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbCat_exc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btExcCatCancela;
        private System.Windows.Forms.Button btExcCat;
    }
}