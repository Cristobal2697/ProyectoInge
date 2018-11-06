using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Proyecto{
    class Conexion{
        SqlConnection cn;
        SqlCommand cmd;
        SqlDataReader dr;
        //SqlDataAdapter da;
        //DataTable dt;

        public Conexion(){
           try{
               cn = new SqlConnection("Data Source=.;Initial Catalog=aguvelDB;Integrated Security=True");
               cn.Open();
               //MessageBox.Show("Conectado");

           }
            catch(Exception ex){
               MessageBox.Show("Ocurrio un error al conectarse a la base de datos: "+ex.ToString());
           }
        }

        public string guardar(string fecha, string hora, float FE, int VAE, float FS, int VAS, float DCloro, float peso1, float peso2,
                    float presionEyectorA, int presionAQME, int presionAQMS, int ADE, int ADS, float PHE, float tempE, float PHS, float tempS, float cloro,
                    float arsenicoE, float arsenicoS, float manganesoEntrada, float manganesoSalida, float hierroEntrada, float hierroSalida)
        {
            string salida = "Se guardo correctamente";

            string sql = "Insert into t_parametrosDeAgua(fecha,hora,flujoEntrada,volumenAcumuladoDeEntrada,flujoDeSalida,volumenAcumuladoDeSalida,dosificacionDeCloro,pesoDeCilindro1,pesoDeCilindro2,presionEnElEyector,presionAQMEntrada,presionAQMSalida,presionADEntrada,presionADSalida,phEntrada, temperaturaEntrada,phSalida,temperaturaSalida,cloro,arsenicoEntrada,arsenicoSalida,manganesoEntrada,manganesoSalida,hierroEntrada,hierroSalida )values('"+fecha+"','"+hora+"', "+FE+","+VAE+","+FS+","+VAS+","+DCloro+","+peso1+","+peso2+","+presionEyectorA+","+presionAQME+","+presionAQMS+","+ADE+","+ADS+","+PHE+","+tempE+","+PHS+","+tempS+","+cloro+","+arsenicoE+","+arsenicoS+","+manganesoEntrada+","+manganesoSalida+","+hierroEntrada+","+hierroSalida+")";
            try
            {
                cmd = new SqlCommand(sql, cn);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                salida = "Ocurrio un error guardando: " + ex.ToString();
            }
            return salida;
        }


        public void completarUsuario(int id, TextBox txtUsuario)
        {
            
            try{
                string sql = "select * from t_usuario where PKidentificacion= "+id+"";

                cmd = new SqlCommand(sql, cn);
                dr = cmd.ExecuteReader();
                if (dr.Read()){
                    txtUsuario.Text = dr["usuario"].ToString();
                    txtUsuario.ReadOnly = true;
                }
                dr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo cargar los datos" + ex.ToString());
            }

        }

        //public void completarId(TextBox txtId, string usuario)
        //{
        //    try
        //    {
        //        string sql = "select * from t_usuario where usuario= '"+usuario +"'";

        //        cmd = new SqlCommand(sql, cn);
        //        dr = cmd.ExecuteReader();
        //        if (dr.Read())
        //        {
        //            txtId.Text = dr["PKidentificacion"].ToString();
        //            txtId.ReadOnly = true;
        //        }
        //        dr.Close();
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show("No se pudo cargar los datos" + ex.ToString());
        //    }

        //}

        public int IdRegistrado(int id)
        {
            int contador = 0;
            try
            {
                cmd = new SqlCommand("Select * from t_usuario where PKidentificacion=" + id + "", cn);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    contador++;
                }
                dr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo consultar correctamente: " + ex.ToString());
            }
            return contador;
        }

        //public int UsuarioRegistrado(string usuario)
        //{
        //    int cont = 0;
        //    try
        //    {
        //        cmd = new SqlCommand("Select * from t_usuario where usuario= '"+usuario+"'", cn);
        //        dr = cmd.ExecuteReader();
        //        while (dr.Read())
        //        {
        //            cont++;
        //        }
        //        dr.Close();
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show("No se pudo consultar correctamente: " + ex.ToString());
        //    }
        //    return cont;
        //}

        public bool verificarContrasena(int id,TextBox txtContrasena)
        {
            bool valor = false;
            string sql = "select * from t_usuario where PKidentificacion = "+id+"";
            try
            {
                cmd = new SqlCommand(sql, cn);
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    if (dr["contrasena"].ToString() == txtContrasena.Text)
                    {
                        valor = true;
                    }
                    else
                    {
                        valor = false;
                    }
                }
                dr.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error en la autenticacion..." + ex, ToString());
            }
            return valor;
        }

        public void registrarUsuario(int id, TextBox user, string contrasena)
        {
            try
            {
                string sql = "insert into t_usuario(PKidentificacion,usuario, contrasena) values ("+id+",'"+user.Text+"','"+contrasena+"')";
                cmd = new SqlCommand(sql, cn);
                cmd.ExecuteNonQuery();
            }
            catch(Exception ex)
            {
                MessageBox.Show("No se pudo agregar usuario" + ex.ToString());
            }
        }

        public string registrarPerfil(int id, string tipo , TextBox user, string contrasena)
        {
            string sql = "insert into t_perfil(PK_id,tipo,acceso,usuario,contrasenia) values ("+id+",'"+tipo+"','ver','"+user.Text+"','"+contrasena+"')";
            string salida = "Se ha registrado correctamente";
            try
            {
                cmd = new SqlCommand(sql, cn);
                cmd.ExecuteNonQuery();
                registrarUsuario(id, user, contrasena);
            }
            catch(Exception ex)
            {
                salida = "Error al registrar usuario" + ex.ToString();
            }
            return salida;
        }




    }
}
