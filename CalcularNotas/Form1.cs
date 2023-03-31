using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CalcularNotas.Formularios;

namespace CalcularNotas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSimular_Click(object sender, EventArgs e)
        {
            FormSimularMedia form = new FormSimularMedia();
            form.ShowDialog();
        }

        private void btnExame_Click(object sender, EventArgs e)
        {
            FormNotaExame form = new FormNotaExame();
            form.ShowDialog();
        }

        private void btnMediaExame_Click(object sender, EventArgs e)
        {
            FormMediaFinal form = new FormMediaFinal();
            form.ShowDialog();
        }
    }
}
