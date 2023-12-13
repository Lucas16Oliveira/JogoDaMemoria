using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using Jogo_da_memória.Properties;

namespace Jogo_da_memória
{
    public partial class FormMenuTemas : Form
    {
        public string[] FotoPerso = new string[5];
        public FormMenuTemas()
        {
            InitializeComponent();
        }

        static public bool btnSelec01 = false;
        static public bool btnSelec02 = false;
        static public bool btnSelec03 = false;
        static public bool btnSelec04 = false;
        static public bool btnComecarSelec = false;
        /*static public bool btnSelec05 = false;
        static public bool btnSelec06 = false;
        static public bool btnSelec07 = false;
        static public bool btnSelec08 = false;
        static public bool btnSelec09 = false;
        static public bool btnSelec10 = false;
        static public bool btnSelec11 = false;
        static public bool btnSelec12 = false;*/

        static public bool TemaSonic = false;
        static public bool TemaMario = false;
        static public bool TemaSpider = false;
        static public bool TemaBen10 = false;

        static public bool btnSelecO = false;
        private void FormMenuTemas_Load(object sender, EventArgs e)
        {

            FormLoadGame.SomLoadOn = false;

            Form1.JogarLoad = false;
            pbPersoTemas.Focus();
            pbClock.Visible = false;
            pbInterativeBoxClock.Visible = false;
            pbPersoTemas.Visible = false;
            pbNotPerson.Visible = true;
            //string Perso0 = "PersoCenterpng";
            //pictureBoxblabal.Image = (Image)Properties.Resources.ResourceManager.GetObject(Perso0);
            // pbNomeTema01.Visible = false;
            //pbNomeTema02.Visible = false;
            //pbNomeTema03.Visible = false;
            btnSelecionarTema.Visible = false;
            btnST02.Visible = false;
            btnST03.Visible = false;
            btnST04.Visible = false;
            //btnST05.Visible = false;
            //btnST06.Visible = false;
           //btnST07.Visible = false;
            //btnST08.Visible = false;
            //btnST09.Visible = false;
            //btnST10.Visible = false;
           // btnST11.Visible = false;
            //btnST12.Visible = false;

        }
        protected override void OnPaint(PaintEventArgs e)
        {
            GraphicsPath forma01 = new GraphicsPath();
            forma01.AddEllipse(0, 0, pbIconTema04.Width, pbIconTema04.Height);
            pbIconTema.Region = new Region(forma01);

            GraphicsPath forma02 = new GraphicsPath();
            forma02.AddEllipse(0, 0, pbIconTema04.Width, pbIconTema04.Height);
            pbIconTema02.Region = new Region(forma02);

            GraphicsPath forma03 = new GraphicsPath();
            forma03.AddEllipse(0, 0, pbIconTema04.Width, pbIconTema04.Height);
            pbIconTema03.Region = new Region(forma03);

            GraphicsPath forma04 = new GraphicsPath();
            forma04.AddEllipse(0, 0, pbIconTema04.Width, pbIconTema04.Height);
            pbIconTema04.Region = new Region(forma04);
        }
        

        /*protected override void OnPaint(PaintEventArgs e)
        {
            GraphicsPath forma = new GraphicsPath();
            forma.AddEllipse(0, 0, btnTema01.Width, btnTema01.Height);
            btnTema01.Region = new Region(forma);
        }*/

