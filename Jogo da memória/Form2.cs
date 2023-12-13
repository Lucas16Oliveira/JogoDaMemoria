using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using System.Diagnostics;

namespace Jogo_da_memória
{
    public partial class Form2 : Form
    {
        static public bool mostrar = false;
        static public bool Vganhou = false;
        static public bool MedioClick = false;

        private int totalSegundos01;
        const int nCartas01 = 12;

        static public byte nMovimentos = 0;
        static public int pontos;
        static public int moedasTotal = 0;
        static public byte moedasGanha;
        byte nCliques01;
        byte restanteCt01 = nCartas01 / 2;
        Button cartaAnterior01;

        //-----------------------------------


        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            pbConfig.Visible = false;
            pbCoinGanho.Visible = false;
            btnDificuldade.Visible = false;
            btnDificuldade02.Visible = false;
            btnConfig02.Visible = false;
            btnJdeNovo.Visible = false;
            btnExit.Visible = false;
            btnTutorial.Visible = false;
            btnCredit.Visible = false;

            moedasTotal = moedasTotal + moedasGanha;
            LabelDinheiro.Text = "X  " + moedasTotal.ToString();

            btnDificuldade.Visible = false;
            btnProximoNivel.Visible = false;
            LabelMostrarTime.Visible = false;
            LabelDinheiroGanho.Visible = false;
            LabelTotalClicks.Visible = false;
            LabelPontos.Visible = false;


            int lvl1 = 2;
            int lvl1s = 30;
            int minutos = int.Parse(lvl1.ToString());
            int segundos = int.Parse(lvl1s.ToString());

            totalSegundos01 = (minutos * 60) + segundos;

            if (FormLvls.LvlFacil == true)
            {
                Ocultar();
                DistribuiCartas();
                AtribuirTags();
            }


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

        private void button4_Click(object sender, EventArgs e)
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
                    LabelMostrarTime.Text = nCliques01.ToString();
                }
                else
                    CompararCartas(cartaAnterior01, cartaAtual);
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
            MedioClick = true;

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
                double minutos = (totalSegundos01 / 60);
                double segundos = totalSegundos01 - (minutos * 60);
                double resultadoTempo = minutos + segundos;
                this.LabelMostrarTime.Text = "Tempo: " + minutos.ToString() + ":" + segundos.ToString();
                LabelTime.Visible = false;
                pbCoinGanho.Visible = true;
                LabelMostrarTime.Visible = true;
                LabelDinheiroGanho.Visible = true;
                LabelTotalClicks.Visible = true;
                LabelTotalClicks.Text = "Jogadas: " + nMovimentos.ToString();
                LabelPontos.Visible = true;



                btnJdeNovo.Visible = true;
                btnDificuldade02.Visible = false;
                btnProximoNivel.Visible = true;
                btnDificuldade.Visible = true;
                btnAntNivel.Visible = false;
                Vganhou = true;
                FormLvls.LvlMedio = true;



                if (nMovimentos >= 12 && nMovimentos <= 15)
                {
                    pontos = 50;
                    LabelPontos.Text = "Pontos:\n " + pontos.ToString();
                }
                if (nMovimentos >= 15 && nMovimentos <= 20)
                {
                    pontos = 30;
                    LabelPontos.Text = "Pontos:\n " + pontos.ToString();
                }
                if (nMovimentos >= 20)
                {
                    pontos = 10;
                    LabelPontos.Text = "Pontos:\n " + pontos.ToString();
                }



