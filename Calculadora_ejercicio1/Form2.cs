using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora_ejercicio1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Suma_Click(object sender, EventArgs e)
        {
            int num1 = int.Parse(TextBB1.Text); 
            int num2 = int.Parse(TextBB2.Text);
            int suma = num1 + num2; 
            MessageBox.Show("El resultado de la suma es" + suma); 
        }

        private void Producto_Click(object sender, EventArgs e)
        {
            int num1 = int.Parse(TextBB1.Text); 
            int num2 = int.Parse(TextBB2.Text); 
            int producto = num1 * num2; 
            MessageBox.Show("El resultado del producto es" + producto);
        }

        private void Division_Click(object sender, EventArgs e)
        {
            float num1 = float.Parse(TextBB1.Text);
            float num2 = float.Parse(TextBB2.Text); 
            if (num2 > 0)  
            { 
                float division = num1 / num2; 
                MessageBox.Show("el resultado es" + division);  
            } 
            else
            { 
                MessageBox.Show("La division es indefinida");  
            }
        }

        private void Factorial_Click(object sender, EventArgs e)
        {
            int num1 = int.Parse(TextBB1.Text);
            int num2 = 1; 
            for (int num3 = 1; num3 <= num1; num3++)  

            
                {
                    num2 = num2 * num3; 
                }
                MessageBox.Show("El resultado del factorial es" + num2);


        }

        private void Potencia_Click(object sender, EventArgs e)
        {
            int num1 = int.Parse(TextBB1.Text);
            int num2 = int.Parse(TextBB2.Text);
            int Potencia = (int)Math.Pow(num1, num2 );
            MessageBox.Show("El resultado de la suma es " + Potencia)
                ;
            


        }
    }
}
