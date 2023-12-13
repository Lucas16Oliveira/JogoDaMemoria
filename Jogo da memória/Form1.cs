using Jogo_da_memória.Properties;
using System.Media;
using System.Security.Cryptography.X509Certificates;

namespace Jogo_da_memória
{
    public partial class Form1 : Form
    {
        static public bool JogarLoad = false;
        static public bool btnJogar = false;
        static public bool login = false;
        static public bool frmIM = false;

        const int nCartas = 20;

        byte nCliques;
        byte restanteCt = nCartas / 2;
        Button cartaAnterior;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Stream SomInicial = Properties.Resources.Pleasant_Creek__MenuInicial;
            System.Media.SoundPlayer Music = new System.Media.SoundPlayer(SomInicial);
            Music.PlayLooping();

            //SoundPlayer SomInicial = new SoundPlayer(@"C:\Users\lucas\Downloads\Pleasant Creek- MenuInicial.wav");
            //SomInicial.PlayLooping();

            pbOpcoes.Visible = false;
            btnCloseOpcoes.Visible = false;
            btnTutorial.Visible = false;
            btnCredit.Visible = false;
            btnExit.Visible = false;
            FormMenuInicial frmMI = new FormMenuInicial();
            tsLabelData.Text = DateTime.Now.ToLongDateString();
            timer1.Enabled = true;
            buttonLoginAP1.Focus();

        }

        

       /* private void buttonLogin_Click(object sender, EventArgs e)
        {
            FormLogin frmL = new FormLogin();
           frmL.ShowDialog();
            buttonLoginAP1.BackgroundImage = Properties.Resources.BtnLoginAP3;
            Application.DoEvents();
            System.Threading.Thread.Sleep(150);
        }
        /*
        private void AtribuirTags()
        {
        }

        private void DistribuiCartas()
        {   
        }

        private void timer1_Tick(object sender, EventArgs e)
        {            
        }

        private void buttonMostrar_Click(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void CompararCartas(Button cAnterior, Button cAtual)
        {
        }

        private void VerificarSeGanhou()
        {
        }
        

        private void Form1_MouseHover(object sender, EventArgs e)
        {
           // buttonLoginAP1.BackgroundImage = Properties.Resources.BtnLoginAP2;
        }
        */
        private void buttonLoginAP1_MouseLeave(object sender, EventArgs e)
        {
            buttonLoginAP1.BackgroundImage = Properties.Resources.BtnLoginAP1;
            
        }

        private void buttonLoginAP1_MouseEnter(object sender, EventArgs e)
        {
            buttonLoginAP1.BackgroundImage = Properties.Resources.BtnLoginAP2;
            //pbSetaBotoes.BackgroundImage = Properties.Resources.Seta_Botoes;
        }

        private void buttonLoginAP1_MouseDown(object sender, MouseEventArgs e)
        {
            buttonLoginAP1.BackgroundImage = Properties.Resources.BtnLoginAP3;
        }

        private void buttonLoginAP1_MouseUp(object sender, MouseEventArgs e)
        {
            buttonLoginAP1.BackgroundImage = Properties.Resources.BtnLoginAP2;
        }

        private void buttonLoginAP1_MouseClick(object sender, MouseEventArgs e)
        {
            Stream pop = Properties.Resources.pop__1___online_audio_converter_com_clickauto05;
            System.Media.SoundPlayer pops = new System.Media.SoundPlayer(pop);
            pops.PlaySync();

            FormLogin frmL = new FormLogin();
            frmL.ShowDialog();
            buttonLoginAP1.BackgroundImage = Properties.Resources.BtnLoginAP2;
            //Application.DoEvents();
            //System.Threading.Thread.Sleep(250);
            if (login == true)
            {
                buttonLoginAP1.Visible = false;
            }
            btnJogarAP1.Focus();
        }

