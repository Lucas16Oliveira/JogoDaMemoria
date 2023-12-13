using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Jogo_da_memória.Properties
{
    public partial class FormLoadGame : Form
    {
        static public bool SomLoadOn = false;

        private double totalSegundos;
        public FormLoadGame()
        {
            InitializeComponent();
        }

        private void FormLoadGame_Load(object sender, EventArgs e)
        {
            pbCaveira01.Visible = false;
            pbCaveira01.Visible = false;
            pbCaveira02.Visible = false;
            pbCaveira3.Visible = false;
            pbCaveiraInsane.Visible = false;

            if(FormLvls.LvlFacilClick == true)
            {
                pbTapar.Visible = false;
                pbCaveira01.Visible = true;
                pbCaveira02.Visible = false;
                pbCaveira3.Visible = false;
                pbCaveiraInsane.Visible = false;
                pbLoadBar.BackgroundImage = Properties.Resources.Sprite_0003LoadBar;
            }
            if (FormLvls.LvlMedio = true)
            {
                pbCaveira01.Visible = true;
                pbCaveira02.Visible = true;
                pbCaveira3.Visible = false;
                pbCaveiraInsane.Visible = false;
                pbLoadBar.BackgroundImage = Properties.Resources.Sprite_0003MedioLoadBar;
            }

            Stream load = Properties.Resources.World_Map___Load03;
            System.Media.SoundPlayer MusicLoad = new System.Media.SoundPlayer(load);
            MusicLoad.Play();
            SomLoadOn = true;
            if (SomLoadOn == false)
            {
                MusicLoad.Stop();
            }

            this.timer1.Enabled = true;
            FormMenuTemas frmMT = new FormMenuTemas();
            int minutos = 0;
            double segundos = 3.9;
            totalSegundos = (minutos * 60) + segundos;


        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            FormMenuTemas frmMT = new FormMenuTemas();
            Form2 frmBen01 = new Form2();
            FormBen10Lvl02 frmBen02 = new FormBen10Lvl02();
            

            if (Form1.btnJogar == true)
            {

                if (totalSegundos >= 0)
                {
                    double minutos = (totalSegundos / 60);
                    double segundos = totalSegundos - (minutos * 60);
                    totalSegundos--;
                }
                else
                {
                    this.timer1.Enabled = false;
                    //MessageBox.Show("Cabo");
                    
                    if(FormMenuTemas.btnSelec04 == true)
                    {
                        frmBen01.ShowDialog();
                        Close();
                    }
                    if (Form2.MedioClick == true)
                    {

                        FormBen10Lvl02 formBen1002 = new FormBen10Lvl02();
                        formBen1002.ShowDialog();
                        Close();


                    }
                    frmMT.ShowDialog();
                    Close();

                }
            }

        }



    }
}
