namespace Projeto_EBD.Janelas.Agendamentos
{
    partial class AgendarPregacao
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
            this.cbIgrejas_agenda = new System.Windows.Forms.ComboBox();
            this.cbCategorias_agenda = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // cbIgrejas_agenda
            // 
            this.cbIgrejas_agenda.BackColor = System.Drawing.Color.White;
            this.cbIgrejas_agenda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbIgrejas_agenda.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.cbIgrejas_agenda.ForeColor = System.Drawing.Color.Black;
            this.cbIgrejas_agenda.FormattingEnabled = true;
            this.cbIgrejas_agenda.Location = new System.Drawing.Point(109, 63);
            this.cbIgrejas_agenda.Name = "cbIgrejas_agenda";
            this.cbIgrejas_agenda.Size = new System.Drawing.Size(224, 29);
            this.cbIgrejas_agenda.TabIndex = 14;
            this.cbIgrejas_agenda.SelectedIndexChanged += new System.EventHandler(this.cbIgrejas_agenda_SelectedIndexChanged);
            // 
            // cbCategorias_agenda
            // 
            this.cbCategorias_agenda.BackColor = System.Drawing.Color.White;
            this.cbCategorias_agenda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCategorias_agenda.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.cbCategorias_agenda.ForeColor = System.Drawing.Color.Black;
            this.cbCategorias_agenda.FormattingEnabled = true;
            this.cbCategorias_agenda.Location = new System.Drawing.Point(109, 130);
            this.cbCategorias_agenda.Name = "cbCategorias_agenda";
            this.cbCategorias_agenda.Size = new System.Drawing.Size(224, 29);
            this.cbCategorias_agenda.TabIndex = 15;
            // 
            // AgendarPregacao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cbCategorias_agenda);
            this.Controls.Add(this.cbIgrejas_agenda);
            this.Name = "AgendarPregacao";
            this.Text = "Agendar Pregação";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cbIgrejas_agenda;
        private System.Windows.Forms.ComboBox cbCategorias_agenda;
    }
}