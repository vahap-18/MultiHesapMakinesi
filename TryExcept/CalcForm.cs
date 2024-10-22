using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TryExcept
{
    public partial class TryExceptForm : Form
    {
        public TryExceptForm()
        {
            InitializeComponent();
        }

      
        private void btnCalculation_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(tbNumber1.Text) && !string.IsNullOrEmpty(tbNumber2.Text))
                {
                    int number1 = Convert.ToInt32(tbNumber1.Text);
                    int number2 = Convert.ToInt32(tbNumber2.Text);
                    
                    switch (lblCalc.Text)
                    {
                        case "+":
                            tbAnswer.Text = Convert.ToString(number1 + number2);
                            break;
                        case "-":
                            tbAnswer.Text = Convert.ToString(number1 - number2);
                            break;
                        case "*":
                            tbAnswer.Text = Convert.ToString(number1 * number2);
                            break;
                        case "/":
                            if (number2 != 0)
                                tbAnswer.Text = Convert.ToString((int)number1 / (int)number2);
                            else
                                throw new DivideByZeroException("Sıfıya bölünemez!");
                            break;
                        case "^":
                            tbAnswer.Text = Math.Pow((int)number1, (int)number2).ToString();
                            break;
                    }
                }
                else
                {
                    MessageBox.Show("Tüm alanları doldurun.");
                }
            }
           
            catch (DivideByZeroException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void rbSummation_CheckedChanged(object sender, EventArgs e)
        {
            if (rbSummation.Checked == true)
                lblCalc.Text = "+";
           
        }

        private void rbDifference_CheckedChanged(object sender, EventArgs e)
        {
              if (rbDifference.Checked == true)
                lblCalc.Text = "-";
        }

        private void rbMultiplication_CheckedChanged(object sender, EventArgs e)
        {
              if (rbMultiplication.Checked == true)
                lblCalc.Text = "*";
        }

        private void rbDivision_CheckedChanged(object sender, EventArgs e)
        {
            if (rbDivision.Checked == true)
                lblCalc.Text = "/";
        }
       
        private void rbExponentiation_CheckedChanged_1(object sender, EventArgs e)
        {
            if (rbExponentiation.Checked == true)
                lblCalc.Text = "^";
        }
    }
}