        private void btnTema01_MouseEnter(object sender, EventArgs e)
        {
            /*
            pbNomeTema01.Visible = true;
            pbNomeTema01.BackgroundImage = Properties.Resources.ImageTemasLayout_removebg_preview__9_;
            pbNomeTema01.Visible = false;
            Application.DoEvents();
            System.Threading.Thread.Sleep(150);

            pbNomeTema02.Visible = true;
            pbNomeTema02.BackgroundImage = Properties.Resources.ImageTemasLayout_removebg_preview__8_;
            Application.DoEvents();
            System.Threading.Thread.Sleep(150);

            pbNomeTema02.BackgroundImage = Properties.Resources.ImageTemasLayout_removebg_preview__7_;
            pbNomeTema02.Visible = false;
            Application.DoEvents();
            System.Threading.Thread.Sleep(150);

            pbNomeTema03.Visible = true;
            pbNomeTema03.BackgroundImage = Properties.Resources.ImageTemasLayout_removebg_preview__6_;
            Application.DoEvents();
            System.Threading.Thread.Sleep(150);

            pbNomeTema03.BackgroundImage = Properties.Resources.ImageTemasLayout_removebg_preview__5_;
            Application.DoEvents();
            System.Threading.Thread.Sleep(150);

            pbNomeTema03.BackgroundImage = Properties.Resources.ImageTemasLayout_removebg_preview__4_;
            Application.DoEvents();
            System.Threading.Thread.Sleep(150);

            pbNomeTema03.BackgroundImage = Properties.Resources.ImageTemasLayout_removebg_preview__3_;
            Application.DoEvents();
            System.Threading.Thread.Sleep(150);

            pbNomeTema03.BackgroundImage = Properties.Resources.ImageTemasLayout_removebg_preview__2_;
            Application.DoEvents();
            System.Threading.Thread.Sleep(150);
            */
            /*pbNomeTema03.Visible = true;
            Application.DoEvents();
            System.Threading.Thread.Sleep(350);
            pbNomeTema03.BackgroundImage = Properties.Resources.ImageTemasLayout_removebg_preview__1_;
            
            */
        }

        private void btnTema01_MouseLeave(object sender, EventArgs e)
        {
            /* pbNomeTema03.Visible = false;
            */
        }

        private void btnSelecionarTema_MouseEnter(object sender, EventArgs e)
        {
            if(btnSelec01 == false)
            btnSelecionarTema.BackgroundImage = Properties.Resources._002;
        }

        private void btnSelecionarTema_MouseLeave(object sender, EventArgs e)
        {
            
            btnSelecionarTema.BackgroundImage = Properties.Resources._001_removebg_preview1;
            if(btnSelec01 == true)
            {
                     btnSelecionarTema.BackgroundImage = Properties.Resources._003;
            }

        }

        private void btnSelecionarTema_MouseDown(object sender, MouseEventArgs e)
        {
            btnSelecionarTema.BackgroundImage = Properties.Resources._003;
        }

        private void pbIconTema_MouseEnter(object sender, EventArgs e)
        {
            pbNotPerson.Visible = false;
            pbPersoTemas.Visible = true;
            FotoPerso[1] = "SonicCenterpng";
            string Perso01 = FotoPerso[1];
            pbPersoTemas.Image = (Image)Properties.Resources.ResourceManager.GetObject(Perso01);


            if (btnSelec01 == true)
            {
                pbPersoTemas.Image = (Image)Properties.Resources.ResourceManager.GetObject(Perso01);
            }
            if (btnSelec02 == true)
            {
                FotoPerso[2] = "MarioCenterpng";
                string Perso02 = FotoPerso[2];
                pbPersoTemas.Image = (Image)Properties.Resources.ResourceManager.GetObject(Perso02);
            }



            if (btnSelec04 == true)
            {
                FotoPerso[3] = "Ben10Centerpng";
                string Perso04 = FotoPerso[3];
                pbPersoTemas.Image = (Image)Properties.Resources.ResourceManager.GetObject(Perso04);
            }
            btnSelecionarTema.Visible = true;
            if (btnSelec02 == true)
            {
                btnST02.Visible = true;
            }
            if (btnSelec02 == false)
            { 
                btnST02.Visible = false;
            }
            if (btnSelec03 == true)
            {
                btnST03.Visible = true;
            }
            if (btnSelec03 == false)
            {
                btnST03.Visible = false;
            }
            if (btnSelec04 == true)
            {
                btnST04.Visible = true;
            }
            if (btnSelec04 == false)
            {
                btnST04.Visible = false;
            }
            /*btnST03.Visible = false;
            btnST04.Visible = false;
            btnST05.Visible = false;
            btnST06.Visible = false;
            btnST07.Visible = false;
            btnST08.Visible = false;*/
            //btnST09.Visible = false;
            //btnST10.Visible = false;
           // btnST11.Visible = false;
            //btnST12.Visible = false;
            

        }

        private void pbIconTema_MouseLeave(object sender, EventArgs e)
        {
            if(btnSelec01 == true)
            {
                btnSelecionarTema.Visible = true;
            }
        }

