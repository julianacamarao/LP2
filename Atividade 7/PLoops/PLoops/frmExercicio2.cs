using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PLoops
{
    public partial class frmExercicio2 : Form
    {
        double N;
        public frmExercicio2()
        {
            InitializeComponent();
        }

        private void txtNumero_Validating(object sender, CancelEventArgs e)
        {
            //double N;
            if (!Double.TryParse(txtNumero.Text, out N) || N <= 0)
            {
                MessageBox.Show("Entrada inválida! Insira um número maior do que ZERO.");
                e.Cancel = true;
            }
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double cont;
            double acumulador = 0;

            if (N == 1)
            {
                acumulador += 1;
            }

            else
                for (cont = 2; cont <= N; cont += 1)
                    acumulador += (1 / cont);

            N = 1 + acumulador;
            MessageBox.Show($"O resultado da conta é: {N}");
        }
    }
}
