namespace Calculadora
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
            panel1 = new Panel();
            Labelnum1 = new Label();
            labelScreen = new Label();
            btn7 = new Button();
            btn8 = new Button();
            btn9 = new Button();
            btnC = new Button();
            btn4 = new Button();
            btn5 = new Button();
            btn6 = new Button();
            btnDividir = new Button();
            btn1 = new Button();
            btn2 = new Button();
            btn3 = new Button();
            btnPlus = new Button();
            btn00 = new Button();
            btn0 = new Button();
            btndecimal = new Button();
            btnEqual = new Button();
            btnCE = new Button();
            btnMulti = new Button();
            btnMinus = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(Labelnum1);
            panel1.Controls.Add(labelScreen);
            panel1.Location = new Point(-2, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(429, 81);
            panel1.TabIndex = 0;
            // 
            // Labelnum1
            // 
            Labelnum1.AutoSize = true;
            Labelnum1.Location = new Point(14, 9);
            Labelnum1.Name = "Labelnum1";
            Labelnum1.Size = new Size(0, 15);
            Labelnum1.TabIndex = 1;
            // 
            // labelScreen
            // 
            labelScreen.AutoSize = true;
            labelScreen.Font = new Font("Segoe UI Black", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelScreen.ForeColor = SystemColors.ControlDarkDark;
            labelScreen.Location = new Point(62, 19);
            labelScreen.Name = "labelScreen";
            labelScreen.Size = new Size(286, 50);
            labelScreen.TabIndex = 0;
            labelScreen.Text = "000000000000";
            labelScreen.Click += labelScreen_Click;
            // 
            // btn7
            // 
            btn7.Location = new Point(1, 87);
            btn7.Name = "btn7";
            btn7.Size = new Size(102, 92);
            btn7.TabIndex = 1;
            btn7.Text = "7";
            btn7.UseVisualStyleBackColor = true;
            btn7.Click += btn7_Click;
            // 
            // btn8
            // 
            btn8.Location = new Point(109, 87);
            btn8.Name = "btn8";
            btn8.Size = new Size(102, 92);
            btn8.TabIndex = 2;
            btn8.Text = "8";
            btn8.UseVisualStyleBackColor = true;
            btn8.Click += btn8_Click;
            // 
            // btn9
            // 
            btn9.Location = new Point(217, 87);
            btn9.Name = "btn9";
            btn9.Size = new Size(102, 92);
            btn9.TabIndex = 3;
            btn9.Text = "9";
            btn9.UseVisualStyleBackColor = true;
            btn9.Click += btn9_Click;
            // 
            // btnC
            // 
            btnC.Location = new Point(325, 87);
            btnC.Name = "btnC";
            btnC.Size = new Size(102, 42);
            btnC.TabIndex = 4;
            btnC.Text = "C";
            btnC.UseVisualStyleBackColor = true;
            btnC.Click += btnC_Click;
            // 
            // btn4
            // 
            btn4.Location = new Point(1, 185);
            btn4.Name = "btn4";
            btn4.Size = new Size(102, 92);
            btn4.TabIndex = 5;
            btn4.Text = "4";
            btn4.UseVisualStyleBackColor = true;
            btn4.Click += btn4_Click;
            // 
            // btn5
            // 
            btn5.Location = new Point(109, 185);
            btn5.Name = "btn5";
            btn5.Size = new Size(102, 92);
            btn5.TabIndex = 6;
            btn5.Text = "5";
            btn5.UseVisualStyleBackColor = true;
            btn5.Click += btn5_Click;
            // 
            // btn6
            // 
            btn6.Location = new Point(217, 185);
            btn6.Name = "btn6";
            btn6.Size = new Size(102, 92);
            btn6.TabIndex = 7;
            btn6.Text = "6";
            btn6.UseVisualStyleBackColor = true;
            btn6.Click += btn6_Click;
            // 
            // btnDividir
            // 
            btnDividir.Location = new Point(325, 185);
            btnDividir.Name = "btnDividir";
            btnDividir.Size = new Size(102, 40);
            btnDividir.TabIndex = 8;
            btnDividir.Text = "-/-";
            btnDividir.UseVisualStyleBackColor = true;
            btnDividir.Click += btnDividir_Click;
            // 
            // btn1
            // 
            btn1.Location = new Point(1, 283);
            btn1.Name = "btn1";
            btn1.Size = new Size(102, 92);
            btn1.TabIndex = 9;
            btn1.Text = "1";
            btn1.UseVisualStyleBackColor = true;
            btn1.Click += btn1_Click;
            // 
            // btn2
            // 
            btn2.Location = new Point(109, 283);
            btn2.Name = "btn2";
            btn2.Size = new Size(102, 92);
            btn2.TabIndex = 10;
            btn2.Text = "2";
            btn2.UseVisualStyleBackColor = true;
            btn2.Click += btn2_Click;
            // 
            // btn3
            // 
            btn3.Location = new Point(217, 283);
            btn3.Name = "btn3";
            btn3.Size = new Size(102, 92);
            btn3.TabIndex = 11;
            btn3.Text = "3";
            btn3.UseVisualStyleBackColor = true;
            btn3.Click += btn3_Click;
            // 
            // btnPlus
            // 
            btnPlus.Location = new Point(325, 283);
            btnPlus.Name = "btnPlus";
            btnPlus.Size = new Size(102, 45);
            btnPlus.TabIndex = 12;
            btnPlus.Text = "+";
            btnPlus.UseVisualStyleBackColor = true;
            btnPlus.Click += btnPlus_Click;
            // 
            // btn00
            // 
            btn00.Location = new Point(1, 381);
            btn00.Name = "btn00";
            btn00.Size = new Size(102, 92);
            btn00.TabIndex = 13;
            btn00.Text = "00";
            btn00.UseVisualStyleBackColor = true;
            btn00.Click += btn00_Click;
            // 
            // btn0
            // 
            btn0.Location = new Point(109, 381);
            btn0.Name = "btn0";
            btn0.Size = new Size(102, 92);
            btn0.TabIndex = 14;
            btn0.Text = "0";
            btn0.UseVisualStyleBackColor = true;
            btn0.Click += btn0_Click;
            // 
            // btndecimal
            // 
            btndecimal.Location = new Point(217, 381);
            btndecimal.Name = "btndecimal";
            btndecimal.Size = new Size(102, 92);
            btndecimal.TabIndex = 15;
            btndecimal.Text = ".";
            btndecimal.UseVisualStyleBackColor = true;
            btndecimal.Click += btndecimal_Click;
            // 
            // btnEqual
            // 
            btnEqual.Location = new Point(325, 381);
            btnEqual.Name = "btnEqual";
            btnEqual.Size = new Size(102, 92);
            btnEqual.TabIndex = 16;
            btnEqual.Text = "=";
            btnEqual.UseVisualStyleBackColor = true;
            btnEqual.Click += btnEqual_Click;
            // 
            // btnCE
            // 
            btnCE.Location = new Point(325, 135);
            btnCE.Name = "btnCE";
            btnCE.Size = new Size(102, 44);
            btnCE.TabIndex = 17;
            btnCE.Text = "CE";
            btnCE.UseVisualStyleBackColor = true;
            btnCE.Click += button17_Click;
            // 
            // btnMulti
            // 
            btnMulti.Location = new Point(325, 231);
            btnMulti.Name = "btnMulti";
            btnMulti.Size = new Size(102, 40);
            btnMulti.TabIndex = 18;
            btnMulti.Text = "X";
            btnMulti.UseVisualStyleBackColor = true;
            btnMulti.Click += button18_Click;
            // 
            // btnMinus
            // 
            btnMinus.Location = new Point(325, 334);
            btnMinus.Name = "btnMinus";
            btnMinus.Size = new Size(102, 41);
            btnMinus.TabIndex = 19;
            btnMinus.Text = "-";
            btnMinus.UseVisualStyleBackColor = true;
            btnMinus.Click += btnMinus_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(427, 480);
            Controls.Add(btnMinus);
            Controls.Add(btnMulti);
            Controls.Add(btnCE);
            Controls.Add(btnEqual);
            Controls.Add(btndecimal);
            Controls.Add(btn0);
            Controls.Add(btn00);
            Controls.Add(btnPlus);
            Controls.Add(btn3);
            Controls.Add(btn2);
            Controls.Add(btn1);
            Controls.Add(btnDividir);
            Controls.Add(btn6);
            Controls.Add(btn5);
            Controls.Add(btn4);
            Controls.Add(btnC);
            Controls.Add(btn9);
            Controls.Add(btn8);
            Controls.Add(btn7);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Calculadora";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btn7;
        private Button btn8;
        private Button btn9;
        private Button btnC;
        private Button btn4;
        private Button btn5;
        private Button btn6;
        private Button btnDividir;
        private Button btn1;
        private Button btn2;
        private Button btn3;
        private Button btnPlus;
        private Button btn00;
        private Button btn0;
        private Button btndecimal;
        private Button btnEqual;
        private Button btnCE;
        private Button btnMulti;
        private Button btnMinus;
        private Label labelScreen;
        private Label Labelnum1;
    }
}
