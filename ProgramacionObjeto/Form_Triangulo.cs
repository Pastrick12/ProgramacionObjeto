using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace ProgramacionObjeto
{
    public partial class Form_Triangulo : Form
    {
        public Form_Triangulo()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void Calcular_Click(object sender, EventArgs e)
        {
            // MessageBox.Show("Caguamon Miller");
            // MessageBox.Show(textBox1.Text + textBox2.Text);
            try 
            {
                int lado1 = Convert.ToInt32(textBox1.Text);
                int lado2 = Convert.ToInt32(textBox2.Text);
                int lado3 = Convert.ToInt32(textBox3.Text);
                MessageBox.Show((lado1 + lado2 + lado3).ToString(), "Este es el titulo de la ventana");
            } catch(Exception Error) { MessageBox.Show("Error","Errorcito", MessageBoxButtons.OK , MessageBoxIcon.Warning);
            }
            

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form_Triangulo_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
