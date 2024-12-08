using Projeto_EBD.Controllers.Categoria;
using Projeto_EBD.DBContexto;
using Projeto_EBD.Model.Sermoes;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using ComboBox = System.Windows.Forms.ComboBox;
using TreeView = System.Windows.Forms.TreeView;

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
                        //commCATEGORIA.ExcluirCategoria(catID);
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

        public bool CarregarSermoesNoTreeView(int categoriaId, TreeView treeView)
        {
            try
            {
                using (var context = new dbContexto())
                {
                    var resultado = context.Sermoes
                        .Where(s => s.id_categoria == categoriaId)
                        .Join(
                            context.Categorias,
                            sermao => sermao.id_categoria,
                            categoria => categoria.id,
                            (sermao, categoria) => new
                            {
                                sermao.id,      // ID do sermão
                                sermao.tema,    // Tema do sermão
                                CategoriaNome = categoria.nome // Nome da categoria
                            }
                        )
                        .ToList();

                    treeView.Nodes.Clear();

                    if (resultado.Any())
                    {
                        foreach (var item in resultado)
                        {
                            var sermaoNode = new TreeNode(item.tema)
                            {
                                Tag = item.id, // Armazena o ID do sermão
                                Checked = false
                            };
                            treeView.Nodes.Add(sermaoNode);
                        }

                        // Retorna true quando resultados são encontrados e adicionados
                        return true;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao carregar sermões: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);

                // Retorna false em caso de exceção
                return false;
            }

            // Retorna false se nenhum sermão for encontrado
            return false;
        }


        public bool ExcluirSermao(int sermaoId)
        {
            using (var context = new dbContexto())
            {
                try
                {
                    // Busca o sermão pelo ID
                    var sermao = context.Sermoes.FirstOrDefault(s => s.id == sermaoId);

                    if (sermao == null)
                    {
                        //MessageBox.Show("Sermão não encontrado.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }

                    // Remove o sermão do contexto
                    context.Sermoes.Remove(sermao);

                    // Salva as alterações no banco
                    context.SaveChanges();

                    //MessageBox.Show("Sermão excluído com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Erro ao excluir o sermão: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
        }

        public void CarregarSermoesNoTreeView(TreeView treeView)
        {
            try
            {
                using (var context = new dbContexto())
                {
                    // Obter os sermões e as categorias
                    var sermaos = context.Sermoes
                        .Join(
                            context.Categorias,
                            sermao => sermao.id_categoria,
                            categoria => categoria.id,
                            (sermao, categoria) => new
                            {
                                sermao.id,      // ID do sermão
                                sermao.tema,    // Tema do sermão
                                categoria.nome  // Nome da categoria
                            }
                        )
                        .ToList();

                    // Limpa o TreeView antes de popular
                    treeView.Nodes.Clear();

                    // Adicionar sermões ao TreeView, agrupando por categoria
                    var categorias = sermaos
                        .GroupBy(s => s.nome) // Agrupar por nome da categoria
                        .ToList();

                    foreach (var categoriaGrupo in categorias)
                    {
                        // Criar um nó para a categoria
                        TreeNode categoriaNode = new TreeNode
                        {
                            Text = categoriaGrupo.Key, // Nome da categoria
                            Tag = categoriaGrupo.Key   // Armazenar o nome da categoria (ou ID, se necessário)
                        };

                        // Adicionar os sermões da categoria como subnós
                        foreach (var sermao in categoriaGrupo)
                        {
                            TreeNode sermaoNode = new TreeNode
                            {
                                Text = sermao.tema, // Tema do sermão
                                Tag = sermao.id     // ID do sermão
                            };

                            // Adicionar o sermão como subnó
                            categoriaNode.Nodes.Add(sermaoNode);
                        }

                        // Adicionar o nó da categoria ao TreeView
                        treeView.Nodes.Add(categoriaNode);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao carregar sermões: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


    }
}
