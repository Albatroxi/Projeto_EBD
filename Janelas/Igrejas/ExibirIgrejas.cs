using Projeto_EBD.Controllers.Categoria;
using Projeto_EBD.Controllers.Igrejas;
using Projeto_EBD.DBContexto;
using Projeto_EBD.Model.Igrejas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_EBD.Janelas.Igrejas
{
    public partial class ExibirIgrejas : Form
    {
        igrejCRUD commIGREJACRUD = new igrejCRUD();
        public ExibirIgrejas()
        {
            InitializeComponent();

            // Carregar as igrejas
            commIGREJACRUD.CarregarIgrejasCadastradas(cbIgrejas);

            // Caminho da imagem incorporada
            string imageName = "Projeto_EBD.Imagens.IGREJA_EVANG.jpg"; // Nome completo, incluindo o namespace e o caminho da pasta

            // Carregar a imagem incorporada
            using (Stream stream = GetType().Assembly.GetManifestResourceStream(imageName))
            {
                Image originalImage = Image.FromStream(stream);

                // Criar uma imagem transparente
                Image transparentImage = SetImageOpacity(originalImage, 0.2f); // Opacidade 20%

                // Definir como plano de fundo
                this.BackgroundImage = transparentImage;
                this.BackgroundImageLayout = ImageLayout.Stretch; // Ajustar ao tamanho do formulário
            }

            // Inicializa as labels como ocultas
            this.label2.Visible = false;
            this.label3.Visible = false;
            this.label4.Visible = false;
            this.label5.Visible = false;
            this.label6.Visible = false;
            this.label7.Visible = false;
            this.label8.Visible = false;
            this.label9.Visible = false;
            this.label10.Visible = false;
            this.label11.Visible = false;
        }


        private Image SetImageOpacity(Image image, float opacity)
        {
            // Criar um bitmap com a mesma dimensão da imagem original
            Bitmap bmp = new Bitmap(image.Width, image.Height);

            // Criar um objeto Graphics para desenhar no bitmap
            using (Graphics gfx = Graphics.FromImage(bmp))
            {
                // Configurar a transparência
                ColorMatrix colorMatrix = new ColorMatrix
                {
                    Matrix33 = opacity // Define a opacidade (0.0f a 1.0f)
                };

                // Criar um atributo de imagem para aplicar a matriz de cores
                ImageAttributes attributes = new ImageAttributes();
                attributes.SetColorMatrix(colorMatrix, ColorMatrixFlag.Default, ColorAdjustType.Bitmap);

                // Desenhar a imagem original no bitmap com a opacidade definida
                gfx.DrawImage(image, new Rectangle(0, 0, bmp.Width, bmp.Height),
                    0, 0, image.Width, image.Height, GraphicsUnit.Pixel, attributes);
            }

            return bmp;
        }

        private void cbIgrejas_SelectedIndexChanged(object sender, EventArgs e)
        {
            Model.Igrejas.Igrejas igrejaSelecionada = (Model.Igrejas.Igrejas)cbIgrejas.SelectedItem;
            int idIgreja = igrejaSelecionada.id;

            if (cbIgrejas.SelectedItem != null)
            {
                
                // Usar o idIgreja conforme necessário

                this.label2.Visible = true;
                this.label3.Text = igrejaSelecionada.iendereco;
                this.label3.Visible = true;
                this.label4.Visible = true;
                this.label5.Text = igrejaSelecionada.ibairro;
                this.label5.Visible = true;
                this.label6.Visible = true;
                this.label7.Text = igrejaSelecionada.icidade;
                this.label7.Visible = true;
                this.label8.Visible = true;
                this.label9.Text = igrejaSelecionada.iestado;
                this.label9.Visible = true;
                this.label10.Visible = true;
                this.label11.Text = igrejaSelecionada.itelefone;
                this.label11.Visible = true;
            }
            else
            {
                MessageBox.Show("Nenhuma igreja selecionada.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
