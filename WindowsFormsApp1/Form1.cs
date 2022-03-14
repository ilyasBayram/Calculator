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
            #region Variables
            int number1;
            int number2;
            int sum;
            int a, b, result;
            #endregion

            #region Sum block
            number1 = Convert.ToInt32(textBox1.Text);
            number2 = Convert.ToInt32(textBox2.Text);
            sum = number1 + number2;
            label4.Text = sum.ToString();
            #endregion

            #region Multiple block
            a = Convert.ToInt32(textBox4.Text);
            b = Convert.ToInt32(textBox3.Text);
            result = a * b;
            label9.Text = result.ToString();

            #endregion
        }

    }
}
