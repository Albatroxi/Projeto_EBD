namespace Projeto_EBD.Janelas.Sermaos
{
    partial class ExcluirSerm
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
            this.cbCat_excSerm = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.label2 = new System.Windows.Forms.Label();
            this.btMarcarTudo = new System.Windows.Forms.Button();
            this.btExcSerms = new System.Windows.Forms.Button();
            this.btDesmarcarTudo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cbCat_excSerm
            // 
            this.cbCat_excSerm.BackColor = System.Drawing.Color.White;
            this.cbCat_excSerm.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCat_excSerm.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.cbCat_excSerm.ForeColor = System.Drawing.Color.Black;
            this.cbCat_excSerm.FormattingEnabled = true;
            this.cbCat_excSerm.Location = new System.Drawing.Point(242, 64);
            this.cbCat_excSerm.Name = "cbCat_excSerm";
            this.cbCat_excSerm.Size = new System.Drawing.Size(265, 29);
            this.cbCat_excSerm.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(174, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(390, 19);
            this.label1.TabIndex = 2;
            this.label1.Text = "Informe abaixo a categoria do sermão que será excluído";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // treeView1
            // 
            this.treeView1.CheckBoxes = true;
            this.treeView1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.treeView1.Location = new System.Drawing.Point(58, 134);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(652, 273);
            this.treeView1.TabIndex = 3;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label2.Location = new System.Drawing.Point(204, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(336, 19);
            this.label2.TabIndex = 4;
            this.label2.Text = "Abaixo os sermões vinculados à categoria selecionada";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btMarcarTudo
            // 
            this.btMarcarTudo.BackColor = System.Drawing.Color.Green;
            this.btMarcarTudo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btMarcarTudo.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btMarcarTudo.ForeColor = System.Drawing.Color.White;
            this.btMarcarTudo.Location = new System.Drawing.Point(315, 427);
            this.btMarcarTudo.Name = "btMarcarTudo";
            this.btMarcarTudo.Size = new System.Drawing.Size(120, 40);
            this.btMarcarTudo.TabIndex = 8;
            this.btMarcarTudo.Text = "Marcar Tudo";
            this.btMarcarTudo.UseVisualStyleBackColor = false;
            this.btMarcarTudo.Click += new System.EventHandler(this.btExcCatCancela_Click);
            // 
            // btExcSerms
            // 
            this.btExcSerms.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btExcSerms.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btExcSerms.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btExcSerms.ForeColor = System.Drawing.Color.White;
            this.btExcSerms.Location = new System.Drawing.Point(58, 427);
            this.btExcSerms.Name = "btExcSerms";
            this.btExcSerms.Size = new System.Drawing.Size(120, 40);
            this.btExcSerms.TabIndex = 7;
            this.btExcSerms.Text = "Excluir";
            this.btExcSerms.UseVisualStyleBackColor = false;
            this.btExcSerms.Click += new System.EventHandler(this.btExcCat_Click);
            // 
            // btDesmarcarTudo
            // 
            this.btDesmarcarTudo.BackColor = System.Drawing.Color.Crimson;
            this.btDesmarcarTudo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btDesmarcarTudo.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btDesmarcarTudo.ForeColor = System.Drawing.Color.White;
            this.btDesmarcarTudo.Location = new System.Drawing.Point(590, 427);
            this.btDesmarcarTudo.Name = "btDesmarcarTudo";
            this.btDesmarcarTudo.Size = new System.Drawing.Size(120, 40);
            this.btDesmarcarTudo.TabIndex = 9;
            this.btDesmarcarTudo.Text = "Desmarcar tudo";
            this.btDesmarcarTudo.UseVisualStyleBackColor = false;
            this.btDesmarcarTudo.Click += new System.EventHandler(this.btDesmarcarTudo_Click);
            // 
            // ExcluirSerm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(773, 494);
            this.Controls.Add(this.btDesmarcarTudo);
            this.Controls.Add(this.btMarcarTudo);
            this.Controls.Add(this.btExcSerms);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbCat_excSerm);
            this.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.Name = "ExcluirSerm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Excluir um sermão";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbCat_excSerm;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btMarcarTudo;
        private System.Windows.Forms.Button btExcSerms;
        private System.Windows.Forms.Button btDesmarcarTudo;
    }
}