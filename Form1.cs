namespace Lotto
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Clears all labels and sets buttons to default values on load
        private void Clear()
        {
            one.Text = "...";
            two.Text = "...";
            three.Text = "...";
            four.Text = "...";
            five.Text = "...";
            six.Text = "...";

            pick.Enabled = true;
            reset.Enabled = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Clear();
        }

        private void reset_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void pick_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            int[] sequence = new int[60];   // Array to hold numebers 1 - 60

            // Fill array elements 0 - 59 with numbers 1 - 60
            for (int i = 1; i <= sequence.Length; i++) sequence[i - 1] = i;
            for (int i = 0; i < sequence.Length; i++)   // Shuffle values in all array elements 
            {
                int j = (random.Next() % sequence.Length);
                int k = sequence[i]; sequence[i] = sequence[j]; sequence[j] = k;
            }

            // Display values in array elements 1 - 6
            one.Text = sequence[1].ToString();
            two.Text = sequence[2].ToString();
            three.Text = sequence[3].ToString();
            four.Text = sequence[4].ToString();
            five.Text = sequence[5].ToString();
            six.Text = sequence[6].ToString();

            pick.Enabled = false;
            reset.Enabled = true;
        }
    }
}