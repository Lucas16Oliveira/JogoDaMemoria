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

    public partial class FormNovoUtilizador : Form
    {
        string pathCd = (@"C:\Users\lucas\OneDrive\Área de Trabalho\Área de trabalho^-^\Lucas Trabalhos\PSI\11º4\Backup Jogo da memória 0210 1528\utilizadores.txt");

        public FormNovoUtilizador()
        {
            InitializeComponent();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if(textBoxUsername.Text!="" && textBoxPassword.Text!="")
            {
                if(textBoxPassword.Text == textBoxRepPass.Text)
                {
                    if (!UtilizadorJaExistente(textBoxUsername.Text))
                        RegistrarUtilizador(textBoxUsername.Text, textBoxPassword.Text);
                    else
                    {
                        MessageBox.Show("Utilizador já existente! Insire novos dados");
                        textBoxUsername.Text = "";
                        textBoxPassword.Text = "";
                        textBoxRepPass.Text = "";
                        textBoxUsername.Focus();
                    }
                }
                else
                {
                    MessageBox.Show("As passwords não coincidem!!");
                    textBoxPassword.Text = "";
                    textBoxRepPass.Text = "";
                    textBoxPassword.Focus();

                }

            }
        }

        private bool UtilizadorJaExistente(string user)
        {
            if(File.Exists(pathCd))
            {
                try
                {
                    string[] dadosUsers = File.ReadAllLines(pathCd);
                    foreach(string linha in dadosUsers )
                    {
                        string[] dadosUsr = linha.Split(':');
                        if (user == dadosUsers[0]) return true;
                    }
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Erro: " + ex.Message);
                
                }
            }
            return false;
        }

        private void RegistrarUtilizador(string user, string pass)
        {
            try
            {
                string texto = "\n " +  user + ":" + pass;
                File.AppendAllText(pathCd, texto);
                MessageBox.Show("Dados do utilizador registrados com sucesso!");
            }
            catch(Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
