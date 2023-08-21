using System.Media;

namespace Stopwatch
{
    public partial class stopwatchForm : Form
    {
        private TimeSpan time;
        private Boolean paused = false;

        public stopwatchForm()
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
                SystemSounds.Beep.Play();
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
            pauseResumeButton.Text = "DURAKLAT";
            pauseResumeButton.Enabled = true;

        }

        private void secondTimer_Tick(object sender, EventArgs e)
        {
            time = time.Add(TimeSpan.FromSeconds(-1));
            stopwatchLabel.Text = time.ToString();

            if (time == TimeSpan.Zero)
            {
                secondTimer.Stop();
                SoundPlayer player = new();
                try
                {
                    player.SoundLocation = "alarm.wav";
                    player.Play();
                }
                catch (Exception ex)
                {
                    SystemSounds.Beep.Play();
                    System.Diagnostics.Debug.Write(ex.Message);
                }
                MessageBox.Show("Süre Doldu!!");
                player.Stop();
                pauseResumeButton.Enabled = false;
            }
        }

        private void stopwatchForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            secondTimer.Stop();
        }

        private void hourTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && hourTextBox.Text != "")
            {
                SendKeys.Send("{Tab}");
                e.SuppressKeyPress = true;
            }
        }

        private void minuteTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && minuteTextBox.Text != "")
            {
                SendKeys.Send("{Tab}");
                e.SuppressKeyPress = true;
            }
        }

        private void secondTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && secondTextBox.Text != "")
            {
                SendKeys.Send("{Tab}");
                e.SuppressKeyPress = true;
            }
        }

        private void pauseResumeButton_Click(object sender, EventArgs e)
        {
            if (paused)
            {
                secondTimer.Start();
                paused = false;
                pauseResumeButton.Text = "DURAKLAT";
            }
            else
            {
                secondTimer.Stop();
                paused = true;
                pauseResumeButton.Text = "DEVAM ET";
            }

        }
    }
}