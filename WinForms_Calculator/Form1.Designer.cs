﻿namespace WinForms_Calculator
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.seven = new System.Windows.Forms.Button();
            this.eight = new System.Windows.Forms.Button();
            this.nine = new System.Windows.Forms.Button();
            this.div = new System.Windows.Forms.Button();
            this.four = new System.Windows.Forms.Button();
            this.five = new System.Windows.Forms.Button();
            this.six = new System.Windows.Forms.Button();
            this.times = new System.Windows.Forms.Button();
            this.one = new System.Windows.Forms.Button();
            this.two = new System.Windows.Forms.Button();
            this.three = new System.Windows.Forms.Button();
            this.zero = new System.Windows.Forms.Button();
            this.dec = new System.Windows.Forms.Button();
            this.add = new System.Windows.Forms.Button();
            this.equal = new System.Windows.Forms.Button();
            this.button16 = new System.Windows.Forms.Button();
            this.button17 = new System.Windows.Forms.Button();
            this.sub = new System.Windows.Forms.Button();
            this.result = new System.Windows.Forms.TextBox();
            this.equation = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // seven
            // 
            this.seven.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.seven.Location = new System.Drawing.Point(12, 59);
            this.seven.Name = "seven";
            this.seven.Size = new System.Drawing.Size(60, 45);
            this.seven.TabIndex = 0;
            this.seven.TabStop = false;
            this.seven.Text = "7";
            this.seven.UseVisualStyleBackColor = true;
            this.seven.Click += new System.EventHandler(this.button_Click);
            // 
            // eight
            // 
            this.eight.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eight.Location = new System.Drawing.Point(78, 59);
            this.eight.Name = "eight";
            this.eight.Size = new System.Drawing.Size(60, 45);
            this.eight.TabIndex = 1;
            this.eight.TabStop = false;
            this.eight.Text = "8";
            this.eight.UseVisualStyleBackColor = true;
            this.eight.Click += new System.EventHandler(this.button_Click);
            // 
            // nine
            // 
            this.nine.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nine.Location = new System.Drawing.Point(144, 59);
            this.nine.Name = "nine";
            this.nine.Size = new System.Drawing.Size(60, 45);
            this.nine.TabIndex = 2;
            this.nine.TabStop = false;
            this.nine.Text = "9";
            this.nine.UseVisualStyleBackColor = true;
            this.nine.Click += new System.EventHandler(this.button_Click);
            // 
            // div
            // 
            this.div.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.div.Location = new System.Drawing.Point(210, 59);
            this.div.Name = "div";
            this.div.Size = new System.Drawing.Size(60, 45);
            this.div.TabIndex = 3;
            this.div.TabStop = false;
            this.div.Text = "/";
            this.div.UseVisualStyleBackColor = true;
            this.div.Click += new System.EventHandler(this.operator_click);
            // 
            // four
            // 
            this.four.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.four.Location = new System.Drawing.Point(12, 110);
            this.four.Name = "four";
            this.four.Size = new System.Drawing.Size(60, 45);
            this.four.TabIndex = 4;
            this.four.TabStop = false;
            this.four.Text = "4";
            this.four.UseVisualStyleBackColor = true;
            this.four.Click += new System.EventHandler(this.button_Click);
            // 
            // five
            // 
            this.five.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.five.Location = new System.Drawing.Point(78, 110);
            this.five.Name = "five";
            this.five.Size = new System.Drawing.Size(60, 45);
            this.five.TabIndex = 5;
            this.five.TabStop = false;
            this.five.Text = "5";
            this.five.UseVisualStyleBackColor = true;
            this.five.Click += new System.EventHandler(this.button_Click);
            // 
            // six
            // 
            this.six.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.six.Location = new System.Drawing.Point(144, 110);
            this.six.Name = "six";
            this.six.Size = new System.Drawing.Size(60, 45);
            this.six.TabIndex = 6;
            this.six.TabStop = false;
            this.six.Text = "6";
            this.six.UseVisualStyleBackColor = true;
            this.six.Click += new System.EventHandler(this.button_Click);
            // 
            // times
            // 
            this.times.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.times.Location = new System.Drawing.Point(210, 110);
            this.times.Name = "times";
            this.times.Size = new System.Drawing.Size(60, 45);
            this.times.TabIndex = 7;
            this.times.TabStop = false;
            this.times.Text = "*";
            this.times.UseVisualStyleBackColor = true;
            this.times.Click += new System.EventHandler(this.operator_click);
            // 
            // one
            // 
            this.one.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.one.Location = new System.Drawing.Point(12, 161);
            this.one.Name = "one";
            this.one.Size = new System.Drawing.Size(60, 45);
            this.one.TabIndex = 8;
            this.one.TabStop = false;
            this.one.Text = "1";
            this.one.UseVisualStyleBackColor = true;
            this.one.Click += new System.EventHandler(this.button_Click);
            // 
            // two
            // 
            this.two.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.two.Location = new System.Drawing.Point(78, 161);
            this.two.Name = "two";
            this.two.Size = new System.Drawing.Size(60, 45);
            this.two.TabIndex = 9;
            this.two.TabStop = false;
            this.two.Text = "2";
            this.two.UseVisualStyleBackColor = true;
            this.two.Click += new System.EventHandler(this.button_Click);
            // 
            // three
            // 
            this.three.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.three.Location = new System.Drawing.Point(144, 161);
            this.three.Name = "three";
            this.three.Size = new System.Drawing.Size(60, 45);
            this.three.TabIndex = 10;
            this.three.TabStop = false;
            this.three.Text = "3";
            this.three.UseVisualStyleBackColor = true;
            this.three.Click += new System.EventHandler(this.button_Click);
            // 
            // zero
            // 
            this.zero.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.zero.Location = new System.Drawing.Point(12, 212);
            this.zero.Name = "zero";
            this.zero.Size = new System.Drawing.Size(126, 45);
            this.zero.TabIndex = 11;
            this.zero.TabStop = false;
            this.zero.Text = "0";
            this.zero.UseVisualStyleBackColor = true;
            this.zero.Click += new System.EventHandler(this.button_Click);
            // 
            // dec
            // 
            this.dec.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dec.Location = new System.Drawing.Point(144, 212);
            this.dec.Name = "dec";
            this.dec.Size = new System.Drawing.Size(60, 45);
            this.dec.TabIndex = 12;
            this.dec.TabStop = false;
            this.dec.Text = ".";
            this.dec.UseVisualStyleBackColor = true;
            this.dec.Click += new System.EventHandler(this.button_Click);
            // 
            // add
            // 
            this.add.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add.Location = new System.Drawing.Point(210, 212);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(60, 45);
            this.add.TabIndex = 13;
            this.add.TabStop = false;
            this.add.Text = "+";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.operator_click);
            // 
            // equal
            // 
            this.equal.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.equal.Location = new System.Drawing.Point(276, 161);
            this.equal.Name = "equal";
            this.equal.Size = new System.Drawing.Size(60, 96);
            this.equal.TabIndex = 14;
            this.equal.Text = "=";
            this.equal.UseVisualStyleBackColor = true;
            this.equal.Click += new System.EventHandler(this.button15_Click);
            // 
            // button16
            // 
            this.button16.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button16.Location = new System.Drawing.Point(276, 110);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(60, 45);
            this.button16.TabIndex = 15;
            this.button16.TabStop = false;
            this.button16.Text = "C";
            this.button16.UseVisualStyleBackColor = true;
            this.button16.Click += new System.EventHandler(this.button16_Click);
            // 
            // button17
            // 
            this.button17.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button17.Location = new System.Drawing.Point(276, 59);
            this.button17.Name = "button17";
            this.button17.Size = new System.Drawing.Size(60, 45);
            this.button17.TabIndex = 16;
            this.button17.TabStop = false;
            this.button17.Text = "CE";
            this.button17.UseVisualStyleBackColor = true;
            this.button17.Click += new System.EventHandler(this.button17_Click);
            // 
            // sub
            // 
            this.sub.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sub.Location = new System.Drawing.Point(210, 161);
            this.sub.Name = "sub";
            this.sub.Size = new System.Drawing.Size(60, 45);
            this.sub.TabIndex = 17;
            this.sub.TabStop = false;
            this.sub.Text = "-";
            this.sub.UseVisualStyleBackColor = true;
            this.sub.Click += new System.EventHandler(this.operator_click);
            // 
            // result
            // 
            this.result.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.result.Location = new System.Drawing.Point(12, 15);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(324, 38);
            this.result.TabIndex = 18;
            this.result.TabStop = false;
            this.result.Text = "0";
            this.result.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // equation
            // 
            this.equation.AutoSize = true;
            this.equation.BackColor = System.Drawing.SystemColors.Window;
            this.equation.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.equation.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.equation.Location = new System.Drawing.Point(15, 17);
            this.equation.Name = "equation";
            this.equation.Size = new System.Drawing.Size(0, 29);
            this.equation.TabIndex = 19;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(350, 270);
            this.Controls.Add(this.equation);
            this.Controls.Add(this.result);
            this.Controls.Add(this.sub);
            this.Controls.Add(this.button17);
            this.Controls.Add(this.button16);
            this.Controls.Add(this.equal);
            this.Controls.Add(this.add);
            this.Controls.Add(this.dec);
            this.Controls.Add(this.zero);
            this.Controls.Add(this.three);
            this.Controls.Add(this.two);
            this.Controls.Add(this.one);
            this.Controls.Add(this.times);
            this.Controls.Add(this.six);
            this.Controls.Add(this.five);
            this.Controls.Add(this.four);
            this.Controls.Add(this.div);
            this.Controls.Add(this.nine);
            this.Controls.Add(this.eight);
            this.Controls.Add(this.seven);
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(368, 317);
            this.MinimumSize = new System.Drawing.Size(368, 317);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculator";
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button seven;
        private System.Windows.Forms.Button eight;
        private System.Windows.Forms.Button nine;
        private System.Windows.Forms.Button div;
        private System.Windows.Forms.Button four;
        private System.Windows.Forms.Button five;
        private System.Windows.Forms.Button six;
        private System.Windows.Forms.Button times;
        private System.Windows.Forms.Button one;
        private System.Windows.Forms.Button two;
        private System.Windows.Forms.Button three;
        private System.Windows.Forms.Button zero;
        private System.Windows.Forms.Button dec;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Button equal;
        private System.Windows.Forms.Button button16;
        private System.Windows.Forms.Button button17;
        private System.Windows.Forms.Button sub;
        private System.Windows.Forms.TextBox result;
        private System.Windows.Forms.Label equation;
    }
}

