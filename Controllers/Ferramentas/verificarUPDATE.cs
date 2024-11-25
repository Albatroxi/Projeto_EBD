using Newtonsoft.Json;
using System;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Reflection;

namespace Projeto_EBD.Controllers.Ferramentas
{
    public class verificarUPDATE
    {
        private static string VersaoAtual = "1.0.0";  // Versão atual do seu aplicativo
        private const string VersaoInfoUrl = "https://raw.githubusercontent.com/Albatroxi/EBD_Update/main/ver.json";

        public bool VerificarAtualizacao()
        {
            try
            {
                using (WebClient client = new WebClient())
                {
                    // Baixar informações da versão do JSON
                    string versaoInfoJson = client.DownloadString(VersaoInfoUrl);
                    dynamic versaoInfo = JsonConvert.DeserializeObject(versaoInfoJson);
                    string novaVersao = versaoInfo.version;
                    string downloadUrl = versaoInfo.downloadUrl;

                    // Verificar se há nova versão
                    if (string.Compare(novaVersao, VersaoAtual) > 0)
                    {
                        Console.WriteLine($"Nova versão disponível: {novaVersao}. Atualizando...");
                        AtualizarAplicativo(downloadUrl);
                        return true;
                    }
                    else
                    {
                        Console.WriteLine("Você já possui a versão mais recente.");
                        //return false;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro ao verificar atualização: {ex.Message}");
            }

            return false;
        }

        private void AtualizarAplicativo(string downloadUrl)
        {
            try
            {
                // Nome dos arquivos
                string nomeExecutavelOriginal = "Projeto_EBD.exe";
                string nomeExecutavelNovo = "Projeto_EBD_Novo.exe";

                // Diretório do executável atual
                string diretorioAtual = AppDomain.CurrentDomain.BaseDirectory;
                string arquivoDestino = Path.Combine(diretorioAtual, nomeExecutavelNovo);
                string caminhoExecutavelOriginal = Path.Combine(diretorioAtual, nomeExecutavelOriginal);

                // Finalizar o processo do executável atual
                FinalizarProcesso(nomeExecutavelOriginal);

                using (WebClient client = new WebClient())
                {
                    Console.WriteLine("Baixando nova versão...");
                    client.DownloadFile(downloadUrl, arquivoDestino);

                    // Garantir que o arquivo foi baixado
                    if (File.Exists(arquivoDestino))
                    {
                        Console.WriteLine("Nova versão baixada com sucesso!");
                        Console.WriteLine($"Novo arquivo salvo em: {arquivoDestino}");

                        // Renomear o arquivo
                        if (File.Exists(caminhoExecutavelOriginal))
                        {
                            File.Delete(caminhoExecutavelOriginal); // Deletar o arquivo antigo se existir
                        }

                        File.Move(arquivoDestino, caminhoExecutavelOriginal); // Renomear para o nome original

                        // Executar o novo executável
                        Console.WriteLine("Iniciando o novo executável...");
                        Process.Start(caminhoExecutavelOriginal);
                    }
                    else
                    {
                        Console.WriteLine("Erro ao baixar o novo arquivo.");
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro ao atualizar o aplicativo: {ex.Message}");
            }
        }

        private void FinalizarProcesso(string nomeProcesso)
        {
            try
            {
                foreach (var processo in Process.GetProcessesByName(Path.GetFileNameWithoutExtension(nomeProcesso)))
                {
                    Console.WriteLine($"Finalizando o processo {nomeProcesso}...");
                    processo.Kill();
                    processo.WaitForExit(); // Aguardar o processo ser completamente finalizado
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro ao finalizar o processo: {ex.Message}");
            }
        }
    }
}
