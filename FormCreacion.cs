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
    public partial class FormCreacion : Form
    {
        List<Codigo> codigos = new List<Codigo>();
        public FormCreacion()
        {
            InitializeComponent();
        }

        private void GuardarCodigo()
        {
            FileStream stream = new FileStream("Codigos.txt", FileMode.Append, FileAccess.Write);
            StreamWriter writer = new StreamWriter(stream);

            Random rdn = new Random();
            int numero = rdn.Next(0, 11); //digito verificador

            string vectorCodigo = textBoxNoCarne.Text + Convert.ToString(numero);
            //int vectorCodigo = Convert.ToInt32(textBoxNoCarne.Text) + numero; //al sumar puede que quede un numero de 9 digitos
            
            foreach(var codigo in codigos)
            {
                writer.WriteLine(codigo.nocarnet); //no agrega el numero de carne a la lista?
                //writer.WriteLine(codigo.vectorcontrol);
                writer.WriteLine(numero);
                writer.WriteLine(vectorCodigo);
             
            }
            writer.Close();
            labelVectorCodigo.Text = vectorCodigo;

             //MessageBox.Show("Su vector codigo es: " +vectorCodigo);
        }
        private void CargarCodigo()
        {
            FileStream stream = new FileStream("Codigos.txt", FileMode.OpenOrCreate, FileAccess.Read);
            StreamReader reader = new StreamReader(stream);

            while(reader.Peek() >-1)
            {
                Codigo codigo = new Codigo();
                codigo.nocarnet = reader.ReadLine();
                codigo.digitoVerificador = reader.ReadLine();
                codigo.vectorCodigo = reader.ReadLine();

                codigos.Add(codigo);
            }
            reader.Close();
        }

        private void buttonCrear_Click(object sender, EventArgs e)
        {

            Codigo codigo = new Codigo();

            codigos.Add(codigo);
            
            GuardarCodigo();
            //Random rdn = new Random();

           
            
        }

        private void FormCreacion_Load(object sender, EventArgs e)
        {
            //CargarCodigo();
        }
    }
}
