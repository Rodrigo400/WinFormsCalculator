﻿using System;
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
            if (b.Text == ".")
            {
                if(!result.Text.Contains("."))              // handles multiple decimals
                {
                    result.Text = result.Text + b.Text;
                }
            }
            else
                result.Text = result.Text + b.Text;
        }

        private void button17_Click(object sender, EventArgs e)
        {
            result.Text = "0";
        }

        private void operator_click(object sender, EventArgs e)
        {
            Button b = (Button)sender;

            if (value != 0)
            {
                equal.PerformClick();
                operation_pressed = true;
                operation = b.Text;
                equation.Text = value + " " + operation;
            }
            else
            {
                operation = b.Text;                 // operation being saved
                value = Double.Parse(result.Text);  // value that was in text box saved
                operation_pressed = true;           // then cleared
                equation.Text = value + " " + operation;
            }
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
            value = Int32.Parse(result.Text);
            operation = "";
        }

        private void button16_Click(object sender, EventArgs e)
        {
            result.Text = "0";
            value = 0;                  // set back to zero
            equation.Text = "";
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            switch (e.KeyChar.ToString())
            {
                case "0":
                    zero.PerformClick();
                    break;
                case "1":
                    one.PerformClick();
                    break;
                case "2":
                    two.PerformClick();
                    break;
                case "3":
                    three.PerformClick();
                    break;
                case "4":
                    four.PerformClick();
                    break;
                case "5":
                    five.PerformClick();
                    break;
                case "6":
                    six.PerformClick();
                    break;
                case "7":
                    seven.PerformClick();
                    break;
                case "8":
                    eight.PerformClick();
                    break;
                case "9":
                    nine.PerformClick();
                    break;
                case "+":
                    add.PerformClick();
                    break;
                case "-":
                    sub.PerformClick();
                    break;
                case "*":
                    times.PerformClick();
                    break;
                case "/":
                    div.PerformClick();
                    break;
                case ".":
                    dec.PerformClick();
                    break;
                case "ENTER":
                    equal.PerformClick();
                    break;
                default:
                    break;
            }
        }
    }
}
