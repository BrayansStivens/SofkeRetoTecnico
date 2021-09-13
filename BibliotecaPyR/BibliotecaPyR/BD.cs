using System;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;

namespace Biblioteca_Cuestionario_PyR.BD
{
    public static class BD
    {
        public static SqlConnection conectar(string nomBD)
        {
            SqlConnection conectar = new SqlConnection("Data Source=localhost;Initial Catalog=" + nomBD + ";Integrated Security=SSPI;");
            try
            {
                conectar.Open();
                //MessageBox.Show("Se realizo la coneccion");

                return conectar;
            }
            catch (Exception ex)
            {
                MessageBox.Show("no se realizo la coneccion");
                return null;
            }
        }
        public static SqlDataReader consulta(string conSQL, SqlConnection conector)
        {
            try
            {
                SqlCommand comando = new SqlCommand(conSQL, conector);
                SqlDataReader tabla = comando.ExecuteReader();
                //MessageBox.Show("Se realizo la consulta");
                return tabla;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Fallo la consulta " + ex.ToString());
                return null;
            }
        }

        public static  void agregar (string conSQL, SqlConnection conector)
        {
            try
            {
                SqlCommand comando = new SqlCommand(conSQL, conector);
                comando.ExecuteNonQuery();
                
            }
            catch (Exception e)
            {
                MessageBox.Show("El juagador no ha sido agregado", e.ToString());
                
            }


        }
        public static int operar(string conSQL, SqlConnection conector)
        {
            int num = 0;
            try
            {
                SqlCommand comando = new SqlCommand(conSQL, conector);
                comando.ExecuteNonQuery();
                num = comando.ExecuteNonQuery();
                return num;
            }
            catch (SqlException e)
            {
                MessageBox.Show("Fallo la consulta " + e.ToString());
                return num;
            }
        }
        public static  void cerrar(SqlConnection conector)
        {
            try
            {
                conector.Close();
            }
            catch (SqlException eq) { }
        }
    }
}

