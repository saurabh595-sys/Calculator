using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        double number1, number2, add, sub, mult, div;
        string n1, n2;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            number1 = Convert.ToDouble(text1.Text);
            number2 = Convert.ToDouble(text2.Text);
            
            
            
            add = number1 + number2;
            sub = number1 - number2;
            div = number1 / number2;
            mult = number1 * number2;
            textADD.Text = add.ToString();
            textSUB.Text = sub.ToString();
            textMULT.Text = mult.ToString();
            textDiv.Text = mult.ToString();
        }
    }
}
