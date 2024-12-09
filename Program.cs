using Projeto_EBD.Controllers.Ferramentas;
using Projeto_EBD.Controllers.Ferramentas.Procedimentos;
using Projeto_EBD.DBContexto;
using Projeto_EBD.Janelas;
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
        //static void Main(string[] args)
        static void Main(string[] args)
        {
            // Simulando os argumentos para teste (somente durante o desenvolvimento)
            /*
            if (args == null || args.Length == 0)
            {
                // Apenas para depuração
                args = new string[] { "projetoEBDStart", "eclesio" };
            }
            */

            // Verifica se os argumentos foram passados corretamente
            if (args == null || args.Length < 2 || args[0] != "projetoEBDStart")
            {
                MessageBox.Show(
                    "Este programa deve ser iniciado pelo launcher.\n\n" +
                    "Inicie o programa através do launcher: Projeto_EBD_Launcher.",
                    "Acesso negado",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
                return; // Fecha o programa
            }

            // Agora que sabemos que os argumentos são válidos, podemos acessar o usuário logado
            string usuarioLogado = args[1]; // Nome do usuário logado (ou outro dado)

            dadosESTATICOS.UsuarioLogado = usuarioLogado;

            // Caminho e arquivo de banco de dados
            string dbPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "projEBD.sqlite");

            // Define o DataDirectory como o diretório do executável
            AppDomain.CurrentDomain.SetData("DataDirectory", AppDomain.CurrentDomain.BaseDirectory);

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Home());
        }


        /*
        public static void CriarBancoDeDadosEIniciarTabelas()
        {
            // Inicializa o contexto do banco de dados
            using (var context = new dbContexto())
            {
                try
                {
                    // Inicializa o banco de dados e cria tabelas, se necessário
                    context.Database.Initialize(force: true);

                    // Verificar se a tabela 'Categorias' existe
                    var tableCategorias = context.Database.SqlQuery<int>(
                        "SELECT COUNT(*) FROM sqlite_master WHERE type='table' AND name='Categorias';"
                    ).FirstOrDefault() > 0;

                    if (!tableCategorias)
                    {
                        context.Database.ExecuteSqlCommand(
                            @"CREATE TABLE Categorias (
                        id INTEGER PRIMARY KEY AUTOINCREMENT, 
                        nome TEXT NOT NULL
                    );"
                        );
                    }

                    // Verificar se a tabela 'Sermoes' existe
                    var tableSermoes = context.Database.SqlQuery<int>(
                        "SELECT COUNT(*) FROM sqlite_master WHERE type='table' AND name='Sermoes';"
                    ).FirstOrDefault() > 0;

                    if (!tableSermoes)
                    {
                        context.Database.ExecuteSqlCommand(
                            @"CREATE TABLE Sermoes (
                        id INTEGER PRIMARY KEY AUTOINCREMENT, 
                        tema TEXT NOT NULL, 
                        arquivo BLOB NOT NULL, 
                        id_categoria INTEGER NOT NULL
                    );"
                        );
                    }

                    // Verificar se a tabela 'Igrejas' existe
                    var tableIgrejas = context.Database.SqlQuery<int>(
                        "SELECT COUNT(*) FROM sqlite_master WHERE type='table' AND name='Igrejas';"
                    ).FirstOrDefault() > 0;

                    if (!tableIgrejas)
                    {
                        context.Database.ExecuteSqlCommand(
                            @"CREATE TABLE Igrejas (
                        id INTEGER PRIMARY KEY AUTOINCREMENT,
                        inome TEXT NOT NULL,
                        iendereco TEXT NOT NULL,
                        ibairro TEXT NOT NULL,
                        iestado TEXT NOT NULL,
                        icidade TEXT NOT NULL,
                        itipo TEXT NOT NULL,
                        itelefone TEXT NOT NULL
                    );"
                        );
                    }

                    // Verificar se a tabela 'Agendas' existe
                    var tableAgendas = context.Database.SqlQuery<int>(
                        "SELECT COUNT(*) FROM sqlite_master WHERE type='table' AND name='Agendas';"
                    ).FirstOrDefault() > 0;

                    if (!tableAgendas)
                    {
                        context.Database.ExecuteSqlCommand(
                            @"CREATE TABLE Agendas (
                        id INTEGER PRIMARY KEY AUTOINCREMENT,
                        igreja_id INTEGER NOT NULL,
                        data DATETIME NOT NULL,
                        categoria_id INTEGER NOT NULL,
                        sermao_id INTEGER NOT NULL
                    );"
                        );
                    }

                    // MessageBox.Show("Banco de dados e tabelas criados com sucesso.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Erro ao criar o banco de dados: {ex.Message}");
                }
            }
        }
        */
    }
}
