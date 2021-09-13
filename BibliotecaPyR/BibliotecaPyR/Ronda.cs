using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BibliotecaPyR
{
     public class Ronda
    {
        //Objetos y Atributos
        Categorias objCategoria = new Categorias();
        Preguntas objPreguntas = new Preguntas();
        Respuestas objRespuestas = new Respuestas();
        Jugador objJugador = new Jugador();
        private string categoria;
        private string pregunta;
        private List<string> respuestas = new List<string>();
        private int numeroRonda;
        private int puntos;
        Dictionary<string, string[]> dp = new Dictionary<string, string[]>();

        //Constructor
        public Ronda()
        {
            numeroRonda = 1;
            objCategoria.categorias();
            Categoria = objCategoria.nombreCategoria(NumeroRonda);
            Pregunta = objPreguntas.preguntaAleatoria(categoria);
            
        }

        //Encapsular
        public string Categoria { get => categoria; set => categoria = value; }
        public string Pregunta { get => pregunta; set => pregunta = value; }
        public int NumeroRonda { get => numeroRonda; set => numeroRonda = value; }
        public List<string> Respuestas { get => respuestas; set => respuestas = value; }
        public int Puntos { get => puntos; set => puntos = value; }


        //Metodos
        public void nuevaRonda(bool si,string jugador, int puntos)
        {
            if (si)
            {
                NumeroRonda = numeroRonda + 1;
                if (NumeroRonda <=5)
                {                    
                    Puntos = Puntos+ objJugador.puntos(NumeroRonda);
                    objCategoria.categorias();
                    Categoria = objCategoria.nombreCategoria(NumeroRonda);
                    Pregunta = objPreguntas.preguntaAleatoria(categoria);

                }
                if (NumeroRonda>5)
                {
                    finJuego(jugador, Puntos);
                }
              

            }
        }

        public void finJuego(string jugador, int puntos)
        {
            objJugador.agregarJugador(jugador.Trim(), puntos);
            MessageBox.Show("GAME OVER!");
            Application.Exit();
        }
    }
}
