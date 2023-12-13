using Jogo_da_memória.Properties;
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
    public partial class FormLvls : Form
    {
        static public bool LvlFacil = true;
        static public bool LvlFacilClick = false;
        static public bool LvlMedio = false;
        static public bool LvlHard = false;
        static public bool LvlInsane = false;
        public FormLvls()
        {
            InitializeComponent();
        }

        private void btnLvlFacil_Click(object sender, EventArgs e)
        {
            LvlFacilClick = true;
            if (LvlFacil == true)
            {
                FormLoadGame loadDif = new FormLoadGame();
                FormMenuInicial frmSonic = new FormMenuInicial();
                FormSM frmMario = new FormSM();
                Form2 frmBen10 = new Form2();

                if (FormMenuTemas.btnSelec01 == true)
                {
                    frmSonic.ShowDialog();
                    Close();
                }
                if (FormMenuTemas.btnSelec02 == true)
                {
                    frmMario.ShowDialog();
                    Close();
                }
                if (FormMenuTemas.btnSelec04 == true)
                {
                    loadDif.ShowDialog();
                    //frmBen10.ShowDialog();
                    Close();
                }
            }

        }

        private void btnLvlMedio_Click(object sender, EventArgs e)
        {
            FormLoadGame frmLoad = new FormLoadGame();
            FormBen10Lvl02 frmB1002 = new FormBen10Lvl02();
            if(Form2.MedioClick == true)
            {
                frmLoad.ShowDialog();
                //frmB1002.ShowDialog();
                Close();
            }
        }

        private void FormLvls_Load(object sender, EventArgs e)
        {
            
            if(Form2.MedioClick == true)
            {
                btnLvlMedio.BackgroundImage = Properties.Resources.TMedio_removebg_preview;
            }
        }
    }
}
