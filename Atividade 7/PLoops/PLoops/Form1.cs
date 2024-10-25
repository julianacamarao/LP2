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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void exercício1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<frmExercicio1>().Count() > 0)
            {
                MessageBox.Show("Form já existe");
                Application.OpenForms["frmExercicio1"].BringToFront();
            }
            else
            {
                frmExercicio1 obj1 = new frmExercicio1();
                obj1.MdiParent = this;
                obj1.WindowState = FormWindowState.Maximized;
                obj1.Show();
            }
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void exercício2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<frmExercicio2>().Count() > 0)
            {
                MessageBox.Show("Form já existe");
                Application.OpenForms["frmExercicio2"].BringToFront();
            }
            else
            {
                frmExercicio2 obj1 = new frmExercicio2();
                obj1.MdiParent = this;
                obj1.WindowState = FormWindowState.Maximized;
                obj1.Show();
            }
        }
    }
}
