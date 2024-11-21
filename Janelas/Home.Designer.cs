namespace Projeto_EBD.Janelas
{
    partial class Home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.categoriaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adicionarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.excluirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sermãoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adicionarSermaoStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.excluirToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.ListarALL = new System.Windows.Forms.TreeView();
            this.lbTitulo = new System.Windows.Forms.Label();
            this.descriptRaiz = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.categoriaToolStripMenuItem,
            this.sermãoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 27);
            this.menuStrip1.TabIndex = 11;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // categoriaToolStripMenuItem
            // 
            this.categoriaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adicionarToolStripMenuItem,
            this.editarToolStripMenuItem,
            this.excluirToolStripMenuItem});
            this.categoriaToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.categoriaToolStripMenuItem.ForeColor = System.Drawing.Color.Navy;
            this.categoriaToolStripMenuItem.Name = "categoriaToolStripMenuItem";
            this.categoriaToolStripMenuItem.Size = new System.Drawing.Size(80, 23);
            this.categoriaToolStripMenuItem.Text = "Categoria";
            // 
            // adicionarToolStripMenuItem
            // 
            this.adicionarToolStripMenuItem.BackColor = System.Drawing.Color.White;
            this.adicionarToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.adicionarToolStripMenuItem.Name = "adicionarToolStripMenuItem";
            this.adicionarToolStripMenuItem.Size = new System.Drawing.Size(135, 24);
            this.adicionarToolStripMenuItem.Text = "Adicionar";
            this.adicionarToolStripMenuItem.Click += new System.EventHandler(this.adicionarToolStripMenuItem_Click);
            // 
            // editarToolStripMenuItem
            // 
            this.editarToolStripMenuItem.BackColor = System.Drawing.Color.White;
            this.editarToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.editarToolStripMenuItem.Name = "editarToolStripMenuItem";
            this.editarToolStripMenuItem.Size = new System.Drawing.Size(135, 24);
            this.editarToolStripMenuItem.Text = "Editar";
            // 
            // excluirToolStripMenuItem
            // 
            this.excluirToolStripMenuItem.BackColor = System.Drawing.Color.White;
            this.excluirToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.excluirToolStripMenuItem.Name = "excluirToolStripMenuItem";
            this.excluirToolStripMenuItem.Size = new System.Drawing.Size(135, 24);
            this.excluirToolStripMenuItem.Text = "Excluir";
            // 
            // sermãoToolStripMenuItem
            // 
            this.sermãoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adicionarSermaoStripMenuItem1,
            this.excluirToolStripMenuItem1});
            this.sermãoToolStripMenuItem.Name = "sermãoToolStripMenuItem";
            this.sermãoToolStripMenuItem.Size = new System.Drawing.Size(67, 23);
            this.sermãoToolStripMenuItem.Text = "Sermão";
            // 
            // adicionarSermaoStripMenuItem1
            // 
            this.adicionarSermaoStripMenuItem1.Name = "adicionarSermaoStripMenuItem1";
            this.adicionarSermaoStripMenuItem1.Size = new System.Drawing.Size(135, 24);
            this.adicionarSermaoStripMenuItem1.Text = "Adicionar";
            this.adicionarSermaoStripMenuItem1.Click += new System.EventHandler(this.adicionarSermaoStripMenuItem1_Click);
            // 
            // excluirToolStripMenuItem1
            // 
            this.excluirToolStripMenuItem1.Name = "excluirToolStripMenuItem1";
            this.excluirToolStripMenuItem1.Size = new System.Drawing.Size(135, 24);
            this.excluirToolStripMenuItem1.Text = "Excluir";
            // 
            // ListarALL
            // 
            this.ListarALL.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ListarALL.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.ListarALL.FullRowSelect = true;
            this.ListarALL.Location = new System.Drawing.Point(239, 88);
            this.ListarALL.Name = "ListarALL";
            this.ListarALL.Size = new System.Drawing.Size(316, 300);
            this.ListarALL.TabIndex = 14;
            this.ListarALL.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.ListarALL_AfterSelect);
            // 
            // lbTitulo
            // 
            this.lbTitulo.AutoSize = true;
            this.lbTitulo.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lbTitulo.ForeColor = System.Drawing.Color.Navy;
            this.lbTitulo.Location = new System.Drawing.Point(368, 66);
            this.lbTitulo.Name = "lbTitulo";
            this.lbTitulo.Size = new System.Drawing.Size(58, 19);
            this.lbTitulo.TabIndex = 10;
            this.lbTitulo.Text = "Acervo";
            // 
            // descriptRaiz
            // 
            this.descriptRaiz.BackColor = System.Drawing.Color.LightGray;
            this.descriptRaiz.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic);
            this.descriptRaiz.ForeColor = System.Drawing.Color.Gray;
            this.descriptRaiz.Location = new System.Drawing.Point(0, 430);
            this.descriptRaiz.Name = "descriptRaiz";
            this.descriptRaiz.Size = new System.Drawing.Size(800, 20);
            this.descriptRaiz.TabIndex = 15;
            this.descriptRaiz.Text = "Aqui você poderá selecionar a categoria e, acessar todos os assuntos vinculados.";
            this.descriptRaiz.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 500);
            this.Controls.Add(this.descriptRaiz);
            this.Controls.Add(this.lbTitulo);
            this.Controls.Add(this.ListarALL);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Home";
            this.Text = "Projeto EBD - Gerenciamento";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem categoriaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adicionarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem excluirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sermãoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adicionarSermaoStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem excluirToolStripMenuItem1;
        private System.Windows.Forms.TreeView ListarALL;
        private System.Windows.Forms.Label lbTitulo;
        private System.Windows.Forms.Label descriptRaiz;
    }
}