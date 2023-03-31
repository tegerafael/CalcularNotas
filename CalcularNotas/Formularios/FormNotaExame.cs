using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalcularNotas.Formularios
{
    public partial class FormNotaExame : Form
    {
        public FormNotaExame()
        {
            InitializeComponent();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            txtNome.Clear();
            txtMedia.Clear();
            lbResultado.Text = string.Empty;
            btnMedia.Visible = false;
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double media, npex;
            media = Convert.ToDouble(txtMedia.Text);
            npex = (500 - 6 * media) / 4;
            lbResultado.Text = "O acadêmico: " + txtNome.Text + ", precisa de " + npex + " para aprovação";
            btnMedia.Visible = true;
        }

        private void btnMedia_Click(object sender, EventArgs e)
        {
            FormMediaFinal form = new FormMediaFinal();
            form.ShowDialog();
        }
    }
}
