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
            this.SuspendLayout();
            // 
            // cbCat_excSerm
            // 
            this.cbCat_excSerm.BackColor = System.Drawing.Color.White;
            this.cbCat_excSerm.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCat_excSerm.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.cbCat_excSerm.ForeColor = System.Drawing.Color.Black;
            this.cbCat_excSerm.FormattingEnabled = true;
            this.cbCat_excSerm.Location = new System.Drawing.Point(242, 87);
            this.cbCat_excSerm.Name = "cbCat_excSerm";
            this.cbCat_excSerm.Size = new System.Drawing.Size(265, 29);
            this.cbCat_excSerm.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(174, 65);
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
            this.treeView1.Location = new System.Drawing.Point(58, 165);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(652, 273);
            this.treeView1.TabIndex = 3;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label2.Location = new System.Drawing.Point(204, 143);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(336, 19);
            this.label2.TabIndex = 4;
            this.label2.Text = "Abaixo os sermões vinculados à categoria selecionada";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ExcluirSerm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
    }
}