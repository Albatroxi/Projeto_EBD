using Newtonsoft.Json;
using System;
using System.Net;
using System.Reflection;

namespace Projeto_EBD.Controllers.Ferramentas
{
    public class verificarUPDATE
    {
        private static string VersaoAtual => Assembly.GetExecutingAssembly().GetName().Version.ToString();
        private const string VersaoInfoUrl = "https://drive.google.com/uc?id=1O-VNvmE-2bb9LzXxPDquakqIvzJH62Xu&export=download";
        private const string NovoExeNome = "NovoApp.exe";

        public bool VerificarAtualizacao()
        {
            try
            {
                using (WebClient client = new WebClient())
                {
                    // Baixar informações da versão
                    string versaoInfoJson = client.DownloadString(VersaoInfoUrl);
                    dynamic versaoInfo = JsonConvert.DeserializeObject(versaoInfoJson);
                    string novaVersao = versaoInfo.version;
                    string downloadUrl = versaoInfo.downloadUrl;

                    // Verificar se há nova versão
                    if (string.Compare(novaVersao, VersaoAtual) > 0)
                    {
                        Console.WriteLine($"Nova versão disponível: {novaVersao}. Atualizando...");
                        //AtualizarAplicativo(downloadUrl);
                    }
                    else
                    {
                        Console.WriteLine("Você já possui a versão mais recente.");

                        return true;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro ao verificar atualização: {ex.Message}");
            }

            return false;
        }
    }
}
