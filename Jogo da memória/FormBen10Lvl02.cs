using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Jogo_da_memória
{
    public partial class FormBen10Lvl02 : Form
    {
        static public bool mostrar = false;
        static public bool Vganhou = false;

        private int totalSegundos01;
        const int nCartas01 = 22;

        static public byte nMovimentos;
        static public int moedasTotal = 0;
        static public byte moedasGanha;
        byte nCliques01;
        byte restanteCt01 = nCartas01 / 2;
        Button cartaAnterior01;

        public FormBen10Lvl02()
        {
            InitializeComponent();
        }

        private void FormBen10Lvl02_Load(object sender, EventArgs e)
        {
            pbCoinGanho.Visible = false;
            btnDificuldade.Visible = false;
            btnDificuldade02.Visible = false;


            moedasTotal = moedasTotal + moedasGanha;
            LabelDinheiro.Text = "X  " + moedasTotal.ToString();

            btnNivelAnterior.Visible = false;
            btnDificuldade.Visible = false;
            btnProximoNivel.Visible = false;
            LabelMostrarTime.Visible = false;
            LabelDinheiroGanho.Visible = false;
            LabelTotalClicks.Visible = false;

            int lvl1 = 2;
            int lvl1s = 0;
            int minutos = int.Parse(lvl1.ToString());
            int segundos = int.Parse(lvl1s.ToString());

            totalSegundos01 = (minutos * 60) + segundos;

            Ocultar();
            DistribuiCartas();
            AtribuirTags();
        }

        private void Ocultar()
        {
            foreach (Control x in this.Controls)
                if (x is Button && x.Tag.ToString() == "c")
                    x.Visible = false;

        }

        private void AtribuirTags()
        {
            int[] tags = new int[nCartas01];
            Random rnd = new Random();
            int n;
            int i = 0;
            while (i < nCartas01)
            {
                n = rnd.Next(1, nCartas01 + 1);
                if (Array.IndexOf(tags, n) == -1)
                {
                    tags[i] = n;
                    i++;
                }
            }

            for (int j = 0; j < nCartas01; j++)
                if (tags[j] > nCartas01 / 2)
                    tags[j] = tags[j] - (nCartas01 / 2);

            /*foreach (Control x in this.Controls)
                if (x is Button && x.Tag.ToString() == "c02")
                    x.Visible = false;*/

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
                    x.BackgroundImage = Properties.Resources.CostasCartaBen10;
                    x.Visible = true;
                }
        }

        private void buttonCartaLvl02_Click(object sender, EventArgs e)
        {
            int nMove = nMovimentos++;
            LabelClicks.Text = nMovimentos.ToString();

            Stream erro = Properties.Resources.errorSound;
            System.Media.SoundPlayer error = new System.Media.SoundPlayer(erro);
            if (mostrar == false)
            {
                error.PlaySync();
            }
            if (mostrar == true)
            {
                Button cartaAtual = (sender as Button);
                string s = "_" + cartaAtual.Tag.ToString();
                object o = Properties.Resources.ResourceManager.GetObject(s);
                cartaAtual.BackgroundImage = (System.Drawing.Image)o;

                if (nCliques01 == 0)
                {
                    cartaAnterior01 = cartaAtual;
                    nCliques01++;
                    
                }
                else
                    CompararCartas(cartaAnterior01, cartaAtual);
            }
        }

        private void CompararCartas(Button cAnterior, Button cAtual)
        {
            Stream erro = Properties.Resources.errorSound;
            System.Media.SoundPlayer error = new System.Media.SoundPlayer(erro);

            Application.DoEvents();
            System.Threading.Thread.Sleep(600);
            if (cAnterior == cAtual)
            {
                error.PlaySync();
                nCliques01 = 0;
                cAtual.BackgroundImage = Properties.Resources.CostasCartaBen10;
            }
            else
            {
                if (cAtual.Tag.ToString() == cAnterior.Tag.ToString())
                {
                    restanteCt01--;
                    nCliques01 = 0;
                    cAnterior.Visible = false;
                    cAtual.Visible = false;
                    VerificarSeGanhou();
                }
                else
                {
                    nCliques01 = 0;
                    cAnterior.BackgroundImage = Properties.Resources.CostasCartaBen10;
                    cAtual.BackgroundImage = Properties.Resources.CostasCartaBen10;
                }
            }
        }
        private void VerificarSeGanhou()
        {

            if (restanteCt01 == 0)
            {

                pbInterativeBarUtil.Visible = false;
                pbInterativeBoxClock.Visible = false;
                pbInterativeBoxClick.Visible = false;
                pbInterativeBarCoins.Visible = false;
                pbClock.Visible = false;
                pbClick.Visible = false;
                pbCoins.Visible = false;
                LabelTime.Visible = false;
                LabelClicks.Visible = false;
                LabelDinheiro.Visible = false;


                this.BackColor = Color.DarkSlateGray;


                this.timer1.Enabled = false;
                int minutos = (totalSegundos01 / 60);
                int segundos = totalSegundos01 - (minutos * 60) + 1;
                int resultadoTempo = minutos + segundos;
                int resultadoSobra = resultadoTempo;
                this.LabelMostrarTime.Text = "Tempo: " + minutos.ToString() + ":" + segundos.ToString();
                pbCoinGanho.Visible = true;
                LabelTime.Visible = false;
                LabelMostrarTime.Visible = true;
                LabelDinheiroGanho.Visible = true;
                LabelTotalClicks.Visible = true;
                LabelTotalClicks.Text = "Jogadas: " + nMovimentos.ToString();

                btnDificuldade02.Visible = false;
                btnNivelAnterior.Visible = true;
                btnProximoNivel.Visible = true;
                btnDificuldade.Visible = true;
                Vganhou = true;
                FormLvls.LvlHard = true;



                if (totalSegundos01 >= 90)
                {
                    moedasGanha = 50;
                    LabelDinheiroGanho.Text = "Moedas:  " + moedasGanha.ToString() + " X ";
                }
                if (totalSegundos01 >= 60 && totalSegundos01 < 89)
                {
                    moedasGanha = 25;
                    LabelDinheiroGanho.Text = "Moedas:  " + moedasGanha.ToString() + " X ";
                }
                if (totalSegundos01 >= 1 && totalSegundos01 < 59)
                {
                    moedasGanha = 15;
                    LabelDinheiroGanho.Text = "Moedas:  " + moedasGanha.ToString() + " X ";
                }

            }

        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            mostrar = true;
            btnMostrar.Visible = false;
            this.timer1.Enabled = true;

            foreach (Control x in this.Controls)
                if (x is Button && x.Tag.ToString() != "o")
                {
                    string s = "_" + x.Tag.ToString();
                    object o = Properties.Resources.ResourceManager.GetObject(s);
                    x.BackgroundImage = (System.Drawing.Image)o;
                }
            Application.DoEvents();
            System.Threading.Thread.Sleep(1000);

            foreach (Control x in this.Controls)
                if (x is Button && x.Tag.ToString() != "o")
                    x.BackgroundImage = Properties.Resources.CostasCartaBen10;
           
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (FormLvls.LvlFacil == true)
            {
                if (totalSegundos01 >= 0)
                {
                    int minutos = (totalSegundos01 / 60);
                    int segundos = totalSegundos01 - (minutos * 60);
                    //segundos = string.Format("{0\\ss}", segundos.ToString());
                    this.LabelTime.Text = minutos.ToString() + ":" + segundos.ToString();
                    totalSegundos01--;
                }
                else
                {
                    this.timer1.Enabled = false;
                    MessageBox.Show("Tempo esgotou");
                }
            }
        }

        private void btnVoltarTemas_Click(object sender, EventArgs e)
        {
            if (Vganhou == true)
            {
                Vganhou = false;
                FormMenuTemas frmMT = new FormMenuTemas();
                frmMT.ShowDialog();
                Close();
            }
        }

        private void btnDificuldade_Click(object sender, EventArgs e)
        {
            if (Vganhou == true)
            {
                Vganhou = false;
                FormLvls frmLvl = new FormLvls();
                frmLvl.ShowDialog();
                Close();
            }
        }

        private void btnProximoNivel_Click(object sender, EventArgs e)
        {
            if (restanteCt01 == 0)
            {
                this.timer1.Enabled = false;

                if (FormLvls.LvlMedio == true)
                {
                    MessageBox.Show("Good");

                }
            }
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            Vganhou = false;
            FormMenuTemas frmMT = new FormMenuTemas();
            frmMT.ShowDialog();
            Close();

        }

        private void btnVoltar_MouseEnter(object sender, EventArgs e)
        {
            
            if (Vganhou == false)
            {
                btnDificuldade02.Visible = true;
            }
            if (Vganhou == true)
            {
                btnDificuldade02.Visible = false;
            }

        }

        private void btnVoltarMenu02_Click(object sender, EventArgs e)
        {
            FormMenuTemas frmMT = new FormMenuTemas();
            frmMT.ShowDialog();
            Close();
        }

        private void btnDificuldade02_Click(object sender, EventArgs e)
        {
            Vganhou = false;
            FormLvls frmLvl = new FormLvls();
            frmLvl.ShowDialog();
            Close();
        }

        private void btnNivelAnterior_Click(object sender, EventArgs e)
        {
            Vganhou = false;
            Form2 frm2 = new Form2();
            frm2.ShowDialog();
            Close();
        }

        private void btnProxLvl_Click(object sender, EventArgs e)
        {
           
        }

        private void btnAntNivel_Click(object sender, EventArgs e)
        {
            Form2 frm2 = new Form2();
            frm2.ShowDialog();
            Close();
        }
    }
}
