

using System.Drawing;
using System.Drawing.Drawing2D;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace atividade_6
{
    public partial class Form1 : Form
    {
        /* Colegio Técnico Antônio Teixeira Fernandes(Univap)
         * Curso Técnico em Informática - Data de Entrega: 17/05/2025
         * Autores do Projeto: Murilo Gonçalves de Lima
         *
         * Turma: 2H
         * Atividade Proposta em aula
         * Observação: <colocar se houver>
         * 
         * 
         * ******************************************************************/

        float[] vetor = null;

        int espessura = 1;
        int x1, y1, x2, y2;
        int contadorCliques = 0;

        bool desenharRetangulo = false;
        int[] posicaoRetangulo = null;

        public Form1()
        {
            InitializeComponent();
        }

        private Color cor(int r, int g, int b)
        {
            Color cor = new Color();

            cor = Color.FromArgb(r, g, b);

            return cor;
        }

        private Pen estiloL(Color cor, int esp, float[] estilo = null)
        {
            Pen caneta = new Pen(cor, esp);
            if (estilo != null)
                caneta.DashPattern = estilo;
            return caneta;

        }

        private void Pintap(int x, int y, Color cor, PaintEventArgs e)
        {
            Pen caneta = new Pen(cor);
            e.Graphics.DrawLine(caneta, x, y, x + 1, y);
        }

        private void PintaL(int x1, int y1, int x2, int y2, Pen estilo, PaintEventArgs e)
        {
            e.Graphics.DrawLine(estilo, x1, y1, x2, y2);
        }

        private void pintaRetangulo(int[] pontos, Pen estilo, PaintEventArgs e)
        {

            /*
                float[] vetor = { 10, 1 };
                int[] vetorRetangulo = { 
                    500, 500, 
                    900, 700
                };

                pintaRetangulo(vetorRetangulo, estiloL(vetor, cor(255, 0, 0), 1), e);

            */


            PintaL(pontos[0], pontos[1], pontos[0], pontos[3], estilo, e);
            PintaL(pontos[2], pontos[1], pontos[2], pontos[3], estilo, e);

            PintaL(pontos[0], pontos[1], pontos[2], pontos[1], estilo, e);
            PintaL(pontos[0], pontos[3], pontos[2], pontos[3], estilo, e);

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            switch (comboBox1.SelectedItem.ToString())
            {
                case "Nenhuma":

                    break;
                case "Sólido":

                    break;
                case "Tracejado":
                    vetor = new float[] { 5f, 5f };
                    break;
                case "Traço ponto":
                    vetor = new float[] { 5f, 5f, 1f, 5f };
                    break;
                case "Traço dois pontos":
                    vetor = new float[] { 5f, 5f, 1f, 5f, 1f, 5f };
                    break;
                case "Pontilhado":
                    vetor = new float[] { 1f, 2f };
                    break;
            }

            panel2.Invalidate(); // Força redesenho
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
           
            if (desenharRetangulo)
            {
                pintaRetangulo(posicaoRetangulo, estiloL(cor(0, 0, 0), espessura, vetor), e); 
                desenharRetangulo = false;
            } else
            {
                PintaL(x1, y1, x2, y2, estiloL(cor(0, 0, 0), espessura, vetor), e);
            }
        }

        private void panel2_MouseClick(object sender, MouseEventArgs e)
        {
            if (contadorCliques == 0)
            {
                x1 = e.X;
                y1 = e.Y;
                contadorCliques = 1;
            }

            if (contadorCliques == 1)
            {
                x2 = e.X;
                y2 = e.Y;
                contadorCliques = 0;

                espessura = int.Parse(numericUpDown1.Text);

                // Calcular equação da reta
                if (x2 != x1)
                {
                    float m = (float)(y2 - y1) / (x2 - x1);
                    float b = y1 - m * x1;

                    string sinal = b >= 0 ? " + " : " - ";

                    label4.Text = $"f(x) = {m:0.##}x{sinal}{Math.Abs(b):0.##}";
                }
                else
                {
                    label4.Text = $"x = {x1} (reta vertical)";
                }

                // Calcular comprimento da reta
                double comprimento = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
                label7.Text = $"Comprimento = {comprimento:0.##} px";

                panel2.Invalidate();
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
           int comprimento = int.Parse(textBox3.Text);
           int largura = int.Parse(textBox4.Text);

            x2 = x1 + comprimento;
            y2 = y1 + largura;


            posicaoRetangulo = new int[] { x1, y1, x2, y2};


            desenharRetangulo = true;
            panel2.Invalidate();

        }
    }
}
