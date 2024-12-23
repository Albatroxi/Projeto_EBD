﻿using Newtonsoft.Json;
using System;
using System.IO;
using System.Net.Http;
using System.Text;
using System.Windows.Forms;

namespace Projeto_EBD.Controllers.Ferramentas
{
    public class githubTOOL
    {
        public void EnviaDBANCO()
        {
            string caminhoArquivo = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "projEBD.sqlite"); // Caminho completo do arquivo
            string nomeArquivo = "projEBD.sqlite"; // Nome do arquivo no repositório
            string repositorio = $"Albatroxi/EBD_Update"; // Repositório correto no GitHub
            string caminhoDestino = $@"DBase/{dadosESTATICOS.UsuarioLogado}"; // Caminho do diretório onde o arquivo será armazenado
            string urlToken = "https://www.dropbox.com/scl/fi/bp2a81ue3qo3lcc36rwl0/access.txt?rlkey=ocgy5y33laskktsz7an1nv95l&st=6o1q0of2&dl=1\r\n"; // URL onde o token está armazenado

            string tokenAcesso = string.Empty;

            try
            {
                // Obter o token de acesso do arquivo de texto
                using (var client = new HttpClient())
                {
                    client.DefaultRequestHeaders.Add("User-Agent", "WindowsFormsApp"); // Requerido pelo GitHub

                    var responseToken = client.GetAsync(urlToken).Result;

                    if (responseToken.IsSuccessStatusCode)
                    {
                        // Ler o conteúdo do arquivo que contém o token
                        tokenAcesso = responseToken.Content.ReadAsStringAsync().Result.Trim();

                        if (string.IsNullOrEmpty(tokenAcesso))
                        {
                            MessageBox.Show("Token de acesso não encontrado no arquivo!");
                            return;
                        }
                    }
                    else
                    {
                        MessageBox.Show($"Erro ao obter o token. Código de status: {responseToken.StatusCode}");
                        return;
                    }
                }

                if (string.IsNullOrEmpty(tokenAcesso))
                {
                    MessageBox.Show("Token de acesso ao GitHub não encontrado!");
                    return;
                }

                if (!File.Exists(caminhoArquivo))
                {
                    MessageBox.Show("Arquivo não encontrado no caminho especificado.");
                    return;
                }

                byte[] conteudoArquivo;

                // Lê o arquivo em partes para gerenciar memória, mas concatena antes do envio
                using (var fileStream = new FileStream(caminhoArquivo, FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
                {
                    conteudoArquivo = new byte[fileStream.Length];
                    fileStream.Read(conteudoArquivo, 0, conteudoArquivo.Length);
                }

                // Codifica o conteúdo completo em Base64
                string conteudoBase64 = Convert.ToBase64String(conteudoArquivo);

                // URL para o endpoint da API do GitHub
                string url = $"https://api.github.com/repos/{repositorio}/contents/{caminhoDestino}/{nomeArquivo}";

                using (var client = new HttpClient())
                {
                    client.DefaultRequestHeaders.Add("User-Agent", "WindowsFormsApp");
                    client.DefaultRequestHeaders.Add("Authorization", $"token {tokenAcesso}");

                    // Verifica se o arquivo já existe no repositório
                    string shaAnterior = null;
                    var response = client.GetAsync(url).Result;
                    if (response.IsSuccessStatusCode)
                    {
                        var existingFile = JsonConvert.DeserializeObject<dynamic>(response.Content.ReadAsStringAsync().Result);
                        shaAnterior = existingFile?.sha; // SHA do arquivo existente
                    }

                    // Cria o corpo da requisição
                    var requestBody = new
                    {
                        message = "Adicionando ou atualizando arquivo via API",
                        content = conteudoBase64,
                        branch = "main",
                        sha = shaAnterior // SHA do arquivo existente (para atualizações)
                    };

                    // Envia o arquivo em uma única requisição PUT
                    var jsonRequestBody = JsonConvert.SerializeObject(requestBody);
                    var content = new StringContent(jsonRequestBody, Encoding.UTF8, "application/json");
                    var putResponse = client.PutAsync(url, content).Result;

                    // Verifica a resposta
                    if (putResponse.IsSuccessStatusCode)
                    {
                        MessageBox.Show("Nuvem atualizada!", "Até mais...");
                    }
                    else
                    {
                        string errorDetails = putResponse.Content.ReadAsStringAsync().Result;
                        MessageBox.Show($"Erro ao enviar arquivo: {putResponse.StatusCode}\n{errorDetails}");
                    }
                }
            }
            catch (IOException ex)
            {
                MessageBox.Show($"Erro ao acessar o arquivo: {ex.Message}");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro: {ex.Message}");
            }
        }

    }
}
