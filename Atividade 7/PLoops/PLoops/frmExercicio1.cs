using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PLoops
{
    public partial class frmExercicio1 : Form
    {
        public frmExercicio1()
        {
            InitializeComponent();
        }

        private void btnEspacoBranco_Click(object sender, EventArgs e)
        {
            int cont;
            int espacoBranco = 0;

            for (cont = 0; cont < rchtxtFrase.Text.Length; cont++)
            {
                {
                    if (rchtxtFrase.Text[cont] == ' ')
                        espacoBranco++;
                }
            }
            MessageBox.Show($"A quantidade de espaços no seu texto é de {espacoBranco}");
        }

        private void btnLetraR_Click(object sender, EventArgs e)
        {
            //int cont;
            int letraR = 0;
            //char letra;

            foreach (char letra in rchtxtFrase.Text)
            {
                if (letra == 'r' || letra == 'R')
                    letraR++;
            }
            MessageBox.Show($"A quantidade de letra(s) R no seu texto é de {letraR}");
        }

        private void btnParLetras_Click(object sender, EventArgs e)
        {
            int cont;
            int paresDeLetras;
            cont = 1;
            paresDeLetras = 0;

            while (cont < rchtxtFrase.Text.Length)
            {
                if (rchtxtFrase.Text.ToLower()[cont-1] == rchtxtFrase.Text.ToLower()[cont])
                    paresDeLetras++;
                cont++;
            }
            MessageBox.Show($"A quantidade de letras em PARES no seu texto é de {paresDeLetras}");
        }
    }
}
