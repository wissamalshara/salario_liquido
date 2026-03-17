using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
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
            double ht, vh, sb;
            ht = Convert.ToDouble(textBox1.Text);
            vh = Convert.ToDouble(textBox4.Text);
            sb = ht * vh;

            label4.Text = "Salário bruto: " + sb.ToString();
           

        }

        private void button2_Click(object sender, EventArgs e)
        {
            double ht, vh, sb, td, pd;
            
            ht = Convert.ToDouble(textBox1.Text);
            vh = Convert.ToDouble(textBox4.Text);
            pd = Convert.ToDouble(textBox2.Text);
            sb = ht * vh;
            td = (pd / 100) * sb;


            label5.Text = "Total de desconto: " + $"{td:0.00}" + td.ToString();
            


        }

        private void button3_Click(object sender, EventArgs e)
        {
            double ht, vh, sb, td, pd, sl;

            ht = Convert.ToDouble(textBox1.Text);
            vh = Convert.ToDouble(textBox4.Text);
            pd = Convert.ToDouble(textBox2.Text);
            sb = ht * vh;
            td = (pd / 100) * sb;
            sl = sb - td;

            label6.Text = "Salário líquido: " + sl.ToString();
            

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
