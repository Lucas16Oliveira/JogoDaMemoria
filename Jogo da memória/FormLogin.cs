using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Jogo_da_memória
{
    
    public partial class FormLogin : Form
    {
        string pathCd = (@"C:\\Users\\lucas\\OneDrive\\Área de Trabalho\\Área de trabalho^-^\\Lucas Trabalhos\\PSI\\11º4\\Backup Jogo da memória 0210 1528\\utilizadores.txt\");

        static public bool btnseta = false;

        //static public bool frmIM = false;
        public FormLogin()
        {
            InitializeComponent();
            gbAvatares.Visible = false;
        }

        private void buttonEntrar_Click(object sender, EventArgs e)
        {
            Stream pop = Properties.Resources.pop__1___online_audio_converter_com_clickauto05;
            System.Media.SoundPlayer pops = new System.Media.SoundPlayer(pop);
            pops.PlaySync();

            string user = textBoxUsername.Text;
            string pass = textBoxPassword.Text;
            //FormMenuInicial frmMI = new FormMenuInicial();
            //Form1 frm1 = new Form1();
            
            buttonEntrar.BackgroundImage = Properties.Resources.BtnEntrarAP3;

            if (textBoxUsername.Text == "q" && textBoxPassword.Text == "q")

                Form1.login = true;
            //Form1.frmIM = true;
            //if(Form1.frmIM == true)
            //frmMI.ShowDialog();
            else
                Form1.login = VerificarLogin(user, pass);
            this.Close();

        }

        private bool VerificarLogin(string us, string ps)
        {
            if(File.Exists(pathCd))
            {
                string[] users = File.ReadAllLines(pathCd);
                foreach(string s  in users )
                {
                    string[] dataUser = s.Split(':');
                    if (us == dataUser[0] && ps == dataUser[1])
                    {
                        MessageBox.Show("Seja bem vindo!");
                        return true;
                    }
                }
            }
            MessageBox.Show("Utilizador nao encontrado!");
            return false;
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            Stream pop = Properties.Resources.pop__1___online_audio_converter_com_clickauto05;
            System.Media.SoundPlayer pops = new System.Media.SoundPlayer(pop);
            pops.PlaySync();

            buttonCancelar.BackgroundImage = Properties.Resources.BtnCancelarAP3;
            Form1.login = false;
            this.Close();
            
           // Form1.buttonLoginAP1.BackgroundImage = Properties.Resources.BtnLoginAP1;
        }

        private void linkLabelMostrar_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if(linkLabelMostrar.Text == "Mostrar")
            {
                textBoxPassword.UseSystemPasswordChar = false;
                linkLabelMostrar.Text = "Ocultar";
            }
            else
            {
                textBoxPassword.UseSystemPasswordChar = true;
                linkLabelMostrar.Text = "Mostrar";
            }
        }

        private void buttonEntrar_MouseEnter(object sender, EventArgs e)
        {
            buttonEntrar.BackgroundImage = Properties.Resources.BtnEntrarAP2;
        }

        private void buttonEntrar_MouseLeave(object sender, EventArgs e)
        {
            buttonEntrar.BackgroundImage = Properties.Resources.BtnEntrarAP1;
        }

        private void buttonEntrar_MouseDown(object sender, MouseEventArgs e)
        {
            buttonEntrar.BackgroundImage = Properties.Resources.BtnEntrarAP3;
        }

        private void buttonEntrar_MouseUp(object sender, MouseEventArgs e)
        {
            buttonEntrar.BackgroundImage = Properties.Resources.BtnEntrarAP2;
        }

        private void buttonCancelar_MouseEnter(object sender, EventArgs e)
        {
            buttonCancelar.BackgroundImage = Properties.Resources.BtnCancelarAP2;
        }

        private void buttonCancelar_MouseLeave(object sender, EventArgs e)
        {
            buttonCancelar.BackgroundImage = Properties.Resources.BtnCancelarAP1;
        }

        private void buttonCancelar_MouseDown(object sender, MouseEventArgs e)
        {
            buttonCancelar.BackgroundImage = Properties.Resources.BtnCancelarAP3;
        }

        private void buttonCancelar_MouseUp(object sender, MouseEventArgs e)
        {
            buttonCancelar.BackgroundImage = Properties.Resources.BtnCancelarAP2;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            gbAvatares.Visible = true;
            btnSeta01.Visible = false;
            btnSeta02.Visible = true;
        }

        private void buttonEntrar_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void button1_MouseClick(object sender, MouseEventArgs e)
        {
            
        }

        private void btnSeta02_Click(object sender, EventArgs e)
        {
            gbAvatares.Visible = false;
            btnSeta02.Visible = false;
            btnSeta01.Visible = true;
        }

        private void btnDireita_Click(object sender, EventArgs e)
        {

        }

        private void btnEsquerda_Click(object sender, EventArgs e)
        {

        }

        private void LinkLNUtilizador_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormNovoUtilizador frm = new FormNovoUtilizador();
            frm.ShowDialog();
            textBoxUsername.Focus();
        }
    }
}