        private void btnOpcoes01_Click(object sender, EventArgs e)
        {
            

            Stream pop = Properties.Resources.pop__1___online_audio_converter_com_clickauto05;
            System.Media.SoundPlayer pops = new System.Media.SoundPlayer(pop);
            pops.PlaySync();

            btnOpcoes01.BackgroundImage = Properties.Resources.BtnOpcoesAP3;

            btnTutorial.Visible = true;
            btnCredit.Visible = true;
            pbOpcoes.Visible = true;
            btnCloseOpcoes.Visible = true;
            btnExit.Visible = true;
            buttonLoginAP1.Visible = false;
            btnJogarAP1.Visible = false;
            btnOpcoes01.Visible = false;
            pbTitulo.Visible = false;

            //Application.DoEvents();
            //System.Threading.Thread.Sleep(250);



        }

        private void btnOpcoes01_MouseEnter(object sender, EventArgs e)
        {
            btnOpcoes01.BackgroundImage = Properties.Resources.BtnOpcoesAP2;
        }

        private void btnOpcoes01_MouseLeave(object sender, EventArgs e)
        {
            btnOpcoes01.BackgroundImage = Properties.Resources.BtnOpcoesAP1;
        }

        private void btnOpcoes01_MouseDown(object sender, MouseEventArgs e)
        {
            btnOpcoes01.BackgroundImage = Properties.Resources.BtnOpcoesAP3;
        }

        private void btnOpcoes01_MouseUp(object sender, MouseEventArgs e)
        {
            btnOpcoes01.BackgroundImage = Properties.Resources.BtnOpcoesAP2;
        }

        private void btnJogarAP1_Click(object sender, EventArgs e)
        {
            btnJogar = true;
            JogarLoad = true;

            Stream pop = Properties.Resources.pop__1___online_audio_converter_com_clickauto05;
            System.Media.SoundPlayer pops = new System.Media.SoundPlayer(pop);
            pops.PlaySync();

            btnJogarAP1.BackgroundImage = Properties.Resources.BtnJogarAP3;

            FormLoadGame frmLG = new FormLoadGame();
            frmLG.ShowDialog();
            Close();
        }

        private void btnJogarAP1_MouseEnter(object sender, EventArgs e)
        {
            btnJogarAP1.BackgroundImage = Properties.Resources.BtnJogarAP2;
        }

        private void btnJogarAP1_MouseLeave(object sender, EventArgs e)
        {
            btnJogarAP1.BackgroundImage = Properties.Resources.BtnJogarAP1;
        }

        private void btnJogarAP1_MouseDown(object sender, MouseEventArgs e)
        {
            btnJogarAP1.BackgroundImage = Properties.Resources.BtnJogarAP3;
        }

        private void btnJogarAP1_MouseUp(object sender, MouseEventArgs e)
        {
            btnJogarAP1.BackgroundImage = Properties.Resources.BtnJogarAP1;
        }

        private void btnCloseOpcoes_Click(object sender, EventArgs e)
        {
            btnCloseOpcoes.Visible = false;
            pbOpcoes.Visible = false;
            btnExit.Visible = false;
            btnTutorial.Visible = false;
            btnCredit.Visible = false;
            buttonLoginAP1.Visible = true;
            btnJogarAP1.Visible = true;
            btnOpcoes01.Visible = true;
            pbTitulo.Visible = true;
        }

        private void TbSomPorcent_Scroll(object sender, EventArgs e)
        {
           
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        /*private void buttonLoginAP1_MouseHover(object sender, EventArgs e)
        {

        }

         private void btnLoginAP2_MouseClick(object sender, MouseEventArgs e)
          {
              btnLoginAP2.BackgroundImage = Properties.Resources.BtnLoginAP3;
              Application.DoEvents();
              System.Threading.Thread.Sleep(150);
              btnLoginAP2.BackgroundImage = Properties.Resources.BtnLoginAP2;
          }

          private void btnLoginAP2_MouseDown(object sender, MouseEventArgs e)
          {
              btnLoginAP2.BackgroundImage = Properties.Resources.BtnLoginAP3;
          }
        */
    }
}