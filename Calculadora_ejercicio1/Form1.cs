using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora_ejercicio1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Textusuario.Text == "5toPCB" && TextClave.Text == "Ejercicio1") 
            {
                this.Hide();
                Form2 app = new Form2();
                app.Show();
            }
            MessageBox.Show("intente de nuevo");
        }
    }
}
