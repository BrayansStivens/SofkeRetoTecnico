using Biblioteca_Cuestionario_PyR.BD;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaPyR
{
    public class Preguntas
    {
        //Atributos
        private string comandoSQL = "";
        
        Categorias categoria = new Categorias();

        //Metodos
        public Dictionary<string, string> llenarDiccionario(string categoria)
        {
            Dictionary<string, string> dicPreguntas = new Dictionary<string, string>();
            SqlConnection conector = BD.conectar("ConcursoPyR");
            comandoSQL = "select pregunta, respuesta from pregunta_respuesta where categoria= '" + categoria + "'";
            SqlDataReader tabla;
            tabla = BD.consulta(comandoSQL, conector);
            while (tabla.Read())
            {
                dicPreguntas.Add(tabla[0].ToString(), tabla[1].ToString());
            }
            BD.cerrar(conector);
            return dicPreguntas;
        }


        public List<string> preguntas(string categoria)
        {
            Dictionary<string, string> DicPreguntas = llenarDiccionario(categoria);
            List<string> pregunta = new List<string>();
            foreach (var key in DicPreguntas.Keys)
            {
                pregunta.Add(key);
            }
            return pregunta;
        }

        public string preguntaAleatoria(string categoria)
        {
            List<string> pregunta = preguntas(categoria);
            Random rmd = new Random();
            int index = rmd.Next(pregunta.Count);
            string p = pregunta[index];
            return p;
        }

        public string obtenerCodigoPregunta(string pregunta)
        {
            SqlConnection conector = BD.conectar("ConcursoPyR");
            comandoSQL = "select codigo from pregunta_respuesta where pregunta= '" + pregunta + "'";
            SqlDataReader tabla;
            tabla = BD.consulta(comandoSQL, conector);
            if (tabla.Read())
            {
                return tabla[0].ToString();
            }
            else
            {
                return "Error";
            }
            BD.cerrar(conector);
        }  
    }
}
