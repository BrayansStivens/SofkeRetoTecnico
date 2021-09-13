using Biblioteca_Cuestionario_PyR.BD;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaPyR
{
    public class Respuestas
    {
        //Atributos y objetos
        private int[] respRandom = new int[4];
        private string comandoSQL = "";
        Preguntas preguntas = new Preguntas();

        //Encapsular
        public int[] RespRandom { get => respRandom; set => respRandom = value; }

        //Metodos
        public bool respuestaCorrecta( string pregunta,string respuesta, string categoria)
        {
            bool correcta = false;
            Dictionary<string, string> d = new Dictionary<string, string>();
            d = preguntas.llenarDiccionario(categoria);
            if (respuesta == d[pregunta])
            {
                return true;
            }
            else
            {
                return false;
            }

        }
        public List<string> respuestas(string pregunta,string categoria)
        {
            Dictionary<string, string> d = preguntas.llenarDiccionario(categoria);
            List<string> respuesta = new List<string>();
            string key = preguntas.obtenerCodigoPregunta(pregunta);
            SqlConnection conector = BD.conectar("ConcursoPyR");
            comandoSQL = "select * from respuestas_incorrectas where codPregunta= '" + key + "'";
            SqlDataReader tabla;
            tabla = BD.consulta(comandoSQL, conector);
            respuesta.Add(d[pregunta]);
            if (tabla.Read())
            {
                respuesta.Add(tabla[1].ToString());
                respuesta.Add(tabla[2].ToString());
                respuesta.Add(tabla[3].ToString());
            }
            return respuesta;
            BD.cerrar(conector);
        }

        public List<string> respuestaAleatoria(string pregunta, string categoria)
        {
            List<string> respuesta = respuestas(pregunta, categoria);
            int contador = 0;
            bool repetido;
            Random rmd = new Random();
            int i;
            while (contador < respRandom.Length)
            {
                i = rmd.Next(respuesta.Count);
                repetido = false;
                for (int j = 0; j < contador && !repetido; j++)
                {
                    if (respRandom[j] == i)
                    {
                        repetido = true;
                    }
                }
                if (!repetido)
                {
                    respRandom[contador] = i;
                    contador++;
                }
            }
            for(int k = 0; k> 5; k++)
            {
                respuesta[k] = respuesta[respRandom[k]];
            }

            return respuesta;
        }
     
    }
}
