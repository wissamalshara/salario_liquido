using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace salario_liquido
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double horas_tra, valor_hora, salario_bruto;
            horas_tra = Convert.ToDouble(textBox1.Text);
            valor_hora = Convert.ToDouble(textBox4.Text);
            salario_bruto = horas_tra * valor_hora;

            label4.Text = "Salário bruto: " + salario_bruto.ToString();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            double horas_tra, valor_hora, salario_bruto, totdisc;
            int disc;
            horas_tra = Convert.ToDouble(textBox1.Text);
            valor_hora = Convert.ToDouble(textBox4.Text);
            disc = Convert.ToInt32(textBox2.Text);
            salario_bruto = horas_tra * valor_hora;
            totdisc = 
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}
