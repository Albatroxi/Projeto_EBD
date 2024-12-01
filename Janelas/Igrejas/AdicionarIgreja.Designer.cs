namespace Projeto_EBD.Janelas.Igrejas
{
    partial class AdicionarIgreja
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
            this.nIgreja = new System.Windows.Forms.TextBox();
            this.endIgreja = new System.Windows.Forms.TextBox();
            this.cmbTipo = new System.Windows.Forms.ComboBox();
            this.btAddIgre = new System.Windows.Forms.Button();
            this.btCancela = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cbEstado = new System.Windows.Forms.ComboBox();
            this.cbCidade = new System.Windows.Forms.ComboBox();
            this.bairroIgreja = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txTel = new System.Windows.Forms.MaskedTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // nIgreja
            // 
            this.nIgreja.BackColor = System.Drawing.Color.WhiteSmoke;
            this.nIgreja.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nIgreja.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.nIgreja.Location = new System.Drawing.Point(30, 78);
            this.nIgreja.Name = "nIgreja";
            this.nIgreja.Size = new System.Drawing.Size(479, 29);
            this.nIgreja.TabIndex = 0;
            // 
            // endIgreja
            // 
            this.endIgreja.BackColor = System.Drawing.Color.WhiteSmoke;
            this.endIgreja.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.endIgreja.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.endIgreja.Location = new System.Drawing.Point(30, 140);
            this.endIgreja.Name = "endIgreja";
            this.endIgreja.Size = new System.Drawing.Size(338, 29);
            this.endIgreja.TabIndex = 1;
            // 
            // cmbTipo
            // 
            this.cmbTipo.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cmbTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipo.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.cmbTipo.FormattingEnabled = true;
            this.cmbTipo.Location = new System.Drawing.Point(30, 264);
            this.cmbTipo.Name = "cmbTipo";
            this.cmbTipo.Size = new System.Drawing.Size(224, 29);
            this.cmbTipo.TabIndex = 2;
            // 
            // btAddIgre
            // 
            this.btAddIgre.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btAddIgre.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btAddIgre.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btAddIgre.ForeColor = System.Drawing.Color.White;
            this.btAddIgre.Location = new System.Drawing.Point(128, 319);
            this.btAddIgre.Name = "btAddIgre";
            this.btAddIgre.Size = new System.Drawing.Size(120, 40);
            this.btAddIgre.TabIndex = 3;
            this.btAddIgre.Text = "Adicionar";
            this.btAddIgre.UseVisualStyleBackColor = false;
            this.btAddIgre.Click += new System.EventHandler(this.btAddIgre_Click);
            // 
            // btCancela
            // 
            this.btCancela.BackColor = System.Drawing.Color.Crimson;
            this.btCancela.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btCancela.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btCancela.ForeColor = System.Drawing.Color.White;
            this.btCancela.Location = new System.Drawing.Point(308, 319);
            this.btCancela.Name = "btCancela";
            this.btCancela.Size = new System.Drawing.Size(120, 40);
            this.btCancela.TabIndex = 4;
            this.btCancela.Text = "Cancelar";
            this.btCancela.UseVisualStyleBackColor = false;
            this.btCancela.Click += new System.EventHandler(this.btCancela_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label1.Location = new System.Drawing.Point(30, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "Nome da Igreja";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label2.Location = new System.Drawing.Point(32, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 25);
            this.label2.TabIndex = 6;
            this.label2.Text = "Endereço";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label3.Location = new System.Drawing.Point(76, 236);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 25);
            this.label3.TabIndex = 7;
            this.label3.Text = "Tipo da Igreja";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label4.Location = new System.Drawing.Point(66, 174);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 25);
            this.label4.TabIndex = 10;
            this.label4.Text = "Estado";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label5.Location = new System.Drawing.Point(312, 174);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 25);
            this.label5.TabIndex = 11;
            this.label5.Text = "Cidade";
            // 
            // cbEstado
            // 
            this.cbEstado.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cbEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbEstado.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.cbEstado.FormattingEnabled = true;
            this.cbEstado.Location = new System.Drawing.Point(30, 204);
            this.cbEstado.Name = "cbEstado";
            this.cbEstado.Size = new System.Drawing.Size(224, 29);
            this.cbEstado.TabIndex = 12;
            // 
            // cbCidade
            // 
            this.cbCidade.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cbCidade.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCidade.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.cbCidade.FormattingEnabled = true;
            this.cbCidade.Location = new System.Drawing.Point(275, 204);
            this.cbCidade.Name = "cbCidade";
            this.cbCidade.Size = new System.Drawing.Size(234, 29);
            this.cbCidade.TabIndex = 13;
            // 
            // bairroIgreja
            // 
            this.bairroIgreja.BackColor = System.Drawing.Color.WhiteSmoke;
            this.bairroIgreja.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.bairroIgreja.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.bairroIgreja.Location = new System.Drawing.Point(374, 140);
            this.bairroIgreja.Name = "bairroIgreja";
            this.bairroIgreja.Size = new System.Drawing.Size(135, 29);
            this.bairroIgreja.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label6.Location = new System.Drawing.Point(397, 112);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 25);
            this.label6.TabIndex = 15;
            this.label6.Text = "Bairro";
            // 
            // txTel
            // 
            this.txTel.Location = new System.Drawing.Point(275, 273);
            this.txTel.Mask = "(99) 00000-0000";
            this.txTel.Name = "txTel";
            this.txTel.Size = new System.Drawing.Size(234, 20);
            this.txTel.TabIndex = 16;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.label8.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label8.Location = new System.Drawing.Point(286, 247);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(199, 25);
            this.label8.TabIndex = 18;
            this.label8.Text = "Número da liderança";
            // 
            // AdicionarIgreja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(559, 371);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txTel);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.bairroIgreja);
            this.Controls.Add(this.cbCidade);
            this.Controls.Add(this.cbEstado);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btCancela);
            this.Controls.Add(this.btAddIgre);
            this.Controls.Add(this.cmbTipo);
            this.Controls.Add(this.endIgreja);
            this.Controls.Add(this.nIgreja);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "AdicionarIgreja";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Adicionar Igreja";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox nIgreja;
        private System.Windows.Forms.TextBox endIgreja;
        private System.Windows.Forms.ComboBox cmbTipo;
        private System.Windows.Forms.Button btAddIgre;
        private System.Windows.Forms.Button btCancela;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbEstado;
        private System.Windows.Forms.ComboBox cbCidade;
        private System.Windows.Forms.TextBox bairroIgreja;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MaskedTextBox txTel;
        private System.Windows.Forms.Label label8;
    }
}