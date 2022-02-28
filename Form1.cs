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

namespace Ejemplo3D
{
    public partial class Form1 : Form
    {
        

        List<Persona> personas = new List<Persona>();
        

        public Form1()
        {
            InitializeComponent();
        }

        private void buttonIngresar_Click(object sender, EventArgs e)
        {
            Persona persona = new Persona();
            persona.Dpi = textBoxDPI.Text;
            persona.Nombre = textBoxNombre.Text;
            persona.Apellido = textBoxApellido.Text;
            persona.Telefono = textBoxTelefono.Text;
            persona.FechaNacimiento = dateTimePicker1.Value;

            personas.Add(persona);
            
        }

        private void buttonSalida_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            dataGridView1.Refresh();

            dataGridView1.DataSource = personas;
            dataGridView1.Refresh();
           
        }

        private void buttonAbrirCuentas_Click(object sender, EventArgs e)
        {
            FormCuenta formularioCuenta = new FormCuenta();
            formularioCuenta.Show();
        }

        private void Guardar(string fileName)
        {

            FileStream stream = new FileStream(fileName, FileMode.OpenOrCreate, FileAccess.Write);
            StreamWriter writer = new StreamWriter(stream);

            
            foreach (var persona in personas)
            {
                writer.WriteLine(persona.Dpi);
                writer.WriteLine(persona.Nombre);
                writer.WriteLine(persona.Apellido);
                writer.WriteLine(persona.Telefono);
                writer.WriteLine(persona.FechaNacimiento);
            }
                     
            writer.Close();
        }

        private void buttonGuardar_Click(object sender, EventArgs e)
        {
            Guardar("Personas.txt");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Leer(string fileName)
        {
            FileStream stream = new FileStream(fileName, FileMode.Open, FileAccess.Read);
            StreamReader reader = new StreamReader(stream);
            
            while (reader.Peek() > -1)
            {
                Persona persona = new Persona();
                persona.Dpi = reader.ReadLine();
                persona.Nombre = reader.ReadLine();
                persona.Apellido = reader.ReadLine();
                persona.Telefono = reader.ReadLine();
                persona.FechaNacimiento = Convert.ToDateTime(reader.ReadLine());
                
                personas.Add(persona);

            }

            reader.Close();

        }
        private void buttonCargar_Click(object sender, EventArgs e)
        {
            Leer("Personas.txt");
        }
    }
}
