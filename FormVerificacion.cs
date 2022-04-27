using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Vectores_Codigo
{
    public partial class FormVerificacion : Form
    {
        List<Codigo> codigos = new List<Codigo>();
        //List<Resumen> resumen1 = new List<Resumen>();
        public FormVerificacion()
        {
            InitializeComponent();
        }
        
        private void CargarCodigo()
        {
            FileStream stream = new FileStream("Codigos.txt", FileMode.OpenOrCreate, FileAccess.Read);
            StreamReader reader = new StreamReader(stream);

            while (reader.Peek() > -1)
            {
                Codigo codigo = new Codigo();
                codigo.nocarnet = reader.ReadLine();
                codigo.digitoVerificador = reader.ReadLine();
                codigo.vectorCodigo = reader.ReadLine();

                codigos.Add(codigo);
            }
            reader.Close();
        }
        private void buttonVerificar_Click(object sender, EventArgs e)
        {
            Codigo codigo = new Codigo();

            for (int i = 0; i<codigos.Count; i++)
            {
                if (textBoxcodigoVerificador.Text == codigos[i].vectorCodigo)
                {
                    //MessageBox.Show("Felicidades el codigo ingresado es correcto!!!");
                    labelVerificacion.Text = "Codigo Correcto!!!";
                    //agragar oculatar la etiqueta incorrecta para que no aparezca junto al incorrecto
                    labelVerificacion1.Hide();
                }
                else
                {
                    labelVerificacion1.Text = "Codigo Incorrecto!!";
                }
            }
            
        }

        private void FormVerificacion_Load(object sender, EventArgs e)
        {
            CargarCodigo();
        }
    }
}