                if (totalSegundos01 >= 120)
                {
                    moedasGanha = 7;
                    LabelDinheiroGanho.Text = "Moedas:  " + moedasGanha.ToString() + " X ";

                }
                if (totalSegundos01 >= 60 && totalSegundos01 < 119)
                {
                    moedasGanha = 4;
                    LabelDinheiroGanho.Text = "Moedas:  " + moedasGanha.ToString() + " X ";


                }
                if (totalSegundos01 >= 1 && totalSegundos01 < 59)
                {
                    moedasGanha = 2;
                    LabelDinheiroGanho.Text = "Moedas:  " + moedasGanha.ToString() + " X ";

                }
                /*if (minutos >= 0.8 || minutos < 1.7)
                {
                    moedasGanha = 5;
                    LabelDinheiroGanho.Text = "Moedas: " + moedasGanha.ToString() + "  X ";
                }
                if (segundos >= 5 && segundos > 50)
                {
                    moedasGanha = 3;
                    LabelDinheiroGanho.Text = "Moedas: " + moedasGanha.ToString() + "  X ";
                }
                if (segundos == 0)
                {
                    moedasGanha = 0;
                    LabelDinheiroGanho.Text = "Moedas: " + moedasGanha.ToString() + "  X ";
                }*/



            }
            /*if (nCartas01 = 0)
            {
                btnProximoNivel.Visible = true;
                btnDificuldade.Visible = true;
                btnVoltarTemas.Visible = true;
                Vganhou = true;
                FormLvls.LvlMedio = true;
            }
            */
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            /*FormMenuTemas frmMT = new FormMenuTemas();
            frmMT.ShowDialog();
            this.Close();*/
        }

        private void button13_Click(object sender, EventArgs e)
        {

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
                FormMenuTemas frmMT = new FormMenuTemas();
                frmMT.ShowDialog();
                Close();
            }

        }

        private void btnDificuldade_Click(object sender, EventArgs e)
        {
            if (Vganhou == true)
            {
                FormLvls formLvl = new FormLvls();
                formLvl.ShowDialog();
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
                    FormBen10Lvl02 formBen1002 = new FormBen10Lvl02();
                    formBen1002.ShowDialog();
                    Close();

                }
            }
        }

        private void LabelMostrarTime_Click(object sender, EventArgs e)
        {

        }

        private void btnVoltar_Click_1(object sender, EventArgs e)
        {

            if (Vganhou == true)
            {
                FormMenuTemas frmMT = new FormMenuTemas();
                frmMT.ShowDialog();
                Close();
            }

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

        private void button14_Click(object sender, EventArgs e)
        {
            Vganhou = false;
            FormLvls formLvl = new FormLvls();
            formLvl.ShowDialog();
            Close();
        }

        private void btnVoltar_Click_2(object sender, EventArgs e)
        {
            Vganhou = false;
            FormMenuTemas frmMT = new FormMenuTemas();
            frmMT.ShowDialog();
            Close();
        }

        /*
        private void btnVoltarMenu02_Click(object sender, EventArgs e)
        {
            FormMenuTemas frmMT = new FormMenuTemas();
            frmMT.ShowDialog();
            Close();
        }
        
        /*private void label1_Click(object sender, EventArgs e)
        {

        }

        private void LabelTime_Click(object sender, EventArgs e)
        {

        }

        private void pbClock_Click(object sender, EventArgs e)
        {

        }

        private void pbInterativeBoxClock_Click(object sender, EventArgs e)
        {

        }
        */

        private void btnNivelAnterior_Click(object sender, EventArgs e)
        {

        }

        private void btnDificuldade_Click_1(object sender, EventArgs e)
        {
            FormLvls formLvl = new FormLvls();
            formLvl.ShowDialog();
            Close();
        }

        private void btnProximoNivel_Click_1(object sender, EventArgs e)
        {
            if (restanteCt01 == 0)
            {
                this.timer1.Enabled = false;

                if (FormLvls.LvlMedio == true)
                {
                    FormBen10Lvl02 formBen1002 = new FormBen10Lvl02();
                    formBen1002.ShowDialog();
                    Close();

                }
            }
        }

        private void btnConfig_Click(object sender, EventArgs e)
        {
            Stream pop = Properties.Resources.pop__1___online_audio_converter_com_clickauto05;
            System.Media.SoundPlayer pops = new System.Media.SoundPlayer(pop);
            pops.PlaySync();

            pbConfig.Visible = true;
            btnConfig.Visible = false;
            btnConfig02.Visible = true;
            btnExit.Visible = true;

        }

        private void btnConfig02_Click(object sender, EventArgs e)
        {
            Stream pop = Properties.Resources.pop__1___online_audio_converter_com_clickauto05;
            System.Media.SoundPlayer pops = new System.Media.SoundPlayer(pop);
            pops.PlaySync();

            pbConfig.Visible = false;
            btnConfig.Visible = true;
            btnConfig02.Visible = false;
            btnExit.Visible = false;

        }

        private void btnJdeNovo_Click(object sender, EventArgs e)
        {
            /*
            pbConfig.Visible = false;
            pbCoinGanho.Visible = false;
            btnVoltarMenu02.Visible = false;
            btnDificuldade.Visible = false;
            btnDificuldade02.Visible = false;
            btnConfig02.Visible = false;
            btnJdeNovo.Visible = false;

            moedasTotal = moedasTotal + moedasGanha;
            LabelDinheiro.Text = "X  " + moedasTotal.ToString();

            btnDificuldade.Visible = false;
            btnProximoNivel.Visible = false;
            LabelMostrarTime.Visible = false;
            LabelDinheiroGanho.Visible = false;
            LabelTotalClicks.Visible = false;
            LabelPontos.Visible = false;

            int lvl1 = 2;
            int lvl1s = 30;
            int minutos = int.Parse(lvl1.ToString());
            int segundos = int.Parse(lvl1s.ToString());

            totalSegundos01 = (minutos * 60) + segundos;

            if (FormLvls.LvlFacil == true)
            {
                Ocultar();
                DistribuiCartas();
                AtribuirTags();
            }
            */
            Form2 frm2 = new Form2();
            frm2.ShowDialog();
            Close();
        }


        private void btnVoltarMenu02_Click(object sender, EventArgs e)
        {

        }

        private void btnProxLvl_Click(object sender, EventArgs e)
        {
            if (Form2.MedioClick == true)
            {
                FormBen10Lvl02 frmB1002 = new FormBen10Lvl02();
                frmB1002.ShowDialog();
                Close();
            }
            
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