        private void btnSelecionarTema_Click(object sender, EventArgs e)
        {
            FotoPerso[1] = "SonicCenterpng";
            string Perso01 = FotoPerso[1];
            pbPersoTemas.Image = (Image)Properties.Resources.ResourceManager.GetObject(Perso01);
            btnComecarSelec = true;
            TemaSonic = true;
            TemaMario = false;
            TemaSpider = false;
            TemaBen10 = false;

            btnSelec01 = true;
            btnSelec02 = false;
            btnSelec03 = false;
            btnSelec04 = false;
            /*btnSelec05 = false;
            btnSelec06 = false;
            btnSelec07 = false;
            btnSelec08 = false;
            btnSelec09 = false;
            btnSelec10 = false;
            btnSelec11 = false;
            btnSelec12 = false;*/
            if(btnSelec01 == true)
            {
                btnSelecionarTema.Visible = true;
                btnST02.Visible = false;
                btnST03.Visible = false;
                btnST04.Visible = false;
                //btnST05.Visible = false;
                //btnST06.Visible = false;
                //btnST07.Visible = false;
                //btnST08.Visible = false;
                //btnST09.Visible = false;
                //btnST10.Visible = false;
                //btnST11.Visible = false;
                //btnST12.Visible = false;
            }
            btnSelecionarTema.BackgroundImage = Properties.Resources._003;
            btnST02.BackgroundImage = Properties.Resources._001_removebg_preview1;
            btnST03.BackgroundImage = Properties.Resources._001_removebg_preview1;
            btnST04.BackgroundImage = Properties.Resources._001_removebg_preview1;

        }

        private void btnST02_Click(object sender, EventArgs e)
        {
            FotoPerso[2] = "MarioCenterpng";
            string Perso02 = FotoPerso[2];
            pbPersoTemas.Image = (Image)Properties.Resources.ResourceManager.GetObject(Perso02);
            btnComecarSelec = true;
            TemaSonic = false;
            TemaMario = true;
            TemaSpider = false;
            TemaBen10 = false;

            btnSelec01 = false;
            btnSelec02 = true;
            btnSelec03 = false;
            btnSelec04 = false;
            /*btnSelec05 = false;
            btnSelec06 = false;
            btnSelec07 = false;
            btnSelec08 = false;
            btnSelec09 = false;
            btnSelec10 = false;
            btnSelec11 = false;
            btnSelec12 = false;*/
            if (btnSelec02 == true)
            {
                btnSelecionarTema.Visible = false;
                btnST02.Visible = true;
                btnST03.Visible = false;
                btnST04.Visible = false;
                //btnST05.Visible = false;
                //btnST06.Visible = false;
                //btnST07.Visible = false;
                //btnST08.Visible = false;
                //btnST09.Visible = false;
               // btnST10.Visible = false;
               //btnST11.Visible = false;
                //btnST12.Visible = false;
            }
            btnST02.BackgroundImage = Properties.Resources._003;
            btnSelecionarTema.BackgroundImage = Properties.Resources._001_removebg_preview1;
            btnST04.BackgroundImage = Properties.Resources._001_removebg_preview1;
            btnST03.BackgroundImage = Properties.Resources._001_removebg_preview1;
        }

        private void btnST02_MouseEnter(object sender, EventArgs e)
        {
            if(btnSelec02 == false)
            btnST02.BackgroundImage = Properties.Resources._002;
        }

        private void btnST02_MouseLeave(object sender, EventArgs e)
        {
            btnST02.BackgroundImage = Properties.Resources._001_removebg_preview1;
            if (btnSelec02 == true)
            { 
                    btnST02.BackgroundImage = Properties.Resources._003;
            }
        }

        private void btnST02_MouseDown(object sender, MouseEventArgs e)
        {
            btnST02.BackgroundImage = Properties.Resources._003;
        }

