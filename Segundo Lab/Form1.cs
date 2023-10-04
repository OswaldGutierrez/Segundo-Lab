using System.Text.RegularExpressions;

namespace Segundo_Lab
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonCalcular_Click(object sender, EventArgs e)
        {
            string funcion1 = textBoxFuncion1.Text;
            string funcion2 = textBoxFuncion2.Text;

            // Patrón actualizado para permitir números negativos en las funciones
            string patronFuncion = @"^y\s*=\s*-?\s*\d+\s*x\s*[\+\-]\s*\d+$";

            if (Regex.IsMatch(funcion1, patronFuncion))
            {
                // La función 1 cumple con el patrón, puedes procesarla aquí
                // Realiza los cálculos o acciones necesarios con la función 1
            }
            else
            {
                MessageBox.Show("La función 1 no cumple con el formato esperado.");
            }

            if (Regex.IsMatch(funcion2, patronFuncion))
            {
                // La función 2 cumple con el patrón, puedes procesarla aquí
                // Realiza los cálculos o acciones necesarios con la función 2
            }
            else
            {
                MessageBox.Show("La función 2 no cumple con el formato esperado.");
            }

            //asdad
        }
    }
}