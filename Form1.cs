using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejemplo3D
{
    public partial class Form1 : Form
    {
        Persona persona = new Persona();

        public Form1()
        {
            InitializeComponent();
        }

        private void buttonIngresar_Click(object sender, EventArgs e)
        {            
            persona.Dpi = textBoxDPI.Text;
            persona.Nombre = textBoxNombre.Text;
            persona.Apellido = textBoxApellido.Text;
            persona.Telefono = textBoxTelefono.Text;
            persona.FechaNacimiento = dateTimePicker1.Value;
            
        }

        private void buttonSalida_Click(object sender, EventArgs e)
        {                                  
            labelDPI.Text = persona.Dpi;
            labelNombre.Text = persona.Nombre;
            labelApellido.Text = persona.Apellido;
            labelTelefono.Text = persona.Telefono;
            labelFechaNacimiento.Text = persona.FechaNacimiento.ToString();
            label1Edad.Text = persona.edad().ToString();
           
        }

        private void buttonAbrirCuentas_Click(object sender, EventArgs e)
        {
            FormCuenta formularioCuenta = new FormCuenta();
            formularioCuenta.Show();
        }
    }
}