        private void btnSelecOutro_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void pbIconTema02_MouseEnter(object sender, EventArgs e)
        {
            pbNotPerson.Visible = false;
            pbPersoTemas.Visible = true;
            FotoPerso[2] = "MarioCenterpng";
            string Perso02 = FotoPerso[2];
            pbPersoTemas.Image = (Image)Properties.Resources.ResourceManager.GetObject(Perso02);


            if (btnSelec01 == true)
            {
                FotoPerso[1] = "SonicCenterpng";
                string Perso01 = FotoPerso[1];
                pbPersoTemas.Image = (Image)Properties.Resources.ResourceManager.GetObject(Perso01);
            }
            if (btnSelec02 == true)
            {
                pbPersoTemas.Image = (Image)Properties.Resources.ResourceManager.GetObject(Perso02);
            }



            if (btnSelec04 == true)
            {
                FotoPerso[3] = "Ben10Centerpng";
                string Perso04 = FotoPerso[3];
                pbPersoTemas.Image = (Image)Properties.Resources.ResourceManager.GetObject(Perso04);
            }
            btnST02.Visible = true;
            if (btnSelec01 == true)
            {
                btnSelecionarTema.Visible = true;
            }
            if (btnSelec01 == false)
            {
                btnSelecionarTema.Visible = false;
            }
            if (btnSelec03 == true)
            {
                btnST03.Visible = true;
            }
            if (btnSelec03 == false)
            {
                btnST03.Visible = false;
            }
            if (btnSelec04 == true)
            {
                btnST04.Visible = true;
            }
            if (btnSelec04 == false)
            {
                btnST04.Visible = false;
            }
            /*btnST02.Visible = true;
            btnST03.Visible = false;
            btnST04.Visible = false;
            btnST05.Visible = false;
            btnST06.Visible = false;
            btnST07.Visible = false;
            btnST08.Visible = false;*/
            //btnST09.Visible = false;
            //btnST10.Visible = false;
           // btnST11.Visible = false;
            //btnST12.Visible = false;
            
        }

        private void pbIconTema02_MouseLeave(object sender, EventArgs e)
        {
            if(btnSelec02 == true)
            {
                btnST02.Visible = true;
            }
             
        }

