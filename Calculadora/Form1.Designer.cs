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
            txtResultado = new TextBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            button9 = new Button();
            button10 = new Button();
            button11 = new Button();
            button12 = new Button();
            button13 = new Button();
            button14 = new Button();
            button15 = new Button();
            button16 = new Button();
            OperadorEscolhido = new Label();
            SuspendLayout();
            // 
            // txtResultado
            // 
            txtResultado.Location = new Point(15, 58);
            txtResultado.Name = "txtResultado";
            txtResultado.Size = new Size(358, 23);
            txtResultado.TabIndex = 1;
            // 
            // button1
            // 
            button1.Location = new Point(15, 190);
            button1.Name = "button1";
            button1.Size = new Size(75, 29);
            button1.TabIndex = 3;
            button1.Text = "1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(113, 190);
            button2.Name = "button2";
            button2.Size = new Size(75, 29);
            button2.TabIndex = 4;
            button2.Text = "2";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(203, 190);
            button3.Name = "button3";
            button3.Size = new Size(75, 29);
            button3.TabIndex = 5;
            button3.Text = "3";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(15, 146);
            button4.Name = "button4";
            button4.Size = new Size(75, 29);
            button4.TabIndex = 6;
            button4.Text = "4";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Location = new Point(203, 146);
            button5.Name = "button5";
            button5.Size = new Size(75, 29);
            button5.TabIndex = 7;
            button5.Text = "6";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.Location = new Point(113, 146);
            button6.Name = "button6";
            button6.Size = new Size(75, 29);
            button6.TabIndex = 8;
            button6.Text = "5";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // button7
            // 
            button7.Location = new Point(15, 101);
            button7.Name = "button7";
            button7.Size = new Size(75, 29);
            button7.TabIndex = 9;
            button7.Text = "7";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // button8
            // 
            button8.Location = new Point(113, 101);
            button8.Name = "button8";
            button8.Size = new Size(75, 29);
            button8.TabIndex = 10;
            button8.Text = "8";
            button8.UseVisualStyleBackColor = true;
            button8.Click += button8_Click;
            // 
            // button9
            // 
            button9.Location = new Point(203, 101);
            button9.Name = "button9";
            button9.Size = new Size(75, 29);
            button9.TabIndex = 11;
            button9.Text = "9";
            button9.UseVisualStyleBackColor = true;
            button9.Click += button9_Click;
            // 
            // button10
            // 
            button10.Location = new Point(15, 236);
            button10.Name = "button10";
            button10.Size = new Size(75, 29);
            button10.TabIndex = 12;
            button10.Text = "0";
            button10.UseVisualStyleBackColor = true;
            button10.Click += button10_Click;
            // 
            // button11
            // 
            button11.Location = new Point(113, 236);
            button11.Name = "button11";
            button11.Size = new Size(165, 29);
            button11.TabIndex = 13;
            button11.Text = "C";
            button11.UseVisualStyleBackColor = true;
            button11.Click += button11_Click;
            // 
            // button12
            // 
            button12.Location = new Point(298, 190);
            button12.Name = "button12";
            button12.Size = new Size(75, 29);
            button12.TabIndex = 14;
            button12.Text = "*";
            button12.UseVisualStyleBackColor = true;
            button12.Click += button12_Click;
            // 
            // button13
            // 
            button13.Location = new Point(298, 146);
            button13.Name = "button13";
            button13.Size = new Size(75, 29);
            button13.TabIndex = 15;
            button13.Text = "-";
            button13.UseVisualStyleBackColor = true;
            button13.Click += button13_Click;
            // 
            // button14
            // 
            button14.Location = new Point(298, 101);
            button14.Name = "button14";
            button14.Size = new Size(75, 29);
            button14.TabIndex = 16;
            button14.Text = "+";
            button14.UseVisualStyleBackColor = true;
            button14.Click += button14_Click;
            // 
            // button15
            // 
            button15.Location = new Point(298, 236);
            button15.Name = "button15";
            button15.Size = new Size(75, 29);
            button15.TabIndex = 17;
            button15.Text = "/";
            button15.UseVisualStyleBackColor = true;
            button15.Click += button15_Click;
            // 
            // button16
            // 
            button16.Location = new Point(15, 294);
            button16.Name = "button16";
            button16.Size = new Size(258, 29);
            button16.TabIndex = 18;
            button16.Text = "=";
            button16.UseVisualStyleBackColor = true;
            button16.Click += button16_Click;
            // 
            // OperadorEscolhido
            // 
            OperadorEscolhido.AutoSize = true;
            OperadorEscolhido.Location = new Point(188, 61);
            OperadorEscolhido.Name = "OperadorEscolhido";
            OperadorEscolhido.Size = new Size(0, 15);
            OperadorEscolhido.TabIndex = 19;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(409, 340);
            Controls.Add(OperadorEscolhido);
            Controls.Add(button16);
            Controls.Add(button15);
            Controls.Add(button14);
            Controls.Add(button13);
            Controls.Add(button12);
            Controls.Add(button11);
            Controls.Add(button10);
            Controls.Add(button9);
            Controls.Add(button8);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(txtResultado);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtResultado;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
        private Button button9;
        private Button button10;
        private Button button11;
        private Button button12;
        private Button button13;
        private Button button14;
        private Button button15;
        private Button button16;
        private Label OperadorEscolhido;
    }
}