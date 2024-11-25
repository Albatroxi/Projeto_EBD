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

            // Defina o token diretamente no código (não recomendado em produção)
            string tokenAcesso = "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";

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

            try
            {
                // Abre o arquivo com permissões de compartilhamento
                byte[] conteudoArquivo;
                using (var fileStream = new FileStream(caminhoArquivo, FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
                {
                    conteudoArquivo = new byte[fileStream.Length];
                    fileStream.Read(conteudoArquivo, 0, conteudoArquivo.Length);
                }

                // Codifica o conteúdo do arquivo em Base64
                string conteudoBase64 = Convert.ToBase64String(conteudoArquivo);

                // URL para o endpoint da API do GitHub (criar ou atualizar um arquivo)
                string url = $"https://api.github.com/repos/{repositorio}/contents/{caminhoDestino}/{nomeArquivo}";

                // Primeiro, vamos fazer uma requisição GET para verificar se o arquivo já existe no repositório
                using (var client = new HttpClient())
                {
                    client.DefaultRequestHeaders.Add("User-Agent", "WindowsFormsApp");
                    client.DefaultRequestHeaders.Add("Authorization", $"token {tokenAcesso}");

                    var response = client.GetAsync(url).Result;

                    // Se o arquivo existir, obtemos o sha para atualização
                    string sha = null;
                    if (response.IsSuccessStatusCode)
                    {
                        var existingFile = JsonConvert.DeserializeObject<dynamic>(response.Content.ReadAsStringAsync().Result);
                        sha = existingFile?.sha; // Obtemos o sha do arquivo existente
                    }

                    // Agora, construímos o corpo da requisição com ou sem o parâmetro sha
                    var requestBody = new
                    {
                        message = "Adicionando ou atualizando arquivo via API", // Mensagem de commit
                        content = conteudoBase64,                             // Conteúdo do arquivo em Base64
                        branch = "main",                                      // Nome do branch (use "main" ou "master")
                        sha = sha                                              // Passa o sha se for atualização
                    };

                    // Envia a requisição PUT para criar ou atualizar o arquivo
                    var jsonRequestBody = JsonConvert.SerializeObject(requestBody);
                    var content = new StringContent(jsonRequestBody, Encoding.UTF8, "application/json");

                    var putResponse = client.PutAsync(url, content).Result;

                    // Verificar se a resposta foi bem-sucedida
                    if (putResponse.IsSuccessStatusCode)
                    {
                        MessageBox.Show("Nuvem atualizada!", "Até mais...");
                    }
                    else
                    {
                        // Exibe detalhes do erro
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