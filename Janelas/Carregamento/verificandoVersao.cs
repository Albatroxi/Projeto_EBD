using Projeto_EBD.Controllers.Ferramentas;
using System;
using System.Windows.Forms;

namespace Projeto_EBD.Janelas.Carregamento
{
    public partial class verificandoVersao : Form
    {
        public string principalPosUPDATE { get; set; }
        private Timer closeTimer;
        verificarUPDATE vUpdate = new verificarUPDATE();
        Home goHome = new Home();
        public verificandoVersao()
        {
            InitializeComponent();

            carregaFuncionalidades();
        }

        public void carregaFuncionalidades()
        {
            var checkOK = vUpdate.VerificarAtualizacao();

            if (checkOK == true)
            {
                // Configurar o Timer
                closeTimer = new Timer();
                closeTimer.Interval = 2000; // Tempo em milissegundos (2 segundos)
                closeTimer.Tick += CloseTimer_Tick;

                // Iniciar o Timer
                closeTimer.Start();
                //this.Close();
            }
            else
            {
                MessageBox.Show("Desculpe, ocorreu um erro ao verificar atualização.\nVerifique se você possui conectividade com a internet.",
                "Erro de Conexão",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
                // Interrompe o timer, se houver
                if (closeTimer != null)
                {
                    closeTimer.Stop();
                    closeTimer.Dispose();
                }
                Environment.Exit(0); // Força o encerramento da aplicação

            }
        }

        private void CloseTimer_Tick(object sender, EventArgs e)
        {
            // Parar o Timer
            closeTimer.Stop();

            this.Close();
        }
    }
}
