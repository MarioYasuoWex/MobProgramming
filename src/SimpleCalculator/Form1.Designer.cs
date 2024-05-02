namespace SimpleCalculator
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            button9 = new Button();
            button0 = new Button();
            btn_sum = new Button();
            btn_sub = new Button();
            btn_div = new Button();
            btn_mult = new Button();
            btn_equal = new Button();
            btn_clear = new Button();
            display = new TextBox();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(140, 138);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 0;
            button1.Text = "1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(255, 138);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 1;
            button2.Text = "2";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(364, 138);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 2;
            button3.Text = "3";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(140, 180);
            button4.Name = "button4";
            button4.Size = new Size(75, 23);
            button4.TabIndex = 3;
            button4.Text = "4";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Location = new Point(255, 180);
            button5.Name = "button5";
            button5.Size = new Size(75, 23);
            button5.TabIndex = 4;
            button5.Text = "5";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.Location = new Point(255, 231);
            button6.Name = "button6";
            button6.Size = new Size(75, 23);
            button6.TabIndex = 5;
            button6.Text = "6";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // button7
            // 
            button7.Location = new Point(140, 231);
            button7.Name = "button7";
            button7.Size = new Size(75, 23);
            button7.TabIndex = 6;
            button7.Text = "7";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // button8
            // 
            button8.Location = new Point(364, 180);
            button8.Name = "button8";
            button8.Size = new Size(75, 23);
            button8.TabIndex = 7;
            button8.Text = "8";
            button8.UseVisualStyleBackColor = true;
            button8.Click += button8_Click;
            // 
            // button9
            // 
            button9.Location = new Point(364, 231);
            button9.Name = "button9";
            button9.Size = new Size(75, 23);
            button9.TabIndex = 8;
            button9.Text = "9";
            button9.UseVisualStyleBackColor = true;
            button9.Click += button9_Click;
            // 
            // button0
            // 
            button0.Location = new Point(255, 276);
            button0.Name = "button0";
            button0.Size = new Size(75, 23);
            button0.TabIndex = 9;
            button0.Text = "0";
            button0.UseVisualStyleBackColor = true;
            button0.Click += button0_Click;
            // 
            // btn_sum
            // 
            btn_sum.Location = new Point(478, 138);
            btn_sum.Name = "btn_sum";
            btn_sum.Size = new Size(75, 23);
            btn_sum.TabIndex = 10;
            btn_sum.Text = "+";
            btn_sum.UseVisualStyleBackColor = true;
            btn_sum.Click += btn_sum_Click;
            // 
            // btn_sub
            // 
            btn_sub.Location = new Point(478, 180);
            btn_sub.Name = "btn_sub";
            btn_sub.Size = new Size(75, 23);
            btn_sub.TabIndex = 11;
            btn_sub.Text = "-";
            btn_sub.UseVisualStyleBackColor = true;
            btn_sub.Click += btn_sub_Click;
            // 
            // btn_div
            // 
            btn_div.Location = new Point(478, 231);
            btn_div.Name = "btn_div";
            btn_div.Size = new Size(75, 23);
            btn_div.TabIndex = 12;
            btn_div.Text = "/";
            btn_div.UseVisualStyleBackColor = true;
            btn_div.Click += btn_div_Click;
            // 
            // btn_mult
            // 
            btn_mult.Location = new Point(478, 276);
            btn_mult.Name = "btn_mult";
            btn_mult.Size = new Size(75, 23);
            btn_mult.TabIndex = 13;
            btn_mult.Text = "*";
            btn_mult.UseVisualStyleBackColor = true;
            btn_mult.Click += btn_mult_Click;
            // 
            // btn_equal
            // 
            btn_equal.Location = new Point(364, 276);
            btn_equal.Name = "btn_equal";
            btn_equal.Size = new Size(75, 23);
            btn_equal.TabIndex = 14;
            btn_equal.Text = "=";
            btn_equal.UseVisualStyleBackColor = true;
            btn_equal.Click += btn_equal_Click;
            // 
            // btn_clear
            // 
            btn_clear.Location = new Point(140, 91);
            btn_clear.Name = "btn_clear";
            btn_clear.Size = new Size(75, 23);
            btn_clear.TabIndex = 15;
            btn_clear.Text = "clear";
            btn_clear.UseVisualStyleBackColor = true;
            btn_clear.Click += btn_clear_Click;
            // 
            // display
            // 
            display.Enabled = false;
            display.Location = new Point(140, 52);
            display.Name = "display";
            display.Size = new Size(413, 23);
            display.TabIndex = 16;
            display.TextChanged += display_TextChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(display);
            Controls.Add(btn_clear);
            Controls.Add(btn_equal);
            Controls.Add(btn_mult);
            Controls.Add(btn_div);
            Controls.Add(btn_sub);
            Controls.Add(btn_sum);
            Controls.Add(button0);
            Controls.Add(button9);
            Controls.Add(button8);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
        private Button button9;
        private Button button0;
        private Button btn_sum;
        private Button btn_sub;
        private Button btn_div;
        private Button btn_mult;
        private Button btn_equal;
        private Button btn_clear;
        private TextBox display;
    }
}