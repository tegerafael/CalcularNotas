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
    public partial class FormMediaFinal : Form
    {
        public FormMediaFinal()
        {
            InitializeComponent();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            txtNome.Clear();    
            txtMedia.Clear();
            txtExame.Clear();

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double maex, nex, mf;
            nex = Convert.ToDouble(txtExame.Text);
            mf = Convert.ToDouble(txtMedia.Text);
            maex = (6 * mf + 4 * nex) / 10;
            
            if (maex >= 50)
            {
                lbResultado.Text = txtNome.Text + ", você foi aprovado(a), com média no exame final = " + maex;
            } else
            {
                lbResultado.Text = txtNome.Text + ", você foi reprovado(a), com média no exame final = " + maex;
            }
        }
    }
}
