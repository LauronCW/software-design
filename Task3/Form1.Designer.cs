namespace Task3
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
            btnCalculateFibonacc = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(178, 87);
            label1.Name = "label1";
            label1.Size = new Size(271, 25);
            label1.TabIndex = 0;
            label1.Text = "Recursive Fibonacci  Sequence";
            // 
            // txtNumberInput
            // 
            txtNumberInput.Location = new Point(188, 124);
            txtNumberInput.Name = "txtNumberInput";
            txtNumberInput.Size = new Size(125, 27);
            txtNumberInput.TabIndex = 1;
            // 
            // lblFibonacciResult
            // 
            lblFibonacciResult.AutoSize = true;
            lblFibonacciResult.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblFibonacciResult.Location = new Point(329, 131);
            lblFibonacciResult.Name = "lblFibonacciResult";
            lblFibonacciResult.Size = new Size(50, 20);
            lblFibonacciResult.TabIndex = 2;
            lblFibonacciResult.Text = "Result";
            // 
            // btnCalculateFibonacc
            // 
            btnCalculateFibonacc.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCalculateFibonacc.Location = new Point(188, 157);
            btnCalculateFibonacc.Name = "btnCalculateFibonacc";
            btnCalculateFibonacc.Size = new Size(94, 29);
            btnCalculateFibonacc.TabIndex = 3;
            btnCalculateFibonacc.Text = "Calculate";
            btnCalculateFibonacc.UseVisualStyleBackColor = true;
            btnCalculateFibonacc.Click += btnCalculateFibonacci_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnCalculateFibonacc);
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
        private Button btnCalculateFibonacc;
    }
}
