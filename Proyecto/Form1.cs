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
    public partial class Form1 : Form
    {
        Conexion c = new Conexion();
        Form f2 = new Form2();
        public Form1()
        {
            InitializeComponent();
        }
        public Form1(String user)
        {
            InitializeComponent();
            txtUsuario.Text = user.ToString();
            txtUsuario.ReadOnly = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Conexion c = new Conexion();
        }
        
        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            bool lleno = true;
            if (txtFlujoEntrada.Text == "") { errorProvider1.SetError(txtFlujoEntrada, "Debe llenar este espacio."); lleno = false; }
            else errorProvider1.Clear();
            if (txtHora.Text == "") { errorProvider1.SetError(txtHora, "Debe llenar este espacio."); lleno = false; }
            else errorProvider1.Clear();
            if (txtFlujoEntrada.Text == "") { errorProvider1.SetError(txtVAE, "Debe llenar este espacio."); lleno = false; }
            else errorProvider1.Clear();
            if (txtHora.Text == "") { errorProvider1.SetError(txtFlujoSalida, "Debe llenar este espacio."); lleno = false; }
            else errorProvider1.Clear();
            if (txtFlujoEntrada.Text == "") { errorProvider1.SetError(txtVAS, "Debe llenar este espacio."); lleno = false; }
            else errorProvider1.Clear();
            if (txtHora.Text == "") { errorProvider1.SetError(txtDCloro, "Debe llenar este espacio."); lleno = false; }
            else errorProvider1.Clear();
            if (txtFlujoEntrada.Text == "") { errorProvider1.SetError(txtPeso1, "Debe llenar este espacio."); lleno = false; }
            else errorProvider1.Clear();
            if (txtHora.Text == "") { errorProvider1.SetError(txtPeso2, "Debe llenar este espacio."); lleno = false; }
            else errorProvider1.Clear();
            if (txtFlujoEntrada.Text == "") { errorProvider1.SetError(txtPresionEyectorA, "Debe llenar este espacio."); lleno = false; }
            else errorProvider1.Clear();
            if (txtHora.Text == "") { errorProvider1.SetError(txtPresionEyectorD, "Debe llenar este espacio."); lleno = false; }
            else errorProvider1.Clear();
            if (txtFlujoEntrada.Text == "") { errorProvider1.SetError(txtAQME, "Debe llenar este espacio."); lleno = false; }
            else errorProvider1.Clear();
            if (txtHora.Text == "") { errorProvider1.SetError(txtAQMS, "Debe llenar este espacio."); lleno = false; }
            else errorProvider1.Clear();
            if (txtHora.Text == "") { errorProvider1.SetError(txtADE, "Debe llenar este espacio."); lleno = false; }
            else errorProvider1.Clear();
            if (txtHora.Text == "") { errorProvider1.SetError(txtADS, "Debe llenar este espacio."); lleno = false; }
            else errorProvider1.Clear();
            if (lleno)
            {
                //float fe;
                //float.TryParse(txtFlujoEntrada.Text,out fe);
                float fe = Convert.ToSingle(txtFlujoEntrada.Text);
                float fs = Convert.ToSingle(txtFlujoSalida.Text);
                float Dcloro = Convert.ToSingle(txtDCloro.Text);
                float peso1 = Convert.ToSingle(txtPeso1.Text);
                float peso2 = Convert.ToSingle(txtPeso2.Text);
                float presion = Convert.ToSingle(txtPresionEyectorA.Text);
                float phe = Convert.ToSingle(txtPHE.Text);
                float tempE = Convert.ToSingle(txtTempE.Text);
                float phs = Convert.ToSingle(txtPHS.Text);
                float tempS = Convert.ToSingle(txtTempS.Text);
                float cloro = Convert.ToSingle(txtCloro.Text);
                float arsenicoE = Convert.ToSingle(txtArsenicoE.Text);
                float arsenicoS = Convert.ToSingle(txtArsenicoS.Text);
                float mgE = Convert.ToSingle(txtMangE.Text);
                float mgS = Convert.ToSingle(txtMangS.Text);
                float hierroE = Convert.ToSingle(txtHierroE.Text);
                float hierroS = Convert.ToSingle(txtHierroS.Text);

                MessageBox.Show(c.guardar(dtpFecha.Text, txtHora.Text,fe,Convert.ToInt32(txtVAE.Text),fs,Convert.ToInt32(txtVAS.Text),Dcloro
                    ,peso1, peso2,presion, Convert.ToInt32(txtAQME.Text), Convert.ToInt32(txtAQMS.Text),Convert.ToInt32(txtADE.Text), 
                    Convert.ToInt32(txtADS.Text), phe,tempE, phs, tempS,cloro, arsenicoE, arsenicoS,mgE, mgS, hierroE,hierroS));


                dtpFecha.Text = "";
                txtHora.Text = "";
                txtFlujoEntrada.Text = "";
                txtVAE.Text = "";
                txtFlujoSalida.Text = "";
                txtVAS.Text = "";
                txtDCloro.Text = "";
                txtPeso1.Text = "";
                txtPeso2.Text = "";
                txtPresionEyectorA.Text = "";
                txtPresionEyectorD.Text = "";
                txtAQME.Text = "";
                txtAQMS.Text = "";
                txtADE.Text = "";
                txtADS.Text = "";
                txtPHE.Text = "";
                txtTempE.Text = "";
                txtPHS.Text = "";
                txtTempS.Text = "";
                txtCloro.Text = "";
                txtArsenicoE.Text = "";
                txtArsenicoS.Text = "";
                txtMangE.Text = "";
                txtMangS.Text = "";
                txtHierroE.Text = "";
                txtHierroS.Text = "";
                txtObservaciones.Text = "";
            }
            else
            {
                MessageBox.Show("Datos sin llenar, favor revisar...");
            }
        }

        private void txtFlujoEntrada_TextChanged(object sender, EventArgs e)
        {
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void GbOpcion_Enter(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txtHora_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void dtpFecha_ValueChanged(object sender, EventArgs e)
        {

        }

        private void txtPeso2_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtAQMS_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPHE_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtVAE_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtFlujoSalida_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtVAS_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtDCloro_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPeso1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPresionEyectorA_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPresionEyectorD_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtAQME_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtADE_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtADS_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPHS_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtTempE_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtTempS_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCloro_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtArsenicoE_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtArsenicoS_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtMangE_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtMangS_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtHierroE_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtHierroS_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtObservaciones_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {
            //txtUsuario.Text = f2.txt
        }

        private void btnLimpiar_Click(object sender, EventArgs e){
            txtHora.Text = "";
            txtFlujoEntrada.Text = "";
            txtVAE.Text = "";
            txtFlujoSalida.Text = "";
            txtVAS.Text = "";
            txtDCloro.Text = "";
            txtPeso1.Text = "";
            txtPeso2.Text = "";
            txtPresionEyectorA.Text = "";
            txtPresionEyectorD.Text = "";
            txtAQME.Text = "";
            txtAQMS.Text = "";
            txtADE.Text = "";
            txtADS.Text = "";
            txtPHE.Text = "";
            txtTempE.Text = "";
            txtPHS.Text = "";
            txtTempS.Text = "";
            txtCloro.Text = "";
            txtArsenicoE.Text = "";
            txtArsenicoS.Text = "";
            txtMangE.Text = "";
            txtMangS.Text = "";
            txtHierroE.Text = "";
            txtHierroS.Text = "";
            txtObservaciones.Text = "";
        }

        private void panel10_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //private void button2_Click(object sender, EventArgs e){
        //    MessageBox.Show(c.eliminar(Convert.ToInt32(txtId.Text)));
        //    c.cargarPersonas(DgvPersonas);
        //}
    }
}
