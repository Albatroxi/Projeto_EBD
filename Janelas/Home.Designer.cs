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
            this.sermãoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adicionarSermaoStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.ListarALL = new System.Windows.Forms.TreeView();
            this.lbTitulo = new System.Windows.Forms.Label();
            this.descriptRaiz = new System.Windows.Forms.Label();
            this.igrejaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agendamentosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastrarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.categoriaToolStripMenuItem,
            this.sermãoToolStripMenuItem,
            this.igrejaToolStripMenuItem,
            this.agendamentosToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1014, 27);
            this.menuStrip1.TabIndex = 11;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // categoriaToolStripMenuItem
            // 
            this.categoriaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adicionarToolStripMenuItem});
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
            // sermãoToolStripMenuItem
            // 
            this.sermãoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adicionarSermaoStripMenuItem1});
            this.sermãoToolStripMenuItem.Name = "sermãoToolStripMenuItem";
            this.sermãoToolStripMenuItem.Size = new System.Drawing.Size(67, 23);
            this.sermãoToolStripMenuItem.Text = "Sermão";
            // 
            // adicionarSermaoStripMenuItem1
            // 
            this.adicionarSermaoStripMenuItem1.Name = "adicionarSermaoStripMenuItem1";
            this.adicionarSermaoStripMenuItem1.Size = new System.Drawing.Size(180, 24);
            this.adicionarSermaoStripMenuItem1.Text = "Adicionar";
            this.adicionarSermaoStripMenuItem1.Click += new System.EventHandler(this.adicionarSermaoStripMenuItem1_Click);
            // 
            // ListarALL
            // 
            this.ListarALL.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ListarALL.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.ListarALL.FullRowSelect = true;
            this.ListarALL.Location = new System.Drawing.Point(304, 88);
            this.ListarALL.Name = "ListarALL";
            this.ListarALL.Size = new System.Drawing.Size(402, 406);
            this.ListarALL.TabIndex = 14;
            this.ListarALL.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.ListarALL_AfterSelect);
            // 
            // lbTitulo
            // 
            this.lbTitulo.AutoSize = true;
            this.lbTitulo.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitulo.ForeColor = System.Drawing.Color.Navy;
            this.lbTitulo.Location = new System.Drawing.Point(460, 57);
            this.lbTitulo.Name = "lbTitulo";
            this.lbTitulo.Size = new System.Drawing.Size(82, 30);
            this.lbTitulo.TabIndex = 10;
            this.lbTitulo.Text = "Acervo";
            // 
            // descriptRaiz
            // 
            this.descriptRaiz.BackColor = System.Drawing.Color.LightGray;
            this.descriptRaiz.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descriptRaiz.ForeColor = System.Drawing.Color.Gray;
            this.descriptRaiz.Location = new System.Drawing.Point(-3, 540);
            this.descriptRaiz.Name = "descriptRaiz";
            this.descriptRaiz.Size = new System.Drawing.Size(1017, 40);
            this.descriptRaiz.TabIndex = 15;
            this.descriptRaiz.Text = "Aqui você poderá selecionar a categoria e, acessar todos os assuntos vinculados.";
            this.descriptRaiz.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // igrejaToolStripMenuItem
            // 
            this.igrejaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastrarToolStripMenuItem});
            this.igrejaToolStripMenuItem.Name = "igrejaToolStripMenuItem";
            this.igrejaToolStripMenuItem.Size = new System.Drawing.Size(55, 23);
            this.igrejaToolStripMenuItem.Text = "Igreja";
            // 
            // agendamentosToolStripMenuItem
            // 
            this.agendamentosToolStripMenuItem.Name = "agendamentosToolStripMenuItem";
            this.agendamentosToolStripMenuItem.Size = new System.Drawing.Size(114, 23);
            this.agendamentosToolStripMenuItem.Text = "Agendamentos";
            // 
            // cadastrarToolStripMenuItem
            // 
            this.cadastrarToolStripMenuItem.Name = "cadastrarToolStripMenuItem";
            this.cadastrarToolStripMenuItem.Size = new System.Drawing.Size(180, 24);
            this.cadastrarToolStripMenuItem.Text = "Cadastrar";
            this.cadastrarToolStripMenuItem.Click += new System.EventHandler(this.cadastrarToolStripMenuItem_Click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1014, 622);
            this.Controls.Add(this.descriptRaiz);
            this.Controls.Add(this.lbTitulo);
            this.Controls.Add(this.ListarALL);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
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
        private System.Windows.Forms.ToolStripMenuItem sermãoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adicionarSermaoStripMenuItem1;
        private System.Windows.Forms.TreeView ListarALL;
        private System.Windows.Forms.Label lbTitulo;
        private System.Windows.Forms.Label descriptRaiz;
        private System.Windows.Forms.ToolStripMenuItem igrejaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agendamentosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastrarToolStripMenuItem;
    }
}