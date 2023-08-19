namespace Stopwatch
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
            components = new System.ComponentModel.Container();
            hourLabel = new Label();
            minuteLabel = new Label();
            secondLabel = new Label();
            hourTextBox = new MaskedTextBox();
            minuteTextBox = new MaskedTextBox();
            secondTextBox = new MaskedTextBox();
            startButton = new Button();
            stopwatchLabel = new Label();
            secondTimer = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // hourLabel
            // 
            hourLabel.AutoSize = true;
            hourLabel.Location = new Point(12, 19);
            hourLabel.Name = "hourLabel";
            hourLabel.Size = new Size(32, 15);
            hourLabel.TabIndex = 0;
            hourLabel.Text = "Saat:";
            // 
            // minuteLabel
            // 
            minuteLabel.AutoSize = true;
            minuteLabel.Location = new Point(12, 59);
            minuteLabel.Name = "minuteLabel";
            minuteLabel.Size = new Size(45, 15);
            minuteLabel.TabIndex = 1;
            minuteLabel.Text = "Dakika:";
            // 
            // secondLabel
            // 
            secondLabel.AutoSize = true;
            secondLabel.Location = new Point(12, 99);
            secondLabel.Name = "secondLabel";
            secondLabel.Size = new Size(44, 15);
            secondLabel.TabIndex = 2;
            secondLabel.Text = "Saniye:";
            // 
            // hourTextBox
            // 
            hourTextBox.BeepOnError = true;
            hourTextBox.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            hourTextBox.Location = new Point(64, 16);
            hourTextBox.Mask = "000";
            hourTextBox.Name = "hourTextBox";
            hourTextBox.RightToLeft = RightToLeft.Yes;
            hourTextBox.Size = new Size(70, 20);
            hourTextBox.TabIndex = 3;
            hourTextBox.Text = "000";
            hourTextBox.TextAlign = HorizontalAlignment.Center;
            hourTextBox.ValidatingType = typeof(int);
            // 
            // minuteTextBox
            // 
            minuteTextBox.BeepOnError = true;
            minuteTextBox.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            minuteTextBox.Location = new Point(64, 56);
            minuteTextBox.Mask = "00";
            minuteTextBox.Name = "minuteTextBox";
            minuteTextBox.RightToLeft = RightToLeft.Yes;
            minuteTextBox.Size = new Size(70, 20);
            minuteTextBox.TabIndex = 4;
            minuteTextBox.Text = "05";
            minuteTextBox.TextAlign = HorizontalAlignment.Center;
            minuteTextBox.ValidatingType = typeof(int);
            minuteTextBox.TextChanged += minuteTextBox_TextChanged;
            // 
            // secondTextBox
            // 
            secondTextBox.BeepOnError = true;
            secondTextBox.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            secondTextBox.Location = new Point(64, 96);
            secondTextBox.Mask = "00";
            secondTextBox.Name = "secondTextBox";
            secondTextBox.RightToLeft = RightToLeft.Yes;
            secondTextBox.Size = new Size(70, 20);
            secondTextBox.TabIndex = 5;
            secondTextBox.Text = "00";
            secondTextBox.TextAlign = HorizontalAlignment.Center;
            secondTextBox.TextChanged += secondTextBox_TextChanged;
            // 
            // startButton
            // 
            startButton.Location = new Point(12, 125);
            startButton.Name = "startButton";
            startButton.Size = new Size(122, 23);
            startButton.TabIndex = 6;
            startButton.Text = "BAŞLAT";
            startButton.UseVisualStyleBackColor = true;
            startButton.Click += startButton_Click;
            // 
            // stopwatchLabel
            // 
            stopwatchLabel.AutoSize = true;
            stopwatchLabel.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            stopwatchLabel.Location = new Point(154, 52);
            stopwatchLabel.MinimumSize = new Size(150, 45);
            stopwatchLabel.Name = "stopwatchLabel";
            stopwatchLabel.Size = new Size(150, 45);
            stopwatchLabel.TabIndex = 7;
            stopwatchLabel.Text = "00:00:00";
            stopwatchLabel.TextAlign = ContentAlignment.TopRight;
            // 
            // secondTimer
            // 
            secondTimer.Interval = 1000;
            secondTimer.Tick += secondTimer_Tick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(340, 159);
            Controls.Add(stopwatchLabel);
            Controls.Add(startButton);
            Controls.Add(secondTextBox);
            Controls.Add(minuteTextBox);
            Controls.Add(hourTextBox);
            Controls.Add(secondLabel);
            Controls.Add(minuteLabel);
            Controls.Add(hourLabel);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label hourLabel;
        private Label minuteLabel;
        private Label secondLabel;
        private MaskedTextBox hourTextBox;
        private MaskedTextBox minuteTextBox;
        private MaskedTextBox secondTextBox;
        private Button startButton;
        private Label stopwatchLabel;
        private System.Windows.Forms.Timer secondTimer;
    }
}