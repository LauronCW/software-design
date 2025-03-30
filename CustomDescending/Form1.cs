namespace CustomDescending
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void btnSort_Click(object sender, EventArgs e)
        {
            int[] numbers = { 90, 75, 53, 21, 14 };
            BubbleSorter sorter = new BubbleSorter();
            int[] sortedNumbers = sorter.SortDescending(numbers);
            listBoxResults.DataSource = sortedNumbers;
        }
    }

    public class BubbleSorter
    {
        public int[] SortDescending(int[] numbers)
        {
            int n = numbers.Length;
            for (int i = 0; i< n - 1; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (numbers[j] < numbers[j + 1]) // descendingg order
                    {
                        int temp = numbers[j];
                        numbers[j] = numbers[j + 1];
                        numbers[j + 1] = temp;
                    }
                }
            }
            return numbers;
        }
    }
}
