using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Vectores_Codigo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonCreacion_Click(object sender, EventArgs e)
        {
            FormCreacion formularioCreacion = new FormCreacion();
            formularioCreacion.Show();
        }

        private void buttonVerificacion_Click(object sender, EventArgs e)
        {
            FormVerificacion formularioVerificacion = new FormVerificacion();
            formularioVerificacion.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
    }
}
