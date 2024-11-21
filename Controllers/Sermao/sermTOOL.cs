﻿using Projeto_EBD.Janelas.Sermaos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_EBD.Controllers.Sermao
{
    public class sermTOOL
    {
        public string carregarArquivoSermao()
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "Arquivos do Word (*.doc;*.docx)|*.doc;*.docx",
                Title = "Selecione o Arquivo do Sermão"
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                //camSermArquiv.Text = openFileDialog.FileName; // Exibe o caminho do arquivo selecionado
                return openFileDialog.FileName;
            }

            return null;
        }
    }
}