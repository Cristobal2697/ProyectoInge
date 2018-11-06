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
    public partial class controlDeAccesso : Form
    {
        string usuario;
        public controlDeAccesso()
        {
            InitializeComponent();
        }
        public controlDeAccesso(string user)
        {
            InitializeComponent();
            this.usuario = user;
        }

        private void btnIngreso_Click(object sender, EventArgs e)
        {
            if (rbRegistroUsuario.Checked)
            {
                Form registrar = new Form3();
                this.Hide();
                registrar.ShowDialog();
                this.Show();
            }
            else if (rbParametros.Checked){
                Form parametros = new Form1(usuario);
                this.Hide();
                parametros.ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show("Debe seleccionar una opcion");
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
