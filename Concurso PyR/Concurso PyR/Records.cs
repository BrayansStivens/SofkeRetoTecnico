using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Concurso_PyR
{
    public partial class Records : Form
    {
        private BibliotecaPyR.Jugador j = new BibliotecaPyR.Jugador();
        private List<string> l = new List<string>();
        
        public Records()
        {
            l = j.records();
            InitializeComponent();
            foreach(var r in l)
            {
                tbLista.Text = tbLista.Text+ r +"\r"+"\n";
            }
        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
            inicio i = new inicio();
            this.Hide();
            i.Show();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
