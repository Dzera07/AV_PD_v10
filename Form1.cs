using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AV_PD_v10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            cena_1.Maximum = 9999;
            cena_2.Maximum = 9999;
            cena_3.Maximum = 9999;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void numericUpDown3_ValueChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown4_ValueChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           int prece1 = Convert.ToInt32(prece_1.Text);
           int prece2 = Convert.ToInt32(prece_2.Text);
           int prece3 = Convert.ToInt32(prece_3.Text);
           
           int cena1  =Convert.ToInt32(cena_1.Value);
           int cena2 = Convert.ToInt32(cena_2.Value);
           int cena3 = Convert.ToInt32(cena_3.Value);

           int kopeja_cena = (prece1 * cena1) + (prece2 * cena2) + (prece3 * cena3);

            summa.Text = kopeja_cena.ToString();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
