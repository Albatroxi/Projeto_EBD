using Projeto_EBD.DBContexto;
using Projeto_EBD.Janelas;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
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
            Application.Run(new Home());
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
