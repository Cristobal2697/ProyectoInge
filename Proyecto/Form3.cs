using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto
{
    public partial class Form3 : Form
    {
        Conexion c = new Conexion();
        public Form3()
        {
            InitializeComponent();
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            bool lleno = true;
            string tipo;
            if (txtId.Text == "") { errorProvider1.SetError(txtId, "Campos vacios"); lleno = false; }
            else errorProvider1.Clear();
            if (txtUsuario.Text == "") { errorProvider1.SetError(txtUsuario, "Campos vacios"); lleno = false; }
            else errorProvider1.Clear();
            if (txtContrasena.Text == "") { errorProvider1.SetError(txtContrasena, "Campos vacios"); lleno = false; }
            else errorProvider1.Clear();
            if (rbRegular.Checked)
            {
                tipo = rbRegular.Text;
            }
            else
            {
                tipo = rbAdmi.Text;
            }
            if (lleno)
            {
                MessageBox.Show(c.registrarPerfil(Convert.ToInt32(txtId.Text), tipo, txtUsuario, txtContrasena.Text));
                
            }
            txtId.Text = "";
            txtUsuario.Text = "";
            txtContrasena.Text = "";
        }

        private void txtId_TextChanged(object sender, EventArgs e)
        {

        }

        private void cbTipo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtContrasena_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click_1(object sender, EventArgs e)
        {
            txtId.Text = "";
            txtUsuario.Text = "";
            txtContrasena.Text = "";
        }

        //private void cbPrueba_CheckedChanged(object sender, EventArgs e)
        //{

        //}
    }
}
