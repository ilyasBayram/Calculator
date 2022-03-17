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

        #region Variables
        int firstNumber, secondNumber;
        int thirdnumber, fourthNumber, result;
        int sum;
        #endregion

        #region sum
        //In this method two number entered by user added and the result is
        //written to label 4
        public void sumofNumbers()
        {
            firstNumber = Convert.ToInt32(textBox1.Text);
            secondNumber = Convert.ToInt32(textBox2.Text);
            sum = firstNumber + secondNumber;
            label4.Text = sum.ToString();
        }
        #endregion

        #region multiply
        //In this method two numbers entered by user multiply and the result is 
        //written to label 9
        public void multiplyofNumbers()
        {
            thirdnumber = Convert.ToInt32(textBox4.Text);
            fourthNumber = Convert.ToInt32(textBox3.Text);
            result = thirdnumber * fourthNumber;
            label9.Text = result.ToString();
        }
        #endregion

        private void button1_Click(object sender, EventArgs e)
        {
        // when button is clicked by user two methods are called
            sumofNumbers();
            multiplyofNumbers();
        }

    }
}
