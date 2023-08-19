namespace Stopwatch
{
    public partial class Form1 : Form
    {
        TimeSpan time;


        public Form1()
        {
            InitializeComponent();
        }

        private void minuteTextBox_TextChanged(object sender, EventArgs e)
        {
            if (minuteTextBox.Text != "" && Convert.ToInt16(minuteTextBox.Text) >= 60)
            {
                minuteTextBox.Text = "59";
            }
        }

        private void secondTextBox_TextChanged(object sender, EventArgs e)
        {
            if (secondTextBox.Text != "" && Convert.ToInt16(secondTextBox.Text) >= 60)
            {
                secondTextBox.Text = "59";
            }
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            if (hourTextBox.Text == "" || minuteTextBox.Text == "" || secondTextBox.Text == "" || Convert.ToInt16(hourTextBox.Text) == 0 && Convert.ToInt16(minuteTextBox.Text) == 0 && Convert.ToInt16(secondTextBox.Text) == 0)
            {
                MessageBox.Show("Lütfen süre giriniz");
                return;
            }
            secondTimer.Stop();

            time = new(
                Convert.ToInt16(hourTextBox.Text),
                Convert.ToInt16(minuteTextBox.Text),
                Convert.ToInt16(secondTextBox.Text)
            );

            stopwatchLabel.Text = time.ToString();
            secondTimer.Start();

        }

        private void secondTimer_Tick(object sender, EventArgs e)
        {
            time = time.Add(TimeSpan.FromSeconds(-1));
            stopwatchLabel.Text = time.ToString();

            if (time == TimeSpan.Zero)
            {
                secondTimer.Stop();
            }
        }
    }
}