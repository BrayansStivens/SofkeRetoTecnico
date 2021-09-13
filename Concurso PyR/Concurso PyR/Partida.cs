using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BibliotecaPyR;

namespace Concurso_PyR
{
    public partial class Partida : Form
    {
        private BibliotecaPyR.Categorias categoria = new BibliotecaPyR.Categorias();
        private BibliotecaPyR.Jugador jugador = new BibliotecaPyR.Jugador();
        private BibliotecaPyR.Preguntas pregunta = new BibliotecaPyR.Preguntas();
        private BibliotecaPyR.Ronda ronda = new BibliotecaPyR.Ronda();
        private BibliotecaPyR.Respuestas respuesta = new BibliotecaPyR.Respuestas();
        private int puntos = 0;
        public Partida()
        {
            InitializeComponent();
            imgMascota.BorderStyle = BorderStyle.None;
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            pnMenu.Visible = true;
            lbPregunta.SendToBack();
            imgMascota.SendToBack();
        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
            jugador.agregarJugador(tbNombre.Text, Int16.Parse(lbPuntaje.Text));
            inicio i = new inicio();
            i.Show();
            Hide();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            ronda.finJuego(tbNombre.Text, Int16.Parse(lbPuntaje.Text));
        }

        private void btRenaudar_Click(object sender, EventArgs e)
        {
            pnMenu.Visible = false;
            lbPregunta.BringToFront();
        }

        private void btnEmpezar_Click(object sender, EventArgs e)
        {
            try
            {
                lbNombre.Text = "Puntos";
                lbPuntaje.Visible = true;
                tbNombre.Visible = false;
                btnEmpezar.Visible = false;
                lbCategoria.Visible = true;
                pnOpciones.Visible = true;
                btnMenu.Visible = true;
                imgMascota.Visible = true;
                macota(lbCategoria.Text);
                lbCategoria.Text = ronda.Categoria;
                lbPregunta.Text = ronda.Pregunta;
                llenarOpcion(lbPregunta.Text.ToString(), lbCategoria.Text.ToString());
            }
            catch(Exception ex)
            {
                MessageBox.Show("ERROR, SE CERRARA LA APP");
                Application.Exit();
            }




        }

        private void btnOpcionUno_Click(object sender, EventArgs e)
        {

            rondas(btnOpcionUno.Text);

        }

        private void btnOpcionDos_Click(object sender, EventArgs e)
        {
            rondas(btnOpcionDos.Text);

        }

        private void btnOpcionTres_Click(object sender, EventArgs e)
        {
            rondas(btnOpcionTres.Text);

        }

        private void btnOpcionCuatro_Click(object sender, EventArgs e)
        {
            rondas(btnOpcionCuatro.Text);
        }
        public void llenarOpcion(string pregunta, string categoria)
        {
            try
            {
                List<string> opciones = respuesta.respuestaAleatoria(pregunta, categoria);

                btnOpcionCuatro.Text = opciones[respuesta.RespRandom[0]];
                btnOpcionUno.Text = opciones[respuesta.RespRandom[1]];
                btnOpcionDos.Text = opciones[respuesta.RespRandom[3]];
                btnOpcionTres.Text = opciones[respuesta.RespRandom[2]];
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR, SE CERRARA LA APP");
                Application.Exit();
            }
        }


        public void rondas(string opcion)
        {
            try
            {
                bool si;
                si = respuesta.respuestaCorrecta(lbPregunta.Text.ToString(), opcion, lbCategoria.Text.ToString());
                if (si)
                {
                    ronda.nuevaRonda(si, tbNombre.Text, Int16.Parse(lbPuntaje.Text));
                    lbPuntaje.Text = ronda.Puntos.ToString();
                    lbCategoria.Text = ronda.Categoria;
                    macota(lbCategoria.Text);
                    lbPregunta.Text = ronda.Pregunta;
                    llenarOpcion(lbPregunta.Text.ToString(), lbCategoria.Text.ToString());
                }
                else
                {
                    ronda.finJuego(tbNombre.Text, Int16.Parse(lbPuntaje.Text));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR, SE CERRARA LA APP");
                Application.Exit();
            }
        }

        private void tbNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (e.KeyChar == Convert.ToChar(Keys.Enter))
                {
                    lbNombre.Text = "Puntos";
                    lbPuntaje.Visible = true;
                    tbNombre.Visible = false;
                    btnEmpezar.Visible = false;
                    lbCategoria.Visible = true;
                    pnOpciones.Visible = true;
                    btnMenu.Visible = true;
                    macota(lbCategoria.Text);
                    imgMascota.Visible = true;
                    lbCategoria.Text = ronda.Categoria;
                    lbPregunta.Text = ronda.Pregunta;
                    llenarOpcion(lbPregunta.Text.ToString(), lbCategoria.Text.ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR, SE CERRARA LA APP");
                Application.Exit();
            }
        }

        public void macota(string categoria)
        {
            switch (categoria)
            {
                case "Geografia":
                    imgMascota.Image = Concurso_PyR.Properties.Resources.globo;
                    break;
                case "Ciencia y Naturaleza":
                    imgMascota.Image = Concurso_PyR.Properties.Resources.botellita;
                    break;
                case "Deportes":
                    imgMascota.Image = Concurso_PyR.Properties.Resources.Balon;
                    break;
                case "Historia":
                    imgMascota.Image = Concurso_PyR.Properties.Resources.pergaminop;
                    break;
            }
        }
    }
}
 