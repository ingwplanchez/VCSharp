using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Program_20_GUI_Datos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonResuldado_Click(object sender, EventArgs e)
        {
            MessageBox.Show(textBNombre.Text,"Nombre");
            MessageBox.Show(textBApellido.Text, "Apellido");
            MessageBox.Show(comboBox1.Text, "Pais");

            if (radioButton1.Checked) {
                MessageBox.Show(radioButton1.Text, "Sexo");
            }

            if (radioButton2.Checked)
            {
                MessageBox.Show(radioButton2.Text, "Sexo");
            }

            if (checkBoxOcio.Checked)
            {
                MessageBox.Show(checkBoxOcio.Text, "Intereses");
            }

            if (checkBoxDeportes.Checked)
            {
                MessageBox.Show(checkBoxDeportes.Text, "Intereses");
            }

            if (checkBoxMusica.Checked)
            {
                MessageBox.Show(checkBoxMusica.Text, "Intereses");
            }

        }

    }
}
