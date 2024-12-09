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
            this.excluirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sermãoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adicionarSermaoStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.excluirToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.igrejaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastrarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.igrejasCadastradasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agendamentosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agendarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ListarALL = new System.Windows.Forms.TreeView();
            this.lbTitulo = new System.Windows.Forms.Label();
            this.descriptRaiz = new System.Windows.Forms.Label();
            this.agendaIgreja_1 = new System.Windows.Forms.Label();
            this.agendaData_1 = new System.Windows.Forms.Label();
            this.agendaEstCidadeBairro_1 = new System.Windows.Forms.Label();
            this.agendaTema_1 = new System.Windows.Forms.Label();
            this.agendaSermao_1 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.agendaSermao_2 = new System.Windows.Forms.Label();
            this.agendaTema_2 = new System.Windows.Forms.Label();
            this.agendaEstCidadeBairro_2 = new System.Windows.Forms.Label();
            this.agendaData_2 = new System.Windows.Forms.Label();
            this.agendaIgreja_2 = new System.Windows.Forms.Label();
            this.agendaSermao_3 = new System.Windows.Forms.Label();
            this.agendaTema_3 = new System.Windows.Forms.Label();
            this.agendaEstCidadeBairro_3 = new System.Windows.Forms.Label();
            this.agendaData_3 = new System.Windows.Forms.Label();
            this.agendaIgreja_3 = new System.Windows.Forms.Label();
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
            this.adicionarToolStripMenuItem,
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
            // excluirToolStripMenuItem
            // 
            this.excluirToolStripMenuItem.Name = "excluirToolStripMenuItem";
            this.excluirToolStripMenuItem.Size = new System.Drawing.Size(135, 24);
            this.excluirToolStripMenuItem.Text = "Excluir";
            this.excluirToolStripMenuItem.Click += new System.EventHandler(this.excluirToolStripMenuItem_Click);
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
            this.excluirToolStripMenuItem1.Click += new System.EventHandler(this.excluirToolStripMenuItem1_Click);
            // 
            // igrejaToolStripMenuItem
            // 
            this.igrejaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastrarToolStripMenuItem,
            this.igrejasCadastradasToolStripMenuItem});
            this.igrejaToolStripMenuItem.Name = "igrejaToolStripMenuItem";
            this.igrejaToolStripMenuItem.Size = new System.Drawing.Size(55, 23);
            this.igrejaToolStripMenuItem.Text = "Igreja";
            // 
            // cadastrarToolStripMenuItem
            // 
            this.cadastrarToolStripMenuItem.Name = "cadastrarToolStripMenuItem";
            this.cadastrarToolStripMenuItem.Size = new System.Drawing.Size(137, 24);
            this.cadastrarToolStripMenuItem.Text = "Cadastrar";
            this.cadastrarToolStripMenuItem.Click += new System.EventHandler(this.cadastrarToolStripMenuItem_Click);
            // 
            // igrejasCadastradasToolStripMenuItem
            // 
            this.igrejasCadastradasToolStripMenuItem.Name = "igrejasCadastradasToolStripMenuItem";
            this.igrejasCadastradasToolStripMenuItem.Size = new System.Drawing.Size(137, 24);
            this.igrejasCadastradasToolStripMenuItem.Text = "Consultar";
            this.igrejasCadastradasToolStripMenuItem.Click += new System.EventHandler(this.igrejasCadastradasToolStripMenuItem_Click);
            // 
            // agendamentosToolStripMenuItem
            // 
            this.agendamentosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agendarToolStripMenuItem});
            this.agendamentosToolStripMenuItem.Name = "agendamentosToolStripMenuItem";
            this.agendamentosToolStripMenuItem.Size = new System.Drawing.Size(114, 23);
            this.agendamentosToolStripMenuItem.Text = "Agendamentos";
            // 
            // agendarToolStripMenuItem
            // 
            this.agendarToolStripMenuItem.Name = "agendarToolStripMenuItem";
            this.agendarToolStripMenuItem.Size = new System.Drawing.Size(180, 24);
            this.agendarToolStripMenuItem.Text = "Agendar";
            this.agendarToolStripMenuItem.Click += new System.EventHandler(this.agendarToolStripMenuItem_Click);
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
            // agendaIgreja_1
            // 
            this.agendaIgreja_1.AutoSize = true;
            this.agendaIgreja_1.Location = new System.Drawing.Point(12, 114);
            this.agendaIgreja_1.Name = "agendaIgreja_1";
            this.agendaIgreja_1.Size = new System.Drawing.Size(57, 13);
            this.agendaIgreja_1.TabIndex = 16;
            this.agendaIgreja_1.Text = "IGREJA_1";
            // 
            // agendaData_1
            // 
            this.agendaData_1.AutoSize = true;
            this.agendaData_1.Location = new System.Drawing.Point(13, 131);
            this.agendaData_1.Name = "agendaData_1";
            this.agendaData_1.Size = new System.Drawing.Size(48, 13);
            this.agendaData_1.TabIndex = 17;
            this.agendaData_1.Text = "DATA_1";
            // 
            // agendaEstCidadeBairro_1
            // 
            this.agendaEstCidadeBairro_1.AutoSize = true;
            this.agendaEstCidadeBairro_1.Location = new System.Drawing.Point(12, 181);
            this.agendaEstCidadeBairro_1.Name = "agendaEstCidadeBairro_1";
            this.agendaEstCidadeBairro_1.Size = new System.Drawing.Size(162, 13);
            this.agendaEstCidadeBairro_1.TabIndex = 18;
            this.agendaEstCidadeBairro_1.Text = "ESTADO - CIDADE - BAIRRO_1";
            // 
            // agendaTema_1
            // 
            this.agendaTema_1.AutoSize = true;
            this.agendaTema_1.Location = new System.Drawing.Point(13, 148);
            this.agendaTema_1.Name = "agendaTema_1";
            this.agendaTema_1.Size = new System.Drawing.Size(49, 13);
            this.agendaTema_1.TabIndex = 19;
            this.agendaTema_1.Text = "TEMA_1";
            // 
            // agendaSermao_1
            // 
            this.agendaSermao_1.AutoSize = true;
            this.agendaSermao_1.Location = new System.Drawing.Point(13, 165);
            this.agendaSermao_1.Name = "agendaSermao_1";
            this.agendaSermao_1.Size = new System.Drawing.Size(53, 13);
            this.agendaSermao_1.TabIndex = 20;
            this.agendaSermao_1.Text = "SERMAO";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(23, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 30);
            this.label1.TabIndex = 21;
            this.label1.Text = "Agendamentos";
            // 
            // agendaSermao_2
            // 
            this.agendaSermao_2.AutoSize = true;
            this.agendaSermao_2.Location = new System.Drawing.Point(66, 277);
            this.agendaSermao_2.Name = "agendaSermao_2";
            this.agendaSermao_2.Size = new System.Drawing.Size(65, 13);
            this.agendaSermao_2.TabIndex = 26;
            this.agendaSermao_2.Text = "SERMAO_2";
            // 
            // agendaTema_2
            // 
            this.agendaTema_2.AutoSize = true;
            this.agendaTema_2.Location = new System.Drawing.Point(66, 260);
            this.agendaTema_2.Name = "agendaTema_2";
            this.agendaTema_2.Size = new System.Drawing.Size(49, 13);
            this.agendaTema_2.TabIndex = 25;
            this.agendaTema_2.Text = "TEMA_2";
            // 
            // agendaEstCidadeBairro_2
            // 
            this.agendaEstCidadeBairro_2.AutoSize = true;
            this.agendaEstCidadeBairro_2.Location = new System.Drawing.Point(65, 293);
            this.agendaEstCidadeBairro_2.Name = "agendaEstCidadeBairro_2";
            this.agendaEstCidadeBairro_2.Size = new System.Drawing.Size(162, 13);
            this.agendaEstCidadeBairro_2.TabIndex = 24;
            this.agendaEstCidadeBairro_2.Text = "ESTADO - CIDADE - BAIRRO_2";
            // 
            // agendaData_2
            // 
            this.agendaData_2.AutoSize = true;
            this.agendaData_2.Location = new System.Drawing.Point(66, 243);
            this.agendaData_2.Name = "agendaData_2";
            this.agendaData_2.Size = new System.Drawing.Size(48, 13);
            this.agendaData_2.TabIndex = 23;
            this.agendaData_2.Text = "DATA_2";
            // 
            // agendaIgreja_2
            // 
            this.agendaIgreja_2.AutoSize = true;
            this.agendaIgreja_2.Location = new System.Drawing.Point(65, 226);
            this.agendaIgreja_2.Name = "agendaIgreja_2";
            this.agendaIgreja_2.Size = new System.Drawing.Size(57, 13);
            this.agendaIgreja_2.TabIndex = 22;
            this.agendaIgreja_2.Text = "IGREJA_2";
            // 
            // agendaSermao_3
            // 
            this.agendaSermao_3.AutoSize = true;
            this.agendaSermao_3.Location = new System.Drawing.Point(13, 390);
            this.agendaSermao_3.Name = "agendaSermao_3";
            this.agendaSermao_3.Size = new System.Drawing.Size(65, 13);
            this.agendaSermao_3.TabIndex = 31;
            this.agendaSermao_3.Text = "SERMAO_3";
            // 
            // agendaTema_3
            // 
            this.agendaTema_3.AutoSize = true;
            this.agendaTema_3.Location = new System.Drawing.Point(13, 373);
            this.agendaTema_3.Name = "agendaTema_3";
            this.agendaTema_3.Size = new System.Drawing.Size(49, 13);
            this.agendaTema_3.TabIndex = 30;
            this.agendaTema_3.Text = "TEMA_3";
            // 
            // agendaEstCidadeBairro_3
            // 
            this.agendaEstCidadeBairro_3.AutoSize = true;
            this.agendaEstCidadeBairro_3.Location = new System.Drawing.Point(12, 406);
            this.agendaEstCidadeBairro_3.Name = "agendaEstCidadeBairro_3";
            this.agendaEstCidadeBairro_3.Size = new System.Drawing.Size(162, 13);
            this.agendaEstCidadeBairro_3.TabIndex = 29;
            this.agendaEstCidadeBairro_3.Text = "ESTADO - CIDADE - BAIRRO_3";
            // 
            // agendaData_3
            // 
            this.agendaData_3.AutoSize = true;
            this.agendaData_3.Location = new System.Drawing.Point(13, 356);
            this.agendaData_3.Name = "agendaData_3";
            this.agendaData_3.Size = new System.Drawing.Size(48, 13);
            this.agendaData_3.TabIndex = 28;
            this.agendaData_3.Text = "DATA_3";
            // 
            // agendaIgreja_3
            // 
            this.agendaIgreja_3.AutoSize = true;
            this.agendaIgreja_3.Location = new System.Drawing.Point(12, 339);
            this.agendaIgreja_3.Name = "agendaIgreja_3";
            this.agendaIgreja_3.Size = new System.Drawing.Size(57, 13);
            this.agendaIgreja_3.TabIndex = 27;
            this.agendaIgreja_3.Text = "IGREJA_3";
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1014, 622);
            this.Controls.Add(this.agendaSermao_3);
            this.Controls.Add(this.agendaTema_3);
            this.Controls.Add(this.agendaEstCidadeBairro_3);
            this.Controls.Add(this.agendaData_3);
            this.Controls.Add(this.agendaIgreja_3);
            this.Controls.Add(this.agendaSermao_2);
            this.Controls.Add(this.agendaTema_2);
            this.Controls.Add(this.agendaEstCidadeBairro_2);
            this.Controls.Add(this.agendaData_2);
            this.Controls.Add(this.agendaIgreja_2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.agendaSermao_1);
            this.Controls.Add(this.agendaTema_1);
            this.Controls.Add(this.agendaEstCidadeBairro_1);
            this.Controls.Add(this.agendaData_1);
            this.Controls.Add(this.agendaIgreja_1);
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
        private System.Windows.Forms.ToolStripMenuItem igrejasCadastradasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agendarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem excluirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem excluirToolStripMenuItem1;
        private System.Windows.Forms.Label agendaIgreja_1;
        private System.Windows.Forms.Label agendaData_1;
        private System.Windows.Forms.Label agendaEstCidadeBairro_1;
        private System.Windows.Forms.Label agendaTema_1;
        private System.Windows.Forms.Label agendaSermao_1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label agendaSermao_2;
        private System.Windows.Forms.Label agendaTema_2;
        private System.Windows.Forms.Label agendaEstCidadeBairro_2;
        private System.Windows.Forms.Label agendaData_2;
        private System.Windows.Forms.Label agendaIgreja_2;
        private System.Windows.Forms.Label agendaSermao_3;
        private System.Windows.Forms.Label agendaTema_3;
        private System.Windows.Forms.Label agendaEstCidadeBairro_3;
        private System.Windows.Forms.Label agendaData_3;
        private System.Windows.Forms.Label agendaIgreja_3;
    }
}