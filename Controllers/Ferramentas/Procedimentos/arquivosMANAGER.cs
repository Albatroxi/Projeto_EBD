using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_EBD.Controllers.Ferramentas.Procedimentos
{
    public class arquivosMANAGER
    {
        public void ExcluirDocsDaPastaExecutavel()
        {
            try
            {
                // Obtém o caminho da pasta do executável (diretório atual do programa)
                string pastaExecutavel = AppDomain.CurrentDomain.BaseDirectory;

                // Obtém todos os arquivos .doc na pasta do executável
                string[] arquivosDoc = Directory.GetFiles(pastaExecutavel, "*.doc");

                // Exclui cada arquivo encontrado
                foreach (string arquivo in arquivosDoc)
                {
                    try
                    {
                        File.Delete(arquivo);
                        Console.WriteLine($"Arquivo {arquivo} excluído com sucesso.");
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"Erro ao excluir o arquivo {arquivo}: {ex.Message}");
                    }
                }

                Console.WriteLine("Processo de exclusão concluído.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro ao buscar arquivos na pasta do executável: {ex.Message}");
            }
        }
    }
}
