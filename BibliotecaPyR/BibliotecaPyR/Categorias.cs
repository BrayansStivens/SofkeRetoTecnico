
using Biblioteca_Cuestionario_PyR.BD;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaPyR
{
    public class Categorias
    {
        //Atributos
        private string nombre = "";
        private string comandoSQL = "";
        private List<string> listaCategorias = new List<string>();

        //Constructores
        public Categorias(string nombre)
        {
            this.nombre = nombre;
        }

        public Categorias()
        {
        }

        //Encapsular
        public string Nombre { get => nombre; set => nombre = value; }
        public string ComandoSQL { get => comandoSQL; set => comandoSQL = value; }
        public List<string> ListaCategorias { get => this.listaCategorias;}

        //Metodos
        #region metodos
        public void categorias()
        {
            SqlConnection conector = BD.conectar("ConcursoPyR");
            ComandoSQL = "select * from pregunta_respuesta";
            SqlDataReader tabla;
            tabla = BD.consulta(ComandoSQL, conector);
            string comparador = "";
            while (tabla.Read())
            {
                if (tabla[1].ToString() != comparador)
                {
                    listaCategorias.Add(tabla[1].ToString());
                    comparador = tabla[1].ToString();
                }
            }
            BD.cerrar(conector);
        }

        public string nombreCategoria(int ronda)
        {
            switch (ronda)
            {
                case 1:
                    nombre = listaCategorias[0];
                    break;
                case 2:
                    nombre = listaCategorias[1];
                    break;
                case 3:
                    nombre = listaCategorias[2];
                    break;
                case 4:
                    nombre = listaCategorias[3];
                    break;
                case 5:
                    nombre = listaCategorias[4];
                    break;
                default:
                    nombre = listaCategorias[0];
                    break;
            }
            return nombre;
        }
        #endregion




    }
}
