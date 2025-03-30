namespace Task3
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
    }
}
