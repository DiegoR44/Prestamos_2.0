using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProyectoPrestamo.Formularios;
using ProyectoPrestamo.Modales;

namespace ProyectoPrestamo
{
    public partial class Form1 : Form
    {
        public string NombreUsuario { get; set; }
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblusuario.Text = string.Format("Usuario: {0}", NombreUsuario);
        }


        private void Frm_Closing(object sender, FormClosingEventArgs e)
        {
            this.Show();
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {

        }

        private void btnregistrarprestamo_Click(object sender, EventArgs e)
        {
            frmRegistrarPrestamo frm = new frmRegistrarPrestamo();
            frm.Show();
            this.Hide();
            frm.FormClosing += Frm_Closing;
        }

        private void btnregistrarcobro_Click(object sender, EventArgs e)
        {
            frmRegistrarCobro frm = new frmRegistrarCobro();
            frm.Show();
            this.Hide();
            frm.FormClosing += Frm_Closing;
        }

        private void btnhistorialprestamo_Click(object sender, EventArgs e)
        {
            frmHistorialPrestamo frm = new frmHistorialPrestamo();
            frm.Show();
            this.Hide();
            frm.FormClosing += Frm_Closing;
        }

        private void btnclientes_Click(object sender, EventArgs e)
        {
            frmClientes frm = new frmClientes();
            frm.Show();
            this.Hide();
            frm.FormClosing += Frm_Closing;
        }

        private void btnconfiguracion_Click(object sender, EventArgs e)
        {
            frmConfiguracion frm = new frmConfiguracion(this);
            frm.Show();
            this.Hide();
            frm.FormClosing += Frm_Closing;
        }

        private void btnresumengeneral_Click(object sender, EventArgs e)
        {
            frmResumenGeneral frm = new frmResumenGeneral();
            frm.Show();
            this.Hide();
            frm.FormClosing += Frm_Closing;
        }

        private void btnInfo_Click(object sender, EventArgs e)
        {
           // mdAcercade form = new mdAcercade();
            
            //form.ShowDialog();
        }

        private void lblusuario_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void bunifuButton22_Click(object sender, EventArgs e)
        {

        }

        private void bunifuLabel5_Click(object sender, EventArgs e)
        {

        }

        private void sesion_btn_Click(object sender, EventArgs e)
        {

        }

        private void bunifuButton21_Click(object sender, EventArgs e)
        {

        }

        private void bunifuButton22_Click_1(object sender, EventArgs e)
        {

        }

        private void bunifuLabel3_Click(object sender, EventArgs e)
        {

        }

        private void lblusuario_Click_1(object sender, EventArgs e)
        {

        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            frmRegistrarCobro frm = new frmRegistrarCobro();
            frm.Show();
            this.Hide();
            frm.FormClosing += Frm_Closing;
        }
    }
}
