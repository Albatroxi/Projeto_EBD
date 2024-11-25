using Projeto_EBD.Controllers.Ferramentas;
using Projeto_EBD.Controllers.Ferramentas.Procedimentos;
using Projeto_EBD.Janelas;
using System;
using System.IO;
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
            /*
            // Simulando os argumentos para teste (somente durante o desenvolvimento)
            if (args == null || args.Length == 0)
            {
                // Apenas para depuração
                args = new string[] { "projetoEBDStart", "eclesio" };
            }
            */            

            arquivosMANAGER gFileManager = new arquivosMANAGER();
            gFileManager.ExcluirDocsDaPastaExecutavel();
            gFileManager = null;  // Agora o objeto pode ser coletado, se não houver mais referências

            string usuarioLogado = args[1]; // Nome do usuário logado (ou outro dado)


            // Verifica se os argumentos foram passados corretamente
            if (args == null || args.Length < 2 || args[0] != "projetoEBDStart")
            {
                MessageBox.Show(
                    "Este programa deve ser iniciado pelo launcher.\n\n" +
                    "Inicie o programa através do launcher ou forneça os argumentos necessários.",
                    "Acesso negado",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
                return; // Fecha o programa
            }

            //string usuarioLogado = args[1]; // Nome do usuário logado (ou outro dado)

            dadosESTATICOS.UsuarioLogado = args[1];


            //Caminho e arquivo de banco de dados
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
        */
    }
}
