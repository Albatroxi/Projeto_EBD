using Projeto_EBD.DBContexto;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Projeto_EBD.Janelas.Igrejas
{
    public partial class AdicionarIgreja : Form
    {
        public AdicionarIgreja()
        {
            InitializeComponent();
            ListarTiposIgreja();
            cbEstado.DataSource = new List<string>(cidadesPorEstado.Keys);
            cbEstado.SelectedIndexChanged += CmbEstados_SelectedIndexChanged;
        }

        // Lista com os nomes de todos os estados do Brasil
        string[] estadosBrasil = new string[]
        {
    "Acre (AC)", "Alagoas (AL)", "Amapá (AP)", "Amazonas (AM)", "Bahia (BA)", "Ceará (CE)",
    "Distrito Federal (DF)", "Espírito Santo (ES)", "Goiás (GO)", "Maranhão (MA)",
    "Mato Grosso (MT)", "Mato Grosso do Sul (MS)", "Minas Gerais (MG)", "Pará (PA)",
    "Paraíba (PB)", "Paraná (PR)", "Pernambuco (PE)", "Piauí (PI)", "Rio de Janeiro (RJ)",
    "Rio Grande do Norte (RN)", "Rio Grande do Sul (RS)", "Rondônia (RO)", "Roraima (RR)",
    "Santa Catarina (SC)", "São Paulo (SP)", "Sergipe (SE)", "Tocantins (TO)"
        };

        private Dictionary<string, List<string>> cidadesPorEstado = new Dictionary<string, List<string>>()
{
    { "Acre (AC)", new List<string> { "Rio Branco", "Cruzeiro do Sul", "Sena Madureira", "Tarauacá", "Feijó" } },
    { "Alagoas (AL)", new List<string> { "Maceió", "Arapiraca", "Palmeira dos Índios", "Rio Largo", "União dos Palmares" } },
    { "Amazonas (AM)", new List<string> { "Manaus", "Parintins", "Itacoatiara", "Tefé", "Manacapuru" } },
    { "Amapá (AP)", new List<string> { "Macapá", "Santana", "Laranjal do Jari", "Oiapoque", "Mazagão" } },
    { "Bahia (BA)", new List<string> { "Salvador", "Feira de Santana", "Vitória da Conquista", "Camaçari", "Itabuna", "Ilhéus", "Lauro de Freitas" } },
    { "Ceará (CE)", new List<string> { "Fortaleza", "Juazeiro do Norte", "Sobral", "Caucaia", "Maracanaú" } },
    { "Distrito Federal (DF)", new List<string> { "Brasília", "Taguatinga", "Ceilândia", "Gama", "Samambaia" } },
    { "Espírito Santo (ES)", new List<string> { "Vitória", "Vila Velha", "Serra", "Cariacica", "Guarapari" } },
    { "Goiás (GO)", new List<string> { "Goiânia", "Aparecida de Goiânia", "Anápolis", "Rio Verde", "Luziânia" } },
    { "Maranhão (MA)", new List<string> { "São Luís", "Imperatriz", "Timon", "Caxias", "Codó" } },
    { "Mato Grosso (MT)", new List<string> { "Cuiabá", "Várzea Grande", "Rondonópolis", "Sinop", "Tangará da Serra" } },
    { "Mato Grosso do Sul (MS)", new List<string> { "Campo Grande", "Dourados", "Três Lagoas", "Corumbá", "Ponta Porã" } },
    { "Minas Gerais (MG)", new List<string> { "Belo Horizonte", "Uberlândia", "Contagem", "Juiz de Fora", "Betim", "Montes Claros", "Ipatinga", "Sete Lagoas" } },
    { "Pará (PA)", new List<string> { "Belém", "Ananindeua", "Santarém", "Marabá", "Castanhal" } },
    { "Paraíba (PB)", new List<string> { "João Pessoa", "Campina Grande", "Santa Rita", "Patos", "Bayeux" } },
    { "Paraná (PR)", new List<string> { "Curitiba", "Londrina", "Maringá", "Cascavel", "Ponta Grossa", "Foz do Iguaçu", "Campo Largo" } },
    { "Pernambuco (PE)", new List<string> { "Recife", "Jaboatão dos Guararapes", "Olinda", "Caruaru", "Petrolina" } },
    { "Piauí (PI)", new List<string> { "Teresina", "Parnaíba", "Picos", "Floriano", "Piripiri" } },
    { "Rio de Janeiro (RJ)", new List<string> { "Rio de Janeiro", "Niterói", "Petrópolis", "Nova Iguaçu", "Duque de Caxias", "Campos dos Goytacazes", "Macaé" } },
    { "Rio Grande do Norte (RN)", new List<string> { "Natal", "Mossoró", "Parnamirim", "Caicó", "São Gonçalo do Amarante" } },
    { "Rio Grande do Sul (RS)", new List<string> { "Porto Alegre", "Caxias do Sul", "Pelotas", "Santa Maria", "Canoas", "Novo Hamburgo" } },
    { "Rondônia (RO)", new List<string> { "Porto Velho", "Ji-Paraná", "Ariquemes", "Cacoal", "Vilhena" } },
    { "Roraima (RR)", new List<string> { "Boa Vista", "Rorainópolis", "Caracaraí", "Mucajaí", "Pacaraima" } },
    { "Santa Catarina (SC)", new List<string> { "Florianópolis", "Joinville", "Blumenau", "Chapecó", "Itajaí", "São José", "Balneário Camboriú" } },
    { "São Paulo (SP)", new List<string> { "São Paulo", "Campinas", "Santos", "Ribeirão Preto", "Sorocaba", "São Bernardo do Campo", "Guarulhos", "Osasco" } },
    { "Sergipe (SE)", new List<string> { "Aracaju", "Nossa Senhora do Socorro", "Lagarto", "Itabaiana", "Estância" } },
    { "Tocantins (TO)", new List<string> { "Palmas", "Araguaína", "Gurupi", "Porto Nacional", "Paraíso do Tocantins" } }
};

        // Evento chamado quando o estado é selecionado
        private void CmbEstados_SelectedIndexChanged(object sender, EventArgs e)
        {
            string estadoSelecionado = cbEstado.SelectedItem.ToString();

            if (cidadesPorEstado.ContainsKey(estadoSelecionado))
            {
                cbCidade.DataSource = cidadesPorEstado[estadoSelecionado];
            }
            else
            {
                cbCidade.DataSource = null; // Limpa o segundo ComboBox se não houver cidades
            }
        }
        private void ListarTiposIgreja()
        {
            cmbTipo.Items.Add("Adventista");
            cmbTipo.Items.Add("Anglicana");
            cmbTipo.Items.Add("Batista");
            cmbTipo.Items.Add("Reformada");
            cmbTipo.Items.Add("Luterana");
            cmbTipo.Items.Add("Metodista");
            cmbTipo.Items.Add("Pentecostal");
        }

        private void btCancela_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Tem certeza que deseja desistir de adicionar uma igreja?", "Cancelar cadastramento", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                // Realizar ações de cancelamento, por exemplo, fechar o formulário
                this.Close();
            }
            // Se o usuário clicar em "No", a ação de cancelamento não será realizada
        }

        private void btAddIgre_Click(object sender, EventArgs e)
        {
            // Obter o valor selecionado no ComboBox
            string estIgreja = cbEstado.SelectedItem?.ToString(); // Usando null conditional operator para evitar exceção caso nada tenha sido selecionado
            string cidIgreja = cbCidade.SelectedItem?.ToString(); // Usando null conditional operator para evitar exceção caso nada tenha sido selecionado
            string tipIgreja = cmbTipo.SelectedItem?.ToString(); // Usando null conditional operator para evitar exceção caso nada tenha sido selecionado

            // Obter o valor inserido no TextBox
            string nomIgreja = nIgreja.Text;
            string eIgreja = endIgreja.Text;
            string bIgreja = bairroIgreja.Text;

            string telLider = txTel.Text;

            // Exibir os valores no console
            Console.WriteLine($"Nome da igreja: {nomIgreja}");
            Console.WriteLine($"Endereço da igreja: {eIgreja}");
            Console.WriteLine($"Bairro da igreja: {bIgreja}");
            Console.WriteLine($"Estado da igreja: {estIgreja}");
            Console.WriteLine($"Cidade da igreja: {cidIgreja}");
            Console.WriteLine($"Tipo da igreja: {tipIgreja}");
            Console.WriteLine($"Telefone da liderança: {telLider}");

        }
    }
}
