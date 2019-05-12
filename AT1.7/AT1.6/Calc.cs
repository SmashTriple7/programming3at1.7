using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// Author : Jonah Cummins P458162
// Date : 9/5/19

namespace Calc
{
    public partial class Calculator : Form
    {
        public Calculator()
        {
            InitializeComponent();
        }

        // Inputs a 0 into the calculator
        private void btn0_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + btn0.Text;
        }

        // Inputs a 1 into the calculator
        private void btn1_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + btn1.Text;
        }

        // Inputs a 2 into the calculator
        private void btn2_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + btn2.Text;
        }

        // Inputs a 3 into the calculator
        private void btn3_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + btn3.Text;
        }

        // Inputs a 4 into the calculator
        private void btn4_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + btn4.Text;
        }

        // Inputs a 5 into the calculator
        private void btn5_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + btn5.Text;
        }

        // Inputs a 6 into the calculator
        private void btn6_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + btn6.Text;
        }

        // Inputs a 7 into the calculator
        private void btn7_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + btn7.Text;
        }

        // Inputs a 8 into the calculator
        private void btn8_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + btn8.Text;
        }

        // Inputs a 9 into the calculator
        private void btn9_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + btn9.Text;
        }

        // Inputs a negative sign into the calculator
        private void btnNegative_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + "-";
        }

        // Inputs a decial place into the calculator
        private void btnDot_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + btnDot.Text;
        }

        // Clears the claculator display
        private void btnClear_Click(object sender, EventArgs e)
        {
            txtDisplay.Clear();
        }

        // Varibles that stores results
        public double tempResult = 0;   
        public double finalResult = 0;

        // Booleanss that tracks + - / * button clicks
        public bool plusClicked = false;
        public bool minusClicked = false;
        public bool divideClicked = false;
        public bool mutiplyClicked = false;

        // Addition Button
        private void btnAdd_Click(object sender, EventArgs e)
        {
            // Ensures the text display is not invalid
            if (!String.IsNullOrEmpty(txtDisplay.Text) && txtDisplay.Text != ".")
            {
                // Puts the text display into ther temp result
                // Ensures the correct boolean is true
                tempResult += double.Parse(txtDisplay.Text);
                txtDisplay.Clear();

                plusClicked = true;
                minusClicked = false;
                divideClicked = false;
                mutiplyClicked = false;
            }         
        }

        // Subtract Button
        private void btnMinus_Click(object sender, EventArgs e)
        {
            // Ensures the text display is not invalid
            if (!String.IsNullOrEmpty(txtDisplay.Text) && txtDisplay.Text != ".")
            {
                // Puts the text display into ther temp result
                // Ensures the correct boolean is true
                tempResult += double.Parse(txtDisplay.Text);
                txtDisplay.Clear();

                plusClicked = false;
                minusClicked = true;
                divideClicked = false;
                mutiplyClicked = false;
            }  
        }

        // Divide Button
        private void btnDivide_Click(object sender, EventArgs e)
        {
            // Ensures the text display is not invalid
            if (!String.IsNullOrEmpty(txtDisplay.Text) && txtDisplay.Text != ".")
            {
                // Puts the text display into ther temp result
                // Ensures the correct boolean is true
                tempResult += double.Parse(txtDisplay.Text);
                txtDisplay.Clear();

                plusClicked = false;
                minusClicked = false;
                divideClicked = true;
                mutiplyClicked = false;
            } 
        }

        // Mutiply Button
        private void btnTimes_Click(object sender, EventArgs e)
        {
            // Ensures the text display is not invalid
            if (!String.IsNullOrEmpty(txtDisplay.Text) && txtDisplay.Text != ".")
            {
                // Puts the text display into ther temp result
                // Ensures the correct boolean is true
                tempResult += double.Parse(txtDisplay.Text);
                txtDisplay.Clear();

                plusClicked = false;
                minusClicked = false;
                divideClicked = false;
                mutiplyClicked = true;
            }  
        }

        // Square Root Button
        private void btnSRoot_Click(object sender, EventArgs e)
        {
            // Ensures the text display is not invalid
            if (!String.IsNullOrEmpty(txtDisplay.Text))
            {
                txtDisplay.Text = Convert.ToString(Algebraic.Algebraic.SquareRoot(double.Parse(txtDisplay.Text)));
            }
            else
            {
                MessageBox.Show("Invalid", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Cube Root Button
        private void btnCRoot_Click(object sender, EventArgs e)
        {
            // Ensures the text display is not invalid
            if (!String.IsNullOrEmpty(txtDisplay.Text))
            {
                txtDisplay.Text = Convert.ToString(Algebraic.Algebraic.CubeRoot(double.Parse(txtDisplay.Text)));
            }
            else
            {
                MessageBox.Show("Invalid", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Inverse Button
        private void btnInv_Click(object sender, EventArgs e)
        {
            // Ensures the text display is not invalid
            if (!String.IsNullOrEmpty(txtDisplay.Text))
            {
                txtDisplay.Text = Convert.ToString(Algebraic.Algebraic.Inverse(double.Parse(txtDisplay.Text)));
            }
            else
            {
                MessageBox.Show("Invalid", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Tan Button
        private void btnTan_Click(object sender, EventArgs e)
        {
            // Ensures the text display is not invalid
            if (!String.IsNullOrEmpty(txtDisplay.Text) && double.Parse(txtDisplay.Text) < 90 && double.Parse(txtDisplay.Text) >= 0)
            {
                txtDisplay.Text = Convert.ToString(Trigonometric.Trigonometric.Tan(double.Parse(txtDisplay.Text)));
            }
            else
            {
                MessageBox.Show("Invalid", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Sin Button
        private void btnSin_Click(object sender, EventArgs e)
        {
            // Ensures the text display is not invalid
            if (!String.IsNullOrEmpty(txtDisplay.Text) && double.Parse(txtDisplay.Text) <= 360 && double.Parse(txtDisplay.Text) >= 0)
            {
                txtDisplay.Text = Convert.ToString(Trigonometric.Trigonometric.Sin(double.Parse(txtDisplay.Text)));
            }
            else
            {
                MessageBox.Show("Invalid", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Cos Button
        private void btnCos_Click(object sender, EventArgs e)
        {
            // Ensures the text display is not invalid
            if (!String.IsNullOrEmpty(txtDisplay.Text) && double.Parse(txtDisplay.Text) <= 360 && double.Parse(txtDisplay.Text) >= 0)
            {
                txtDisplay.Text = Convert.ToString(Trigonometric.Trigonometric.Cos(double.Parse(txtDisplay.Text)));
            }
            else
            {
                MessageBox.Show("Invalid", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Equals Button
        private void btnEquals_Click(object sender, EventArgs e)
        {
            if (plusClicked)
            {
                finalResult = Arithmetic.Arithmetic.Add(tempResult, double.Parse(txtDisplay.Text));
            }
            else if (minusClicked)
            {
                finalResult = Arithmetic.Arithmetic.Sub(tempResult, double.Parse(txtDisplay.Text));
            }
            else if (mutiplyClicked)
            {
                finalResult = Arithmetic.Arithmetic.Mult(tempResult, double.Parse(txtDisplay.Text));
            }
            else if (divideClicked)
            {
                finalResult = Arithmetic.Arithmetic.Div(tempResult, double.Parse(txtDisplay.Text));
            }
            txtDisplay.Text = finalResult.ToString();
            tempResult = 0;
        }
    }
}
