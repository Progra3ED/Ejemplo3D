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
    public partial class FormCuenta : Form
    {
        Cuenta cuenta = new Cuenta();
        public FormCuenta()
        {
            InitializeComponent();
        }

        private void buttonIngresar_Click(object sender, EventArgs e)
        {
            cuenta.NumeroCuenta = textBoxNumeroCuenta.Text;
            cuenta.Dpi = textBoxDpi.Text;
            cuenta.Saldo = Convert.ToDouble(textBoxSaldo.Text);
        }

        private void buttonSalida_Click(object sender, EventArgs e)
        {
            labelNumeroCuenta.Text = cuenta.NumeroCuenta;
            labelDpi.Text = cuenta.Dpi;
            labelSaldo.Text = cuenta.Saldo.ToString();
        }
    }
}