        private void btnComecarJogo_Click(object sender, EventArgs e)
        {
           

            if (btnComecarSelec == false)
            {
                do
                {
                    Stream erro = Properties.Resources.errorSound;
                    System.Media.SoundPlayer error = new System.Media.SoundPlayer(erro);
                    error.PlaySync();

                } while (btnComecarSelec == true);
            }
            if (btnComecarSelec == true)
            {
                Stream pop = Properties.Resources.pop__1___online_audio_converter_com_clickauto05;
                System.Media.SoundPlayer pops = new System.Media.SoundPlayer(pop);
                pops.PlaySync();

                FormLvls frmLvl = new FormLvls();
                frmLvl.ShowDialog();
                Close();
            }


        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pbIconTema_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {

        }

        private void btnST04_Click(object sender, EventArgs e)
        {
            FotoPerso[3] = "Ben10Centerpng";
            string Perso04 = FotoPerso[3];
            pbPersoTemas.Image = (Image)Properties.Resources.ResourceManager.GetObject(Perso04);
            btnComecarSelec = true;
            TemaSonic = false;
            TemaMario = false;
            TemaSpider = false;
            TemaBen10 = true;

            btnSelec01 = false;
            btnSelec02 = false;
            btnSelec03 = false;
            btnSelec04 = true;
            /*btnSelec05 = false;
            btnSelec06 = false;
            btnSelec07 = false;
            btnSelec08 = false;
            btnSelec09 = false;
            btnSelec10 = false;
            btnSelec11 = false;
            btnSelec12 = false;*/
            if (btnSelec04 == true)
            {
                btnSelecionarTema.Visible = false;
                btnST02.Visible = false;
                btnST03.Visible = false;
                btnST04.Visible = true;
                //btnST05.Visible = false;
                //btnST06.Visible = false;
                //btnST07.Visible = false;
                //btnST08.Visible = false;
                //btnST09.Visible = false;
                // btnST10.Visible = false;
                //btnST11.Visible = false;
                //btnST12.Visible = false;
            }
            btnST04.BackgroundImage = Properties.Resources._002;
            btnST03.BackgroundImage = Properties.Resources._001_removebg_preview1;
            btnST02.BackgroundImage = Properties.Resources._001_removebg_preview1;
            btnSelecionarTema.BackgroundImage = Properties.Resources._001_removebg_preview1;

        }

        private void pbIconTema04_MouseEnter(object sender, EventArgs e)
        {
            pbNotPerson.Visible = false;
            pbPersoTemas.Visible = true;
            FotoPerso[3] = "Ben10Centerpng";
            string Perso04 = FotoPerso[3];
            pbPersoTemas.Image = (Image)Properties.Resources.ResourceManager.GetObject(Perso04);

            if (btnSelec01 == true)
            {
                FotoPerso[1] = "SonicCenterpng";
                string Perso01 = FotoPerso[1];
                pbPersoTemas.Image = (Image)Properties.Resources.ResourceManager.GetObject(Perso01);
            }
            if(btnSelec02 == true)
            {
                FotoPerso[2] = "MarioCenterpng";
                string Perso02 = FotoPerso[2];
                pbPersoTemas.Image = (Image)Properties.Resources.ResourceManager.GetObject(Perso02);
            }



            if(btnSelec04 == true)
            {
                pbPersoTemas.Image = (Image)Properties.Resources.ResourceManager.GetObject(Perso04);
            }
            
            btnST04.Visible = true;
            if (btnSelec01 == true)
            {
                btnSelecionarTema.Visible = true;
            }
            if (btnSelec01 == false)
            {
                btnSelecionarTema.Visible = false;
            }
            if (btnSelec02 == true)
            {
                btnST02.Visible = true;
            }
            if (btnSelec02 == false)
            {
                btnST02.Visible = false;
            }
            if (btnSelec03 == true)
            {
                btnST03.Visible = true;
            }
            if (btnSelec03 == false)
            {
                btnST03.Visible = false;
            }
           /* btnST02.Visible = false;
            btnST03.Visible = false;
            btnST04.Visible = true;
            btnST05.Visible = false;
            btnST06.Visible = false;
            btnST07.Visible = false;
            btnST08.Visible = false;*/
            //btnST09.Visible = false;
            //btnST10.Visible = false;
            // btnST11.Visible = false;
            //btnST12.Visible = false;
        }

        private void pbIconTema04_MouseLeave(object sender, EventArgs e)
        {
            if (btnSelec04 == true)
            {
                btnST04.Visible = true;
            }
        }

        private void btnST04_MouseEnter(object sender, EventArgs e)
        {
            if (btnSelec04 == false)
                btnST04.BackgroundImage = Properties.Resources._002;
        }

        private void btnST04_MouseLeave(object sender, EventArgs e)
        {
            btnST04.BackgroundImage = Properties.Resources._001_removebg_preview1;
            if (btnSelec04 == true)
            {
                btnST04.BackgroundImage = Properties.Resources._003;
            }
        }

        private void btnST04_MouseDown(object sender, MouseEventArgs e)
        {
            btnST04.BackgroundImage = Properties.Resources._002__2_;
        }

        private void pbPersoTemas_MouseEnter(object sender, EventArgs e)
        {
            if(btnSelec01 == false)
            {
                btnSelecionarTema.Visible = false;
                //pbPersoTemas.Visible = false;
                //pbNotPerson.Visible = true;
            }
            if (btnSelec01 == true)
            {
                //pbNotPerson.Visible = false;
               // pbPersoTemas.Visible = true;
            }
            if(btnSelec02 == false)
            {
                btnST02.Visible = false;
                //pbPersoTemas.Visible = false;
                //pbNotPerson.Visible = true;
            }
            if (btnSelec02 == true)
            {
               //pbNotPerson.Visible = false;
                //pbPersoTemas.Visible = true;
            }
            if (btnSelec03 == false)
            {
                btnST03.Visible = false;
                //pbPersoTemas.Visible = false;
                //pbNotPerson.Visible = true;
            }
            if (btnSelec03 == true)
            {
                //pbNotPerson.Visible = false;
                //pbPersoTemas.Visible = true;
            }
            if (btnSelec04 == false)
            {
                btnST04.Visible = false;
               // pbPersoTemas.Visible = false;
                //pbNotPerson.Visible = true;
            }
            if (btnSelec04 == true)
            {
               // pbNotPerson.Visible = false;
               // pbPersoTemas.Visible = true;
            }
            //pbPersoTemas.Visible = false;
            //pbNotPerson.Visible = true;

        }

        private void btnComecarJogo_MouseEnter(object sender, EventArgs e)
        {

            btnComecarJogo.BackgroundImage = Properties.Resources.Comecar02;


        }

        private void btnComecarJogo_MouseLeave(object sender, EventArgs e)
        {
            btnComecarJogo.BackgroundImage = Properties.Resources.Comecar01;

        }

        private void btnComecarJogo_MouseDown(object sender, MouseEventArgs e)
        {
            btnComecarJogo.BackgroundImage = Properties.Resources.Comecar03;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }



        /*private void pbIconTema_Click(object sender, EventArgs e)
        {

        }*/
    }
}
