namespace Task_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public int RecursiveFibonacci(int n)
        {
            if (n <= 0) return 0;
            if (n == 1) return 1;
            return RecursiveFibonacci(n - 1) + RecursiveFibonacci(n - 2);
        }

        private void btnCalculateFibonacci_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtNumberInput.Text, out int n) && n >= 0)
            {
                int result = RecursiveFibonacci(n);
                lblFibonacciResult.Text = $"Fibonacci({n}): {result}";
            }
            else
            {
                lblFibonacciResult.Text = "Please enter a valid non-negative integer.";
            }

        }

        public int RecursivePower(int baseNum, int exponent)
        {
            if (exponent == 0) return 1;
            return baseNum * RecursivePower(baseNum, exponent - 1);
        }

        private void btnCalculatePower_Click(object sender, EventArgs e)
        {
            string[] inputs = txtNumberInput2.Text.Split(',');
            if (inputs.Length == 2 && int.TryParse(inputs[0], out int baseNum) && int.TryParse(inputs[1], out int exponent) && exponent >= 0)
            {
                int result = RecursivePower(baseNum, exponent);
                lblPowerResult.Text = $"{baseNum}^{exponent}: {result}";
            }
              else
             {
                 lblPowerResult.Text = "Please enter two valid non-negative integers separated by a comma.";
             }
        }
    }
}
