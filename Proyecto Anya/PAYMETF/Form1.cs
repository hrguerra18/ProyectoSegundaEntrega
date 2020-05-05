using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PAYMETF
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
           this.WindowState = FormWindowState.Minimized;
        }

        private void horafecha_Tick(object sender, EventArgs e)
        {
            LbFecha.Text = DateTime.Now.ToLongDateString();
            LbHora.Text = DateTime.Now.ToLongTimeString();
        }

        private void btnAbono_Click(object sender, EventArgs e)
        {
            FrmAbono frmAbono = new FrmAbono();
            frmAbono.Show();
            frmAbono.Visible = true;
            Visible = false;
            

        }

        private void btnCartera_Click(object sender, EventArgs e)
        {
            FrmCartera frmCartera = new FrmCartera();
            frmCartera.Show();
            frmCartera.Visible = true;
            Visible = false;


        }

        private void btnPrestamo_Click(object sender, EventArgs e)
        {
            FrmRegistrar frmRegistrar = new FrmRegistrar();
            frmRegistrar.Show();
            frmRegistrar.Visible = true;
            Visible = false;

        }

        private void btnInformacion_Click(object sender, EventArgs e)
        {
            FrmInformacionUsuario frmInformacionUsuario = new FrmInformacionUsuario();
            frmInformacionUsuario.Show();
            frmInformacionUsuario.Visible = true;
            Visible = false;



        }
    }
}
