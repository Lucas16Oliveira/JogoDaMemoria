using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Jogo_da_memória
{
    public partial class FormSM : Form
    {
        const int nCartas = 12;

        byte nCliques;
        byte restanteCt = nCartas / 2;
        Button cartaAnterior;

        public FormSM()
        {
            InitializeComponent();
        }

        private void FormSM_Load(object sender, EventArgs e)
        {
            Ocultar();
            DistribuiCartas();
            AtribuirTags();
            btnVoltar.Visible = false;
            /*tsLabelData.Text = DateTime.Now.ToLongDateString();
            timer1.Enabled = true;
            buttonMostrar.Visible = false;
            buttonJogardnv.Visible = false;*/

        }

        private void Ocultar()
        {
            foreach (Control x in this.Controls)
                if (x is Button && x.Tag.ToString() == "c")
                    x.Visible = false;
        }

        private void AtribuirTags()
        {
            int[] tags = new int[nCartas];
            Random rnd = new Random();
            int n;
            int i = 0;
            while (i < nCartas)
            {
                n = rnd.Next(1, nCartas + 1);
                if (Array.IndexOf(tags, n) == -1)
                {
                    tags[i] = n;
                    i++;
                }
            }

            for (int j = 0; j < nCartas; j++)
                if (tags[j] > nCartas / 2)
                    tags[j] = tags[j] - (nCartas / 2);

            i = 0;
            foreach (Control x in this.Controls)
                if (x is Button && x.Tag.ToString() == "c")
                {
                    x.Tag = tags[i];
                    i++;
                }

        }

        private void DistribuiCartas()
        {
            foreach (Control x in this.Controls)
                if (x is Button && x.Tag.ToString() == "c")
                {
                    x.BackgroundImage = Properties.Resources.CostasCartaMario;
                    x.Visible = true;
                }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Button cartaAtual = (sender as Button);
            string s = "_" + cartaAtual.Tag.ToString();
            object o = Properties.Resources.ResourceManager.GetObject(s);
            cartaAtual.BackgroundImage = (System.Drawing.Image)o;

            if (nCliques == 0)
            {
                cartaAnterior = cartaAtual;
                nCliques++;
            }
            else
                CompararCartas(cartaAnterior, cartaAtual);
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            foreach (Control x in this.Controls)
                if (x is Button && x.Tag.ToString() != "o")
                {
                    string s = "_" + x.Tag.ToString();
                    object o = Properties.Resources.ResourceManager.GetObject(s);
                    x.BackgroundImage = (System.Drawing.Image)o;
                }
            Application.DoEvents();
            System.Threading.Thread.Sleep(800);

            foreach (Control x in this.Controls)
                if (x is Button && x.Tag.ToString() != "o")
                    x.BackgroundImage = Properties.Resources.CostasCartaMario;
        }

        private void CompararCartas(Button cAnterior, Button cAtual)
        {
            Application.DoEvents();
            System.Threading.Thread.Sleep(600);
            if (cAnterior == cAtual)
            {
                MessageBox.Show("Selecionou a mesma carta");
                nCliques = 0;
                cAtual.BackgroundImage = Properties.Resources.CostasCartaMario;

            }
            else
            {
                if (cAtual.Tag.ToString() == cAnterior.Tag.ToString())
                {
                    restanteCt--;
                    nCliques = 0;
                    cAnterior.Visible = false;
                    cAtual.Visible = false;
                    VerificarSeGanhou();
                }
                else
                {
                    nCliques = 0;
                    cAnterior.BackgroundImage = Properties.Resources.CostasCartaMario;
                    cAtual.BackgroundImage = Properties.Resources.CostasCartaMario;
                }
            }
        }

        private void VerificarSeGanhou()
        {

            if (restanteCt == 0)
                MessageBox.Show("Ganhou");
            btnMostrar.Visible = false;
            btnVoltar.Visible = true;
               
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            FormMenuTemas frmMT = new FormMenuTemas();
            frmMT.ShowDialog();
            this.Close();
            
        }

        private void btnVoltarMenuSM_Click(object sender, EventArgs e)
        {
            FormMenuTemas frmM = new FormMenuTemas();
            frmM.ShowDialog();
            Close();
        }
    }
}
