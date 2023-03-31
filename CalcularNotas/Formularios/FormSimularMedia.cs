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

namespace CalcularNotas.Formularios
{
    public partial class FormSimularMedia : Form
    {
        public FormSimularMedia()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double nota1, nota2, media;
            nota1 = Convert.ToDouble(txtNota1.Text);
            nota2 = Convert.ToDouble(txtNota2.Text);
            media = (nota1 + nota2) / 2;    

            if (media >= 60.0)
            {
                lbResultado.Text = txtNome.Text + ", você foi aprovado(a), com média = " + media;
            } else
            {
                lbResultado.Text = txtNome.Text + ", você foi reprovado(a), com média = " + media;
                btnExame.Visible = true;
            }
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            txtNome.Clear();
            txtNota1.Clear();
            txtNota2.Clear();
            lbResultado.Text = string.Empty;
            btnExame.Visible = false;
        }

        private void btnExame_Click(object sender, EventArgs e)
        {
            FormNotaExame form = new FormNotaExame();
            form.ShowDialog();
        }
    }
}
