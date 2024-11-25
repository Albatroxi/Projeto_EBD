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
                // Lê o arquivo em bytes
                byte[] conteudoArquivo = File.ReadAllBytes(caminhoArquivo);

                // Dividir o arquivo em partes menores (menores que 1 MB)
                int tamanhoMaximoParte = 950_000; // 950 KB por parte
                int partes = (int)Math.Ceiling((double)conteudoArquivo.Length / tamanhoMaximoParte);

                string shaAnterior = null; // SHA do arquivo anterior
                for (int i = 0; i < partes; i++)
                {
                    // Obtém a parte do arquivo
                    int tamanhoParte = Math.Min(tamanhoMaximoParte, conteudoArquivo.Length - (i * tamanhoMaximoParte));
                    byte[] parteAtual = new byte[tamanhoParte];
                    Array.Copy(conteudoArquivo, i * tamanhoMaximoParte, parteAtual, 0, tamanhoParte);

                    // Codifica a parte em Base64
                    string conteudoBase64 = Convert.ToBase64String(parteAtual);

                    // URL para o endpoint da API do GitHub
                    string url = $"https://api.github.com/repos/{repositorio}/contents/{caminhoDestino}/{nomeArquivo}";

                    using (var client = new HttpClient())
                    {
                        client.DefaultRequestHeaders.Add("User-Agent", "WindowsFormsApp");
                        client.DefaultRequestHeaders.Add("Authorization", $"token {tokenAcesso}");

                        // Verificar se o arquivo já existe para obter o SHA
                        if (i == 0) // Apenas na primeira parte
                        {
                            var response = client.GetAsync(url).Result;
                            if (response.IsSuccessStatusCode)
                            {
                                var existingFile = JsonConvert.DeserializeObject<dynamic>(response.Content.ReadAsStringAsync().Result);
                                shaAnterior = existingFile?.sha; // SHA do arquivo existente
                            }
                        }

                        // Corpo da requisição
                        var requestBody = new
                        {
                            message = $"Enviando parte {i + 1}/{partes} do arquivo",
                            content = conteudoBase64,
                            branch = "main",
                            sha = shaAnterior // Inclui o SHA se necessário
                        };

                        // Enviar a requisição PUT
                        var jsonRequestBody = JsonConvert.SerializeObject(requestBody);
                        var content = new StringContent(jsonRequestBody, Encoding.UTF8, "application/json");
                        var putResponse = client.PutAsync(url, content).Result;

                        // Verificar a resposta
                        if (putResponse.IsSuccessStatusCode)
                        {
                            var result = JsonConvert.DeserializeObject<dynamic>(putResponse.Content.ReadAsStringAsync().Result);
                            shaAnterior = result?.content?.sha; // Atualiza o SHA
                        }
                        else
                        {
                            string errorDetails = putResponse.Content.ReadAsStringAsync().Result;
                            MessageBox.Show($"Erro ao enviar parte {i + 1}: {putResponse.StatusCode}\n{errorDetails}");
                            return;
                        }
                    }
                }

                MessageBox.Show("Arquivo enviado com sucesso!", "Concluído");
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
