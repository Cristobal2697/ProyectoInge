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
    public partial class Form2 : Form
    {
        Conexion c = new Conexion();
        public Form2()
        {
            InitializeComponent();
            
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {
            //bool lleno = true;
            //if (txtUsuario.Text == "") { errorProvider1.SetError(txtUsuario, "Campos vacios"); lleno = false; }
            //else errorProvider1.Clear();
            //if (lleno)
            //{
            //    if (c.UsuarioRegistrado(txtUsuario.Text)>0)
            //    {
            //        c.completarId(txtId, txtUsuario.Text);
            //    }
            //    else
            //    {
            //        txtId.Text = "";
            //    }
            //}
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            bool lleno = true;
            if (txtId.Text == "") { errorProvider1.SetError(txtId, "Campos vacios"); lleno = false; }
            else errorProvider1.Clear();
            if (txtContrasena.Text == "") { errorProvider1.SetError(txtContrasena, "Campos vacios"); lleno = false; }
            else errorProvider1.Clear();
            if (lleno) {
                if (c.verificarContrasena(Convert.ToInt32(txtId.Text), txtContrasena)) {
                    MessageBox.Show("Usuario verificado");
                    string user = txtUsuario.Text;
                    Form control = new controlDeAccesso(user);
                    this.Hide();
                    control.ShowDialog();
                    this.Show();
                    txtUsuario.Text = "";
                    txtContrasena.Text = "";
                }
            }
        }

        private void txtId_TextChanged(object sender, EventArgs e)
        {

            bool lleno = true;
            if (txtId.Text == "") { errorProvider1.SetError(txtId, "Campos vacios"); lleno = false; }
            else errorProvider1.Clear();
            if (lleno)
            {
                if (c.IdRegistrado(Convert.ToInt32(txtId.Text)) > 0)
                {
                    c.completarUsuario(Convert.ToInt32(txtId.Text), txtUsuario);
                }
                else
                {
                    txtUsuario.Text = "";
                }
            }
            else
            {
                MessageBox.Show("Campo vacio");
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
