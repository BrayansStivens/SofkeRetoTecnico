using Biblioteca_Cuestionario_PyR.BD;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace BibliotecaPyR
{
    public class Jugador
    {   //Atributos
        private int punto =0;
        private string comandoSQL = "";

        //Encapsular
        public int Punto { get => punto; set => punto = value; }
        public string ComandoSQL { get => comandoSQL; set => comandoSQL = value; }

        //Metodos
        public int puntos(int ronda)
        {
            switch (ronda)
            {
                case 1:
                    punto = 5;
                    break;
                case 2:
                    punto = 10;
                    break;
                case 3:
                    punto = 15;
                    break;
                case 4:
                    punto = 20;
                    break;
                case 5:
                    punto = 25;
                    break;
            }

            return punto;
        }
        public void agregarJugador(string nombre, int puntos)
        {
            SqlConnection conector = BD.conectar("ConcursoPyR");
            comandoSQL = "insert into jugador values('"+nombre+"','"+puntos+"')";
            BD.agregar(ComandoSQL, conector);
            BD.cerrar(conector);
        }

        public List<string> records()
        {
            List<string> records = new List<string>();
            SqlConnection conector = BD.conectar("ConcursoPyR");
            comandoSQL = "select * from jugador order by puntaje desc";
            SqlDataReader tabla;
            tabla = BD.consulta(comandoSQL, conector);
          
            while (tabla.Read())
            {
                if (!tabla.HasRows)
                {
                    break;
                }
                else
                {
                    records.Add(tabla[1].ToString() + "     : " + tabla[2].ToString());
                }
               
            }
            BD.cerrar(conector);
            return records;
        }
    }
}
