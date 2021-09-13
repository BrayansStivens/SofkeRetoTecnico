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
    public partial class inicio : Form
    {
        public inicio()
        {
            InitializeComponent();
        }

        private void btnJugar_Click(object sender, EventArgs e)
        {
            Partida r = new Partida();
            r.Show();
            Hide();
        }

        private void btnRecords_Click(object sender, EventArgs e)
        {
            Records r =new Records();
            this.Hide();
            r.Show();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
