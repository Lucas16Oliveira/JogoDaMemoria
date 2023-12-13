using System.Security.Cryptography.X509Certificates;

namespace Jogo_da_memória
{
    public partial class FormMenuInicial : Form
    {
        static public bool login = false;

        const int nCartas = 20;

        byte nCliques;
        byte restanteCt = nCartas / 2;
        Button cartaAnterior;

        public FormMenuInicial()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Ocultar();
            tsLabelData.Text = DateTime.Now.ToLongDateString();
            timer1.Enabled = true;
            buttonMostrar.Visible = false;
            buttonJogardnv.Visible = false;
        }

        private void Ocultar()
        {
            foreach (Control x in this.Controls)
                if (x is Button && x.Tag.ToString() == "c")
                    x.Visible = false;
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
        
                DistribuiCartas();
                AtribuirTags();
                buttonLogin.Visible = false;
                buttonJogardnv.Visible = false;
                buttonMostrar.Visible = true;

        }

        private void AtribuirTags()
        {
            int[] tags = new int[nCartas];
            Random rnd = new Random();
            int n;
            int i = 0;
            while(i<nCartas)
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
                    x.BackgroundImage = Properties.Resources.costas_da_carta__1_;
                    x.Visible = true;
                }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            tsLabelHora.Text = DateTime.Now.ToLongTimeString();
        }

        private void buttonMostrar_Click(object sender, EventArgs e)
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
                    x.BackgroundImage = Properties.Resources.costas_da_carta__1_;

        }

        private void button1_Click(object sender, EventArgs e)
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

        private void CompararCartas(Button cAnterior, Button cAtual)
        {
            Application.DoEvents();
            System.Threading.Thread.Sleep(600);
            if (cAnterior == cAtual)
            {
                MessageBox.Show("Selecionou a mesma carta");
                nCliques = 0;
                cAtual.BackgroundImage = Properties.Resources.costas_da_carta__1_;

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
                    cAnterior.BackgroundImage = Properties.Resources.costas_da_carta__1_;
                    cAtual.BackgroundImage = Properties.Resources.costas_da_carta__1_;
                }
            }
        }

        private void VerificarSeGanhou()
        {

            if (restanteCt == 0)
                buttonJogardnv.Visible = true;
        }

        private void btnVoltarMenuSonic_Click(object sender, EventArgs e)
        {
            FormMenuTemas frmM = new FormMenuTemas();
            frmM.ShowDialog();
            Close();
        }
    }
}