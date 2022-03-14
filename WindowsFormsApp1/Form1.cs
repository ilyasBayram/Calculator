using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int sayı1;
            int sayı2;
            int toplam;
            int a, b, sonuç;

            sayı1 = Convert.ToInt32(textBox1.Text);
            sayı2 = Convert.ToInt32(textBox2.Text);
            toplam = sayı1 + sayı2;
            label4.Text = toplam.ToString();

            a = Convert.ToInt32(textBox4.Text);
            b = Convert.ToInt32(textBox3.Text);
            sonuç = a * b;
            label9.Text = sonuç.ToString();

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
