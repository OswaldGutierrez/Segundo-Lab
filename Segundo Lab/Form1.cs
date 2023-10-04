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

            // Patr�n actualizado para permitir n�meros negativos en las funciones
            string patronFuncion = @"^y\s*=\s*-?\s*\d+\s*x\s*[\+\-]\s*\d+$";

            if (Regex.IsMatch(funcion1, patronFuncion))
            {
                // La funci�n 1 cumple con el patr�n, puedes procesarla aqu�
                // Realiza los c�lculos o acciones necesarios con la funci�n 1
            }
            else
            {
                MessageBox.Show("La funci�n 1 no cumple con el formato esperado.");
            }

            if (Regex.IsMatch(funcion2, patronFuncion))
            {
                // La funci�n 2 cumple con el patr�n, puedes procesarla aqu�
                // Realiza los c�lculos o acciones necesarios con la funci�n 2
            }
            else
            {
                MessageBox.Show("La funci�n 2 no cumple con el formato esperado.");
            }

            //asdad
        }
    }
}