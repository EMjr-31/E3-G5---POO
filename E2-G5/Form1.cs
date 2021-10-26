using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace E2_G5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public bool validarCampos()
        {
            bool validado = true;
            if (txtNombre.Text == "")
            {
                validado = false;
                errorProvider1.SetError(txtNombre, "Ingresar nombre");
            }
            if (txtApellido.Text == "")
            {
                validado = false;
                errorProvider1.SetError(txtApellido, "Ingresar Apellido");
            }
            return validado;
        }
        private void BorrarMensaje()
        {
            errorProvider1.SetError(txtNombre, "");
            errorProvider1.SetError(txtApellido, "");
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            BorrarMensaje();
            if (validarCampos())
            {
                MessageBox.Show("Los datos se ingresaron correctamente");
                DateTime fechaNacimiento = dtpFecha.Value;
                int anios = System.DateTime.Now.Year - fechaNacimiento.Year;
                if (System.DateTime.Now.Subtract(fechaNacimiento.AddYears(anios)).TotalDays < 0)
                {
                    txtEdad.Text = Convert.ToString(anios - 1);
                }
                else { txtEdad.Text = Convert.ToString(anios); }
            }
        }
    }
}
