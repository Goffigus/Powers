using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Powers
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string numS1 = textBox1.Text;
            string numS2 = textBox2.Text;

            
            double num1;
            double num2;

            bool check1 = Double.TryParse(numS1, out num1); // is the number an int
            bool check2 = Double.TryParse(numS2, out num2);

            if( check1 || check2)
            {
                if (check1)
                {
                    if (check2)
                    {
                        double solution = Math.Pow(num1, num2);
                        result.Text = Convert.ToString(solution);
                    }
                    else
                    {
                        result.Text = "please use a number in the 2nd box";
                    }

                }
                else
                {
                    result.Text = "please use a number in the first box";
                }
            }
            else
            {
                result.Text = "you have to use numbers";
            }
            
        }
    }
}
