namespace Task_3
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
            label1 = new Label();
            txtNumberInput = new TextBox();
            lblFibonacciResult = new Label();
            btnCalculateFibonacci = new Button();
            label2 = new Label();
            txtNumberInput2 = new TextBox();
            btnCalculatePower = new Button();
            lblPowerResult = new Label();
            label4 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(242, 70);
            label1.Name = "label1";
            label1.Size = new Size(294, 28);
            label1.TabIndex = 0;
            label1.Text = "Recursive Fibonacci Sequence";
            // 
            // txtNumberInput
            // 
            txtNumberInput.Location = new Point(250, 111);
            txtNumberInput.Name = "txtNumberInput";
            txtNumberInput.Size = new Size(125, 27);
            txtNumberInput.TabIndex = 1;
            // 
            // lblFibonacciResult
            // 
            lblFibonacciResult.AutoSize = true;
            lblFibonacciResult.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblFibonacciResult.Location = new Point(381, 118);
            lblFibonacciResult.Name = "lblFibonacciResult";
            lblFibonacciResult.Size = new Size(50, 20);
            lblFibonacciResult.TabIndex = 2;
            lblFibonacciResult.Text = "Result";
            lblFibonacciResult.Click += btnCalculateFibonacci_Click;
            // 
            // btnCalculateFibonacci
            // 
            btnCalculateFibonacci.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCalculateFibonacci.Location = new Point(250, 155);
            btnCalculateFibonacci.Name = "btnCalculateFibonacci";
            btnCalculateFibonacci.Size = new Size(94, 29);
            btnCalculateFibonacci.TabIndex = 3;
            btnCalculateFibonacci.Text = "Calculate";
            btnCalculateFibonacci.UseVisualStyleBackColor = true;
            btnCalculateFibonacci.Click += btnCalculateFibonacci_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(242, 205);
            label2.Name = "label2";
            label2.Size = new Size(279, 28);
            label2.TabIndex = 4;
            label2.Text = "Recursive Power Calculation";
            // 
            // txtNumberInput2
            // 
            txtNumberInput2.Location = new Point(250, 253);
            txtNumberInput2.Name = "txtNumberInput2";
            txtNumberInput2.Size = new Size(125, 27);
            txtNumberInput2.TabIndex = 5;
            // 
            // btnCalculatePower
            // 
            btnCalculatePower.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCalculatePower.Location = new Point(250, 314);
            btnCalculatePower.Name = "btnCalculatePower";
            btnCalculatePower.Size = new Size(94, 29);
            btnCalculatePower.TabIndex = 6;
            btnCalculatePower.Text = "Calculate";
            btnCalculatePower.UseVisualStyleBackColor = true;
            btnCalculatePower.Click += btnCalculatePower_Click;
            // 
            // lblPowerResult
            // 
            lblPowerResult.AutoSize = true;
            lblPowerResult.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPowerResult.Location = new Point(385, 257);
            lblPowerResult.Name = "lblPowerResult";
            lblPowerResult.Size = new Size(50, 20);
            lblPowerResult.TabIndex = 7;
            lblPowerResult.Text = "Result";
            lblPowerResult.Click += btnCalculatePower_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 7.8F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label4.Location = new Point(250, 283);
            label4.Name = "label4";
            label4.Size = new Size(252, 17);
            label4.TabIndex = 8;
            label4.Text = "Enter base and exponent as X, n (e.g., 10, 2)";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label4);
            Controls.Add(lblPowerResult);
            Controls.Add(btnCalculatePower);
            Controls.Add(txtNumberInput2);
            Controls.Add(label2);
            Controls.Add(btnCalculateFibonacci);
            Controls.Add(lblFibonacciResult);
            Controls.Add(txtNumberInput);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtNumberInput;
        private Label lblFibonacciResult;
        private Button btnCalculateFibonacci;
        private Label label2;
        private TextBox txtNumberInput2;
        private Button btnCalculatePower;
        private Label lblPowerResult;
        private Label label4;
    }
}
