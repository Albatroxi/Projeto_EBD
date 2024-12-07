using Projeto_EBD.Controllers.Categoria;
using Projeto_EBD.DBContexto;
using Projeto_EBD.Model.Sermoes;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Projeto_EBD.Controllers.Sermao
{
    public class sermCRUD
    {
        catCRUD commCATEGORIA = new catCRUD();
        public bool addSermao(string tema, string camArquivo, int catID)
        {
            using (var context = new dbContexto())
            {
                //string categoria = cbCategoria.Text;
                //int categoriaId = (int)cbCategoria.SelectedValue; // Obtém o ID selecionado
                int categoriaId = catID; // Obtém o ID selecionado

                try
                {
                    byte[] arquivoBytes = File.ReadAllBytes(camArquivo); // Carregar o arquivo como byte[]

                    var sermao = new Sermoes
                    {
                        tema = tema,
                        arquivo = arquivoBytes,
                        id_categoria = categoriaId
                    };

                    context.Sermoes.Add(sermao);
                    context.SaveChanges(); // Salvar no banco

                    MessageBox.Show("Sermão cadastrado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    return true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Erro ao salvar o sermão: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            return false;

        }

        public bool updateSermao(int sermaoId, string camArquivo)
        {
            using (var context = new dbContexto())
            {
                try
                {
                    // Encontrar o sermão pelo ID
                    var sermao = context.Sermoes.SingleOrDefault(s => s.id == sermaoId);

                    if (sermao != null)
                    {
                        // Carregar o novo arquivo como byte[]
                        byte[] arquivoBytes = File.ReadAllBytes(camArquivo);

                        // Atualizar o arquivo do sermão
                        sermao.arquivo = arquivoBytes;

                        // Salvar as alterações no banco de dados
                        context.SaveChanges();

                        MessageBox.Show("Sermão atualizado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        return true;
                    }
                    else
                    {
                        MessageBox.Show("Sermão não encontrado!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Erro ao atualizar o sermão: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            return false;
        }

        public void CarregarSermoes(ComboBox cbSermoes)
        {
            try
            {
                using (var context = new DBContexto.dbContexto())
                {
                    var sermoes = context.Sermoes.ToList();
                    // Criar um item em branco (ou "placeholder") e adicioná-lo à lista
                    sermoes.Insert(0, new Model.Sermoes.Sermoes { id = 0, tema = "Selecione um sermão" });

                    // Preencha o ComboBox com os nomes das igreja
                    cbSermoes.DataSource = sermoes;
                    cbSermoes.DisplayMember = "tema"; // Exibe o nome da igreja
                    cbSermoes.ValueMember = "id"; // O valor será o Id da igreja

                }
            }
            catch (Exception ex)
            {
                // Tratamento genérico para outras exceções
                MessageBox.Show($"Ocorreu um erro inesperado ao carregar as informações do sermão.\nDetalhes: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        public bool BuscarSermoesPorCategoria(int catID)
        {
            using (var context = new dbContexto())
            {
                try
                {
                    // Busca os sermões relacionados ao ID da categoria
                    var sermoes = context.Sermoes
                        .Where(s => s.id_categoria == catID)
                        .ToList();

                    if (sermoes.Any())
                    {
                        MessageBox.Show($"Foram encontrados {sermoes.Count} sermões para a categoria selecionada.\n"
                            + "Não é permitido a exclusão de uma categoria contendo um ou mais sermões.\n"
                            + "Revise o conteúdo da categoria e realize a exclusão.",
                            "Impossível excluir!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        return false; // Não permite excluir a categoria, pois existem sermões associados.
                    }
                    else
                    {
                        // Nenhum sermão encontrado, permitir exclusão.
                        commCATEGORIA.ExcluirCategoria(catID);
                        return true; // Exclusão bem-sucedida.
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Erro ao buscar sermões: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false; // Falha ao buscar ou excluir.
                }
            }
        }



    }
}
