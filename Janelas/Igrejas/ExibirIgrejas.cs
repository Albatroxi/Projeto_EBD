﻿using Projeto_EBD.Controllers.Categoria;
using Projeto_EBD.Controllers.Igrejas;
using Projeto_EBD.DBContexto;
using Projeto_EBD.Model.Igrejas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_EBD.Janelas.Igrejas
{
    public partial class ExibirIgrejas : Form
    {
        igrejTOOL commIGREJATOOL = new igrejTOOL();
        public ExibirIgrejas()
        {
            InitializeComponent();

            //Carregar as igrejas
            commIGREJATOOL.CarregarIgrejasCadastradas(cbIgrejas);
        }

        private void cbIgrejas_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}