using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForms_Calculator
{
    public partial class Form1 : Form
    {
        Double value = 0;                       // decimal place
        String operation = "";                  // capture arithmetic operation
        bool operation_pressed = false;         

        public Form1()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, EventArgs e)
        {
            if ((result.Text == "0") || (operation_pressed))             // will get rid of zero at first
                result.Clear();

            operation_pressed = false;
            Button b = (Button)sender;          // object sender converted to button
            result.Text = result.Text + b.Text;
        }

        private void button17_Click(object sender, EventArgs e)
        {
            result.Text = "0";
        }

        private void operator_click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            operation = b.Text;                 // operation being saved
            value = Double.Parse(result.Text);  // value that was in text box saved
            operation_pressed = true;           // then cleared
            equation.Text = value + " " + operation;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            
            equation.Text = "";                 // clear when pressed equals
            switch(operation)
            {
                case "+":
                    result.Text = (value + Double.Parse(result.Text)).ToString();
                    break;
                case "-":
                    result.Text = (value - Double.Parse(result.Text)).ToString();
                    break;
                case "*":
                    result.Text = (value * Double.Parse(result.Text)).ToString();
                    break;
                case "/":
                    result.Text = (value / Double.Parse(result.Text)).ToString();
                    break;
                default:
                    break;
            }//end of switch
            
        }

        private void button16_Click(object sender, EventArgs e)
        {
            result.Text = "0";
            value = 0;                  // set back to zero
        }
    }
}
