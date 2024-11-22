using Projeto_EBD.DBContexto;
using Projeto_EBD.Janelas;
using Projeto_EBD.Janelas.Carregamento;
using Projeto_EBD.Janelas.Identificacao;
using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Projeto_EBD
{
    internal static class Program
    {
        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //Caminho e arquivo de banco de dados
            string dbPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "projEBD.sqlite");

            // Define o DataDirectory como o diretório do executável
            AppDomain.CurrentDomain.SetData("DataDirectory", AppDomain.CurrentDomain.BaseDirectory);

            // Verificar se o arquivo do banco de dados existe
            if (!File.Exists(dbPath))
            {
                // Se o banco não existir, criar o banco e as tabelas
                CriarBancoDeDadosEIniciarTabelas();
            }

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new verificandoVersao());

            // Primeiro, abre o formulário de verificação
            verificandoVersao formVerificandoVersao = new verificandoVersao();
            formVerificandoVersao.ShowDialog(); // Aguarda o fechamento do formulário de verificação

            // Após o fechamento da tela de verificação, abre o formulário de login
            loginFormulario formLogin = new loginFormulario();

            // Mostra o formulário de login como uma janela modal
            if (formLogin.ShowDialog() == DialogResult.OK) // Supondo que você retorne OK no login bem-sucedido
            {
                // Se o login for bem-sucedido, fecha o login e abre o home
                formLogin.Close();

                Home formHome = new Home();
                Application.Run(formHome); // Inicia o formulário principal
            }
            else
            {
                // Caso o login falhe, a aplicação pode ser encerrada ou algo mais pode ser feito
                MessageBox.Show("Login falhou! A aplicação será encerrada.");
                Environment.Exit(0);
            }


            /*
            using (var verificandoVersao = new verificandoVersao())
            {
                // Exibe o primeiro formulário
                if (verificandoVersao.ShowDialog() == DialogResult.OK)
                {
                    // Abre o próximo formulário Home somente após o fechamento do VerificandoVersao
                    Application.Run(new Home());
                }
            }
            */


        }

        public static void CriarBancoDeDadosEIniciarTabelas()
        {
            // Inicializa o contexto do banco de dados
            using (var context = new dbContexto())
            {
                // Verificar se o banco de dados está acessível
                try
                {
                    context.Database.Initialize(force: true); // Cria o banco e as tabelas, se necessário

                    // Verificar se a tabela 'Categorias' existe
                    var tableCategoria = context.Database.SqlQuery<int>(
                        "SELECT COUNT(*) FROM sqlite_master WHERE type='table' AND name='Categorias';"
                    ).FirstOrDefault() > 0;

                    // Se a tabela não existir, cria a tabela
                    if (!tableCategoria)
                    {
                        context.Database.ExecuteSqlCommand(
                            @"CREATE TABLE Categorias (id INTEGER PRIMARY KEY AUTOINCREMENT, nome TEXT NOT NULL);"
                        );
                    }


                    // Verificar se a tabela 'Categorias' existe
                    var tableSermoes = context.Database.SqlQuery<int>(
                        "SELECT COUNT(*) FROM sqlite_master WHERE type='table' AND name='Sermoes';"
                    ).FirstOrDefault() > 0;

                    // Se a tabela não existir, cria a tabela
                    if (!tableSermoes)
                    {
                        context.Database.ExecuteSqlCommand(
                            @"CREATE TABLE Sermoes (id INTEGER PRIMARY KEY AUTOINCREMENT, tema TEXT NOT NULL, arquivo BLOB NOT NULL, id_categoria INTEGER NOT NULL);"
                        );
                    }

                    //MessageBox.Show("Banco de dados e tabelas criados com sucesso.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Erro ao criar o banco de dados: {ex.Message}");
                }
            }
        }
    }
}
