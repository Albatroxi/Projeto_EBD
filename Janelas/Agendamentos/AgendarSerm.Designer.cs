namespace Projeto_EBD.Janelas.Agendamentos
{
    partial class AgendarSerm
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
            this.treeView_agendSerm = new System.Windows.Forms.TreeView();
            this.cbCat_agendSerm = new System.Windows.Forms.ComboBox();
            this.dataAgendaSerm = new System.Windows.Forms.MonthCalendar();
            this.btCancAgendamento = new System.Windows.Forms.Button();
            this.btAgendar = new System.Windows.Forms.Button();
            this.cbIgrejas_agendSerm = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // treeView_agendSerm
            // 
            this.treeView_agendSerm.CheckBoxes = true;
            this.treeView_agendSerm.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.treeView_agendSerm.Location = new System.Drawing.Point(12, 346);
            this.treeView_agendSerm.Name = "treeView_agendSerm";
            this.treeView_agendSerm.Size = new System.Drawing.Size(652, 273);
            this.treeView_agendSerm.TabIndex = 5;
            // 
            // cbCat_agendSerm
            // 
            this.cbCat_agendSerm.BackColor = System.Drawing.Color.White;
            this.cbCat_agendSerm.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCat_agendSerm.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.cbCat_agendSerm.ForeColor = System.Drawing.Color.Black;
            this.cbCat_agendSerm.FormattingEnabled = true;
            this.cbCat_agendSerm.Location = new System.Drawing.Point(200, 292);
            this.cbCat_agendSerm.Name = "cbCat_agendSerm";
            this.cbCat_agendSerm.Size = new System.Drawing.Size(265, 29);
            this.cbCat_agendSerm.TabIndex = 4;
            this.cbCat_agendSerm.SelectedIndexChanged += new System.EventHandler(this.cbCat_agendSerm_SelectedIndexChanged);
            // 
            // dataAgendaSerm
            // 
            this.dataAgendaSerm.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.dataAgendaSerm.Location = new System.Drawing.Point(132, 99);
            this.dataAgendaSerm.Name = "dataAgendaSerm";
            this.dataAgendaSerm.TabIndex = 6;
            // 
            // btCancAgendamento
            // 
            this.btCancAgendamento.BackColor = System.Drawing.Color.Crimson;
            this.btCancAgendamento.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btCancAgendamento.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.btCancAgendamento.ForeColor = System.Drawing.Color.White;
            this.btCancAgendamento.Location = new System.Drawing.Point(402, 645);
            this.btCancAgendamento.Name = "btCancAgendamento";
            this.btCancAgendamento.Size = new System.Drawing.Size(120, 40);
            this.btCancAgendamento.TabIndex = 11;
            this.btCancAgendamento.Text = "Cancelar";
            this.btCancAgendamento.UseVisualStyleBackColor = false;
            this.btCancAgendamento.Click += new System.EventHandler(this.btCancAgendamento_Click);
            // 
            // btAgendar
            // 
            this.btAgendar.BackColor = System.Drawing.Color.Green;
            this.btAgendar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btAgendar.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.btAgendar.ForeColor = System.Drawing.Color.White;
            this.btAgendar.Location = new System.Drawing.Point(127, 645);
            this.btAgendar.Name = "btAgendar";
            this.btAgendar.Size = new System.Drawing.Size(120, 40);
            this.btAgendar.TabIndex = 10;
            this.btAgendar.Text = "Agendar";
            this.btAgendar.UseVisualStyleBackColor = false;
            this.btAgendar.Click += new System.EventHandler(this.btAgendar_Click);
            // 
            // cbIgrejas_agendSerm
            // 
            this.cbIgrejas_agendSerm.BackColor = System.Drawing.Color.White;
            this.cbIgrejas_agendSerm.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbIgrejas_agendSerm.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.cbIgrejas_agendSerm.ForeColor = System.Drawing.Color.Black;
            this.cbIgrejas_agendSerm.FormattingEnabled = true;
            this.cbIgrejas_agendSerm.Location = new System.Drawing.Point(215, 39);
            this.cbIgrejas_agendSerm.Name = "cbIgrejas_agendSerm";
            this.cbIgrejas_agendSerm.Size = new System.Drawing.Size(224, 29);
            this.cbIgrejas_agendSerm.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(262, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 19);
            this.label1.TabIndex = 15;
            this.label1.Text = "Selecione o local";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(262, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 19);
            this.label2.TabIndex = 16;
            this.label2.Text = "Selecione a data";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(262, 270);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 19);
            this.label3.TabIndex = 17;
            this.label3.Text = "Selecione o tema";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(262, 324);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(140, 19);
            this.label4.TabIndex = 18;
            this.label4.Text = "Selecione o sermão";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AgendarSerm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(677, 698);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbIgrejas_agendSerm);
            this.Controls.Add(this.btCancAgendamento);
            this.Controls.Add(this.btAgendar);
            this.Controls.Add(this.dataAgendaSerm);
            this.Controls.Add(this.treeView_agendSerm);
            this.Controls.Add(this.cbCat_agendSerm);
            this.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.Name = "AgendarSerm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agendar um sermão";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView treeView_agendSerm;
        private System.Windows.Forms.ComboBox cbCat_agendSerm;
        private System.Windows.Forms.MonthCalendar dataAgendaSerm;
        private System.Windows.Forms.Button btCancAgendamento;
        private System.Windows.Forms.Button btAgendar;
        private System.Windows.Forms.ComboBox cbIgrejas_agendSerm;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}