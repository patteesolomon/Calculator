namespace Calculator
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
            this.label1 = new System.Windows.Forms.Label();
            this.Mod = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Div = new System.Windows.Forms.Button();
            this.Mul = new System.Windows.Forms.Button();
            this.plus = new System.Windows.Forms.Button();
            this.MemA = new System.Windows.Forms.Button();
            this.Minus = new System.Windows.Forms.Button();
            this.seven = new System.Windows.Forms.Button();
            this.enter = new System.Windows.Forms.Button();
            this.eight = new System.Windows.Forms.Button();
            this.nine = new System.Windows.Forms.Button();
            this.four = new System.Windows.Forms.Button();
            this.five = new System.Windows.Forms.Button();
            this.six = new System.Windows.Forms.Button();
            this.two = new System.Windows.Forms.Button();
            this.three = new System.Windows.Forms.Button();
            this.one = new System.Windows.Forms.Button();
            this.XOR = new System.Windows.Forms.Button();
            this.ClearEntry = new System.Windows.Forms.Button();
            this.Clear = new System.Windows.Forms.Button();
            this.ReMem = new System.Windows.Forms.Button();
            this.zero = new System.Windows.Forms.Button();
            this.Sqrt = new System.Windows.Forms.Button();
            this.Abs = new System.Windows.Forms.Button();
            this.equation = new System.Windows.Forms.Label();
            this.decima = new System.Windows.Forms.Button();
            this.EXP = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(96, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bootleg Calculator++";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Mod
            // 
            this.Mod.Location = new System.Drawing.Point(115, 221);
            this.Mod.Name = "Mod";
            this.Mod.Size = new System.Drawing.Size(47, 47);
            this.Mod.TabIndex = 1;
            this.Mod.Text = "%";
            this.Mod.UseVisualStyleBackColor = true;
            this.Mod.Click += new System.EventHandler(this.Operator_click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(29, 118);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(286, 22);
            this.textBox1.TabIndex = 2;
            // 
            // Div
            // 
            this.Div.Location = new System.Drawing.Point(168, 222);
            this.Div.Name = "Div";
            this.Div.Size = new System.Drawing.Size(47, 47);
            this.Div.TabIndex = 3;
            this.Div.Text = "/";
            this.Div.UseVisualStyleBackColor = true;
            this.Div.Click += new System.EventHandler(this.Operator_click);
            // 
            // Mul
            // 
            this.Mul.Location = new System.Drawing.Point(221, 221);
            this.Mul.Name = "Mul";
            this.Mul.Size = new System.Drawing.Size(48, 47);
            this.Mul.TabIndex = 4;
            this.Mul.Text = "*";
            this.Mul.UseVisualStyleBackColor = true;
            this.Mul.Click += new System.EventHandler(this.Operator_click);
            // 
            // plus
            // 
            this.plus.Location = new System.Drawing.Point(274, 272);
            this.plus.Name = "plus";
            this.plus.Size = new System.Drawing.Size(52, 84);
            this.plus.TabIndex = 5;
            this.plus.Text = "+";
            this.plus.UseVisualStyleBackColor = true;
            this.plus.Click += new System.EventHandler(this.Operator_click);
            // 
            // MemA
            // 
            this.MemA.Location = new System.Drawing.Point(115, 169);
            this.MemA.Name = "MemA";
            this.MemA.Size = new System.Drawing.Size(47, 47);
            this.MemA.TabIndex = 6;
            this.MemA.Text = "+M";
            this.MemA.UseVisualStyleBackColor = true;
            this.MemA.Click += new System.EventHandler(this.Button5_Click);
            // 
            // Minus
            // 
            this.Minus.Location = new System.Drawing.Point(62, 222);
            this.Minus.Name = "Minus";
            this.Minus.Size = new System.Drawing.Size(47, 47);
            this.Minus.TabIndex = 7;
            this.Minus.Text = "-";
            this.Minus.UseVisualStyleBackColor = true;
            this.Minus.Click += new System.EventHandler(this.Operator_click);
            // 
            // seven
            // 
            this.seven.Location = new System.Drawing.Point(115, 274);
            this.seven.Name = "seven";
            this.seven.Size = new System.Drawing.Size(47, 53);
            this.seven.TabIndex = 8;
            this.seven.Text = "7";
            this.seven.UseVisualStyleBackColor = true;
            this.seven.Click += new System.EventHandler(this.Button_Click);
            // 
            // enter
            // 
            this.enter.Location = new System.Drawing.Point(274, 373);
            this.enter.Name = "enter";
            this.enter.Size = new System.Drawing.Size(52, 59);
            this.enter.TabIndex = 9;
            this.enter.Text = "enter";
            this.enter.UseVisualStyleBackColor = true;
            this.enter.Click += new System.EventHandler(this.Button8_Click);
            // 
            // eight
            // 
            this.eight.Location = new System.Drawing.Point(168, 274);
            this.eight.Name = "eight";
            this.eight.Size = new System.Drawing.Size(47, 53);
            this.eight.TabIndex = 10;
            this.eight.Text = "8";
            this.eight.UseVisualStyleBackColor = true;
            this.eight.Click += new System.EventHandler(this.Button_Click);
            // 
            // nine
            // 
            this.nine.Location = new System.Drawing.Point(221, 274);
            this.nine.Name = "nine";
            this.nine.Size = new System.Drawing.Size(47, 53);
            this.nine.TabIndex = 11;
            this.nine.Text = "9";
            this.nine.UseVisualStyleBackColor = true;
            this.nine.Click += new System.EventHandler(this.Button_Click);
            // 
            // four
            // 
            this.four.Location = new System.Drawing.Point(115, 333);
            this.four.Name = "four";
            this.four.Size = new System.Drawing.Size(47, 46);
            this.four.TabIndex = 12;
            this.four.Text = "4";
            this.four.UseVisualStyleBackColor = true;
            this.four.Click += new System.EventHandler(this.Button_Click);
            // 
            // five
            // 
            this.five.Location = new System.Drawing.Point(168, 333);
            this.five.Name = "five";
            this.five.Size = new System.Drawing.Size(47, 46);
            this.five.TabIndex = 13;
            this.five.Text = "5";
            this.five.UseVisualStyleBackColor = true;
            this.five.Click += new System.EventHandler(this.Button_Click);
            // 
            // six
            // 
            this.six.Location = new System.Drawing.Point(221, 333);
            this.six.Name = "six";
            this.six.Size = new System.Drawing.Size(47, 46);
            this.six.TabIndex = 14;
            this.six.Text = "6";
            this.six.UseVisualStyleBackColor = true;
            this.six.Click += new System.EventHandler(this.Button_Click);
            // 
            // two
            // 
            this.two.Location = new System.Drawing.Point(168, 389);
            this.two.Name = "two";
            this.two.Size = new System.Drawing.Size(47, 44);
            this.two.TabIndex = 15;
            this.two.Text = "2";
            this.two.UseVisualStyleBackColor = true;
            this.two.Click += new System.EventHandler(this.Button_Click);
            // 
            // three
            // 
            this.three.Location = new System.Drawing.Point(221, 389);
            this.three.Name = "three";
            this.three.Size = new System.Drawing.Size(47, 44);
            this.three.TabIndex = 16;
            this.three.Text = "3";
            this.three.UseVisualStyleBackColor = true;
            this.three.Click += new System.EventHandler(this.Button_Click);
            // 
            // one
            // 
            this.one.Location = new System.Drawing.Point(115, 389);
            this.one.Name = "one";
            this.one.Size = new System.Drawing.Size(47, 43);
            this.one.TabIndex = 17;
            this.one.Text = "1";
            this.one.UseVisualStyleBackColor = true;
            this.one.Click += new System.EventHandler(this.Button_Click);
            // 
            // XOR
            // 
            this.XOR.Location = new System.Drawing.Point(62, 169);
            this.XOR.Name = "XOR";
            this.XOR.Size = new System.Drawing.Size(47, 47);
            this.XOR.TabIndex = 18;
            this.XOR.Text = "^";
            this.XOR.UseVisualStyleBackColor = true;
            this.XOR.Click += new System.EventHandler(this.Operator_click);
            // 
            // ClearEntry
            // 
            this.ClearEntry.Location = new System.Drawing.Point(274, 169);
            this.ClearEntry.Name = "ClearEntry";
            this.ClearEntry.Size = new System.Drawing.Size(52, 47);
            this.ClearEntry.TabIndex = 19;
            this.ClearEntry.Text = "CE";
            this.ClearEntry.UseVisualStyleBackColor = true;
            this.ClearEntry.Click += new System.EventHandler(this.Button18_Click);
            // 
            // Clear
            // 
            this.Clear.Location = new System.Drawing.Point(220, 169);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(48, 47);
            this.Clear.TabIndex = 20;
            this.Clear.Text = "C";
            this.Clear.UseVisualStyleBackColor = true;
            this.Clear.Click += new System.EventHandler(this.Button19_Click);
            // 
            // ReMem
            // 
            this.ReMem.Location = new System.Drawing.Point(168, 169);
            this.ReMem.Name = "ReMem";
            this.ReMem.Size = new System.Drawing.Size(47, 47);
            this.ReMem.TabIndex = 21;
            this.ReMem.Text = "M";
            this.ReMem.UseVisualStyleBackColor = true;
            this.ReMem.Click += new System.EventHandler(this.Button20_Click);
            // 
            // zero
            // 
            this.zero.Location = new System.Drawing.Point(62, 334);
            this.zero.Name = "zero";
            this.zero.Size = new System.Drawing.Size(47, 44);
            this.zero.TabIndex = 22;
            this.zero.Text = "0";
            this.zero.UseVisualStyleBackColor = true;
            this.zero.Click += new System.EventHandler(this.Button_Click);
            // 
            // Sqrt
            // 
            this.Sqrt.Location = new System.Drawing.Point(62, 274);
            this.Sqrt.Name = "Sqrt";
            this.Sqrt.Size = new System.Drawing.Size(47, 49);
            this.Sqrt.TabIndex = 23;
            this.Sqrt.Text = "sqrt";
            this.Sqrt.UseVisualStyleBackColor = true;
            this.Sqrt.Click += new System.EventHandler(this.Operator_click);
            // 
            // Abs
            // 
            this.Abs.Location = new System.Drawing.Point(274, 225);
            this.Abs.Name = "Abs";
            this.Abs.Size = new System.Drawing.Size(52, 44);
            this.Abs.TabIndex = 24;
            this.Abs.Text = "Abs";
            this.Abs.UseVisualStyleBackColor = true;
            this.Abs.Click += new System.EventHandler(this.Operator_click);
            // 
            // equation
            // 
            this.equation.AutoSize = true;
            this.equation.ForeColor = System.Drawing.Color.DimGray;
            this.equation.Location = new System.Drawing.Point(234, 118);
            this.equation.Name = "equation";
            this.equation.Size = new System.Drawing.Size(0, 16);
            this.equation.TabIndex = 25;
            // 
            // decima
            // 
            this.decima.Location = new System.Drawing.Point(62, 390);
            this.decima.Name = "decima";
            this.decima.Size = new System.Drawing.Size(47, 43);
            this.decima.TabIndex = 26;
            this.decima.Text = ".";
            this.decima.UseVisualStyleBackColor = true;
            this.decima.Click += new System.EventHandler(this.Button_Click);
            // 
            // EXP
            // 
            this.EXP.Location = new System.Drawing.Point(12, 169);
            this.EXP.Name = "EXP";
            this.EXP.Size = new System.Drawing.Size(44, 47);
            this.EXP.TabIndex = 27;
            this.EXP.Text = "nⁿ";
            this.EXP.UseVisualStyleBackColor = true;
            this.EXP.Click += new System.EventHandler(this.Operator_click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(333, 450);
            this.Controls.Add(this.EXP);
            this.Controls.Add(this.decima);
            this.Controls.Add(this.equation);
            this.Controls.Add(this.Abs);
            this.Controls.Add(this.Sqrt);
            this.Controls.Add(this.zero);
            this.Controls.Add(this.ReMem);
            this.Controls.Add(this.Clear);
            this.Controls.Add(this.ClearEntry);
            this.Controls.Add(this.XOR);
            this.Controls.Add(this.one);
            this.Controls.Add(this.three);
            this.Controls.Add(this.two);
            this.Controls.Add(this.six);
            this.Controls.Add(this.five);
            this.Controls.Add(this.four);
            this.Controls.Add(this.nine);
            this.Controls.Add(this.eight);
            this.Controls.Add(this.enter);
            this.Controls.Add(this.seven);
            this.Controls.Add(this.Minus);
            this.Controls.Add(this.MemA);
            this.Controls.Add(this.plus);
            this.Controls.Add(this.Mul);
            this.Controls.Add(this.Div);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Mod);
            this.Controls.Add(this.label1);
            this.KeyPreview = true;
            this.Name = "Form1";
            this.Text = "Form1";
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Mod;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button Div;
        private System.Windows.Forms.Button Mul;
        private System.Windows.Forms.Button plus;
        private System.Windows.Forms.Button MemA;
        private System.Windows.Forms.Button Minus;
        private System.Windows.Forms.Button seven;
        private System.Windows.Forms.Button enter;
        private System.Windows.Forms.Button eight;
        private System.Windows.Forms.Button nine;
        private System.Windows.Forms.Button four;
        private System.Windows.Forms.Button five;
        private System.Windows.Forms.Button six;
        private System.Windows.Forms.Button two;
        private System.Windows.Forms.Button three;
        private System.Windows.Forms.Button one;
        private System.Windows.Forms.Button XOR;
        private System.Windows.Forms.Button ClearEntry;
        private System.Windows.Forms.Button Clear;
        private System.Windows.Forms.Button ReMem;
        private System.Windows.Forms.Button zero;
        private System.Windows.Forms.Button Sqrt;
        private System.Windows.Forms.Button Abs;
        private System.Windows.Forms.Label equation;
        private System.Windows.Forms.Button decima;
        private System.Windows.Forms.Button EXP;
    }
}

