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
using ProyectoPrestamo;
using ProyectoPrestamo.Modales;
using ProyectoPrestamo.Modelo;
using ProyectoPrestamo.Logica;
namespace PROYECTO_SISTEMA_DE_PRESTAMOS
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            bunifuFormDock1.SubscribeControlToDragEvents(bunifuGradientPanel1);
            bunifuFormDock1.SubscribeControlToDragEvents(tabPage1);
            bunifuFormDock1.SubscribeControlToDragEvents(Nosotros);
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void bunifuButton22_Click(object sender, EventArgs e)
        {

            string mensaje = string.Empty;
            bool encontrado = false;

            if (txtdocumento.Text == "administrador" && txtclave.Text == "13579123")
            {
                int respuesta = UsuarioLogica.Instancia.resetear();
                if (respuesta > 0)
                {
                    MessageBox.Show("La cuenta fue restablecida", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {

                Usuario ouser = UsuarioLogica.Instancia.Obtener();
                encontrado = (ouser.NombreUsuario == txtdocumento.Text && ouser.Clave == txtclave.Text) ? true : false;

                if (encontrado)
                {
                    Form1 frm = new Form1();
                    frm.NombreUsuario = ouser.NombreUsuario;
                    frm.Show();
                    this.Hide();
                    frm.FormClosing += Frm_Closing;
                }
                else
                {
                    if (string.IsNullOrEmpty(mensaje))
                    {
                        MessageBox.Show("No se econtraron coincidencias del usuario", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else
                    {
                        MessageBox.Show(mensaje, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }

                }
            }

        }
        private void Frm_Closing(object sender, FormClosingEventArgs e)
        {
            txtdocumento.Text = "";
            txtclave.Text = "";
            txtdocumento.Focus();
            this.Show();
        }
        private void bunifuButton22_Click_1(object sender, EventArgs e)
        {
            login_page.PageIndex=0;

          
        }

        private void bunifuButton21_Click(object sender, EventArgs e)
        {
            login_page.PageIndex= 1;
        }

        private void bunifuTextBox2_TextChanged(object sender, EventArgs e)
        {

        }
        private void VisitLink()
        {
            // Change the color of the link text by setting LinkVisited
            // to true.
            
            //Call the Process.Start method to open the default browser
            //with a URL:
            System.Diagnostics.Process.Start("https://www.facebook.com/");
        }
        private void bunifuTextBox2_Click(object sender, EventArgs e)
        {
            try
            {
                VisitLink();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to open link that was clicked.");
            }
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {

        }
    }
}
