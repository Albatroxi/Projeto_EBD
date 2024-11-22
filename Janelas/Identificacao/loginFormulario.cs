using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_EBD.Janelas.Identificacao
{
    public partial class loginFormulario : Form
    {
        Home goHome = new Home();
        public loginFormulario()
        {
            InitializeComponent();
        }

        private void loginButton_Click_1(object sender, EventArgs e)
        {
            // Simples verificação de login
            string usuario = userText.Text;
            string senha = passText.Text;

            // Autenticação fictícia (pode ser substituída por verificação real)
            if (usuario == "eclesio" && senha == "eliane2024")
            {
                // Se o login for válido, fechar o formulário e retornar DialogResult.OK
                this.DialogResult = DialogResult.OK;
                this.Close(); // Fecha o formulário de login

            }
            else
            {
                MessageBox.Show("Usuário ou senha inválidos.");
            }
        }
    }
}
